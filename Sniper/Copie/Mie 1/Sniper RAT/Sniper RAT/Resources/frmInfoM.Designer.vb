<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoM))
        Me.lblbClID = New System.Windows.Forms.Label()
        Me.lblCliIDda = New System.Windows.Forms.Label()
        Me.txtInfoARR = New System.Windows.Forms.TextBox()
        Me.tmrDatiDa = New System.Windows.Forms.Timer(Me.components)
        Me.cxmstrToolBoxInfo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GetInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetCPUUsageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cxmstrToolBoxInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblbClID
        '
        Me.lblbClID.AutoSize = True
        Me.lblbClID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbClID.Location = New System.Drawing.Point(12, 6)
        Me.lblbClID.Name = "lblbClID"
        Me.lblbClID.Size = New System.Drawing.Size(60, 13)
        Me.lblbClID.TabIndex = 0
        Me.lblbClID.Text = "Client ID:"
        '
        'lblCliIDda
        '
        Me.lblCliIDda.AutoSize = True
        Me.lblCliIDda.Location = New System.Drawing.Point(79, 6)
        Me.lblCliIDda.Name = "lblCliIDda"
        Me.lblCliIDda.Size = New System.Drawing.Size(13, 13)
        Me.lblCliIDda.TabIndex = 1
        Me.lblCliIDda.Text = "0"
        '
        'txtInfoARR
        '
        Me.txtInfoARR.BackColor = System.Drawing.Color.Black
        Me.txtInfoARR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoARR.ForeColor = System.Drawing.Color.Lime
        Me.txtInfoARR.Location = New System.Drawing.Point(0, 25)
        Me.txtInfoARR.Multiline = True
        Me.txtInfoARR.Name = "txtInfoARR"
        Me.txtInfoARR.ReadOnly = True
        Me.txtInfoARR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInfoARR.Size = New System.Drawing.Size(450, 257)
        Me.txtInfoARR.TabIndex = 2
        '
        'tmrDatiDa
        '
        Me.tmrDatiDa.Interval = 1
        '
        'cxmstrToolBoxInfo
        '
        Me.cxmstrToolBoxInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetInfoToolStripMenuItem, Me.GetCPUUsageToolStripMenuItem, Me.ClearTextToolStripMenuItem})
        Me.cxmstrToolBoxInfo.Name = "cxmstrToolBoxInfo"
        Me.cxmstrToolBoxInfo.Size = New System.Drawing.Size(153, 92)
        '
        'GetInfoToolStripMenuItem
        '
        Me.GetInfoToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499579_info1
        Me.GetInfoToolStripMenuItem.Name = "GetInfoToolStripMenuItem"
        Me.GetInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GetInfoToolStripMenuItem.Text = "Get info"
        '
        'GetCPUUsageToolStripMenuItem
        '
        Me.GetCPUUsageToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499257_application_x_desktop1
        Me.GetCPUUsageToolStripMenuItem.Name = "GetCPUUsageToolStripMenuItem"
        Me.GetCPUUsageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GetCPUUsageToolStripMenuItem.Text = "Get CPU usage"
        '
        'ClearTextToolStripMenuItem
        '
        Me.ClearTextToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources.cut
        Me.ClearTextToolStripMenuItem.Name = "ClearTextToolStripMenuItem"
        Me.ClearTextToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearTextToolStripMenuItem.Text = "Clear text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tip: If the presence on registry is equal to NO, you can set it to YES by restart" & _
            "ing the client"
        '
        'frmInfoM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInfoARR)
        Me.Controls.Add(Me.lblCliIDda)
        Me.Controls.Add(Me.lblbClID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInfoM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info manager"
        Me.cxmstrToolBoxInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbClID As System.Windows.Forms.Label
    Friend WithEvents lblCliIDda As System.Windows.Forms.Label
    Friend WithEvents txtInfoARR As System.Windows.Forms.TextBox
    Friend WithEvents tmrDatiDa As System.Windows.Forms.Timer
    Friend WithEvents cxmstrToolBoxInfo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GetInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetCPUUsageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
