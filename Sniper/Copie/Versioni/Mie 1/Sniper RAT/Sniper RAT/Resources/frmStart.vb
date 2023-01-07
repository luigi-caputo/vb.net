Public Class frmStart

    Private Sub tmrSta_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSta.Tick
        frmMain.Show()
        Me.Close()
    End Sub
End Class