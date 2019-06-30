<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMotif))
        Me.btnChargerMtf = New System.Windows.Forms.Button()
        Me.btnEnregistrerMtf = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cboMotifPred = New System.Windows.Forms.ComboBox()
        Me.lblMotifPred = New System.Windows.Forms.Label()
        Me.btnRechargerMotif = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChargerMtf
        '
        Me.btnChargerMtf.Location = New System.Drawing.Point(41, 24)
        Me.btnChargerMtf.Name = "btnChargerMtf"
        Me.btnChargerMtf.Size = New System.Drawing.Size(483, 55)
        Me.btnChargerMtf.TabIndex = 0
        Me.btnChargerMtf.Text = "Charger motif"
        Me.btnChargerMtf.UseVisualStyleBackColor = True
        '
        'btnEnregistrerMtf
        '
        Me.btnEnregistrerMtf.Location = New System.Drawing.Point(41, 109)
        Me.btnEnregistrerMtf.Name = "btnEnregistrerMtf"
        Me.btnEnregistrerMtf.Size = New System.Drawing.Size(483, 58)
        Me.btnEnregistrerMtf.TabIndex = 1
        Me.btnEnregistrerMtf.Text = "Enregistrer motif"
        Me.btnEnregistrerMtf.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(41, 385)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(483, 53)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cboMotifPred
        '
        Me.cboMotifPred.FormattingEnabled = True
        Me.cboMotifPred.Location = New System.Drawing.Point(41, 243)
        Me.cboMotifPred.Name = "cboMotifPred"
        Me.cboMotifPred.Size = New System.Drawing.Size(483, 33)
        Me.cboMotifPred.TabIndex = 4
        '
        'lblMotifPred
        '
        Me.lblMotifPred.AutoSize = True
        Me.lblMotifPred.Location = New System.Drawing.Point(36, 204)
        Me.lblMotifPred.Name = "lblMotifPred"
        Me.lblMotifPred.Size = New System.Drawing.Size(194, 25)
        Me.lblMotifPred.TabIndex = 5
        Me.lblMotifPred.Text = "Motifs prédéfinies :"
        '
        'btnRechargerMotif
        '
        Me.btnRechargerMotif.Location = New System.Drawing.Point(197, 296)
        Me.btnRechargerMotif.Name = "btnRechargerMotif"
        Me.btnRechargerMotif.Size = New System.Drawing.Size(173, 53)
        Me.btnRechargerMotif.TabIndex = 6
        Me.btnRechargerMotif.Text = "RECHARGER"
        Me.btnRechargerMotif.UseVisualStyleBackColor = True
        '
        'frmMotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 450)
        Me.Controls.Add(Me.btnRechargerMotif)
        Me.Controls.Add(Me.lblMotifPred)
        Me.Controls.Add(Me.cboMotifPred)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnEnregistrerMtf)
        Me.Controls.Add(Me.btnChargerMtf)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(596, 521)
        Me.Name = "frmMotif"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChargerMtf As Button
    Friend WithEvents btnEnregistrerMtf As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents cboMotifPred As ComboBox
    Friend WithEvents lblMotifPred As Label
    Friend WithEvents btnRechargerMotif As Button
End Class
