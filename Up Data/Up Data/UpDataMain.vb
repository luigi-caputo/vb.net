Public Class UpDataMain
    Public us As String
    Public ur As String
    Public pass As String
    Dim compath() As String
    Private Sub UpDataMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("File Name", 200)
        ListView1.Columns.Add("File Size", 200)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim sfo As OpenFileDialog
            sfo = New OpenFileDialog
            sfo.Filter = "All files|*.*"
            sfo.Multiselect = True
            sfo.ShowDialog()

            If sfo.FileNames(0) <> "" Then
                ReDim compath(UBound(sfo.FileNames))
                For i = 0 To UBound(sfo.FileNames)
                    compath(i) = sfo.FileNames(i)
                    ListView1.Items.Add(Split(sfo.FileNames(i), "\")(UBound(Split(sfo.FileNames(i), "\"))), 0)
                    ListView1.Items.Item(i).SubItems.Add(FileLen(sfo.FileNames(i)) & "b")
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start("www.gicopirosite.altervista.org")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            For k = 0 To ListView1.Items.Count - 1
                Dim clsR As System.Net.FtpWebRequest = _
                                DirectCast(System.Net.WebRequest.Create("ftp://" & ur & "/" & ListView1.Items.Item(k).Text), System.Net.FtpWebRequest)
                clsR.Credentials = New System.Net.NetworkCredential(us, pass)
                clsR.Method = System.Net.WebRequestMethods.Ftp.UploadFile


                Dim bFi() As Byte = System.IO.File.ReadAllBytes(compath(k))


                Dim clsStr As System.IO.Stream = _
                    clsR.GetRequestStream()
                clsStr.Write(bFi, 0, bFi.Length)
                clsStr.Close()
                clsStr.Dispose()

            Next k
            ListView1.Items.Clear()
            MsgBox("Uploading completed !")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

   
End Class
