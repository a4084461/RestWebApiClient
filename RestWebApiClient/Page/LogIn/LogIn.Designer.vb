<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_Username = New System.Windows.Forms.Label()
        Me.L_PassWord = New System.Windows.Forms.Label()
        Me.T_Username = New System.Windows.Forms.TextBox()
        Me.T_Password = New System.Windows.Forms.TextBox()
        Me.B_Authorize = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic authorization"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Basic auth"
        '
        'L_Username
        '
        Me.L_Username.AutoSize = True
        Me.L_Username.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Username.Location = New System.Drawing.Point(196, 197)
        Me.L_Username.Name = "L_Username"
        Me.L_Username.Size = New System.Drawing.Size(139, 36)
        Me.L_Username.TabIndex = 2
        Me.L_Username.Text = "Username"
        '
        'L_PassWord
        '
        Me.L_PassWord.AutoSize = True
        Me.L_PassWord.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PassWord.Location = New System.Drawing.Point(196, 305)
        Me.L_PassWord.Name = "L_PassWord"
        Me.L_PassWord.Size = New System.Drawing.Size(138, 36)
        Me.L_PassWord.TabIndex = 3
        Me.L_PassWord.Text = "PassWord"
        '
        'T_Username
        '
        Me.T_Username.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T_Username.Location = New System.Drawing.Point(202, 245)
        Me.T_Username.Name = "T_Username"
        Me.T_Username.Size = New System.Drawing.Size(260, 46)
        Me.T_Username.TabIndex = 4
        '
        'T_Password
        '
        Me.T_Password.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T_Password.Location = New System.Drawing.Point(202, 364)
        Me.T_Password.Name = "T_Password"
        Me.T_Password.Size = New System.Drawing.Size(260, 46)
        Me.T_Password.TabIndex = 5
        '
        'B_Authorize
        '
        Me.B_Authorize.Location = New System.Drawing.Point(202, 456)
        Me.B_Authorize.Name = "B_Authorize"
        Me.B_Authorize.Size = New System.Drawing.Size(120, 46)
        Me.B_Authorize.TabIndex = 6
        Me.B_Authorize.Text = "Authorize"
        Me.B_Authorize.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(342, 456)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(120, 46)
        Me.B_Close.TabIndex = 7
        Me.B_Close.Text = "Close"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 584)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.B_Authorize)
        Me.Controls.Add(Me.T_Password)
        Me.Controls.Add(Me.T_Username)
        Me.Controls.Add(Me.L_PassWord)
        Me.Controls.Add(Me.L_Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LogIn"
        Me.Text = "LogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents L_Username As Label
    Friend WithEvents L_PassWord As Label
    Friend WithEvents T_Username As TextBox
    Friend WithEvents T_Password As TextBox
    Friend WithEvents B_Authorize As Button
    Friend WithEvents B_Close As Button
End Class
