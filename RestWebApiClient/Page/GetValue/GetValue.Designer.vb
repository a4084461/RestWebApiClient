<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetValue
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
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.L_Machine_Name = New System.Windows.Forms.Label()
        Me.T_Machine_Name = New System.Windows.Forms.TextBox()
        Me.L_Nyuko_Stno = New System.Windows.Forms.Label()
        Me.L_Service_Name = New System.Windows.Forms.Label()
        Me.L_Machinme_Type = New System.Windows.Forms.Label()
        Me.L_Syukko_Stno = New System.Windows.Forms.Label()
        Me.T_Service_Name = New System.Windows.Forms.TextBox()
        Me.T_Machinme_Type = New System.Windows.Forms.TextBox()
        Me.T_Nyuko_Stno = New System.Windows.Forms.TextBox()
        Me.T_Syukko_Stno = New System.Windows.Forms.TextBox()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Location = New System.Drawing.Point(99, 281)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(1197, 607)
        Me.FpSpread1.TabIndex = 0
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        '
        'L_Machine_Name
        '
        Me.L_Machine_Name.AutoSize = True
        Me.L_Machine_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.L_Machine_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Machine_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L_Machine_Name.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_Machine_Name.Location = New System.Drawing.Point(99, 55)
        Me.L_Machine_Name.Name = "L_Machine_Name"
        Me.L_Machine_Name.Size = New System.Drawing.Size(194, 26)
        Me.L_Machine_Name.TabIndex = 1
        Me.L_Machine_Name.Text = "MACHINE_NAME"
        Me.L_Machine_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Machine_Name
        '
        Me.T_Machine_Name.Location = New System.Drawing.Point(310, 55)
        Me.T_Machine_Name.Name = "T_Machine_Name"
        Me.T_Machine_Name.Size = New System.Drawing.Size(234, 29)
        Me.T_Machine_Name.TabIndex = 6
        '
        'L_Nyuko_Stno
        '
        Me.L_Nyuko_Stno.AutoSize = True
        Me.L_Nyuko_Stno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.L_Nyuko_Stno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Nyuko_Stno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L_Nyuko_Stno.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_Nyuko_Stno.Location = New System.Drawing.Point(653, 55)
        Me.L_Nyuko_Stno.Name = "L_Nyuko_Stno"
        Me.L_Nyuko_Stno.Size = New System.Drawing.Size(178, 26)
        Me.L_Nyuko_Stno.TabIndex = 7
        Me.L_Nyuko_Stno.Text = "NYUUKO_STNO"
        Me.L_Nyuko_Stno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Service_Name
        '
        Me.L_Service_Name.AutoSize = True
        Me.L_Service_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.L_Service_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Service_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L_Service_Name.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_Service_Name.Location = New System.Drawing.Point(99, 124)
        Me.L_Service_Name.Name = "L_Service_Name"
        Me.L_Service_Name.Size = New System.Drawing.Size(191, 26)
        Me.L_Service_Name.TabIndex = 7
        Me.L_Service_Name.Text = "SERVER_CLIENT"
        Me.L_Service_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Machinme_Type
        '
        Me.L_Machinme_Type.AutoSize = True
        Me.L_Machinme_Type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.L_Machinme_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Machinme_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L_Machinme_Type.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_Machinme_Type.Location = New System.Drawing.Point(99, 194)
        Me.L_Machinme_Type.Name = "L_Machinme_Type"
        Me.L_Machinme_Type.Size = New System.Drawing.Size(205, 26)
        Me.L_Machinme_Type.TabIndex = 8
        Me.L_Machinme_Type.Text = "MACHINME_TYPE"
        Me.L_Machinme_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Syukko_Stno
        '
        Me.L_Syukko_Stno.AutoSize = True
        Me.L_Syukko_Stno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.L_Syukko_Stno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Syukko_Stno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.L_Syukko_Stno.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_Syukko_Stno.Location = New System.Drawing.Point(653, 124)
        Me.L_Syukko_Stno.Name = "L_Syukko_Stno"
        Me.L_Syukko_Stno.Size = New System.Drawing.Size(175, 26)
        Me.L_Syukko_Stno.TabIndex = 9
        Me.L_Syukko_Stno.Text = "SYUKKO_STNO"
        Me.L_Syukko_Stno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Service_Name
        '
        Me.T_Service_Name.Location = New System.Drawing.Point(310, 126)
        Me.T_Service_Name.Name = "T_Service_Name"
        Me.T_Service_Name.Size = New System.Drawing.Size(234, 29)
        Me.T_Service_Name.TabIndex = 10
        '
        'T_Machinme_Type
        '
        Me.T_Machinme_Type.Location = New System.Drawing.Point(310, 196)
        Me.T_Machinme_Type.Name = "T_Machinme_Type"
        Me.T_Machinme_Type.Size = New System.Drawing.Size(234, 29)
        Me.T_Machinme_Type.TabIndex = 11
        '
        'T_Nyuko_Stno
        '
        Me.T_Nyuko_Stno.Location = New System.Drawing.Point(853, 55)
        Me.T_Nyuko_Stno.Name = "T_Nyuko_Stno"
        Me.T_Nyuko_Stno.Size = New System.Drawing.Size(234, 29)
        Me.T_Nyuko_Stno.TabIndex = 12
        '
        'T_Syukko_Stno
        '
        Me.T_Syukko_Stno.Location = New System.Drawing.Point(853, 124)
        Me.T_Syukko_Stno.Name = "T_Syukko_Stno"
        Me.T_Syukko_Stno.Size = New System.Drawing.Size(234, 29)
        Me.T_Syukko_Stno.TabIndex = 13
        '
        'GetValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 931)
        Me.Controls.Add(Me.T_Syukko_Stno)
        Me.Controls.Add(Me.T_Nyuko_Stno)
        Me.Controls.Add(Me.T_Machinme_Type)
        Me.Controls.Add(Me.T_Service_Name)
        Me.Controls.Add(Me.L_Syukko_Stno)
        Me.Controls.Add(Me.L_Machinme_Type)
        Me.Controls.Add(Me.L_Service_Name)
        Me.Controls.Add(Me.L_Nyuko_Stno)
        Me.Controls.Add(Me.T_Machine_Name)
        Me.Controls.Add(Me.L_Machine_Name)
        Me.Controls.Add(Me.FpSpread1)
        Me.Name = "GetValue"
        Me.Text = "GetValue"
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents L_Machine_Name As Label
    Friend WithEvents T_Machine_Name As TextBox
    Friend WithEvents L_Nyuko_Stno As Label
    Friend WithEvents L_Service_Name As Label
    Friend WithEvents L_Machinme_Type As Label
    Friend WithEvents L_Syukko_Stno As Label
    Friend WithEvents T_Service_Name As TextBox
    Friend WithEvents T_Machinme_Type As TextBox
    Friend WithEvents T_Nyuko_Stno As TextBox
    Friend WithEvents T_Syukko_Stno As TextBox
End Class
