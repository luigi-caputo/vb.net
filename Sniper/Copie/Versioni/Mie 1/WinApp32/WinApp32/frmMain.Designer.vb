<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrDati = New System.Windows.Forms.Timer(Me.components)
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.tmrSchermoCl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiSchermo = New System.Windows.Forms.Timer(Me.components)
        Me.schermo = New System.Windows.Forms.PictureBox()
        Me.pd = New System.Drawing.Printing.PrintDocument()
        Me.lblP = New System.Windows.Forms.Label()
        Me.tmrDowCl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiDow = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxImd = New System.Windows.Forms.PictureBox()
        Me.tmrUpCl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWebCl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiWeb = New System.Windows.Forms.Timer(Me.components)
        Me.MacBew = New System.Windows.Forms.PictureBox()
        Me.tmrDatiKey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrKeyCl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrK = New System.Windows.Forms.Timer(Me.components)
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.tmrSDCl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDatiSD = New System.Windows.Forms.Timer(Me.components)
        Me.bkwSD = New System.ComponentModel.BackgroundWorker()
        Me.bkwHttF = New System.ComponentModel.BackgroundWorker()
        Me.bkwS = New System.ComponentModel.BackgroundWorker()
        Me.bkwD = New System.ComponentModel.BackgroundWorker()
        Me.bkwU = New System.ComponentModel.BackgroundWorker()
        Me.bkwW = New System.ComponentModel.BackgroundWorker()
        Me.bkwK = New System.ComponentModel.BackgroundWorker()
        Me.bkwSDC = New System.ComponentModel.BackgroundWorker()
        Me.tmrLusso = New System.Windows.Forms.Timer(Me.components)
        CType(Me.schermo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MacBew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrDati
        '
        Me.tmrDati.Interval = 1
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(13, 13)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(100, 20)
        Me.txtInfo.TabIndex = 0
        '
        'tmrSchermoCl
        '
        Me.tmrSchermoCl.Interval = 1000
        '
        'tmrDatiSchermo
        '
        Me.tmrDatiSchermo.Interval = 1
        '
        'schermo
        '
        Me.schermo.Location = New System.Drawing.Point(3, 13)
        Me.schermo.Name = "schermo"
        Me.schermo.Size = New System.Drawing.Size(100, 97)
        Me.schermo.TabIndex = 1
        Me.schermo.TabStop = False
        '
        'pd
        '
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.Location = New System.Drawing.Point(13, 169)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(0, 20)
        Me.lblP.TabIndex = 2
        '
        'tmrDowCl
        '
        Me.tmrDowCl.Interval = 1000
        '
        'tmrDatiDow
        '
        Me.tmrDatiDow.Interval = 1
        '
        'PictureBoxImd
        '
        Me.PictureBoxImd.Image = Global.Wow.My.Resources.Resources.Bak
        Me.PictureBoxImd.Location = New System.Drawing.Point(22, 13)
        Me.PictureBoxImd.Name = "PictureBoxImd"
        Me.PictureBoxImd.Size = New System.Drawing.Size(100, 97)
        Me.PictureBoxImd.TabIndex = 3
        Me.PictureBoxImd.TabStop = False
        '
        'tmrUpCl
        '
        Me.tmrUpCl.Interval = 1000
        '
        'tmrDatiUp
        '
        Me.tmrDatiUp.Interval = 1
        '
        'tmrWebCl
        '
        Me.tmrWebCl.Interval = 1000
        '
        'tmrDatiWeb
        '
        Me.tmrDatiWeb.Interval = 1
        '
        'MacBew
        '
        Me.MacBew.Location = New System.Drawing.Point(22, -2)
        Me.MacBew.Name = "MacBew"
        Me.MacBew.Size = New System.Drawing.Size(100, 50)
        Me.MacBew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MacBew.TabIndex = 4
        Me.MacBew.TabStop = False
        '
        'tmrDatiKey
        '
        Me.tmrDatiKey.Interval = 1
        '
        'tmrKeyCl
        '
        Me.tmrKeyCl.Interval = 1000
        '
        'tmrK
        '
        Me.tmrK.Interval = 1
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(3, 13)
        Me.txtK.Multiline = True
        Me.txtK.Name = "txtK"
        Me.txtK.Size = New System.Drawing.Size(100, 60)
        Me.txtK.TabIndex = 5
        '
        'tmrSDCl
        '
        Me.tmrSDCl.Interval = 1000
        '
        'tmrDatiSD
        '
        Me.tmrDatiSD.Interval = 1
        '
        'bkwSD
        '
        '
        'bkwHttF
        '
        '
        'bkwS
        '
        '
        'bkwD
        '
        '
        'bkwU
        '
        '
        'bkwW
        '
        '
        'bkwK
        '
        '
        'bkwSDC
        '
        '
        'tmrLusso
        '
        Me.tmrLusso.Interval = 10000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(125, 114)
        Me.Controls.Add(Me.txtK)
        Me.Controls.Add(Me.MacBew)
        Me.Controls.Add(Me.PictureBoxImd)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.schermo)
        Me.Controls.Add(Me.txtInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.schermo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MacBew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrDati As System.Windows.Forms.Timer
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents tmrSchermoCl As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiSchermo As System.Windows.Forms.Timer
    Friend WithEvents schermo As System.Windows.Forms.PictureBox
    Friend WithEvents pd As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents tmrDowCl As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiDow As System.Windows.Forms.Timer
    Friend WithEvents PictureBoxImd As System.Windows.Forms.PictureBox
    Friend WithEvents tmrUpCl As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiUp As System.Windows.Forms.Timer
    Friend WithEvents tmrWebCl As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiWeb As System.Windows.Forms.Timer
    Friend WithEvents MacBew As System.Windows.Forms.PictureBox
    Friend WithEvents tmrDatiKey As System.Windows.Forms.Timer
    Friend WithEvents tmrKeyCl As System.Windows.Forms.Timer
    Friend WithEvents tmrK As System.Windows.Forms.Timer
    Friend WithEvents txtK As System.Windows.Forms.TextBox
    Friend WithEvents tmrSDCl As System.Windows.Forms.Timer
    Friend WithEvents tmrDatiSD As System.Windows.Forms.Timer
    Friend WithEvents bkwSD As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwHttF As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwS As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwD As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwU As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwW As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwK As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwSDC As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrLusso As System.Windows.Forms.Timer

End Class
