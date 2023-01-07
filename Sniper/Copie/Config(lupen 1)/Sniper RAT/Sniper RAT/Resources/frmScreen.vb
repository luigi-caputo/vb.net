Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Public Class frmScreen
    Public LoopScreen As Boolean = False
    Public LoopMouse As Boolean = False
    Public Xc As Integer
    Public Xy As Integer
    Public LoopLeft As Boolean = False
    Public LoopRight As Boolean = False
    Public LoopTwoClick As Boolean = False
    Public LoopTenPLeft As Boolean = False
    Public IsAttK As Boolean = True
    Private Sub frmScreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            If Not frmMain.FPAN(Me.lblIDC.Text - 1) Is Nothing Then
                frmMain.FPAN(Me.lblIDC.Text - 1).cmdVisII.Enabled = True
            End If

            Me.LoopMouse = False
            Me.LoopScreen = False
            Me.LoopLeft = False
            Me.LoopRight = False
            Me.LoopTwoClick = False
            Me.IsAttK = True
            Me.LoopTenPLeft = False
            FileClose(Me.lblIDC.Text + 2)
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub frmScreen_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            picImm.Width = Me.Width - 40
            picImm.Height = Me.Height - prgImmR.Height - 60 - lblCl.Height
            prgImmR.Width = Me.Width - 40
            prgImmR.Top = Me.Height - 70
            ToolStriptxtScrii.Left = Me.Width - ToolStriptxtScrii.Width - 25
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    

    Private Sub TakeShotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeShotToolStripMenuItem.Click
        If Me.prgImmR.Value = 0 Then
            Try
                If frmMain.FPAN(Me.lblIDC.Text - 1).picScreen.BackColor = Color.Red Then
                    MsgBox("The screen client is not connected!", MsgBoxStyle.Exclamation)
                Else
                    TakeOneFrameToolStripMenuItem.Enabled = False
                    TakeShotToolStripMenuItem.Enabled = False
                    Me.LoopScreen = True
                    frmMain.FPAN(Me.lblIDC.Text - 1).netstreamschermo.Write(UTF8.GetBytes("<Take>"), 0, UTF8.GetBytes("<Take>").Length) 'invio il comando il Client
                End If
            Catch ex As Exception
                Me.LoopScreen = False
                TakeOneFrameToolStripMenuItem.Enabled = True
                TakeShotToolStripMenuItem.Enabled = True
                frmMain.FPAN(Me.lblIDC.Text - 1).ISPCschermo = False
            End Try
        Else
            MsgBox("You can't take a new frame before the transfer is completed", MsgBoxStyle.Information)
        End If
    End Sub


   
    
   
    Private Sub StopItToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopItToolStripMenuItem.Click
        Me.LoopScreen = False
        TakeOneFrameToolStripMenuItem.Enabled = True
        TakeShotToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TakeOneFrameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeOneFrameToolStripMenuItem.Click
        If Me.prgImmR.Value = 0 Then
            FileClose(Me.lblIDC.Text + 2)
            If frmMain.FPAN(Me.lblIDC.Text - 1).picScreen.BackColor = Color.Red Then
                MsgBox("The screen client is not connected!", MsgBoxStyle.Exclamation)
            End If
            Me.LoopScreen = False
            Try
                frmMain.FPAN(Me.lblIDC.Text - 1).netstreamschermo.Write(UTF8.GetBytes("<Take>"), 0, UTF8.GetBytes("<Take>").Length) 'invio il comando il Client
            Catch ex As Exception
                Me.LoopScreen = False
                TakeOneFrameToolStripMenuItem.Enabled = True
                frmMain.FPAN(Me.lblIDC.Text - 1).ISPCschermo = False
            End Try
        Else
            MsgBox("You can't take a new frame before the transfer is completed", MsgBoxStyle.Information)
        End If
    End Sub

   
    
    Private Sub lblCl_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCl.MouseClick
        cxmstrScreen.Show(lblCl, New Point(e.X, e.Y))
    End Sub

    Private Sub picImm_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImm.MouseClick
        If MouseToolStripMenuItem.Checked = True Then
            Try
                If e.Button = Windows.Forms.MouseButtons.Left Then
                    Me.LoopRight = False
                    Me.LoopLeft = True
                    Me.LoopTenPLeft = False
                End If

                If e.Button = Windows.Forms.MouseButtons.Right Then
                    Me.LoopLeft = False
                    Me.LoopRight = True
                    Me.LoopTenPLeft = False
                End If
                Me.LoopTenPLeft = False
            Catch ex As Exception
                frmMain.FPAN(Me.lblIDC.Text - 1).ISPCschermo = False
            End Try
        End If
    End Sub

    Private Sub picImm_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImm.MouseDoubleClick
        Try
            If MouseToolStripMenuItem.Checked = True Then
                If e.Button = Windows.Forms.MouseButtons.Left Then
                    Me.LoopRight = False
                    Me.LoopLeft = True
                    Me.LoopTwoClick = True
                    Me.LoopTenPLeft = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub picImm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImm.MouseDown
        If MouseToolStripMenuItem.Checked = True Then
            Try
                If e.Button = Windows.Forms.MouseButtons.Left Then
                    'Me.LoopRight = False
                    Me.LoopTenPLeft = True
                End If

                'If e.Button = Windows.Forms.MouseButtons.Right Then
                'Me.LoopTenPLeft = False
                'Me.LoopRight = True
                'End If
            Catch ex As Exception
                frmMain.FPAN(Me.lblIDC.Text - 1).ISPCschermo = False
            End Try
        End If
    End Sub

    Private Sub picImm_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImm.MouseLeave
        Me.LoopMouse = False
        Me.LoopLeft = False
        Me.LoopRight = False
        Me.LoopTwoClick = False
        Me.LoopTenPLeft = False

    End Sub

    
    Private Sub picImm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImm.MouseMove
        If MouseToolStripMenuItem.Checked = True Then

            If ToolStriptxtScrii.Text = "" Then

                Try
                    Xc = e.X
                    Xy = e.Y
                    If Not LoopMouse = True Then
                        frmMain.netstream(Me.lblIDC.Text - 1).Write(UTF8.GetBytes(
                                                                                  e.X / Me.picImm.Width & " , " & e.Y / Me.picImm.Height & "<CCMOU|>"), 0, UTF8.GetBytes(
                                                                    e.X / Me.picImm.Width & " , " & e.Y / Me.picImm.Height & "<CCMOU|>").Length) 'invio il comando il Client)
                        LoopMouse = True
                    End If



                Catch ex As Exception
                    LoopMouse = False
                    frmMain.FPAN(Me.lblIDC.Text - 1).ISPCschermo = False
                End Try
            Else
                picImm.Enabled = False
                Me.LoopMouse = False
                Me.LoopLeft = False
                Me.LoopRight = False
                Me.LoopTwoClick = False
                Me.LoopTenPLeft = False
            End If
        End If
    End Sub

    
    Private Sub SetImageSizeAsFormSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetImageSizeAsFormSizeToolStripMenuItem.Click
        Try
            frmMain.netstream(Me.lblIDC.Text - 1).Write(UTF8.GetBytes(
                                                                      Me.picImm.Width & " , " &
                                                                      Me.picImm.Height & "ResIm"), 0, UTF8.GetBytes(Me.picImm.Width & " , " &
                                                                                                                                              Me.picImm.Height & "ResIm").Length) 'invio il comando il Client
        Catch ex As Exception
            frmMain.FPAN(Me.lblIDC.Text - 1).ISPC = False
        End Try
    End Sub

    Private Sub RestoreOriginalImageSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreOriginalImageSizeToolStripMenuItem.Click
        Try
            frmMain.netstream(Me.lblIDC.Text - 1).Write(UTF8.GetBytes("NIb"), 0, UTF8.GetBytes("NIb").Length) 'invio il comando il Client
        Catch ex As Exception
            frmMain.FPAN(Me.lblIDC.Text - 1).ISPC = False
        End Try
    End Sub

    Private Sub HideRestoreProgressBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideRestoreProgressBarToolStripMenuItem.Click
        If Me.prgImmR.Visible = True Then
            Me.prgImmR.Visible = False
        Else
            Me.prgImmR.Visible = True
        End If
    End Sub

   




   
    Private Sub lblCl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCl.Click
        Me.LoopMouse = False
        Me.LoopLeft = False
        Me.LoopRight = False
        Me.LoopTwoClick = False
        Me.LoopTenPLeft = False
    End Sub


   

   
   

    

    Private Sub ToolStriptxtScrii_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStriptxtScrii.KeyPress

        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            If KeyboardToolStripMenuItem.Checked = True Then
                'Try
                'frmMain.netstream(Me.lblIDC.Text - 1).Write(UTF8.GetBytes("|en|"), 0, UTF8.GetBytes("|en|").Length) 'invio il comando il Client
                'Catch ex As Exception
                'frmMain.FPAN(Me.lblIDC.Text - 1).ISPC = False
                'End Try

                ToolStriptxtScrii.Text = ToolStriptxtScrii.Text & "╔"

            End If
        End If

        If e.KeyChar = Chr(8) Then
            If KeyboardToolStripMenuItem.Checked = True Then
                'Try
                'frmMain.netstream(Me.lblIDC.Text - 1).Write(UTF8.GetBytes("|bk|"), 0, UTF8.GetBytes("|bk|").Length) 'invio il comando il Client
                'Catch ex As Exception
                'frmMain.FPAN(Me.lblIDC.Text - 1).ISPC = False
                'End Try

                ToolStriptxtScrii.Text = ToolStriptxtScrii.Text & "▒"

            End If
        End If
    End Sub

    Private Sub ToolStriptxtScrii_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStriptxtScrii.TextChanged
        If LoopMouse = False Then
            picImm.Enabled = False
            Me.LoopMouse = False
            Me.LoopLeft = False
            Me.LoopRight = False
            Me.LoopTwoClick = False
            Me.LoopTenPLeft = False
            If IsAttK = True Then
                If picImm.Enabled = False Then
                    Try

                        IsAttK = False
                        frmMain.netstream(Me.lblIDC.Text - 1).Write(UTF8.GetBytes("|#ã#|" &
                                                                                  Microsoft.VisualBasic.Left(ToolStriptxtScrii.Text, 1)), 0, UTF8.GetBytes("|#ã#|" &
                                                                                                                                                            Microsoft.VisualBasic.Left(ToolStriptxtScrii.Text, 1)).Length) 'invio il comando il Client
                        ToolStriptxtScrii.Text = Replace(ToolStriptxtScrii.Text, Microsoft.VisualBasic.Left(ToolStriptxtScrii.Text, 1), "")

                    Catch ex As Exception
                        IsAttK = True
                        frmMain.FPAN(Me.lblIDC.Text - 1).ISPC = False
                    End Try
                End If
            End If
        End If
    End Sub

   
   
    Private Sub KeyboardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KeyboardToolStripMenuItem.Click
        If ToolStriptxtScrii.Enabled = False Then
            ToolStriptxtScrii.Enabled = True
            Else
            IsAttK = True
            ToolStriptxtScrii.Enabled = False
            ToolStriptxtScrii.Text = ""
        End If
    End Sub


    Private Sub MouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseToolStripMenuItem.Click
        If MouseToolStripMenuItem.Checked = True Then
            picImm.Enabled = True
        End If
    End Sub

End Class