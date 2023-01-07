<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImmWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImmWeb))
        Me.cxmstrWebC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TakeOnePhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pal1w = New System.Windows.Forms.Panel()
        Me.VScrollBarW = New System.Windows.Forms.VScrollBar()
        Me.picBoxWebcam = New System.Windows.Forms.PictureBox()
        Me.HScrollBarw = New System.Windows.Forms.HScrollBar()
        Me.cxmstrWebC.SuspendLayout()
        Me.pal1w.SuspendLayout()
        CType(Me.picBoxWebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cxmstrWebC
        '
        Me.cxmstrWebC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartCaptureToolStripMenuItem, Me.TakeOnePhotoToolStripMenuItem, Me.StopCaptureToolStripMenuItem})
        Me.cxmstrWebC.Name = "cxmstrWebC"
        Me.cxmstrWebC.Size = New System.Drawing.Size(158, 70)
        '
        'StartCaptureToolStripMenuItem
        '
        Me.StartCaptureToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1302375075_webcam1
        Me.StartCaptureToolStripMenuItem.Name = "StartCaptureToolStripMenuItem"
        Me.StartCaptureToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StartCaptureToolStripMenuItem.Text = "Start capture"
        '
        'TakeOnePhotoToolStripMenuItem
        '
        Me.TakeOnePhotoToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1299786608_101
        Me.TakeOnePhotoToolStripMenuItem.Name = "TakeOnePhotoToolStripMenuItem"
        Me.TakeOnePhotoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TakeOnePhotoToolStripMenuItem.Text = "Take one photo"
        '
        'StopCaptureToolStripMenuItem
        '
        Me.StopCaptureToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1300362518_Circle_Red
        Me.StopCaptureToolStripMenuItem.Name = "StopCaptureToolStripMenuItem"
        Me.StopCaptureToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StopCaptureToolStripMenuItem.Text = "Stop capture"
        '
        'pal1w
        '
        Me.pal1w.Controls.Add(Me.HScrollBarw)
        Me.pal1w.Controls.Add(Me.VScrollBarW)
        Me.pal1w.Controls.Add(Me.picBoxWebcam)
        Me.pal1w.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pal1w.Location = New System.Drawing.Point(0, 0)
        Me.pal1w.Name = "pal1w"
        Me.pal1w.Size = New System.Drawing.Size(480, 396)
        Me.pal1w.TabIndex = 1
        '
        'VScrollBarW
        '
        Me.VScrollBarW.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBarW.Location = New System.Drawing.Point(463, 0)
        Me.VScrollBarW.Name = "VScrollBarW"
        Me.VScrollBarW.Size = New System.Drawing.Size(17, 396)
        Me.VScrollBarW.TabIndex = 2
        '
        'picBoxWebcam
        '
        Me.picBoxWebcam.Location = New System.Drawing.Point(0, 0)
        Me.picBoxWebcam.Name = "picBoxWebcam"
        Me.picBoxWebcam.Size = New System.Drawing.Size(480, 396)
        Me.picBoxWebcam.TabIndex = 1
        Me.picBoxWebcam.TabStop = False
        '
        'HScrollBarw
        '
        Me.HScrollBarw.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HScrollBarw.Location = New System.Drawing.Point(0, 379)
        Me.HScrollBarw.Name = "HScrollBarw"
        Me.HScrollBarw.Size = New System.Drawing.Size(463, 17)
        Me.HScrollBarw.TabIndex = 3
        '
        'frmImmWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 396)
        Me.Controls.Add(Me.pal1w)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmImmWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Webcam viewer"
        Me.cxmstrWebC.ResumeLayout(False)
        Me.pal1w.ResumeLayout(False)
        CType(Me.picBoxWebcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cxmstrWebC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TakeOnePhotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pal1w As System.Windows.Forms.Panel
    Friend WithEvents picBoxWebcam As System.Windows.Forms.PictureBox
    Friend WithEvents VScrollBarW As System.Windows.Forms.VScrollBar
    Friend WithEvents HScrollBarw As System.Windows.Forms.HScrollBar
End Class
