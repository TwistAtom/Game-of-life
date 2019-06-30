<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametre))
        Me.grpBoxApparence = New System.Windows.Forms.GroupBox()
        Me.chkBoxMur = New System.Windows.Forms.CheckBox()
        Me.chkBoxMultiCouleur = New System.Windows.Forms.CheckBox()
        Me.lblCouleurCellule = New System.Windows.Forms.Label()
        Me.lblCouleurGrille = New System.Windows.Forms.Label()
        Me.lblCouleurFond = New System.Windows.Forms.Label()
        Me.pnlCouleurCellule = New System.Windows.Forms.Panel()
        Me.pnlCouleurGrille = New System.Windows.Forms.Panel()
        Me.pnlCouleurFond = New System.Windows.Forms.Panel()
        Me.chkBoxAfficherGrille = New System.Windows.Forms.CheckBox()
        Me.grpBoxRaccourci = New System.Windows.Forms.GroupBox()
        Me.lblRaccourci7 = New System.Windows.Forms.Label()
        Me.lblRaccourci6 = New System.Windows.Forms.Label()
        Me.lblRaccourci5 = New System.Windows.Forms.Label()
        Me.lblRaccourci4 = New System.Windows.Forms.Label()
        Me.lblRaccourci3 = New System.Windows.Forms.Label()
        Me.lblRaccourci2 = New System.Windows.Forms.Label()
        Me.lblRaccourci1 = New System.Windows.Forms.Label()
        Me.lblEffacer = New System.Windows.Forms.Label()
        Me.lblAcMotif = New System.Windows.Forms.Label()
        Me.lblRalentir = New System.Windows.Forms.Label()
        Me.lblAccélérer = New System.Windows.Forms.Label()
        Me.lblAvancer = New System.Windows.Forms.Label()
        Me.lblReculer = New System.Windows.Forms.Label()
        Me.lblLancer = New System.Windows.Forms.Label()
        Me.grpRegle = New System.Windows.Forms.GroupBox()
        Me.TbCtrlReglePara = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlNbCellNaissance = New System.Windows.Forms.Panel()
        Me.btnChckN8 = New System.Windows.Forms.CheckBox()
        Me.btnChckN7 = New System.Windows.Forms.CheckBox()
        Me.btnChckN6 = New System.Windows.Forms.CheckBox()
        Me.btnChckN5 = New System.Windows.Forms.CheckBox()
        Me.btnChckN4 = New System.Windows.Forms.CheckBox()
        Me.btnChckN3 = New System.Windows.Forms.CheckBox()
        Me.btnChckN2 = New System.Windows.Forms.CheckBox()
        Me.btnChckN1 = New System.Windows.Forms.CheckBox()
        Me.lblNbCellNaissance = New System.Windows.Forms.Label()
        Me.lblNbCellVie = New System.Windows.Forms.Label()
        Me.pnlNbCellVie = New System.Windows.Forms.Panel()
        Me.btnChckV8 = New System.Windows.Forms.CheckBox()
        Me.btnChckV7 = New System.Windows.Forms.CheckBox()
        Me.btnChckV6 = New System.Windows.Forms.CheckBox()
        Me.btnChckV5 = New System.Windows.Forms.CheckBox()
        Me.btnChckV4 = New System.Windows.Forms.CheckBox()
        Me.btnChckV3 = New System.Windows.Forms.CheckBox()
        Me.btnChckV2 = New System.Windows.Forms.CheckBox()
        Me.btnChckV1 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pbDemoReglePred = New System.Windows.Forms.PictureBox()
        Me.cboBoxReglePred = New System.Windows.Forms.ComboBox()
        Me.lblReglePred = New System.Windows.Forms.Label()
        Me.lblRegleRecap = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDefaut = New System.Windows.Forms.Button()
        Me.pnlBoutons = New System.Windows.Forms.Panel()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnAppliquer = New System.Windows.Forms.Button()
        Me.paletteCouleur = New System.Windows.Forms.ColorDialog()
        Me.grpBoxApparence.SuspendLayout()
        Me.grpBoxRaccourci.SuspendLayout()
        Me.grpRegle.SuspendLayout()
        Me.TbCtrlReglePara.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlNbCellNaissance.SuspendLayout()
        Me.pnlNbCellVie.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pbDemoReglePred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBoutons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxApparence
        '
        Me.grpBoxApparence.Controls.Add(Me.chkBoxMur)
        Me.grpBoxApparence.Controls.Add(Me.chkBoxMultiCouleur)
        Me.grpBoxApparence.Controls.Add(Me.lblCouleurCellule)
        Me.grpBoxApparence.Controls.Add(Me.lblCouleurGrille)
        Me.grpBoxApparence.Controls.Add(Me.lblCouleurFond)
        Me.grpBoxApparence.Controls.Add(Me.pnlCouleurCellule)
        Me.grpBoxApparence.Controls.Add(Me.pnlCouleurGrille)
        Me.grpBoxApparence.Controls.Add(Me.pnlCouleurFond)
        Me.grpBoxApparence.Controls.Add(Me.chkBoxAfficherGrille)
        Me.grpBoxApparence.Location = New System.Drawing.Point(60, 56)
        Me.grpBoxApparence.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBoxApparence.Name = "grpBoxApparence"
        Me.grpBoxApparence.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBoxApparence.Size = New System.Drawing.Size(458, 479)
        Me.grpBoxApparence.TabIndex = 0
        Me.grpBoxApparence.TabStop = False
        Me.grpBoxApparence.Text = "Apparence"
        '
        'chkBoxMur
        '
        Me.chkBoxMur.AutoSize = True
        Me.chkBoxMur.Location = New System.Drawing.Point(24, 185)
        Me.chkBoxMur.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBoxMur.Name = "chkBoxMur"
        Me.chkBoxMur.Size = New System.Drawing.Size(81, 29)
        Me.chkBoxMur.TabIndex = 49
        Me.chkBoxMur.Text = "Mur"
        Me.chkBoxMur.UseVisualStyleBackColor = True
        '
        'chkBoxMultiCouleur
        '
        Me.chkBoxMultiCouleur.AutoSize = True
        Me.chkBoxMultiCouleur.Location = New System.Drawing.Point(24, 126)
        Me.chkBoxMultiCouleur.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBoxMultiCouleur.Name = "chkBoxMultiCouleur"
        Me.chkBoxMultiCouleur.Size = New System.Drawing.Size(220, 29)
        Me.chkBoxMultiCouleur.TabIndex = 48
        Me.chkBoxMultiCouleur.Text = "Mode multicouleur"
        Me.chkBoxMultiCouleur.UseVisualStyleBackColor = True
        '
        'lblCouleurCellule
        '
        Me.lblCouleurCellule.AutoSize = True
        Me.lblCouleurCellule.Location = New System.Drawing.Point(19, 400)
        Me.lblCouleurCellule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCouleurCellule.Name = "lblCouleurCellule"
        Me.lblCouleurCellule.Size = New System.Drawing.Size(155, 25)
        Me.lblCouleurCellule.TabIndex = 47
        Me.lblCouleurCellule.Text = "Couleur cellule"
        '
        'lblCouleurGrille
        '
        Me.lblCouleurGrille.AutoSize = True
        Me.lblCouleurGrille.Location = New System.Drawing.Point(19, 349)
        Me.lblCouleurGrille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCouleurGrille.Name = "lblCouleurGrille"
        Me.lblCouleurGrille.Size = New System.Drawing.Size(139, 25)
        Me.lblCouleurGrille.TabIndex = 46
        Me.lblCouleurGrille.Text = "Couleur grille"
        '
        'lblCouleurFond
        '
        Me.lblCouleurFond.AutoSize = True
        Me.lblCouleurFond.Location = New System.Drawing.Point(19, 299)
        Me.lblCouleurFond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCouleurFond.Name = "lblCouleurFond"
        Me.lblCouleurFond.Size = New System.Drawing.Size(135, 25)
        Me.lblCouleurFond.TabIndex = 45
        Me.lblCouleurFond.Text = "Couleur fond"
        '
        'pnlCouleurCellule
        '
        Me.pnlCouleurCellule.BackColor = System.Drawing.Color.Gold
        Me.pnlCouleurCellule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCouleurCellule.Location = New System.Drawing.Point(300, 400)
        Me.pnlCouleurCellule.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlCouleurCellule.Name = "pnlCouleurCellule"
        Me.pnlCouleurCellule.Size = New System.Drawing.Size(84, 35)
        Me.pnlCouleurCellule.TabIndex = 5
        '
        'pnlCouleurGrille
        '
        Me.pnlCouleurGrille.BackColor = System.Drawing.Color.DarkGray
        Me.pnlCouleurGrille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCouleurGrille.Location = New System.Drawing.Point(300, 349)
        Me.pnlCouleurGrille.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlCouleurGrille.Name = "pnlCouleurGrille"
        Me.pnlCouleurGrille.Size = New System.Drawing.Size(84, 35)
        Me.pnlCouleurGrille.TabIndex = 5
        '
        'pnlCouleurFond
        '
        Me.pnlCouleurFond.BackColor = System.Drawing.Color.DimGray
        Me.pnlCouleurFond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCouleurFond.Location = New System.Drawing.Point(300, 299)
        Me.pnlCouleurFond.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlCouleurFond.Name = "pnlCouleurFond"
        Me.pnlCouleurFond.Size = New System.Drawing.Size(84, 35)
        Me.pnlCouleurFond.TabIndex = 4
        '
        'chkBoxAfficherGrille
        '
        Me.chkBoxAfficherGrille.AutoSize = True
        Me.chkBoxAfficherGrille.Location = New System.Drawing.Point(24, 67)
        Me.chkBoxAfficherGrille.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBoxAfficherGrille.Name = "chkBoxAfficherGrille"
        Me.chkBoxAfficherGrille.Size = New System.Drawing.Size(169, 29)
        Me.chkBoxAfficherGrille.TabIndex = 0
        Me.chkBoxAfficherGrille.Text = "Afficher grille"
        Me.chkBoxAfficherGrille.UseVisualStyleBackColor = True
        '
        'grpBoxRaccourci
        '
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci7)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci6)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci5)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci4)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci3)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci2)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRaccourci1)
        Me.grpBoxRaccourci.Controls.Add(Me.lblEffacer)
        Me.grpBoxRaccourci.Controls.Add(Me.lblAcMotif)
        Me.grpBoxRaccourci.Controls.Add(Me.lblRalentir)
        Me.grpBoxRaccourci.Controls.Add(Me.lblAccélérer)
        Me.grpBoxRaccourci.Controls.Add(Me.lblAvancer)
        Me.grpBoxRaccourci.Controls.Add(Me.lblReculer)
        Me.grpBoxRaccourci.Controls.Add(Me.lblLancer)
        Me.grpBoxRaccourci.Location = New System.Drawing.Point(60, 569)
        Me.grpBoxRaccourci.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBoxRaccourci.Name = "grpBoxRaccourci"
        Me.grpBoxRaccourci.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBoxRaccourci.Size = New System.Drawing.Size(458, 434)
        Me.grpBoxRaccourci.TabIndex = 1
        Me.grpBoxRaccourci.TabStop = False
        Me.grpBoxRaccourci.Text = "Raccourci"
        '
        'lblRaccourci7
        '
        Me.lblRaccourci7.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci7.Location = New System.Drawing.Point(264, 357)
        Me.lblRaccourci7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci7.Name = "lblRaccourci7"
        Me.lblRaccourci7.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci7.TabIndex = 62
        Me.lblRaccourci7.Text = "Ctrl + Retour"
        Me.lblRaccourci7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaccourci6
        '
        Me.lblRaccourci6.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci6.Location = New System.Drawing.Point(264, 311)
        Me.lblRaccourci6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci6.Name = "lblRaccourci6"
        Me.lblRaccourci6.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci6.TabIndex = 61
        Me.lblRaccourci6.Text = "Ctrl + R"
        Me.lblRaccourci6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaccourci5
        '
        Me.lblRaccourci5.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci5.Location = New System.Drawing.Point(264, 264)
        Me.lblRaccourci5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci5.Name = "lblRaccourci5"
        Me.lblRaccourci5.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci5.TabIndex = 60
        Me.lblRaccourci5.Text = "Shift + Q"
        Me.lblRaccourci5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaccourci4
        '
        Me.lblRaccourci4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci4.Location = New System.Drawing.Point(264, 218)
        Me.lblRaccourci4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci4.Name = "lblRaccourci4"
        Me.lblRaccourci4.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci4.TabIndex = 59
        Me.lblRaccourci4.Text = "Shift + A"
        Me.lblRaccourci4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaccourci3
        '
        Me.lblRaccourci3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci3.Location = New System.Drawing.Point(264, 171)
        Me.lblRaccourci3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci3.Name = "lblRaccourci3"
        Me.lblRaccourci3.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci3.TabIndex = 58
        Me.lblRaccourci3.Text = "Shift + Z"
        Me.lblRaccourci3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaccourci2
        '
        Me.lblRaccourci2.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci2.Location = New System.Drawing.Point(264, 124)
        Me.lblRaccourci2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci2.Name = "lblRaccourci2"
        Me.lblRaccourci2.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci2.TabIndex = 57
        Me.lblRaccourci2.Text = "Shift + S"
        Me.lblRaccourci2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaccourci1
        '
        Me.lblRaccourci1.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRaccourci1.Location = New System.Drawing.Point(264, 77)
        Me.lblRaccourci1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaccourci1.Name = "lblRaccourci1"
        Me.lblRaccourci1.Size = New System.Drawing.Size(159, 37)
        Me.lblRaccourci1.TabIndex = 56
        Me.lblRaccourci1.Text = "Ctrl + Espace"
        Me.lblRaccourci1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEffacer
        '
        Me.lblEffacer.AutoSize = True
        Me.lblEffacer.Location = New System.Drawing.Point(19, 357)
        Me.lblEffacer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEffacer.Name = "lblEffacer"
        Me.lblEffacer.Size = New System.Drawing.Size(80, 25)
        Me.lblEffacer.TabIndex = 55
        Me.lblEffacer.Text = "Effacer"
        '
        'lblAcMotif
        '
        Me.lblAcMotif.AutoSize = True
        Me.lblAcMotif.Location = New System.Drawing.Point(19, 311)
        Me.lblAcMotif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAcMotif.Name = "lblAcMotif"
        Me.lblAcMotif.Size = New System.Drawing.Size(159, 25)
        Me.lblAcMotif.TabIndex = 54
        Me.lblAcMotif.Text = "Actualiser motif"
        '
        'lblRalentir
        '
        Me.lblRalentir.AutoSize = True
        Me.lblRalentir.Location = New System.Drawing.Point(19, 267)
        Me.lblRalentir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRalentir.Name = "lblRalentir"
        Me.lblRalentir.Size = New System.Drawing.Size(86, 25)
        Me.lblRalentir.TabIndex = 53
        Me.lblRalentir.Text = "Ralentir"
        '
        'lblAccélérer
        '
        Me.lblAccélérer.AutoSize = True
        Me.lblAccélérer.Location = New System.Drawing.Point(19, 222)
        Me.lblAccélérer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccélérer.Name = "lblAccélérer"
        Me.lblAccélérer.Size = New System.Drawing.Size(103, 25)
        Me.lblAccélérer.TabIndex = 52
        Me.lblAccélérer.Text = "Accélérer"
        '
        'lblAvancer
        '
        Me.lblAvancer.AutoSize = True
        Me.lblAvancer.Location = New System.Drawing.Point(19, 176)
        Me.lblAvancer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvancer.Name = "lblAvancer"
        Me.lblAvancer.Size = New System.Drawing.Size(139, 25)
        Me.lblAvancer.TabIndex = 51
        Me.lblAvancer.Text = "Avancer de 1"
        '
        'lblReculer
        '
        Me.lblReculer.AutoSize = True
        Me.lblReculer.Location = New System.Drawing.Point(19, 124)
        Me.lblReculer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReculer.Name = "lblReculer"
        Me.lblReculer.Size = New System.Drawing.Size(134, 25)
        Me.lblReculer.TabIndex = 50
        Me.lblReculer.Text = "Recluer de 1"
        '
        'lblLancer
        '
        Me.lblLancer.AutoSize = True
        Me.lblLancer.Location = New System.Drawing.Point(19, 77)
        Me.lblLancer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLancer.Name = "lblLancer"
        Me.lblLancer.Size = New System.Drawing.Size(159, 25)
        Me.lblLancer.TabIndex = 49
        Me.lblLancer.Text = "Lancer/Stopper"
        '
        'grpRegle
        '
        Me.grpRegle.Controls.Add(Me.TbCtrlReglePara)
        Me.grpRegle.Controls.Add(Me.lblRegleRecap)
        Me.grpRegle.Controls.Add(Me.Label1)
        Me.grpRegle.Controls.Add(Me.btnDefaut)
        Me.grpRegle.Location = New System.Drawing.Point(712, 56)
        Me.grpRegle.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRegle.Name = "grpRegle"
        Me.grpRegle.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRegle.Size = New System.Drawing.Size(786, 902)
        Me.grpRegle.TabIndex = 2
        Me.grpRegle.TabStop = False
        Me.grpRegle.Text = "Règles"
        '
        'TbCtrlReglePara
        '
        Me.TbCtrlReglePara.Controls.Add(Me.TabPage1)
        Me.TbCtrlReglePara.Controls.Add(Me.TabPage2)
        Me.TbCtrlReglePara.Location = New System.Drawing.Point(6, 67)
        Me.TbCtrlReglePara.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCtrlReglePara.Name = "TbCtrlReglePara"
        Me.TbCtrlReglePara.SelectedIndex = 0
        Me.TbCtrlReglePara.Size = New System.Drawing.Size(776, 512)
        Me.TbCtrlReglePara.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.pnlNbCellNaissance)
        Me.TabPage1.Controls.Add(Me.lblNbCellNaissance)
        Me.TabPage1.Controls.Add(Me.lblNbCellVie)
        Me.TabPage1.Controls.Add(Me.pnlNbCellVie)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(760, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Règles paramétrables"
        '
        'pnlNbCellNaissance
        '
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN8)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN7)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN6)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN5)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN4)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN3)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN2)
        Me.pnlNbCellNaissance.Controls.Add(Me.btnChckN1)
        Me.pnlNbCellNaissance.Location = New System.Drawing.Point(6, 88)
        Me.pnlNbCellNaissance.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNbCellNaissance.Name = "pnlNbCellNaissance"
        Me.pnlNbCellNaissance.Size = New System.Drawing.Size(748, 90)
        Me.pnlNbCellNaissance.TabIndex = 43
        '
        'btnChckN8
        '
        Me.btnChckN8.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN8.Location = New System.Drawing.Point(644, 19)
        Me.btnChckN8.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN8.Name = "btnChckN8"
        Me.btnChckN8.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN8.TabIndex = 42
        Me.btnChckN8.Text = "8"
        Me.btnChckN8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN8.UseVisualStyleBackColor = True
        '
        'btnChckN7
        '
        Me.btnChckN7.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN7.Location = New System.Drawing.Point(560, 19)
        Me.btnChckN7.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN7.Name = "btnChckN7"
        Me.btnChckN7.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN7.TabIndex = 41
        Me.btnChckN7.Text = "7"
        Me.btnChckN7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN7.UseVisualStyleBackColor = True
        '
        'btnChckN6
        '
        Me.btnChckN6.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN6.Location = New System.Drawing.Point(476, 19)
        Me.btnChckN6.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN6.Name = "btnChckN6"
        Me.btnChckN6.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN6.TabIndex = 40
        Me.btnChckN6.Text = "6"
        Me.btnChckN6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN6.UseVisualStyleBackColor = True
        '
        'btnChckN5
        '
        Me.btnChckN5.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN5.Location = New System.Drawing.Point(394, 19)
        Me.btnChckN5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN5.Name = "btnChckN5"
        Me.btnChckN5.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN5.TabIndex = 39
        Me.btnChckN5.Text = "5"
        Me.btnChckN5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN5.UseVisualStyleBackColor = True
        '
        'btnChckN4
        '
        Me.btnChckN4.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN4.Location = New System.Drawing.Point(310, 19)
        Me.btnChckN4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN4.Name = "btnChckN4"
        Me.btnChckN4.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN4.TabIndex = 38
        Me.btnChckN4.Text = "4"
        Me.btnChckN4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN4.UseVisualStyleBackColor = True
        '
        'btnChckN3
        '
        Me.btnChckN3.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN3.Location = New System.Drawing.Point(226, 19)
        Me.btnChckN3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN3.Name = "btnChckN3"
        Me.btnChckN3.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN3.TabIndex = 37
        Me.btnChckN3.Text = "3"
        Me.btnChckN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN3.UseVisualStyleBackColor = True
        '
        'btnChckN2
        '
        Me.btnChckN2.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN2.Location = New System.Drawing.Point(142, 19)
        Me.btnChckN2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN2.Name = "btnChckN2"
        Me.btnChckN2.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN2.TabIndex = 36
        Me.btnChckN2.Text = "2"
        Me.btnChckN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN2.UseVisualStyleBackColor = True
        '
        'btnChckN1
        '
        Me.btnChckN1.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckN1.Location = New System.Drawing.Point(58, 19)
        Me.btnChckN1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckN1.Name = "btnChckN1"
        Me.btnChckN1.Size = New System.Drawing.Size(49, 50)
        Me.btnChckN1.TabIndex = 35
        Me.btnChckN1.Text = "1"
        Me.btnChckN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckN1.UseVisualStyleBackColor = True
        '
        'lblNbCellNaissance
        '
        Me.lblNbCellNaissance.AutoSize = True
        Me.lblNbCellNaissance.Location = New System.Drawing.Point(12, 50)
        Me.lblNbCellNaissance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbCellNaissance.Name = "lblNbCellNaissance"
        Me.lblNbCellNaissance.Size = New System.Drawing.Size(424, 25)
        Me.lblNbCellNaissance.TabIndex = 13
        Me.lblNbCellNaissance.Text = "Nombre de cellule(s) voisine(s)  pour naître"
        '
        'lblNbCellVie
        '
        Me.lblNbCellVie.AutoSize = True
        Me.lblNbCellVie.Location = New System.Drawing.Point(12, 242)
        Me.lblNbCellVie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbCellVie.Name = "lblNbCellVie"
        Me.lblNbCellVie.Size = New System.Drawing.Size(535, 25)
        Me.lblNbCellVie.TabIndex = 14
        Me.lblNbCellVie.Text = "Nombre de cellule(s) voisine(s)  pour continuer à vivre "
        '
        'pnlNbCellVie
        '
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV8)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV7)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV6)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV5)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV4)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV3)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV2)
        Me.pnlNbCellVie.Controls.Add(Me.btnChckV1)
        Me.pnlNbCellVie.Location = New System.Drawing.Point(6, 283)
        Me.pnlNbCellVie.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNbCellVie.Name = "pnlNbCellVie"
        Me.pnlNbCellVie.Size = New System.Drawing.Size(748, 90)
        Me.pnlNbCellVie.TabIndex = 44
        '
        'btnChckV8
        '
        Me.btnChckV8.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV8.Location = New System.Drawing.Point(645, 23)
        Me.btnChckV8.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV8.Name = "btnChckV8"
        Me.btnChckV8.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV8.TabIndex = 42
        Me.btnChckV8.Text = "8"
        Me.btnChckV8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV8.UseVisualStyleBackColor = True
        '
        'btnChckV7
        '
        Me.btnChckV7.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV7.Location = New System.Drawing.Point(561, 23)
        Me.btnChckV7.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV7.Name = "btnChckV7"
        Me.btnChckV7.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV7.TabIndex = 41
        Me.btnChckV7.Text = "7"
        Me.btnChckV7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV7.UseVisualStyleBackColor = True
        '
        'btnChckV6
        '
        Me.btnChckV6.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV6.Location = New System.Drawing.Point(477, 23)
        Me.btnChckV6.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV6.Name = "btnChckV6"
        Me.btnChckV6.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV6.TabIndex = 40
        Me.btnChckV6.Text = "6"
        Me.btnChckV6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV6.UseVisualStyleBackColor = True
        '
        'btnChckV5
        '
        Me.btnChckV5.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV5.Location = New System.Drawing.Point(393, 23)
        Me.btnChckV5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV5.Name = "btnChckV5"
        Me.btnChckV5.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV5.TabIndex = 39
        Me.btnChckV5.Text = "5"
        Me.btnChckV5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV5.UseVisualStyleBackColor = True
        '
        'btnChckV4
        '
        Me.btnChckV4.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV4.Location = New System.Drawing.Point(309, 23)
        Me.btnChckV4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV4.Name = "btnChckV4"
        Me.btnChckV4.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV4.TabIndex = 38
        Me.btnChckV4.Text = "4"
        Me.btnChckV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV4.UseVisualStyleBackColor = True
        '
        'btnChckV3
        '
        Me.btnChckV3.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV3.Location = New System.Drawing.Point(225, 23)
        Me.btnChckV3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV3.Name = "btnChckV3"
        Me.btnChckV3.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV3.TabIndex = 37
        Me.btnChckV3.Text = "3"
        Me.btnChckV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV3.UseVisualStyleBackColor = True
        '
        'btnChckV2
        '
        Me.btnChckV2.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV2.Location = New System.Drawing.Point(141, 23)
        Me.btnChckV2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV2.Name = "btnChckV2"
        Me.btnChckV2.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV2.TabIndex = 36
        Me.btnChckV2.Text = "2"
        Me.btnChckV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV2.UseVisualStyleBackColor = True
        '
        'btnChckV1
        '
        Me.btnChckV1.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnChckV1.Location = New System.Drawing.Point(57, 23)
        Me.btnChckV1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChckV1.Name = "btnChckV1"
        Me.btnChckV1.Size = New System.Drawing.Size(50, 50)
        Me.btnChckV1.TabIndex = 35
        Me.btnChckV1.Text = "1"
        Me.btnChckV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChckV1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.pbDemoReglePred)
        Me.TabPage2.Controls.Add(Me.cboBoxReglePred)
        Me.TabPage2.Controls.Add(Me.lblReglePred)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(760, 465)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Règles prédéfinies"
        '
        'pbDemoReglePred
        '
        Me.pbDemoReglePred.Location = New System.Drawing.Point(39, 136)
        Me.pbDemoReglePred.Name = "pbDemoReglePred"
        Me.pbDemoReglePred.Size = New System.Drawing.Size(682, 310)
        Me.pbDemoReglePred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbDemoReglePred.TabIndex = 47
        Me.pbDemoReglePred.TabStop = False
        '
        'cboBoxReglePred
        '
        Me.cboBoxReglePred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBoxReglePred.Location = New System.Drawing.Point(24, 78)
        Me.cboBoxReglePred.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBoxReglePred.Name = "cboBoxReglePred"
        Me.cboBoxReglePred.Size = New System.Drawing.Size(300, 33)
        Me.cboBoxReglePred.TabIndex = 45
        '
        'lblReglePred
        '
        Me.lblReglePred.AutoSize = True
        Me.lblReglePred.Location = New System.Drawing.Point(18, 38)
        Me.lblReglePred.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReglePred.Name = "lblReglePred"
        Me.lblReglePred.Size = New System.Drawing.Size(203, 25)
        Me.lblReglePred.TabIndex = 46
        Me.lblReglePred.Text = "Règles prédéfinies :"
        '
        'lblRegleRecap
        '
        Me.lblRegleRecap.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegleRecap.Location = New System.Drawing.Point(20, 621)
        Me.lblRegleRecap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegleRecap.Name = "lblRegleRecap"
        Me.lblRegleRecap.Size = New System.Drawing.Size(754, 212)
        Me.lblRegleRecap.TabIndex = 24
        Me.lblRegleRecap.Text = "Si une cellule morte a 3 voisine(s), elle naît" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si une cellule vivante a 2 ou " &
    "3 voisine(s), elle meurt, sinon elle continue à vivre."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 227)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 12
        '
        'btnDefaut
        '
        Me.btnDefaut.Location = New System.Drawing.Point(436, 837)
        Me.btnDefaut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDefaut.Name = "btnDefaut"
        Me.btnDefaut.Size = New System.Drawing.Size(330, 50)
        Me.btnDefaut.TabIndex = 0
        Me.btnDefaut.Text = "Paramètrespar défaut"
        Me.btnDefaut.UseVisualStyleBackColor = True
        '
        'pnlBoutons
        '
        Me.pnlBoutons.Controls.Add(Me.btnAnnuler)
        Me.pnlBoutons.Controls.Add(Me.btnAppliquer)
        Me.pnlBoutons.Location = New System.Drawing.Point(712, 963)
        Me.pnlBoutons.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBoutons.Name = "pnlBoutons"
        Me.pnlBoutons.Size = New System.Drawing.Size(786, 79)
        Me.pnlBoutons.TabIndex = 3
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(132, 10)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(238, 60)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnAppliquer
        '
        Me.btnAppliquer.Location = New System.Drawing.Point(420, 10)
        Me.btnAppliquer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAppliquer.Name = "btnAppliquer"
        Me.btnAppliquer.Size = New System.Drawing.Size(238, 60)
        Me.btnAppliquer.TabIndex = 0
        Me.btnAppliquer.Text = "Appliquer"
        Me.btnAppliquer.UseVisualStyleBackColor = True
        '
        'frmParametre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1550, 1071)
        Me.Controls.Add(Me.pnlBoutons)
        Me.Controls.Add(Me.grpRegle)
        Me.Controls.Add(Me.grpBoxRaccourci)
        Me.Controls.Add(Me.grpBoxApparence)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1576, 1142)
        Me.Name = "frmParametre"
        Me.Text = "Paramètres avancés"
        Me.grpBoxApparence.ResumeLayout(False)
        Me.grpBoxApparence.PerformLayout()
        Me.grpBoxRaccourci.ResumeLayout(False)
        Me.grpBoxRaccourci.PerformLayout()
        Me.grpRegle.ResumeLayout(False)
        Me.grpRegle.PerformLayout()
        Me.TbCtrlReglePara.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlNbCellNaissance.ResumeLayout(False)
        Me.pnlNbCellVie.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pbDemoReglePred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBoutons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBoxApparence As GroupBox
    Friend WithEvents grpBoxRaccourci As GroupBox
    Friend WithEvents grpRegle As GroupBox
    Friend WithEvents pnlBoutons As Panel
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnAppliquer As Button
    Friend WithEvents chkBoxAfficherGrille As CheckBox
    Friend WithEvents btnDefaut As Button
    Friend WithEvents lblRegleRecap As Label
    Friend WithEvents lblNbCellVie As Label
    Friend WithEvents lblNbCellNaissance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChckV8 As CheckBox
    Friend WithEvents btnChckV7 As CheckBox
    Friend WithEvents btnChckV6 As CheckBox
    Friend WithEvents btnChckV5 As CheckBox
    Friend WithEvents btnChckV4 As CheckBox
    Friend WithEvents btnChckV3 As CheckBox
    Friend WithEvents btnChckV2 As CheckBox
    Friend WithEvents btnChckV1 As CheckBox
    Friend WithEvents pnlNbCellNaissance As Panel
    Friend WithEvents btnChckN8 As CheckBox
    Friend WithEvents btnChckN7 As CheckBox
    Friend WithEvents btnChckN6 As CheckBox
    Friend WithEvents btnChckN5 As CheckBox
    Friend WithEvents btnChckN4 As CheckBox
    Friend WithEvents btnChckN3 As CheckBox
    Friend WithEvents btnChckN2 As CheckBox
    Friend WithEvents btnChckN1 As CheckBox
    Friend WithEvents pnlNbCellVie As Panel
    Friend WithEvents cboBoxReglePred As ComboBox
    Friend WithEvents lblReglePred As Label
    Friend WithEvents TbCtrlReglePara As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnlCouleurFond As Panel
    Friend WithEvents paletteCouleur As ColorDialog
    Friend WithEvents pnlCouleurCellule As Panel
    Friend WithEvents pnlCouleurGrille As Panel
    Friend WithEvents lblCouleurCellule As Label
    Friend WithEvents lblCouleurGrille As Label
    Friend WithEvents lblCouleurFond As Label
    Friend WithEvents chkBoxMultiCouleur As CheckBox
    Friend WithEvents lblEffacer As Label
    Friend WithEvents lblAcMotif As Label
    Friend WithEvents lblRalentir As Label
    Friend WithEvents lblAccélérer As Label
    Friend WithEvents lblAvancer As Label
    Friend WithEvents lblReculer As Label
    Friend WithEvents lblLancer As Label
    Friend WithEvents lblRaccourci7 As Label
    Friend WithEvents lblRaccourci6 As Label
    Friend WithEvents lblRaccourci5 As Label
    Friend WithEvents lblRaccourci4 As Label
    Friend WithEvents lblRaccourci3 As Label
    Friend WithEvents lblRaccourci2 As Label
    Friend WithEvents lblRaccourci1 As Label
    Friend WithEvents chkBoxMur As CheckBox
    Friend WithEvents pbDemoReglePred As PictureBox
End Class
