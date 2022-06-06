<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.登入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PutValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登入ToolStripMenuItem, Me.GetValueToolStripMenuItem, Me.PostValueToolStripMenuItem, Me.PutValueToolStripMenuItem, Me.DeleteValueToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1332, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '登入ToolStripMenuItem
        '
        Me.登入ToolStripMenuItem.Name = "登入ToolStripMenuItem"
        Me.登入ToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.登入ToolStripMenuItem.Text = "登入"
        '
        'GetValueToolStripMenuItem
        '
        Me.GetValueToolStripMenuItem.Name = "GetValueToolStripMenuItem"
        Me.GetValueToolStripMenuItem.Size = New System.Drawing.Size(104, 27)
        Me.GetValueToolStripMenuItem.Text = "GetValue"
        '
        'PostValueToolStripMenuItem
        '
        Me.PostValueToolStripMenuItem.Name = "PostValueToolStripMenuItem"
        Me.PostValueToolStripMenuItem.Size = New System.Drawing.Size(111, 27)
        Me.PostValueToolStripMenuItem.Text = "PostValue"
        '
        'PutValueToolStripMenuItem
        '
        Me.PutValueToolStripMenuItem.Name = "PutValueToolStripMenuItem"
        Me.PutValueToolStripMenuItem.Size = New System.Drawing.Size(103, 27)
        Me.PutValueToolStripMenuItem.Text = "PutValue"
        '
        'DeleteValueToolStripMenuItem
        '
        Me.DeleteValueToolStripMenuItem.Name = "DeleteValueToolStripMenuItem"
        Me.DeleteValueToolStripMenuItem.Size = New System.Drawing.Size(130, 27)
        Me.DeleteValueToolStripMenuItem.Text = "DeleteValue"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 781)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 登入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PostValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PutValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteValueToolStripMenuItem As ToolStripMenuItem
End Class
