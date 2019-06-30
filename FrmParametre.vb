''Thibault ANIN                                                 2019                                               -- Dedi Orsay TP2E --

Public Class frmParametre
    Dim reglesPred() As String = {"Aucune", "Vie", "HighLife", "Vie3-4", "Prolifération", "Day&Night"}
    Dim selecteurTouche As Boolean
    Dim touche, toucheMod As Keys
    Public couleurFond, couleurGrille, couleurCellule As Color
    Private Sub FrmParametre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkBoxAfficherGrille.Checked = MoteurUI.afficherGrille

        chkBoxMultiCouleur.Checked = MoteurUI.multicolor
        couleurFond = MoteurUI.couleurFondChoisi
        couleurGrille = MoteurUI.couleurGrilleChoisi
        couleurCellule = MoteurUI.couleurCelluleChoisi
        pnlCouleurFond.BackColor = couleurFond
        pnlCouleurGrille.BackColor = couleurGrille
        pnlCouleurCellule.BackColor = couleurCellule

        If MoteurUI.UseMur Then
            chkBoxMur.Checked = MoteurUI.mur
        Else
            chkBoxMur.Hide()
        End If

        For Each regle As String In reglesPred
            cboBoxReglePred.Items.Add(regle)
        Next

        For Each ctrl In pnlNbCellNaissance.Controls
            Dim c As CheckBox = CType(ctrl, CheckBox)

            If MoteurUI.tabNbCellNaissance(CInt(c.Text)) <> 0 Then
                c.Checked = True
            End If
        Next

        For Each ctrl In pnlNbCellVie.Controls
            Dim c As CheckBox = CType(ctrl, CheckBox)

            If MoteurUI.tabNbCellMort(CInt(c.Text)) <> 0 Then
                c.Checked = True
            End If
        Next
        cboBoxReglePred.SelectedIndex = MoteurUI.reglePred

    End Sub
    Private Sub BtnAppliquer_Click(sender As Object, e As EventArgs) Handles btnAppliquer.Click
        MoteurUI.afficherGrille = chkBoxAfficherGrille.Checked
        MoteurUI.multicolor = chkBoxMultiCouleur.Checked


        MoteurUI.setCouleurFond(couleurFond)
        MoteurUI.setCouleurGrille(couleurGrille)
        MoteurUI.setCouleurCellule(couleurCellule)
        If MoteurUI.UseMur Then
            MoteurUI.mur = chkBoxMur.Checked
            MoteurUI.DefMur(chkBoxMur.Checked)
        End If
        regle()
        MoteurUI.majRegle()
        MoteurUI.Invalidate()
        Close()

    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        couleurFond = MoteurUI.couleurFondChoisi
        couleurGrille = MoteurUI.couleurGrilleChoisi
        couleurCellule = MoteurUI.couleurCelluleChoisi
        pnlCouleurFond.BackColor = couleurFond
        pnlCouleurGrille.BackColor = couleurGrille
        pnlCouleurCellule.BackColor = couleurCellule

        Close()
    End Sub

    Sub regle()
        Dim chckBoxTemp As New CheckBox
        Dim cpt As Integer = 8
        For Each ctrl In pnlNbCellNaissance.Controls
            Dim c As CheckBox = CType(ctrl, CheckBox)
            If c.Checked = True And c.Text <> "" Then
                MoteurUI.tabNbCellNaissance(cpt) = CInt((c.Text))
            Else
                MoteurUI.tabNbCellNaissance(cpt) = 0
            End If
            cpt -= 1
        Next
        cpt = 8
        For Each ctrl In pnlNbCellVie.Controls
            Dim c As CheckBox = CType(ctrl, CheckBox)
            If c.Checked = True And c.Text <> "" Then
                MoteurUI.tabNbCellMort(cpt) = CInt((c.Text))
            Else
                MoteurUI.tabNbCellMort(cpt) = 0
            End If
            cpt -= 1
        Next
    End Sub

    Sub regleRecap()
        Dim cptNaissance As Integer
        Dim cptMort As Integer
        Dim textRecapNaissance As String = ""
        Dim textRecapMort As String = ""
        For i = 0 To 8
            If MoteurUI.tabNbCellNaissance(i) > 0 Then
                cptNaissance += 1
            End If
            If MoteurUI.tabNbCellMort(i) > 0 Then
                cptMort += 1
            End If
        Next

        For i = 8 To 0 Step -1
            If MoteurUI.tabNbCellNaissance(i) > 0 Then
                textRecapNaissance += " " + CStr(MoteurUI.tabNbCellNaissance(i))
                cptNaissance -= 1
                If cptNaissance > 1 Then
                    textRecapNaissance += ","
                ElseIf cptNaissance <= 1 And cptNaissance > 0 Then
                    textRecapNaissance += " ou"
                End If
            End If
            If MoteurUI.tabNbCellMort(i) > 0 Then
                textRecapMort += " " + CStr(MoteurUI.tabNbCellMort(i))
                cptMort -= 1
                If cptMort > 1 Then
                    textRecapMort += ","
                ElseIf cptMort <= 1 And cptMort > 0 Then
                    textRecapMort += " ou"
                End If
            End If
        Next

        lblRegleRecap.Text = "Si une cellule morte a" & textRecapNaissance & " voisine(s), elle naît.

