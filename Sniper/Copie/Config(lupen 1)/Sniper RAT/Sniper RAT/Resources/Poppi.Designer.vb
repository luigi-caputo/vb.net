<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Poppi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Poppi))
        Me.lblConn = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tmrOp = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConn
        '
        Me.lblConn.AutoSize = True
        Me.lblConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConn.ForeColor = System.Drawing.Color.Blue
        Me.lblConn.Location = New System.Drawing.Point(50, 12)
        Me.lblConn.Name = "lblConn"
        Me.lblConn.Size = New System.Drawing.Size(119, 16)
        Me.lblConn.TabIndex = 1
        Me.lblConn.Text = "New Connection"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(50, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(65, 13)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "Connected!!"
        '
        'tmrOp
        '
        Me.tmrOp.Enabled = True
        Me.tmrOp.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sniper.My.Resources.Resources._1295813182_Internet_Explorer
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Poppi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 55)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblConn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Poppi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "//..Sniper Notification..//"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblConn As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents tmrOp As System.Windows.Forms.Timer
End Class
