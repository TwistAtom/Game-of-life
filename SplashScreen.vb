''Thibault ANIN                                                 2019                                               -- Dedi Orsay TP2E --

Public NotInheritable Class fenChargement
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DoubleBuffered = True
    End Sub


    Public Delegate Sub SetProgressBarDelegate(ByVal max As Integer)
    Public Delegate Sub UpdateProgressBarDelegate(ByVal value As Integer)

    Public Sub BarLong(ByVal MemCount As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New SetProgressBarDelegate(AddressOf BarLong), MemCount)
        Else
            Me.prgbLancement.Maximum = MemCount
        End If
    End Sub

    Public Sub ShowBar(ByVal SoFar As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateProgressBarDelegate(AddressOf ShowBar), SoFar)
        Else
            Me.prgbLancement.Value = SoFar
        End If
    End Sub

    Private Sub LblChargement_Click(sender As Object, e As EventArgs) Handles lblChargement.Click

    End Sub
End Class
