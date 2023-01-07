Public Class frmSettings


    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMain.Notification = True Then
            chkSound.Checked = True
        End If
    End Sub

    Private Sub cmdDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDone.Click
        If chkSound.Checked = True Then
            frmMain.Notification = True
        Else
            frmMain.Notification = False
        End If

        frmMain.FU = txtFTPURL.Text
        frmMain.FUS = txtFTPUs.Text
        frmMain.FP = txtFTPP.Text
        Me.Close()
    End Sub
End Class