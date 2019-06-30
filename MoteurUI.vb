''Thibault ANIN                                                 2019                                               -- Dedi Orsay TP2E --

Imports System.IO
Imports System.Reflection

Public Class MoteurUI

    Public moteur As New Moteur
    Dim StatutSimulation As Boolean
    Dim generation As Integer = 1
    Dim echelles As Integer(,) = {{1440, 768}, {719, 383}, {359, 191}, {181, 97}, {90, 48}, {45, 24}}
    Dim largeurGrille As Integer = 90
    Dim hauteurGrille As Integer = 48
    Dim celluleRectangle(,) As Rectangle
    Dim etatPrecedant(,) As Boolean
    Dim nbCellVie, nbCellDetruite, nbCellCreee, nbCellCreeeTmp As Integer
    Dim minMort As Integer
    Dim maxMort As Integer
    Dim minNaissance As Integer
    Dim maxNaissance As Integer
    Dim iteration As Integer = -1
    Dim nbCellule As Integer = 0
    Dim couleurFond As SolidBrush
    Dim couleurGrille As Pen
    Dim couleurCellule As SolidBrush

    Public afficherGrille, mur, multicolor, statutCell(,), UseMur As Boolean

    Public couleurFondChoisi, couleurGrilleChoisi, couleurCelluleChoisi As Color
    Public reglePred, motifPred, tabNbCellNaissance(8), tabNbCellMort(8) As Integer

    Public Property Form2 As Object

    Private Sub FrmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim celluleRectangle(echelles(0, 0), echelles(0, 1))
        ReDim etatPrecedant(echelles(0, 0), echelles(0, 1))
        fenChargement.BarLong(100)
        Dim i As Integer = 0

        While i <= 100
            fenChargement.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(1)
        End While
        For i = 0 To echelles(0, 0)
            For j = 0 To echelles(0, 1)
                celluleRectangle(i, j) = New Rectangle
            Next
        Next
        cboBoxEchelle.Text = "Taille"
        For i = 0 To UBound(echelles, 1)
            cboBoxEchelle.Items.Add(Str(echelles(i, 0)) & " X " & Str(echelles(i, 1)))
        Next


        cboBoxIteration.Items.Add("Infini")
        For i = 100 To 10000 Step 1000
            cboBoxIteration.Items.Add(i)
        Next
        cboBoxIteration.SelectedItem = 0

        CheckMoteur()
        moteur.setRegle(2, 3, 3, 3)
        ReDim statutCell(largeurGrille + 1, hauteurGrille + 1)

        moteur.setTailleGrille(largeurGrille, hauteurGrille)
        tabNbCellNaissance(3) = 3
        tabNbCellMort(2) = 2
        tabNbCellMort(3) = 3

        couleurFondChoisi = frmParametre.pnlCouleurFond.BackColor
        couleurGrilleChoisi = frmParametre.pnlCouleurGrille.BackColor
        couleurCelluleChoisi = frmParametre.pnlCouleurCellule.BackColor
        couleurFond = New SolidBrush(couleurFondChoisi)
        couleurGrille = New Pen(couleurGrilleChoisi)
        couleurCellule = New SolidBrush(couleurCelluleChoisi)

        'Réduit le scintillement des graphismes
        DoubleBuffered = True

        Call calculerCellules()
        Invalidate()
    End Sub

    Sub CheckMoteur()

        'Permet de tester par reflexion si la methode optionelle <setMur> du Moteur exist et est implémentables par l'IHM

        Dim t As Type = GetType(Moteur)

        If t.GetMethod("setMur") Is Nothing Then
            UseMur = False
        Else
            UseMur = True
        End If

    End Sub

    Public Sub DefMur(ByRef valid As Boolean)
        Dim t As Type = GetType(Moteur)
        Try
            t.InvokeMember("setMur", BindingFlags.InvokeMethod, Nothing, moteur, {valid})
        Catch err As System.MissingMethodException
            ' Dans le cas ou la méthode n'est pas un membre de ce type ...
        End Try
    End Sub

    Private Sub FrmPrincipale_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Modifiers = Keys.Control And e.KeyValue = Keys.Space Then Lancer()
        If e.Modifiers = Keys.Control And e.KeyValue = Keys.Back Then EffacerCellule()
        If e.Modifiers = Keys.Control And e.KeyValue = Keys.R Then choixMotif(motifPred)
        If e.Modifiers = Keys.Shift And e.KeyValue = Keys.A Then accelerer()
        If e.Modifiers = Keys.Shift And e.KeyValue = Keys.Q Then ralentir()
        If e.Modifiers = Keys.Shift And e.KeyValue = Keys.Z Then avancerDe1()
        If e.Modifiers = Keys.Shift And e.KeyValue = Keys.S Then reculerDe1()
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim colonne, ligne As Integer
        colonne = CInt(Int((e.Y) * largeurGrille / 900)) : ligne = CInt(Int((e.X) * hauteurGrille / 480))
        If colonne > hauteurGrille Or colonne < 1 Or ligne > largeurGrille Or ligne < 1 Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            statutCell(ligne, colonne) = Not moteur.getEtatCellule(ligne, colonne)
            moteur.setEtatCellule(ligne, colonne, Not moteur.getEtatCellule(ligne, colonne))
        End If
        Invalidate()
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.None Then Exit Sub
        Dim colonne, ligne As Integer
        colonne = CInt(Int((e.Y) * largeurGrille / 900)) : ligne = CInt(Int((e.X) * hauteurGrille / 480))
        If colonne > hauteurGrille Or colonne < 1 Or ligne > largeurGrille Or ligne < 1 Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            moteur.setEtatCellule(ligne, colonne, True)
            statutCell(ligne, colonne) = True
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            moteur.setEtatCellule(ligne, colonne, False)
            statutCell(ligne, colonne) = False
        End If
        Invalidate()
    End Sub

    Private Sub BtnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        Lancer()
    End Sub

    Private Sub BtnAvance_Click(sender As Object, e As EventArgs)
        frmParametre.Show()
    End Sub

    Private Sub BtnMotif_Click(sender As Object, e As EventArgs) Handles btnMotif.Click
        frmMotif.Show()
    End Sub

    Private Sub CboBoxEchelle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBoxEchelle.SelectedIndexChanged
        largeurGrille = echelles(cboBoxEchelle.SelectedIndex, 0)
        hauteurGrille = echelles(cboBoxEchelle.SelectedIndex, 1)
        moteur.setTailleGrille(largeurGrille, hauteurGrille)
        ReDim statutCell(largeurGrille + 1, hauteurGrille + 1)
        txtBoxCellule.Text = ""
        Call calculerCellules()
        Invalidate()
    End Sub
    Sub Lancer()
        'Echange les états (lancé ou en pause)
        StatutSimulation = Not StatutSimulation
        If StatutSimulation = True Then
            btnLancer.BackColor = Color.LightCoral
            ltmLancer.Text = "Stopper"
            btnLancer.Text = "STOPPER"
            TimerJeu.Start()
            If nbCellule > 0 Then
                randomLocalisation()
            End If
        Else
            btnLancer.BackColor = Color.LightGreen
            ltmLancer.Text = "Lancer"
            btnLancer.Text = "LANCER"
            TimerJeu.Stop()
        End If
    End Sub

    Sub calculerCellules()
        Dim X, Y As Double
        X = 0 : Y = 0
        For i = 0 To largeurGrille
            For j = 0 To hauteurGrille
                celluleRectangle(i, j) = New Rectangle(CInt(X), CInt(Y), CInt(900 / largeurGrille), CInt(900 / largeurGrille))
                'celluleRectangle(i, j) = New Rectangle(CInt(X), CInt(Y), 10, 10)
                Y += 900 / largeurGrille
            Next
            Y = 0
            X += 900 / largeurGrille
        Next
    End Sub



    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        nbCellVie = 0
        If multicolor = True Then randomColor()
        If afficherGrille = True Then
            For i = 0 To largeurGrille
                For j = 0 To hauteurGrille
                    'e.Graphics.FillRectangle(couleurFond, celluleRectangle(i, j))
                    e.Graphics.DrawRectangle(couleurGrille, celluleRectangle(i, j))
                Next
            Next
        End If
        For i = 0 To largeurGrille
            For j = 0 To hauteurGrille
                If moteur.getEtatCellule(i, j) = True Then
                    e.Graphics.FillRectangle(couleurCellule, celluleRectangle(i, j))

                    nbCellVie += 1
                    If statutCell(i, j) = True Then
                        statutCell(i, j) = True
                    Else
                        statutCell(i, j) = True
                        nbCellCreee += 1
                    End If
                Else
                    If statutCell(i, j) = True Then
                        statutCell(i, j) = False
                        nbCellDetruite += 1
                    Else
                        statutCell(i, j) = False
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub TimerJeu_Tick(sender As Object, e As EventArgs) Handles TimerJeu.Tick
        If generation <= iteration Or iteration = -1 Then
            Call moteur.etatSuivant()
            Call RefreshStat()
            Invalidate()
        End If
    End Sub

    Sub accelerer()
        If trckBrVitesse.Value < trckBrVitesse.Maximum - 50 Then
            trckBrVitesse.Value += 50
        Else
            trckBrVitesse.Value += trckBrVitesse.Maximum - trckBrVitesse.Value
        End If
        majVitesse()
    End Sub

    Sub ralentir()
        If trckBrVitesse.Value > trckBrVitesse.Minimum + 50 Then
            trckBrVitesse.Value -= 50
        Else
            trckBrVitesse.Value -= trckBrVitesse.Minimum - trckBrVitesse.Value
        End If
        majVitesse()
    End Sub

    Sub majVitesse()
        TimerJeu.Interval = 1001 - trckBrVitesse.Value
        lblVitesse.Text = Str(trckBrVitesse.Value) & " (ticks/s)"
    End Sub

    Sub avancerDe1()
        If nbCellule > 0 And generation = 1 Then
            randomLocalisation()
        End If
        moteur.etatSuivant()
        Invalidate()
        RefreshStat()
    End Sub

    Sub reculerDe1()

    End Sub
    Sub RefreshStat()
        lblCelluleEnVieDyn.Text = nbCellVie
        lblCelluleCreeeDyn.Text = nbCellCreee
        lblCelluleDetruiteDyn.Text = nbCellDetruite
        lblGenerationDyn.Text = generation
        generation += 1
        nbCellVie = 0
    End Sub

    Private Sub CboIteration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBoxIteration.SelectedIndexChanged
        If cboBoxIteration.SelectedIndex = 0 Then
            iteration = -1
        Else
            iteration = CInt(cboBoxIteration.SelectedItem)
        End If
        Invalidate()
    End Sub

    Private Sub TxtBoxCellule_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCellule.TextChanged, txtBoxCellule.Validating
        If txtBoxCellule.Text <> "" Then
            If IsNumeric(txtBoxCellule.Text) = False Then
                MsgBox("Ce champ ne prend pas de caractère.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                nbCellule = 0
                txtBoxCellule.Text = ""
            ElseIf largeurGrille * hauteurGrille < CInt(txtBoxCellule.Text) Then
                MsgBox("La valeur " & txtBoxCellule.Text & " correspondant au nombre de cellule, est trop grande pour cette grille." & vbNewLine &
                           "La valeur maximal de cette grille est : " & CInt(largeurGrille * hauteurGrille),
                           MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                nbCellule = 0
                txtBoxCellule.Text = ""
            Else
                nbCellule = CInt(txtBoxCellule.Text)
            End If
        Else
            nbCellule = 0
        End If
    End Sub

    Sub EffacerCellule()
        generation = 0
        nbCellCreee = 0
        nbCellDetruite = 0
        nbCellVie = 0
        For i = 0 To largeurGrille
            For j = 0 To hauteurGrille
                moteur.setEtatCellule(i, j, False)
                statutCell(i, j) = False
            Next
        Next
        RefreshStat()
        Invalidate()
    End Sub


    Sub majRegle()
        minMort = 8
        minNaissance = 8
        For i = 0 To 8
            If tabNbCellMort(i) > 0 And minMort > tabNbCellMort(i) Then
                minMort = tabNbCellMort(i)
            End If
            If tabNbCellNaissance(i) > 0 And minNaissance > tabNbCellNaissance(i) Then
                minNaissance = tabNbCellNaissance(i)
            End If
        Next

        maxMort = tabNbCellMort.Max()
        maxNaissance = tabNbCellNaissance.Max()

        moteur.setRegle(minMort, maxMort,
                minNaissance, maxNaissance)
    End Sub

    Sub randomLocalisation()
        Dim cpt As Integer = 0
        Dim random As New Random(), randomLargeur, randomHauteur As Integer
        EffacerCellule()

        While cpt < nbCellule
            randomLargeur = random.Next(0, largeurGrille)
            randomHauteur = random.Next(0, hauteurGrille)
            If moteur.getEtatCellule(randomLargeur, randomHauteur) = False Then
                moteur.setEtatCellule(randomLargeur, randomHauteur, True)
                cpt += 1
            End If
        End While
    End Sub

    Private Sub TrckBrVitesse_Scroll(sender As Object, e As EventArgs) Handles trckBrVitesse.Scroll
        majVitesse()
    End Sub

    Sub changerCouleur()

    End Sub


    Sub setCouleurFond(ByVal couleur As Color)
        couleurFondChoisi = couleur
        couleurFond.Color = couleurFondChoisi
        BackColor = couleurFondChoisi
    End Sub

    Sub setCouleurGrille(ByVal couleur As Color)
        couleurGrilleChoisi = couleur
        couleurGrille.Color = couleurGrilleChoisi
    End Sub
    Sub setCouleurCellule(ByVal couleur As Color)
        couleurCelluleChoisi = couleur
        couleurCellule.Color = couleurCelluleChoisi
    End Sub

    Sub randomColor()
        Dim nbRandom As New Random
        couleurCellule.Color = Color.FromArgb(nbRandom.Next(100, 255), nbRandom.Next(255), nbRandom.Next(255))
    End Sub

    Public Sub chargerMotif(nomFichier As String)
        EffacerCellule()
        Dim cellulesChargees() As String = File.ReadAllLines(nomFichier)
        For Each valeur As String In cellulesChargees
            moteur.setEtatCellule(valeur.Split("-")(0), valeur.Split("-")(1), True)
        Next
        Invalidate()
    End Sub

    Public Sub enregistrerMotif(filename As String)
        Dim cellulesVivantesL As New List(Of Integer)
        Dim cellulesVivantesC As New List(Of Integer)
        For ligne As Integer = 0 To largeurGrille
            For colonne As Integer = 0 To hauteurGrille
                If moteur.getEtatCellule(ligne, colonne) = True Then
                    cellulesVivantesL.Add(ligne)
                    cellulesVivantesC.Add(colonne)
                End If
            Next
        Next

        Dim sw As StreamWriter = File.CreateText(filename)

        For i As Integer = 0 To cellulesVivantesL.LongCount() - 1
            sw.WriteLine(String.Format("{0}-{1}", cellulesVivantesL(i), cellulesVivantesC(i)))
        Next
        sw.Close()
    End Sub


    Private Sub PbAvance_Click(sender As Object, e As EventArgs) Handles pbAvance.Click
        frmParametre.Show()
    End Sub
    Private Sub PbAvance_MouseDown(sender As Object, e As MouseEventArgs) Handles pbAvance.MouseDown
        pbAvance.Image = My.Resources.setting3
    End Sub

    Private Sub PbAvance_MouseUp(sender As Object, e As MouseEventArgs) Handles pbAvance.MouseUp
        pbAvance.Image = My.Resources.setting1
    End Sub

    Private Sub PbAvance_MouseMove(sender As Object, e As MouseEventArgs) Handles pbAvance.MouseMove
        pbAvance.Image = My.Resources.setting2
    End Sub

    Private Sub PbAvance_MouseLeave(sender As Object, e As EventArgs) Handles pbAvance.MouseLeave
        pbAvance.Image = My.Resources.setting1
    End Sub

    Private Sub PbQuitter_Click(sender As Object, e As EventArgs) Handles pbQuitter.Click
        Dispose()
    End Sub

    Private Sub PbQuitter_MouseDown(sender As Object, e As MouseEventArgs) Handles pbQuitter.MouseDown
        pbQuitter.Image = My.Resources.Quitter3
    End Sub

    Private Sub PbQuitter_MouseUp(sender As Object, e As MouseEventArgs) Handles pbQuitter.MouseUp
        pbQuitter.Image = My.Resources.Quitter1
    End Sub

    Private Sub PbQuitter_MouseMove(sender As Object, e As MouseEventArgs) Handles pbQuitter.MouseMove
        pbQuitter.Image = My.Resources.Quitter2
    End Sub

    Private Sub PbQuitter_MouseLeave(sender As Object, e As EventArgs) Handles pbQuitter.MouseLeave
        pbQuitter.Image = My.Resources.Quitter1
    End Sub

    Private Sub PbEffacer_Click(sender As Object, e As EventArgs) Handles pbEffacer.Click
        EffacerCellule()
    End Sub

    Private Sub PbEffacer_MouseDown(sender As Object, e As MouseEventArgs) Handles pbEffacer.MouseDown
        pbEffacer.Image = My.Resources.Supprimer2
    End Sub

    Private Sub PbEffacer_MouseUp(sender As Object, e As MouseEventArgs) Handles pbEffacer.MouseUp
        pbEffacer.Image = My.Resources.Supprimer1
    End Sub

    Private Sub PbEffacer_MouseMove(sender As Object, e As MouseEventArgs) Handles pbEffacer.MouseMove
        pbEffacer.Image = My.Resources.Supprimer3
    End Sub

    Private Sub PbEffacer_MouseLeave(sender As Object, e As EventArgs) Handles pbEffacer.MouseLeave
        pbEffacer.Image = My.Resources.Supprimer1
    End Sub

    Private Sub PbAvancerDe1_Click(sender As Object, e As EventArgs) Handles pbAvancerDe1.Click
        avancerDe1()
    End Sub

    Private Sub PbAvancerDe1_MouseDown(sender As Object, e As MouseEventArgs) Handles pbAvancerDe1.MouseDown
        pbAvancerDe1.Image = My.Resources.AvancerDe1_3
    End Sub

    Private Sub PbAvancerDe1_MouseUp(sender As Object, e As MouseEventArgs) Handles pbAvancerDe1.MouseUp
        pbAvancerDe1.Image = My.Resources.AvancerDe1_1
    End Sub

    Private Sub PbAvancerDe1_MouseMove(sender As Object, e As MouseEventArgs) Handles pbAvancerDe1.MouseMove
        pbAvancerDe1.Image = My.Resources.AvancerDe1_2
    End Sub

    Private Sub PbAvancerDe1_MouseLeave(sender As Object, e As EventArgs) Handles pbAvancerDe1.MouseLeave
        pbAvancerDe1.Image = My.Resources.AvancerDe1_1
    End Sub

    Private Sub PbReculerDe1_Click(sender As Object, e As EventArgs) Handles pbReculerDe1.Click
        For i = 0 To echelles(0, 0)
            For j = 0 To echelles(0, 1)
                moteur.setEtatCellule(i, j, etatPrecedant(i, j))
            Next
        Next
        Invalidate()
    End Sub

    Private Sub PbReculerDe1_MouseDown(sender As Object, e As MouseEventArgs) Handles pbReculerDe1.MouseDown
        pbReculerDe1.Image = My.Resources.ReculerDe1_3
    End Sub

    Private Sub PbReculerDe1_MouseUp(sender As Object, e As MouseEventArgs) Handles pbReculerDe1.MouseUp
        pbReculerDe1.Image = My.Resources.ReculerDe1_1
    End Sub

    Private Sub PbReculerDe1_MouseMove(sender As Object, e As MouseEventArgs) Handles pbReculerDe1.MouseMove
        pbReculerDe1.Image = My.Resources.ReculerDe1_2
    End Sub

    Private Sub PbReculerDe1_MouseLeave(sender As Object, e As EventArgs) Handles pbReculerDe1.MouseLeave
        pbReculerDe1.Image = My.Resources.ReculerDe1_1
    End Sub

    Private Sub PbAide_Click(sender As Object, e As EventArgs) Handles pbAide.Click
        frmAide.Show()
    End Sub

    Private Sub PbAide_MouseDown(sender As Object, e As MouseEventArgs) Handles pbAide.MouseDown
        pbAide.Image = My.Resources.Aide3
    End Sub

    Private Sub PbAide_MouseUp(sender As Object, e As MouseEventArgs) Handles pbAide.MouseUp
        pbAide.Image = My.Resources.Aide1
    End Sub

    Private Sub PbAide_MouseMove(sender As Object, e As MouseEventArgs) Handles pbAide.MouseMove
        pbAide.Image = My.Resources.Aide2
    End Sub

    Private Sub PbAide_MouseLeave(sender As Object, e As EventArgs) Handles pbAide.MouseLeave
        pbAide.Image = My.Resources.Aide1
    End Sub

    Private Sub FrmPrincipale_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctMenu.Show(New System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y))
        End If
    End Sub

    Private Sub LancerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ltmLancer.Click
        Lancer()
    End Sub
    Private Sub TsmParametreAvance_Click(sender As Object, e As EventArgs) Handles tsmParametreAvance.Click
        frmParametre.Show()
    End Sub

    Private Sub TsmMotif_Click(sender As Object, e As EventArgs) Handles tsmMotif.Click
        frmMotif.Show()
    End Sub

    Private Sub TsmQuitter_Click(sender As Object, e As EventArgs) Handles tsmQuitter.Click
        Dispose()
    End Sub
    Sub choixMotif(ByVal choix As Integer)
        Select Case choix
            Case 1
                DessinCroix()
            Case 2
                DessinLignesParalleles()
            Case 3
                DessinGrille()
            Case 4
                DessinPlaneurSimple()
            Case 5
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinPlaneurs()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
            Case 6
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinDoublePlaneurs()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
            Case 7
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinCanon()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
            Case 8
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinVaisseaux()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
            Case 9
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinGrosVaisseaux()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
            Case 10
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinGrosVaisseaux2()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
            Case 11
                If largeurGrille > 45 And hauteurGrille > 24 Then
                    DessinCulbuteurs()
                Else
                    MsgBox("Désolé ce motif est trop grand pour cette grille.", MsgBoxStyle.OkOnly + vbExclamation, "Opération impossible")
                End If
        End Select
        Invalidate()
    End Sub

    'Dessin de l'ensemble des motifs prédefinis
    '------------------------------------------
    Sub DessinGrille()
        Dim ligne, colonne As Integer
        Dim add As Double
        If largeurGrille >= 1440 Then
            add = 40
        ElseIf largeurGrille < 1440 And largeurGrille >= 719 Then
            add = 33
        ElseIf largeurGrille < 719 And largeurGrille >= 359 Then
            add = 43
        ElseIf largeurGrille < 359 And largeurGrille >= 181 Then
            add = 38
        ElseIf largeurGrille < 181 And largeurGrille > 45 Then
            add = 37
        ElseIf largeurGrille <= 45 Then
            add = 28
        End If
        ligne = CInt(largeurGrille / 2.8)
        colonne = CInt(hauteurGrille / 4.4)

        For i = ligne To ligne + (largeurGrille / 4) + largeurGrille / add Step largeurGrille / add
            For j = colonne To colonne + (largeurGrille / 4) + largeurGrille / add
                moteur.setEtatCellule(i, j, True)
            Next
        Next
        For j = colonne To colonne + (largeurGrille / 4) + largeurGrille / add Step largeurGrille / add
            For i = ligne To ligne + (largeurGrille / 4) + largeurGrille / add
                moteur.setEtatCellule(i, j, True)
            Next
        Next
    End Sub

    Sub DessinCroix()
        Dim add As Double
        For i = hauteurGrille / 4 To hauteurGrille * 0.75
            moteur.setEtatCellule(largeurGrille / 2, i, True)
        Next
        If largeurGrille >= 359 Then
            add = hauteurGrille / 2.28
        ElseIf largeurGrille < 359 And largeurGrille >= 181 Then
            add = hauteurGrille / 2.3
        ElseIf largeurGrille < 181 And largeurGrille > 45 Then
            add = hauteurGrille / 2.27
        ElseIf largeurGrille <= 45 Then
            add = hauteurGrille / 2.5
        End If
        For i = hauteurGrille / 4 To hauteurGrille * 0.75
            moteur.setEtatCellule(i + add, hauteurGrille / 2, True)
        Next
    End Sub

    Sub DessinLignesParalleles()
        For i = largeurGrille / 10 To largeurGrille Step largeurGrille / 5
            For j = hauteurGrille * 0.3 To hauteurGrille * 0.7
                moteur.setEtatCellule(i, j, True)
            Next
        Next
    End Sub

    Private Sub BtnAleatoire_Click(sender As Object, e As EventArgs) Handles btnAleatoire.Click
        Dim random As New Random
        Dim randomEchelles As Integer
        txtBoxCellule.Text = ""
        EffacerCellule()
        randomEchelles = random.Next(0, echelles.GetLength(0) - 1)
        largeurGrille = echelles(randomEchelles, 0)
        hauteurGrille = echelles(randomEchelles, 1)
        ReDim statutCell(largeurGrille, hauteurGrille)
        moteur.setTailleGrille(echelles(randomEchelles, 0), echelles(randomEchelles, 1))
        calculerCellules()
        choixMotif(random.Next(1, 11))
    End Sub

    Sub DessinCulbuteurs()
        Dim ligne, colonne As Integer
        Dim motif(,) As Integer = {{0, 0}, {1, 0}, {2, 0}, {4, 0}, {5, 0}, {6, 0}, {0, 1}, {6, 1}, {2, 2}, {4, 2}, {1, 3}, {2, 3}, {4, 3},
            {5, 3}, {0, 4}, {6, 4}}

        ligne = CInt((largeurGrille - 36) / 2)
        colonne = CInt((hauteurGrille - 36) / 2)
        For i = ligne To colonne + 30 Step 15
            For j = colonne To colonne + 30 Step 15
                For k = 0 To 15
                    moteur.setEtatCellule(i + motif(k, 0), j + motif(k, 1), True)
                    moteur.setEtatCellule(i + 15 + motif(k, 0), j + motif(k, 1), True)
                    moteur.setEtatCellule(i + 30 + motif(k, 0), j + motif(k, 1), True)
                Next
            Next
        Next
    End Sub

    Sub DessinPlaneurSimple()
        Dim ligne, colonne As Integer
        Dim ligneY() As Integer = {0, 1, 2, 2, 2}
        Dim colonneX() As Integer = {0, 1, -1, 0, 1}
        ligne = CInt((largeurGrille) / 2)
        colonne = CInt((hauteurGrille) / 2)

        For k = 0 To 4
            moteur.setEtatCellule(ligne + ligneY(k), colonne + colonneX(k), True)
        Next
    End Sub

    Sub DessinPlaneurs()
        Dim ligne, colonne As Integer
        Dim ligneY() As Integer = {0, 1, 2, 2, 2}
        Dim colonneX() As Integer = {0, 1, -1, 0, 1}
        ligne = CInt((largeurGrille - 32) / 2)
        colonne = CInt((hauteurGrille - 32) / 2)
        For i = ligne To ligne + 30 Step 10
            For j = colonne To colonne + 30 Step 10
                For k = 0 To 4
                    moteur.setEtatCellule(i + ligneY(k), j + colonneX(k), True)
                Next
            Next
        Next
    End Sub
    Sub DessinDoublePlaneurs()
        Dim ligne, colonne As Integer
        Dim motif(,) As Integer = {{0, 2}, {1, 0}, {1, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 5}, {4, 3}, {4, 4}, {5, 5}, {5, 6}, {6, 4}}
        ligne = CInt((largeurGrille - 38) / 2)
        colonne = CInt((hauteurGrille - 38) / 2)
        For i = ligne To ligne + 30 Step 15
            For j = colonne To colonne + 30 Step 15
                For k = 0 To motif.GetLength(0) - 1
                    moteur.setEtatCellule(i + motif(k, 0), j + motif(k, 1), True)
                Next
            Next
        Next
    End Sub

    Sub DessinVaisseaux()
        Dim ligne, colonne As Integer
        Dim motif(,) As Integer = {{0, 1}, {0, 2}, {0, 3}, {0, 4}, {1, 0}, {1, 4}, {2, 4}, {3, 0}, {3, 3}}
        ligne = CInt((largeurGrille - 36) / 2)
        colonne = CInt((hauteurGrille - 36) / 2)
        For i = ligne To colonne + 30 Step 25
            For j = colonne To colonne + 30 Step 25
                For k = 0 To motif.GetLength(0) - 1
                    moteur.setEtatCellule(i + motif(k, 0), j + motif(k, 1), True)
                Next
            Next
        Next
    End Sub
    Sub DessinGrosVaisseaux()
        Dim ligne, colonne As Integer
        Dim ligneY() As Integer = {0, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4,
                                 6, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8, 9, 9, 10}
        Dim colonneX() As Integer = {2, 0, 1, 0, 3, 4, 5, 8, 0, 5, 6, 7, 1, 2, 3, 6, 7,
                                 1, 2, 3, 6, 7, 0, 5, 6, 7, 0, 3, 4, 5, 8, 0, 1, 2}

        ligne = CInt((largeurGrille - 34) / 2)
        colonne = CInt((hauteurGrille - 34) / 2)
        For j = colonne To colonne + 25 Step 25
            For k = 0 To 33
                moteur.setEtatCellule(ligne + ligneY(k), j + colonneX(k), True)
            Next
        Next
        ligne += 25
        For j = colonne To colonne + 25 Step 25
            For k = 0 To 33
                moteur.setEtatCellule(ligne + 10 - ligneY(k), j + 8 - colonneX(k), True)
            Next
        Next
    End Sub

    Sub DessinGrosVaisseaux2()
        Dim ligne, colonne As Integer
        Dim ligneY() As Integer = {0, 1, 1, 1, 1, 2, 2, 2, 3, 4, 4,
                                 5, 5, 6, 6, 6, 7, 7, 8, 8, 9, 9,
                                 9, 10, 10, 11, 11, 12, 13, 13, 13, 14, 14, 14, 14, 15}
        Dim colonneX() As Integer = {2, 0, 1, 3, 4, 2, 5, 7, 7, 7, 9,
                                 7, 10, 5, 6, 10, 5, 6, 5, 6, 5, 6,
                                 10, 7, 10, 7, 9, 7, 2, 5, 7, 0, 1, 3, 4, 2}
        ligne = CInt((largeurGrille - 36) / 2)
        colonne = CInt((hauteurGrille - 36) / 2)
        For j = colonne To colonne + 25 Step 25
            For k = 0 To 35
                moteur.setEtatCellule(ligne + ligneY(k), j + colonneX(k), True)
            Next
        Next
        ligne += 25
        For j = colonne To colonne + 25 Step 25
            For k = 0 To 35
                moteur.setEtatCellule(ligne + 15 - ligneY(k), j + 10 - colonneX(k), True)
            Next
        Next
    End Sub
    Sub DessinCanon()
        Dim ligne, colonne As Integer
        Dim ligneY() As Integer = {0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4,
                                 4, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7, 7, 8}
        Dim colonneX() As Integer = {22, 23, 20, 24, 11, 19, 25, 11, 13, 18, 19, 21, 25, 34,
                                 35, 14, 15, 19, 25, 34, 35, 0, 1, 14, 15, 20, 24, 0, 1,
                                 14, 15, 22, 23, 11, 13, 11}
        ligne = CInt((largeurGrille - 10) / 2)
        colonne = CInt((hauteurGrille - 36) / 2)
        For k = 0 To 35
            moteur.setEtatCellule(ligne + ligneY(k), colonne + colonneX(k), True)
        Next
    End Sub

End Class