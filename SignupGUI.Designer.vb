<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupGUI
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inp_acc = New System.Windows.Forms.TextBox()
        Me.inp_pwd = New System.Windows.Forms.TextBox()
        Me.inp_pwd2 = New System.Windows.Forms.TextBox()
        Me.inp_name = New System.Windows.Forms.TextBox()
        Me.cbb_sex = New System.Windows.Forms.ComboBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(83, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "帳號："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(83, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "密碼："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(35, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "重複密碼："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(83, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "姓名："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(83, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "性別："
        '
        'inp_acc
        '
        Me.inp_acc.BackColor = System.Drawing.Color.Gray
        Me.inp_acc.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.inp_acc.Location = New System.Drawing.Point(171, 42)
        Me.inp_acc.Name = "inp_acc"
        Me.inp_acc.Size = New System.Drawing.Size(177, 36)
        Me.inp_acc.TabIndex = 5
        '
        'inp_pwd
        '
        Me.inp_pwd.BackColor = System.Drawing.Color.Gray
        Me.inp_pwd.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.inp_pwd.Location = New System.Drawing.Point(171, 89)
        Me.inp_pwd.Name = "inp_pwd"
        Me.inp_pwd.Size = New System.Drawing.Size(177, 36)
        Me.inp_pwd.TabIndex = 6
        '
        'inp_pwd2
        '
        Me.inp_pwd2.BackColor = System.Drawing.Color.Gray
        Me.inp_pwd2.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.inp_pwd2.Location = New System.Drawing.Point(171, 136)
        Me.inp_pwd2.Name = "inp_pwd2"
        Me.inp_pwd2.Size = New System.Drawing.Size(177, 36)
        Me.inp_pwd2.TabIndex = 7
        '
        'inp_name
        '
        Me.inp_name.BackColor = System.Drawing.Color.Gray
        Me.inp_name.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.inp_name.Location = New System.Drawing.Point(171, 183)
        Me.inp_name.Name = "inp_name"
        Me.inp_name.Size = New System.Drawing.Size(177, 36)
        Me.inp_name.TabIndex = 8
        '
        'cbb_sex
        '
        Me.cbb_sex.BackColor = System.Drawing.Color.Gray
        Me.cbb_sex.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbb_sex.FormattingEnabled = True
        Me.cbb_sex.Location = New System.Drawing.Point(171, 230)
        Me.cbb_sex.Name = "cbb_sex"
        Me.cbb_sex.Size = New System.Drawing.Size(177, 32)
        Me.cbb_sex.TabIndex = 9
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(87, 291)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(127, 37)
        Me.btn_submit.TabIndex = 10
        Me.btn_submit.Text = "註冊"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(231, 291)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(127, 37)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "取消"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'SignupGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(436, 357)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.cbb_sex)
        Me.Controls.Add(Me.inp_name)
        Me.Controls.Add(Me.inp_pwd2)
        Me.Controls.Add(Me.inp_pwd)
        Me.Controls.Add(Me.inp_acc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SignupGUI"
        Me.Text = "註冊"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents inp_acc As TextBox
    Friend WithEvents inp_pwd As TextBox
    Friend WithEvents inp_pwd2 As TextBox
    Friend WithEvents inp_name As TextBox
    Friend WithEvents cbb_sex As ComboBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_cancel As Button
End Class
