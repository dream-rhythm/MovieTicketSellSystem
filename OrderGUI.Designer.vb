<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderGUI
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_MagicCard = New System.Windows.Forms.RadioButton()
        Me.rdb_cash = New System.Windows.Forms.RadioButton()
        Me.GB_cash = New System.Windows.Forms.GroupBox()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_5 = New System.Windows.Forms.Label()
        Me.lbl_10 = New System.Windows.Forms.Label()
        Me.lbl_50 = New System.Windows.Forms.Label()
        Me.lbl_100 = New System.Windows.Forms.Label()
        Me.lbl_500 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inp_paycash = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_place = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GB_cash.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 323)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "選擇數量"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(177, 276)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(21, 24)
        Me.lbl_total.TabIndex = 9
        Me.lbl_total.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "總金額："
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(177, 217)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(120, 36)
        Me.NumericUpDown4.TabIndex = 7
        Me.NumericUpDown4.Tag = "150"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "敬老票(150)："
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(177, 157)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(120, 36)
        Me.NumericUpDown3.TabIndex = 5
        Me.NumericUpDown3.Tag = "150"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "孩童票(150)："
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(177, 97)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 36)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.Tag = "200"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "學生票(200)："
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(177, 37)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 36)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Tag = "230"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "    全票(230)："
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(717, 397)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(93, 38)
        Me.btn_next.TabIndex = 0
        Me.btn_next.Text = "下一步"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb_MagicCard)
        Me.GroupBox2.Controls.Add(Me.rdb_cash)
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(346, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "付款方式"
        '
        'rdb_MagicCard
        '
        Me.rdb_MagicCard.AutoSize = True
        Me.rdb_MagicCard.Location = New System.Drawing.Point(28, 82)
        Me.rdb_MagicCard.Name = "rdb_MagicCard"
        Me.rdb_MagicCard.Size = New System.Drawing.Size(100, 28)
        Me.rdb_MagicCard.TabIndex = 1
        Me.rdb_MagicCard.Text = "信用卡"
        Me.rdb_MagicCard.UseVisualStyleBackColor = True
        '
        'rdb_cash
        '
        Me.rdb_cash.AutoSize = True
        Me.rdb_cash.Checked = True
        Me.rdb_cash.Location = New System.Drawing.Point(28, 39)
        Me.rdb_cash.Name = "rdb_cash"
        Me.rdb_cash.Size = New System.Drawing.Size(124, 28)
        Me.rdb_cash.TabIndex = 0
        Me.rdb_cash.TabStop = True
        Me.rdb_cash.Text = "現金交易"
        Me.rdb_cash.UseVisualStyleBackColor = True
        '
        'GB_cash
        '
        Me.GB_cash.Controls.Add(Me.lbl_1)
        Me.GB_cash.Controls.Add(Me.lbl_5)
        Me.GB_cash.Controls.Add(Me.lbl_10)
        Me.GB_cash.Controls.Add(Me.lbl_50)
        Me.GB_cash.Controls.Add(Me.lbl_100)
        Me.GB_cash.Controls.Add(Me.lbl_500)
        Me.GB_cash.Controls.Add(Me.Label13)
        Me.GB_cash.Controls.Add(Me.Label12)
        Me.GB_cash.Controls.Add(Me.Label11)
        Me.GB_cash.Controls.Add(Me.Label10)
        Me.GB_cash.Controls.Add(Me.Label9)
        Me.GB_cash.Controls.Add(Me.Label8)
        Me.GB_cash.Controls.Add(Me.Label7)
        Me.GB_cash.Controls.Add(Me.inp_paycash)
        Me.GB_cash.Controls.Add(Me.Label6)
        Me.GB_cash.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GB_cash.Location = New System.Drawing.Point(346, 244)
        Me.GB_cash.Name = "GB_cash"
        Me.GB_cash.Size = New System.Drawing.Size(365, 191)
        Me.GB_cash.TabIndex = 2
        Me.GB_cash.TabStop = False
        Me.GB_cash.Text = "現金交易"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(325, 144)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(21, 24)
        Me.lbl_1.TabIndex = 14
        Me.lbl_1.Text = "0"
        '
        'lbl_5
        '
        Me.lbl_5.AutoSize = True
        Me.lbl_5.Location = New System.Drawing.Point(276, 144)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(21, 24)
        Me.lbl_5.TabIndex = 13
        Me.lbl_5.Text = "0"
        '
        'lbl_10
        '
        Me.lbl_10.AutoSize = True
        Me.lbl_10.Location = New System.Drawing.Point(231, 144)
        Me.lbl_10.Name = "lbl_10"
        Me.lbl_10.Size = New System.Drawing.Size(21, 24)
        Me.lbl_10.TabIndex = 12
        Me.lbl_10.Text = "0"
        '
        'lbl_50
        '
        Me.lbl_50.AutoSize = True
        Me.lbl_50.Location = New System.Drawing.Point(173, 144)
        Me.lbl_50.Name = "lbl_50"
        Me.lbl_50.Size = New System.Drawing.Size(21, 24)
        Me.lbl_50.TabIndex = 11
        Me.lbl_50.Text = "0"
        '
        'lbl_100
        '
        Me.lbl_100.AutoSize = True
        Me.lbl_100.Location = New System.Drawing.Point(107, 144)
        Me.lbl_100.Name = "lbl_100"
        Me.lbl_100.Size = New System.Drawing.Size(21, 24)
        Me.lbl_100.TabIndex = 10
        Me.lbl_100.Text = "0"
        '
        'lbl_500
        '
        Me.lbl_500.AutoSize = True
        Me.lbl_500.Location = New System.Drawing.Point(33, 144)
        Me.lbl_500.Name = "lbl_500"
        Me.lbl_500.Size = New System.Drawing.Size(21, 24)
        Me.lbl_500.TabIndex = 9
        Me.lbl_500.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(325, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(278, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 24)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "5"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 24)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 24)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "50"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "100"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "500"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "找零："
        '
        'inp_paycash
        '
        Me.inp_paycash.Location = New System.Drawing.Point(105, 33)
        Me.inp_paycash.MaxLength = 5
        Me.inp_paycash.Name = "inp_paycash"
        Me.inp_paycash.Size = New System.Drawing.Size(140, 36)
        Me.inp_paycash.TabIndex = 1
        Me.inp_paycash.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "付款："
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_place)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lbl_time)
        Me.GroupBox4.Controls.Add(Me.lbl_name)
        Me.GroupBox4.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(697, 93)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "電影資訊"
        '
        'lbl_place
        '
        Me.lbl_place.AutoSize = True
        Me.lbl_place.Location = New System.Drawing.Point(608, 43)
        Me.lbl_place.Name = "lbl_place"
        Me.lbl_place.Size = New System.Drawing.Size(26, 24)
        Me.lbl_place.TabIndex = 4
        Me.lbl_place.Text = "A"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(328, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 24)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "時間："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(530, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 24)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "影廳："
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(416, 43)
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
        'OrderGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 460)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GB_cash)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OrderGUI"
        Me.Text = "訂購"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB_cash.ResumeLayout(False)
        Me.GB_cash.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_next As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdb_MagicCard As RadioButton
    Friend WithEvents rdb_cash As RadioButton
    Friend WithEvents GB_cash As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inp_paycash As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_5 As Label
    Friend WithEvents lbl_10 As Label
    Friend WithEvents lbl_50 As Label
    Friend WithEvents lbl_100 As Label
    Friend WithEvents lbl_500 As Label
    Friend WithEvents lbl_place As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
End Class
