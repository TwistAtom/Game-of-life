<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MoteurUI
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoteurUI))
        Me.pnlBoutons = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbReculerDe1 = New System.Windows.Forms.PictureBox()
        Me.pbAvancerDe1 = New System.Windows.Forms.PictureBox()
        Me.pbEffacer = New System.Windows.Forms.PictureBox()
        Me.cboBoxEchelle = New System.Windows.Forms.ComboBox()
        Me.lblVitesse = New System.Windows.Forms.Label()
        Me.trckBrVitesse = New System.Windows.Forms.TrackBar()
        Me.txtBoxCellule = New System.Windows.Forms.TextBox()
        Me.btnAleatoire = New System.Windows.Forms.Button()
        Me.lblGenerationDyn = New System.Windows.Forms.Label()
        Me.lblCelluleEnVieDyn = New System.Windows.Forms.Label()
        Me.lblCelluleDetruiteDyn = New System.Windows.Forms.Label()
        Me.lblGeneration = New System.Windows.Forms.Label()
        Me.lblCelluleEnVie = New System.Windows.Forms.Label()
        Me.lblCelluleDetruite = New System.Windows.Forms.Label()
        Me.lblCelluleCreeeDyn = New System.Windows.Forms.Label()
        Me.lblCelluleCreee = New System.Windows.Forms.Label()
        Me.lblIteration = New System.Windows.Forms.Label()
        Me.lblEchelle = New System.Windows.Forms.Label()
        Me.lblCellule = New System.Windows.Forms.Label()
        Me.cboBoxIteration = New System.Windows.Forms.ComboBox()
        Me.btnMotif = New System.Windows.Forms.Button()
        Me.btnLancer = New System.Windows.Forms.Button()
        Me.pbAvance = New System.Windows.Forms.PictureBox()
        Me.pbQuitter = New System.Windows.Forms.PictureBox()
        Me.TimerJeu = New System.Windows.Forms.Timer(Me.components)
        Me.pbAide = New System.Windows.Forms.PictureBox()
        Me.ctMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ltmLancer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmParametreAvance = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMotif = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBoutons.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReculerDe1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAvancerDe1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEffacer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trckBrVitesse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBoutons
        '
        Me.pnlBoutons.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlBoutons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBoutons.Controls.Add(Me.PictureBox2)
        Me.pnlBoutons.Controls.Add(Me.PictureBox1)
        Me.pnlBoutons.Controls.Add(Me.pbReculerDe1)
        Me.pnlBoutons.Controls.Add(Me.pbAvancerDe1)
        Me.pnlBoutons.Controls.Add(Me.pbEffacer)
        Me.pnlBoutons.Controls.Add(Me.cboBoxEchelle)
        Me.pnlBoutons.Controls.Add(Me.lblVitesse)
        Me.pnlBoutons.Controls.Add(Me.trckBrVitesse)
        Me.pnlBoutons.Controls.Add(Me.txtBoxCellule)
        Me.pnlBoutons.Controls.Add(Me.btnAleatoire)
        Me.pnlBoutons.Controls.Add(Me.lblGenerationDyn)
        Me.pnlBoutons.Controls.Add(Me.lblCelluleEnVieDyn)
        Me.pnlBoutons.Controls.Add(Me.lblCelluleDetruiteDyn)
        Me.pnlBoutons.Controls.Add(Me.lblGeneration)
        Me.pnlBoutons.Controls.Add(Me.lblCelluleEnVie)
        Me.pnlBoutons.Controls.Add(Me.lblCelluleDetruite)
        Me.pnlBoutons.Controls.Add(Me.lblCelluleCreeeDyn)
        Me.pnlBoutons.Controls.Add(Me.lblCelluleCreee)
        Me.pnlBoutons.Controls.Add(Me.lblIteration)
        Me.pnlBoutons.Controls.Add(Me.lblEchelle)
        Me.pnlBoutons.Controls.Add(Me.lblCellule)
        Me.pnlBoutons.Controls.Add(Me.cboBoxIteration)
        Me.pnlBoutons.Controls.Add(Me.btnMotif)
        Me.pnlBoutons.Controls.Add(Me.btnLancer)
        Me.pnlBoutons.Controls.Add(Me.pbAvance)
        Me.pnlBoutons.Controls.Add(Me.pbQuitter)
        Me.pnlBoutons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBoutons.Location = New System.Drawing.Point(0, 882)
        Me.pnlBoutons.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBoutons.Name = "pnlBoutons"
        Me.pnlBoutons.Size = New System.Drawing.Size(1816, 178)
        Me.pnlBoutons.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1284, 28)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(692, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'pbReculerDe1
        '
        Me.pbReculerDe1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbReculerDe1.BackColor = System.Drawing.Color.Transparent
        Me.pbReculerDe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbReculerDe1.Image = CType(resources.GetObject("pbReculerDe1.Image"), System.Drawing.Image)
        Me.pbReculerDe1.Location = New System.Drawing.Point(864, 104)
        Me.pbReculerDe1.Margin = New System.Windows.Forms.Padding(0)
        Me.pbReculerDe1.Name = "pbReculerDe1"
        Me.pbReculerDe1.Size = New System.Drawing.Size(66, 68)
        Me.pbReculerDe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReculerDe1.TabIndex = 31
        Me.pbReculerDe1.TabStop = False
        '
        'pbAvancerDe1
        '
        Me.pbAvancerDe1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAvancerDe1.BackColor = System.Drawing.Color.Transparent
        Me.pbAvancerDe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbAvancerDe1.Image = CType(resources.GetObject("pbAvancerDe1.Image"), System.Drawing.Image)
        Me.pbAvancerDe1.Location = New System.Drawing.Point(1072, 104)
        Me.pbAvancerDe1.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAvancerDe1.Name = "pbAvancerDe1"
        Me.pbAvancerDe1.Size = New System.Drawing.Size(62, 68)
        Me.pbAvancerDe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAvancerDe1.TabIndex = 30
        Me.pbAvancerDe1.TabStop = False
        '
        'pbEffacer
        '
        Me.pbEffacer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbEffacer.BackColor = System.Drawing.Color.Transparent
        Me.pbEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbEffacer.Image = CType(resources.GetObject("pbEffacer.Image"), System.Drawing.Image)
        Me.pbEffacer.Location = New System.Drawing.Point(960, 94)
        Me.pbEffacer.Margin = New System.Windows.Forms.Padding(0)
        Me.pbEffacer.Name = "pbEffacer"
        Me.pbEffacer.Size = New System.Drawing.Size(84, 84)
        Me.pbEffacer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEffacer.TabIndex = 29
        Me.pbEffacer.TabStop = False
        '
        'cboBoxEchelle
        '
        Me.cboBoxEchelle.FormattingEnabled = True
        Me.cboBoxEchelle.Location = New System.Drawing.Point(426, 84)
        Me.cboBoxEchelle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBoxEchelle.Name = "cboBoxEchelle"
        Me.cboBoxEchelle.Size = New System.Drawing.Size(140, 33)
        Me.cboBoxEchelle.TabIndex = 27
        '
        'lblVitesse
        '
        Me.lblVitesse.AutoSize = True
        Me.lblVitesse.ForeColor = System.Drawing.Color.White
        Me.lblVitesse.Location = New System.Drawing.Point(944, 68)
        Me.lblVitesse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVitesse.Name = "lblVitesse"
        Me.lblVitesse.Size = New System.Drawing.Size(126, 25)
        Me.lblVitesse.TabIndex = 26
        Me.lblVitesse.Text = "300 (en ms)"
        '
        'trckBrVitesse
        '
        Me.trckBrVitesse.Location = New System.Drawing.Point(748, 16)
        Me.trckBrVitesse.Margin = New System.Windows.Forms.Padding(4)
        Me.trckBrVitesse.Maximum = 1000
        Me.trckBrVitesse.Minimum = 1
        Me.trckBrVitesse.Name = "trckBrVitesse"
        Me.trckBrVitesse.Size = New System.Drawing.Size(528, 90)
        Me.trckBrVitesse.TabIndex = 22
        Me.trckBrVitesse.Value = 300
        '
        'txtBoxCellule
        '
        Me.txtBoxCellule.Location = New System.Drawing.Point(426, 32)
        Me.txtBoxCellule.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxCellule.Name = "txtBoxCellule"
        Me.txtBoxCellule.Size = New System.Drawing.Size(140, 31)
        Me.txtBoxCellule.TabIndex = 21
        '
        'btnAleatoire
        '
        Me.btnAleatoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAleatoire.Location = New System.Drawing.Point(1440, 116)
        Me.btnAleatoire.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAleatoire.Name = "btnAleatoire"
        Me.btnAleatoire.Size = New System.Drawing.Size(180, 54)
        Me.btnAleatoire.TabIndex = 20
        Me.btnAleatoire.Text = "Tout aléatoire"
        Me.btnAleatoire.UseVisualStyleBackColor = True
        '
        'lblGenerationDyn
        '
        Me.lblGenerationDyn.AutoSize = True
        Me.lblGenerationDyn.ForeColor = System.Drawing.Color.White
        Me.lblGenerationDyn.Location = New System.Drawing.Point(1654, 80)
        Me.lblGenerationDyn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenerationDyn.Name = "lblGenerationDyn"
        Me.lblGenerationDyn.Size = New System.Drawing.Size(24, 25)
        Me.lblGenerationDyn.TabIndex = 16
        Me.lblGenerationDyn.Text = "0"
        '
        'lblCelluleEnVieDyn
        '
        Me.lblCelluleEnVieDyn.AutoSize = True
        Me.lblCelluleEnVieDyn.ForeColor = System.Drawing.Color.White
        Me.lblCelluleEnVieDyn.Location = New System.Drawing.Point(1654, 54)
        Me.lblCelluleEnVieDyn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelluleEnVieDyn.Name = "lblCelluleEnVieDyn"
        Me.lblCelluleEnVieDyn.Size = New System.Drawing.Size(24, 25)
        Me.lblCelluleEnVieDyn.TabIndex = 14
        Me.lblCelluleEnVieDyn.Text = "0"
        '
        'lblCelluleDetruiteDyn
        '
        Me.lblCelluleDetruiteDyn.AutoSize = True
        Me.lblCelluleDetruiteDyn.ForeColor = System.Drawing.Color.White
        Me.lblCelluleDetruiteDyn.Location = New System.Drawing.Point(1654, 28)
        Me.lblCelluleDetruiteDyn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelluleDetruiteDyn.Name = "lblCelluleDetruiteDyn"
        Me.lblCelluleDetruiteDyn.Size = New System.Drawing.Size(24, 25)
        Me.lblCelluleDetruiteDyn.TabIndex = 13
        Me.lblCelluleDetruiteDyn.Text = "0"
        '
        'lblGeneration
        '
        Me.lblGeneration.AutoSize = True
        Me.lblGeneration.ForeColor = System.Drawing.Color.White
        Me.lblGeneration.Location = New System.Drawing.Point(1436, 80)
        Me.lblGeneration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGeneration.Name = "lblGeneration"
        Me.lblGeneration.Size = New System.Drawing.Size(118, 25)
        Me.lblGeneration.TabIndex = 12
        Me.lblGeneration.Text = "Génération"
        '
        'lblCelluleEnVie
        '
        Me.lblCelluleEnVie.AutoSize = True
        Me.lblCelluleEnVie.ForeColor = System.Drawing.Color.White
        Me.lblCelluleEnVie.Location = New System.Drawing.Point(1436, 54)
        Me.lblCelluleEnVie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelluleEnVie.Name = "lblCelluleEnVie"
        Me.lblCelluleEnVie.Size = New System.Drawing.Size(142, 25)
        Me.lblCelluleEnVie.TabIndex = 11
        Me.lblCelluleEnVie.Text = "Cellule en vie"
        '
        'lblCelluleDetruite
        '
        Me.lblCelluleDetruite.AutoSize = True
        Me.lblCelluleDetruite.ForeColor = System.Drawing.Color.White
        Me.lblCelluleDetruite.Location = New System.Drawing.Point(1436, 28)
        Me.lblCelluleDetruite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelluleDetruite.Name = "lblCelluleDetruite"
        Me.lblCelluleDetruite.Size = New System.Drawing.Size(156, 25)
        Me.lblCelluleDetruite.TabIndex = 10
        Me.lblCelluleDetruite.Text = "Cellule détruite"
        '
        'lblCelluleCreeeDyn
        '
        Me.lblCelluleCreeeDyn.AutoSize = True
        Me.lblCelluleCreeeDyn.ForeColor = System.Drawing.Color.White
        Me.lblCelluleCreeeDyn.Location = New System.Drawing.Point(1654, 2)
        Me.lblCelluleCreeeDyn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelluleCreeeDyn.Name = "lblCelluleCreeeDyn"
        Me.lblCelluleCreeeDyn.Size = New System.Drawing.Size(24, 25)
        Me.lblCelluleCreeeDyn.TabIndex = 9
        Me.lblCelluleCreeeDyn.Text = "0"
        '
        'lblCelluleCreee
        '
        Me.lblCelluleCreee.AutoSize = True
        Me.lblCelluleCreee.ForeColor = System.Drawing.Color.White
        Me.lblCelluleCreee.Location = New System.Drawing.Point(1436, 2)
        Me.lblCelluleCreee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelluleCreee.Name = "lblCelluleCreee"
        Me.lblCelluleCreee.Size = New System.Drawing.Size(138, 25)
        Me.lblCelluleCreee.TabIndex = 8
        Me.lblCelluleCreee.Text = "Cellule créée"
        '
        'lblIteration
        '
        Me.lblIteration.AutoSize = True
        Me.lblIteration.ForeColor = System.Drawing.Color.White
        Me.lblIteration.Location = New System.Drawing.Point(316, 138)
        Me.lblIteration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIteration.Name = "lblIteration"
        Me.lblIteration.Size = New System.Drawing.Size(89, 25)
        Me.lblIteration.TabIndex = 7
        Me.lblIteration.Text = "Itération"
        '
        'lblEchelle
        '
        Me.lblEchelle.AutoSize = True
        Me.lblEchelle.ForeColor = System.Drawing.Color.White
        Me.lblEchelle.Location = New System.Drawing.Point(316, 88)
        Me.lblEchelle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEchelle.Name = "lblEchelle"
        Me.lblEchelle.Size = New System.Drawing.Size(83, 25)
        Me.lblEchelle.TabIndex = 6
        Me.lblEchelle.Text = "Echelle"
        '
        'lblCellule
        '
        Me.lblCellule.AutoSize = True
        Me.lblCellule.ForeColor = System.Drawing.Color.White
        Me.lblCellule.Location = New System.Drawing.Point(316, 32)
        Me.lblCellule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCellule.Name = "lblCellule"
        Me.lblCellule.Size = New System.Drawing.Size(103, 25)
        Me.lblCellule.TabIndex = 5
        Me.lblCellule.Text = "Cellule(s)"
        '
        'cboBoxIteration
        '
        Me.cboBoxIteration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBoxIteration.FormattingEnabled = True
        Me.cboBoxIteration.Location = New System.Drawing.Point(426, 136)
        Me.cboBoxIteration.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBoxIteration.Name = "cboBoxIteration"
        Me.cboBoxIteration.Size = New System.Drawing.Size(140, 33)
        Me.cboBoxIteration.TabIndex = 4
        '
        'btnMotif
        '
        Me.btnMotif.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotif.Location = New System.Drawing.Point(1628, 116)
        Me.btnMotif.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMotif.Name = "btnMotif"
        Me.btnMotif.Size = New System.Drawing.Size(168, 54)
        Me.btnMotif.TabIndex = 3
        Me.btnMotif.Text = "Motif"
        Me.btnMotif.UseVisualStyleBackColor = True
        '
        'btnLancer
        '
        Me.btnLancer.BackColor = System.Drawing.Color.LightGreen
        Me.btnLancer.Font = New System.Drawing.Font("Impact", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancer.ForeColor = System.Drawing.Color.Black
        Me.btnLancer.Location = New System.Drawing.Point(18, 16)
        Me.btnLancer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(260, 80)
        Me.btnLancer.TabIndex = 0
        Me.btnLancer.Text = "LANCER"
        Me.btnLancer.UseVisualStyleBackColor = False
        '
        'pbAvance
        '
        Me.pbAvance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAvance.BackColor = System.Drawing.Color.Transparent
        Me.pbAvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbAvance.Image = CType(resources.GetObject("pbAvance.Image"), System.Drawing.Image)
        Me.pbAvance.Location = New System.Drawing.Point(42, 88)
        Me.pbAvance.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Size = New System.Drawing.Size(108, 100)
        Me.pbAvance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAvance.TabIndex = 3
        Me.pbAvance.TabStop = False
        '
        'pbQuitter
        '
        Me.pbQuitter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbQuitter.BackColor = System.Drawing.Color.Transparent
        Me.pbQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitter.Image = CType(resources.GetObject("pbQuitter.Image"), System.Drawing.Image)
        Me.pbQuitter.Location = New System.Drawing.Point(149, 86)
        Me.pbQuitter.Margin = New System.Windows.Forms.Padding(0)
        Me.pbQuitter.Name = "pbQuitter"
        Me.pbQuitter.Size = New System.Drawing.Size(104, 104)
        Me.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbQuitter.TabIndex = 28
        Me.pbQuitter.TabStop = False
        '
        'TimerJeu
        '
        Me.TimerJeu.Interval = 300
        '
        'pbAide
        '
        Me.pbAide.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAide.BackColor = System.Drawing.Color.Transparent
        Me.pbAide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbAide.Image = CType(resources.GetObject("pbAide.Image"), System.Drawing.Image)
        Me.pbAide.Location = New System.Drawing.Point(1776, -8)
        Me.pbAide.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAide.Name = "pbAide"
        Me.pbAide.Size = New System.Drawing.Size(48, 70)
        Me.pbAide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAide.TabIndex = 32
        Me.pbAide.TabStop = False
        '
        'ctMenu
        '
        Me.ctMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ctMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ltmLancer, Me.ToolStripSeparator1, Me.tsmParametreAvance, Me.tsmMotif, Me.ToolStripSeparator2, Me.tsmQuitter})
        Me.ctMenu.Name = "ContextMenuStrip1"
        Me.ctMenu.Size = New System.Drawing.Size(299, 160)
        '
        'ltmLancer
        '
        Me.ltmLancer.Name = "ltmLancer"
        Me.ltmLancer.Size = New System.Drawing.Size(298, 36)
        Me.ltmLancer.Text = "Lancer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(295, 6)
        '
        'tsmParametreAvance
        '
        Me.tsmParametreAvance.Name = "tsmParametreAvance"
        Me.tsmParametreAvance.Size = New System.Drawing.Size(298, 36)
        Me.tsmParametreAvance.Text = "Paramètres avancés"
        '
        'tsmMotif
        '
        Me.tsmMotif.Name = "tsmMotif"
        Me.tsmMotif.Size = New System.Drawing.Size(298, 36)
        Me.tsmMotif.Text = "Motifs"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(295, 6)
        '
        'tsmQuitter
        '
        Me.tsmQuitter.Name = "tsmQuitter"
        Me.tsmQuitter.Size = New System.Drawing.Size(298, 36)
        Me.tsmQuitter.Text = "Quitter"
        '
        'MoteurUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1816, 1060)
        Me.Controls.Add(Me.pbAide)
        Me.Controls.Add(Me.pnlBoutons)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1842, 1171)
        Me.Name = "MoteurUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu de la vie"
        Me.pnlBoutons.ResumeLayout(False)
        Me.pnlBoutons.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReculerDe1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAvancerDe1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEffacer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trckBrVitesse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBoutons As Panel
    Friend WithEvents btnLancer As Button
    Friend WithEvents lblCelluleCreee As Label
    Friend WithEvents lblIteration As Label
    Friend WithEvents lblEchelle As Label
    Friend WithEvents lblCellule As Label
    Friend WithEvents cboBoxIteration As ComboBox
    Friend WithEvents btnMotif As Button
    Friend WithEvents lblCelluleEnVie As Label
    Friend WithEvents lblCelluleDetruite As Label
    Friend WithEvents lblCelluleCreeeDyn As Label
    Friend WithEvents lblCelluleEnVieDyn As Label
    Friend WithEvents lblCelluleDetruiteDyn As Label
    Friend WithEvents lblGeneration As Label
    Friend WithEvents lblGenerationDyn As Label
    Friend WithEvents btnAleatoire As Button
    Friend WithEvents lblVitesse As Label
    Friend WithEvents trckBrVitesse As TrackBar
    Friend WithEvents txtBoxCellule As TextBox
    Friend WithEvents cboBoxEchelle As ComboBox
    Friend WithEvents TimerJeu As Timer
    Friend WithEvents pbAvance As PictureBox
    Friend WithEvents pbQuitter As PictureBox
    Friend WithEvents pbEffacer As PictureBox
    Friend WithEvents pbAvancerDe1 As PictureBox
    Friend WithEvents pbReculerDe1 As PictureBox
    Friend WithEvents pbAide As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ctMenu As ContextMenuStrip
    Friend WithEvents tsmParametreAvance As ToolStripMenuItem
    Friend WithEvents ltmLancer As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmMotif As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmQuitter As ToolStripMenuItem
End Class
