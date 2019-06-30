<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fenChargement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fenChargement))
        Me.prgbLancement = New System.Windows.Forms.ProgressBar()
        Me.pnlChargement = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblChargement = New System.Windows.Forms.Label()
        Me.pnlChargement.SuspendLayout()
        Me.SuspendLayout()
        '
        'prgbLancement
        '
        Me.prgbLancement.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.prgbLancement.ForeColor = System.Drawing.Color.Transparent
        Me.prgbLancement.Location = New System.Drawing.Point(51, 211)
        Me.prgbLancement.Name = "prgbLancement"
        Me.prgbLancement.Size = New System.Drawing.Size(758, 50)
        Me.prgbLancement.TabIndex = 0
        '
        'pnlChargement
        '
        Me.pnlChargement.BackgroundImage = CType(resources.GetObject("pnlChargement.BackgroundImage"), System.Drawing.Image)
        Me.pnlChargement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlChargement.Controls.Add(Me.Label1)
        Me.pnlChargement.Controls.Add(Me.lblTitre)
        Me.pnlChargement.Controls.Add(Me.lblVersion)
        Me.pnlChargement.Controls.Add(Me.lblChargement)
        Me.pnlChargement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChargement.Location = New System.Drawing.Point(0, 0)
        Me.pnlChargement.Name = "pnlChargement"
        Me.pnlChargement.Size = New System.Drawing.Size(866, 493)
        Me.pnlChargement.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(567, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "© BY THIBAULT IN 2019"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Verdana", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Gold
        Me.lblTitre.Location = New System.Drawing.Point(143, 126)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(440, 72)
        Me.lblTitre.TabIndex = 1
        Me.lblTitre.Text = "Jeu de la vie"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.Gold
        Me.lblVersion.Location = New System.Drawing.Point(575, 154)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(91, 38)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "V4.0"
        '
        'lblChargement
        '
        Me.lblChargement.AutoSize = True
        Me.lblChargement.BackColor = System.Drawing.Color.Transparent
        Me.lblChargement.Font = New System.Drawing.Font("Verdana", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChargement.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblChargement.Location = New System.Drawing.Point(234, 276)
        Me.lblChargement.Name = "lblChargement"
        Me.lblChargement.Size = New System.Drawing.Size(368, 52)
        Me.lblChargement.TabIndex = 3
        Me.lblChargement.Text = "Chargement..."
        '
        'fenChargement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(866, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.prgbLancement)
        Me.Controls.Add(Me.pnlChargement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fenChargement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlChargement.ResumeLayout(False)
        Me.pnlChargement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prgbLancement As ProgressBar
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblChargement As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlChargement As Panel
End Class
