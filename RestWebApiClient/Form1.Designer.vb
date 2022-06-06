<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GetValue = New System.Windows.Forms.Button()
        Me.responce = New System.Windows.Forms.TextBox()
        Me.PostValue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GetValue
        '
        Me.GetValue.Location = New System.Drawing.Point(75, 39)
        Me.GetValue.Name = "GetValue"
        Me.GetValue.Size = New System.Drawing.Size(167, 45)
        Me.GetValue.TabIndex = 1
        Me.GetValue.Text = "GetAllProducts"
        Me.GetValue.UseVisualStyleBackColor = True
        '
        'responce
        '
        Me.responce.Location = New System.Drawing.Point(365, 39)
        Me.responce.Multiline = True
        Me.responce.Name = "responce"
        Me.responce.Size = New System.Drawing.Size(666, 525)
        Me.responce.TabIndex = 2
        '
        'PostValue
        '
        Me.PostValue.Location = New System.Drawing.Point(75, 90)
        Me.PostValue.Name = "PostValue"
        Me.PostValue.Size = New System.Drawing.Size(167, 45)
        Me.PostValue.TabIndex = 3
        Me.PostValue.Text = "PostAllProducts"
        Me.PostValue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 632)
        Me.Controls.Add(Me.PostValue)
        Me.Controls.Add(Me.responce)
        Me.Controls.Add(Me.GetValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GetValue As Button
    Friend WithEvents responce As TextBox
    Friend WithEvents PostValue As Button
End Class
