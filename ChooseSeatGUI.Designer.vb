<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChooseSeatGUI
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_chooesed = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_waitChoose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_place = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_chooesed)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lbl_waitChoose)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lbl_place)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lbl_time)
        Me.GroupBox4.Controls.Add(Me.lbl_name)
        Me.GroupBox4.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(39, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1176, 87)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "電影資訊"
        '
        'lbl_chooesed
        '
        Me.lbl_chooesed.AutoSize = True
        Me.lbl_chooesed.Location = New System.Drawing.Point(1096, 43)
        Me.lbl_chooesed.Name = "lbl_chooesed"
        Me.lbl_chooesed.Size = New System.Drawing.Size(21, 24)
        Me.lbl_chooesed.TabIndex = 8
        Me.lbl_chooesed.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(993, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "已選擇：      位"
        '
        'lbl_waitChoose
        '
        Me.lbl_waitChoose.AutoSize = True
        Me.lbl_waitChoose.Location = New System.Drawing.Point(870, 43)
        Me.lbl_waitChoose.Name = "lbl_waitChoose"
        Me.lbl_waitChoose.Size = New System.Drawing.Size(21, 24)
        Me.lbl_waitChoose.TabIndex = 6
        Me.lbl_waitChoose.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(767, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "待選擇：      位"
        '
        'lbl_place
        '
        Me.lbl_place.AutoSize = True
        Me.lbl_place.Location = New System.Drawing.Point(657, 43)
        Me.lbl_place.Name = "lbl_place"
        Me.lbl_place.Size = New System.Drawing.Size(26, 24)
        Me.lbl_place.TabIndex = 4
        Me.lbl_place.Text = "A"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(273, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 24)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "時間："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(579, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 24)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "影廳："
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(361, 43)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(60, 24)
        Me.lbl_time.TabIndex = 1
        Me.lbl_time.Text = "00:00"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(20, 43)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(130, 24)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "今晚打老虎"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(39, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1176, 36)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "銀幕位置"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(1092, 547)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(123, 35)
        Me.btn_submit.TabIndex = 6
        Me.btn_submit.Text = "完成訂票"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btn_back.Location = New System.Drawing.Point(963, 547)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(123, 35)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "修改張數"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(834, 547)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(123, 35)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "取消"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 547)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "尚有空位"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.OrangeRed
        Me.Label4.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 547)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "已訂位"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Orange
        Me.Label5.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 547)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "已選擇"
        '
        'ChooseSeatGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 594)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "ChooseSeatGUI"
        Me.Text = "選擇座位"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_place As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_chooesed As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_waitChoose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
