Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpDataMain.ur = TextBox1.Text
        UpDataMain.us = TextBox2.Text
        UpDataMain.pass = TextBox3.Text
        Me.Close()
    End Sub
End Class