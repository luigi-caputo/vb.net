Public Class frmConnR

    Private Sub frmConnR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRC.Text = frmMain.RCL
    End Sub

    Private Sub cmdRefRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefRec.Click
        txtRC.Text = frmMain.RCL
    End Sub

    Private Sub cmdCCRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCCRC.Click
        txtRC.Text = ""
        frmMain.RCL = ""
    End Sub
End Class