Si une cellule vivante a" & textRecapMort & " voisine(s), elle meurt, sinon elle continue à vivre."

        textRecapNaissance = ""
        textRecapMort = ""
    End Sub

    Private Sub BtnChckN_CheckedChanged(sender As Object, e As EventArgs) Handles btnChckN1.MouseClick,
            btnChckN2.MouseClick, btnChckN3.MouseClick, btnChckN4.MouseClick, btnChckN5.MouseClick,
            btnChckN6.MouseClick, btnChckN7.MouseClick, btnChckN8.MouseClick,
            btnChckV1.MouseClick, btnChckV2.MouseClick, btnChckV3.MouseClick, btnChckV4.MouseClick,
            btnChckV5.MouseClick, btnChckV6.MouseClick, btnChckV7.MouseClick, btnChckV8.MouseClick
        regle()
        regleRecap()
    End Sub

    Private Sub PnlCouleurFond_Click(sender As Object, e As EventArgs) Handles pnlCouleurFond.Click
        couleurFond = RecupCouleur(pnlCouleurFond.BackColor)
        pnlCouleurFond.BackColor = couleurFond

    End Sub

    Private Sub PnlCouleurGrille_Click(sender As Object, e As EventArgs) Handles pnlCouleurGrille.Click
        couleurGrille = RecupCouleur(pnlCouleurGrille.BackColor)
        pnlCouleurGrille.BackColor = couleurGrille

    End Sub

    Private Sub PnlCouleurCellule_Click(sender As Object, e As EventArgs) Handles pnlCouleurCellule.Click
        couleurCellule = RecupCouleur(pnlCouleurCellule.BackColor)
        pnlCouleurCellule.BackColor = couleurCellule
    End Sub

    Function RecupCouleur(ByVal couleur As Color) As Color
        Dim couleurs As DialogResult
        couleurs = paletteCouleur.ShowDialog()

        If couleurs = Windows.Forms.DialogResult.OK Then
            Return paletteCouleur.Color
        Else
            Return couleur
        End If
    End Function

    Private Sub CboBoxReglePred_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBoxReglePred.SelectedIndexChanged
        MoteurUI.reglePred = cboBoxReglePred.SelectedIndex
        If cboBoxReglePred.SelectedIndex <> 0 Then
            For Each ctrl In pnlNbCellNaissance.Controls
                Dim c As CheckBox = CType(ctrl, CheckBox)
                If c.Checked = True Then
                    c.Checked = False
                End If
            Next

            For Each ctrl In pnlNbCellVie.Controls
                Dim c As CheckBox = CType(ctrl, CheckBox)
                If c.Checked = True Then
                    c.Checked = False
                End If
            Next
        Else
            pbDemoReglePred.Image = Nothing
        End If

        Select Case cboBoxReglePred.SelectedIndex
            Case 1
                btnChckV2.Checked = True
                btnChckV3.Checked = True
                btnChckN3.Checked = True
                pbDemoReglePred.Image = My.Resources.heure
            Case 2
                btnChckV2.Checked = True
                btnChckV3.Checked = True
                btnChckN3.Checked = True
                btnChckN6.Checked = True
                pbDemoReglePred.Image = My.Resources.Conways_game_of_life_breeder_animation
            Case 3
                btnChckV3.Checked = True
                btnChckV4.Checked = True
                btnChckN3.Checked = True
                btnChckN4.Checked = True
                pbDemoReglePred.Image = My.Resources.Gospers_glider_gun
            Case 4

                btnChckV8.Checked = True
                btnChckN1.Checked = True
                pbDemoReglePred.Image = My.Resources.IncredibleShamefulCalf_max_1mb
            Case 5
                btnChckV3.Checked = True
                btnChckV4.Checked = True
                btnChckV6.Checked = True
                btnChckV7.Checked = True
                btnChckV8.Checked = True
                btnChckN3.Checked = True
                btnChckN4.Checked = True
                btnChckN6.Checked = True
                btnChckN7.Checked = True
                btnChckN8.Checked = True
                pbDemoReglePred.Image = My.Resources.Day_and_night
        End Select
    End Sub

    Private Sub BtnDefaut_Click(sender As Object, e As EventArgs) Handles btnDefaut.Click
        For Each ctrl In pnlNbCellNaissance.Controls
            Dim c As CheckBox = CType(ctrl, CheckBox)
            If c.Checked = True Then
                c.Checked = False
            End If
        Next
        For Each ctrl In pnlNbCellVie.Controls
            Dim c As CheckBox = CType(ctrl, CheckBox)
            If c.Checked = True Then
                c.Checked = False
            End If
        Next

        btnChckV2.Checked = True
        btnChckV3.Checked = True
        btnChckN3.Checked = True
    End Sub
End Class