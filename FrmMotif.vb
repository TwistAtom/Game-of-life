''Thibault ANIN                                                 2019                                               -- Dedi Orsay TP2E --

Public Class frmMotif
    Dim nomMotifs() As String = {"Aucun", "Croix", "Lignes parallèles", "Grille", "Planeur simple", "Planeurs", "Double planneurs", "Canon", "Vaisseaux", "Gros vaisseaux", "Gros vaisseaux2", "Culbuteurs"}
    Private Sub FrmMotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nom As String In nomMotifs
            cboMotifPred.Items.Add(nom)
        Next
        'cboMotifPred.SelectedIndex = 0
    End Sub
    Private Sub BtnChargerMtf_Click(sender As Object, e As EventArgs) Handles btnChargerMtf.Click
        Dim confirmation As DialogResult = MsgBox("Êtes vous sûrs de vouloir charger un motif ?" & vbNewLine & " Votre grille actuelle sera effacée", MsgBoxStyle.YesNoCancel, "Êtes vous sûrs ?")
        If confirmation = Windows.Forms.DialogResult.Yes Then

            'Si l'utilisateur à bien quitter le motif a bien étté chargé
            Dim fichiers As New OpenFileDialog With {.Filter = "Text File|.txt"}
            If fichiers.ShowDialog = Windows.Forms.DialogResult.OK Then
                MoteurUI.chargerMotif(fichiers.FileName)
            End If
        End If
    End Sub
    Private Sub BtnEnregistrerMtf_Click(sender As Object, e As EventArgs) Handles btnEnregistrerMtf.Click
        Dim fichiers As New SaveFileDialog With {.Filter = "Text File|.txt"}
        If fichiers.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Si l'utilisateur à bien quitter le motif a bien été sauvegardé
            MoteurUI.enregistrerMotif(fichiers.FileName)
            MsgBox("Motif sauvegardé !", MsgBoxStyle.OkOnly, "Le motif a bien été enregistré")
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub CboMotifPred_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMotifPred.SelectedIndexChanged, btnRechargerMotif.Click
        MoteurUI.motifPred = cboMotifPred.SelectedIndex
        MoteurUI.EffacerCellule()
        MoteurUI.choixMotif(cboMotifPred.SelectedIndex)
    End Sub
End Class