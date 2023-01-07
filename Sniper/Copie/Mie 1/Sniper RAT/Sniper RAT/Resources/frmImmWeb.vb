Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Public Class frmImmWeb
    Public LoopWeb As Boolean

    Private Sub frmImmWeb_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not frmMain.FPAN(Split(Me.Text, " ")(0) - 1) Is Nothing Then


            frmMain.FPAN(Split(Me.Text, " ")(0) - 1).chkImmSizeW.Enabled = False
            frmMain.FPAN(Split(Me.Text, " ")(0) - 1).cmdOpImmW.Enabled = True
            LoopWeb = False
            Try
                frmMain.netstream(
                    Split(Me.Text, " ")(0) - 1).Write(
                    UTF8.GetBytes("STo||P"), 0, UTF8.GetBytes("STo||P").Length) 'invio il comando il Client
            Catch ex As Exception
                frmMain.FPAN(Split(Me.Text, " ")(0) - 1).ISPC = False
            End Try
        
        End If

    End Sub

    Private Sub frmImmWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not frmMain.FPAN(Split(Me.Text, " ")(0) - 1) Is Nothing Then
            frmMain.FPAN(Split(Me.Text, " ")(0) - 1).chkImmSizeW.Enabled = True


            If frmMain.FPAN(Split(Me.Text, " ")(0) - 1).chkImmSizeW.Checked = True Then

                VScrollBarW.Visible = False
                HScrollBarw.Visible = False
                picBoxWebcam.Dock = DockStyle.Fill
                pal1w.Dock = DockStyle.Fill
                MaximizeBox = True
                FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                picBoxWebcam.SizeMode = PictureBoxSizeMode.StretchImage


            Else

                VScrollBarW.Dock = DockStyle.Right
                HScrollBarw.Dock = DockStyle.Bottom
                picBoxWebcam.Dock = DockStyle.None
                pal1w.Dock = DockStyle.None
                VScrollBarW.Maximum = picBoxWebcam.Height
                HScrollBarw.Maximum = picBoxWebcam.Width
                VScrollBarW.Visible = True
                HScrollBarw.Visible = True
                MaximizeBox = False
                FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                picBoxWebcam.SizeMode = PictureBoxSizeMode.AutoSize

            End If

        End If
    End Sub

    Private Sub StartCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartCaptureToolStripMenuItem.Click
        Try
            If Not frmMain.FPAN(Split(Me.Text, " ")(0) - 1) Is Nothing Then
                If frmMain.FPAN(Split(Me.Text, " ")(0) - 1).prgDatiWeb.Value = 0 Then
                    If frmMain.FPAN(Split(Me.Text, " ")(0) - 1).picWeb.BackColor = Color.Red Then
                        MsgBox("The webcam client is not connected!", MsgBoxStyle.Exclamation)
                    Else
                        TakeOnePhotoToolStripMenuItem.Enabled = False
                        StartCaptureToolStripMenuItem.Enabled = False
                        frmMain.FPAN(Split(Me.Text, " ")(0) - 1).netstreamweb.Write(UTF8.GetBytes("<Wake>"), 0, UTF8.GetBytes("<Wake>").Length) 'invio il comando il Client
                        Me.LoopWeb = True
                    End If
                Else
                    MsgBox("You can't take a new photo before the transfer is completed", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            Me.LoopWeb = False
            TakeOnePhotoToolStripMenuItem.Enabled = True
            StartCaptureToolStripMenuItem.Enabled = True
            frmMain.FPAN(Split(Me.Text, " ")(0) - 1).ISCONNweb = False
        End Try
    End Sub

    Private Sub StopCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopCaptureToolStripMenuItem.Click
        Me.LoopWeb = False
        TakeOnePhotoToolStripMenuItem.Enabled = True
        StartCaptureToolStripMenuItem.Enabled = True
    End Sub

    Private Sub frmImmWeb_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cxmstrWebC.Show(Me, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub frmImmWeb_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            frmMain.FPAN(Split(Me.Text, " ")(0) - 1).lblFormWXY.Text = "X: " & Me.Size.Width & " " & "Y: " & Me.Size.Height
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TakeOnePhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeOnePhotoToolStripMenuItem.Click
        Try
            If Not frmMain.FPAN(Split(Me.Text, " ")(0) - 1) Is Nothing Then
                If frmMain.FPAN(Split(Me.Text, " ")(0) - 1).prgDatiWeb.Value = 0 Then
                    If frmMain.FPAN(Split(Me.Text, " ")(0) - 1).picWeb.BackColor = Color.Red Then
                        MsgBox("The webcam client is not connected!", MsgBoxStyle.Exclamation)
                    Else
                        Me.LoopWeb = False
                        frmMain.FPAN(Split(Me.Text, " ")(0) - 1).netstreamweb.Write(UTF8.GetBytes("<Wake>"), 0, UTF8.GetBytes("<Wake>").Length) 'invio il comando il Client
                    End If
                Else
                    MsgBox("You can't take a new photo before the transfer is completed", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            Me.LoopWeb = False
            TakeOnePhotoToolStripMenuItem.Enabled = True
            StartCaptureToolStripMenuItem.Enabled = True
            frmMain.FPAN(Split(Me.Text, " ")(0) - 1).ISCONNweb = False
        End Try
    End Sub


    Private Sub VScrollBarW_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VScrollBarW.ValueChanged
        picBoxWebcam.Top = -VScrollBarW.Value
    End Sub

    Private Sub pal1w_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pal1w.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cxmstrWebC.Show(pal1w, New Point(e.X, e.Y))
        End If
    End Sub


    Private Sub picBoxWebcam_MouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBoxWebcam.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cxmstrWebC.Show(picBoxWebcam, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub HScrollBarw_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarw.ValueChanged
        Try
            picBoxWebcam.Left = -HScrollBarw.Value
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class