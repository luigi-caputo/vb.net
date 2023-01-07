<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.tmrSta = New System.Windows.Forms.Timer(Me.components)
        Me.picSta = New System.Windows.Forms.PictureBox()
        CType(Me.picSta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSta
        '
        Me.tmrSta.Enabled = True
        Me.tmrSta.Interval = 4000
        '
        'picSta
        '
        Me.picSta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picSta.Image = Global.Sniper.My.Resources.Resources.Sniper_Logo
        Me.picSta.Location = New System.Drawing.Point(0, 0)
        Me.picSta.Name = "picSta"
        Me.picSta.Size = New System.Drawing.Size(473, 297)
        Me.picSta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSta.TabIndex = 0
        Me.picSta.TabStop = False
        Me.picSta.UseWaitCursor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 297)
        Me.Controls.Add(Me.picSta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStart"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStart"
        CType(Me.picSta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrSta As System.Windows.Forms.Timer
    Friend WithEvents picSta As System.Windows.Forms.PictureBox
End Class
