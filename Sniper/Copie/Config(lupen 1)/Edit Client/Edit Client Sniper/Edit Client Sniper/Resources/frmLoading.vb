Public Class frmLoading

    Private Sub tmrStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStart.Tick
        EditMain.Show()
        Me.Close()
    End Sub
End Class