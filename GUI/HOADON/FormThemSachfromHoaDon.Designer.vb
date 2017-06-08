Partial Class FormThemSachfromHoaDon
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.TenSach = New System.Windows.Forms.ComboBox()
		Me.MaSach = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.TheLoai = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.TacGia = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.soluongton_tb = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.dongia_tb = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.Them = New System.Windows.Forms.Button()
		Me.label7 = New System.Windows.Forms.Label()
		Me.soluongban = New System.Windows.Forms.NumericUpDown()
		Me.label8 = New System.Windows.Forms.Label()
		Me.thanhtien_tb = New System.Windows.Forms.TextBox()
		Me.lable9 = New System.Windows.Forms.Label()
		Me.dongiaban_tb = New System.Windows.Forms.TextBox()
		DirectCast(Me.soluongban, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(19, 18)
		Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(48, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Mã sách"
		' 
		' TenSach
		' 
		Me.TenSach.DisplayMember = "TenSach"
		Me.TenSach.FormattingEnabled = True
		Me.TenSach.Location = New System.Drawing.Point(109, 47)
		Me.TenSach.Margin = New System.Windows.Forms.Padding(2)
		Me.TenSach.Name = "TenSach"
		Me.TenSach.Size = New System.Drawing.Size(80, 21)
		Me.TenSach.TabIndex = 1
		AddHandler Me.TenSach.SelectedIndexChanged, New System.EventHandler(AddressOf Me.TenSach_SelectedIndexChanged)
		' 
		' MaSach
		' 
		Me.MaSach.Location = New System.Drawing.Point(109, 14)
		Me.MaSach.Margin = New System.Windows.Forms.Padding(2)
		Me.MaSach.Name = "MaSach"
		Me.MaSach.[ReadOnly] = True
		Me.MaSach.Size = New System.Drawing.Size(80, 20)
		Me.MaSach.TabIndex = 2
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(19, 51)
		Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(52, 13)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Tên sách"
		' 
		' TheLoai
		' 
		Me.TheLoai.Location = New System.Drawing.Point(109, 79)
		Me.TheLoai.Margin = New System.Windows.Forms.Padding(2)
		Me.TheLoai.Name = "TheLoai"
		Me.TheLoai.[ReadOnly] = True
		Me.TheLoai.Size = New System.Drawing.Size(80, 20)
		Me.TheLoai.TabIndex = 5
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(19, 83)
		Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(45, 13)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Thể loại"
		' 
		' TacGia
		' 
		Me.TacGia.Location = New System.Drawing.Point(109, 112)
		Me.TacGia.Margin = New System.Windows.Forms.Padding(2)
		Me.TacGia.Name = "TacGia"
		Me.TacGia.[ReadOnly] = True
		Me.TacGia.Size = New System.Drawing.Size(80, 20)
		Me.TacGia.TabIndex = 7
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(19, 116)
		Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(43, 13)
		Me.label4.TabIndex = 6
		Me.label4.Text = "Tác giả"
		' 
		' soluongton_tb
		' 
		Me.soluongton_tb.Location = New System.Drawing.Point(109, 144)
		Me.soluongton_tb.Margin = New System.Windows.Forms.Padding(2)
		Me.soluongton_tb.Name = "soluongton_tb"
		Me.soluongton_tb.[ReadOnly] = True
		Me.soluongton_tb.Size = New System.Drawing.Size(80, 20)
		Me.soluongton_tb.TabIndex = 9
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(19, 207)
		Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(65, 13)
		Me.label5.TabIndex = 8
		Me.label5.Text = "Đơn giá bán"
		' 
		' dongia_tb
		' 
		Me.dongia_tb.Location = New System.Drawing.Point(109, 171)
		Me.dongia_tb.Margin = New System.Windows.Forms.Padding(2)
		Me.dongia_tb.Name = "dongia_tb"
		Me.dongia_tb.[ReadOnly] = True
		Me.dongia_tb.Size = New System.Drawing.Size(80, 20)
		Me.dongia_tb.TabIndex = 11
		' 
		' label6
		' 
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(19, 147)
		Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(67, 13)
		Me.label6.TabIndex = 10
		Me.label6.Text = "Số lượng tồn"
		' 
		' Them
		' 
		Me.Them.Location = New System.Drawing.Point(88, 307)
		Me.Them.Margin = New System.Windows.Forms.Padding(2)
		Me.Them.Name = "Them"
		Me.Them.Size = New System.Drawing.Size(50, 21)
		Me.Them.TabIndex = 15
		Me.Them.Text = "Thêm"
		Me.Them.UseVisualStyleBackColor = True
		AddHandler Me.Them.Click, New System.EventHandler(AddressOf Me.Them_Click)
		' 
		' label7
		' 
		Me.label7.AutoSize = True
		Me.label7.Location = New System.Drawing.Point(19, 236)
		Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(70, 13)
		Me.label7.TabIndex = 16
		Me.label7.Text = "Số lượng bán"
		' 
		' soluongban
		' 
		Me.soluongban.Location = New System.Drawing.Point(109, 234)
		Me.soluongban.Margin = New System.Windows.Forms.Padding(2)
		Me.soluongban.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
		Me.soluongban.Name = "soluongban"
		Me.soluongban.Size = New System.Drawing.Size(80, 20)
		Me.soluongban.TabIndex = 17
		AddHandler Me.soluongban.ValueChanged, New System.EventHandler(AddressOf Me.soluongban_ValueChanged)
		' 
		' label8
		' 
		Me.label8.AutoSize = True
		Me.label8.Location = New System.Drawing.Point(19, 264)
		Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(58, 13)
		Me.label8.TabIndex = 18
		Me.label8.Text = "Thành tiền"
		AddHandler Me.label8.Click, New System.EventHandler(AddressOf Me.label8_Click)
		' 
		' thanhtien_tb
		' 
		Me.thanhtien_tb.Location = New System.Drawing.Point(107, 261)
		Me.thanhtien_tb.Margin = New System.Windows.Forms.Padding(2)
		Me.thanhtien_tb.Name = "thanhtien_tb"
		Me.thanhtien_tb.[ReadOnly] = True
		Me.thanhtien_tb.Size = New System.Drawing.Size(82, 20)
		Me.thanhtien_tb.TabIndex = 19
		AddHandler Me.thanhtien_tb.TextChanged, New System.EventHandler(AddressOf Me.textBox1_TextChanged)
		' 
		' lable9
		' 
		Me.lable9.AutoSize = True
		Me.lable9.Location = New System.Drawing.Point(19, 178)
		Me.lable9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lable9.Name = "lable9"
		Me.lable9.Size = New System.Drawing.Size(47, 13)
		Me.lable9.TabIndex = 20
		Me.lable9.Text = "Đơn giá "
		' 
		' dongiaban_tb
		' 
		Me.dongiaban_tb.Location = New System.Drawing.Point(109, 200)
		Me.dongiaban_tb.Margin = New System.Windows.Forms.Padding(2)
		Me.dongiaban_tb.Name = "dongiaban_tb"
		Me.dongiaban_tb.Size = New System.Drawing.Size(80, 20)
		Me.dongiaban_tb.TabIndex = 21
		AddHandler Me.dongiaban_tb.TextChanged, New System.EventHandler(AddressOf Me.dongiaban_tb_TextChanged)
		' 
		' FormThemSachfromHoaDon
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(235, 339)
		Me.Controls.Add(Me.dongiaban_tb)
		Me.Controls.Add(Me.lable9)
		Me.Controls.Add(Me.thanhtien_tb)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.soluongban)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.Them)
		Me.Controls.Add(Me.dongia_tb)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.soluongton_tb)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.TacGia)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.TheLoai)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.MaSach)
		Me.Controls.Add(Me.TenSach)
		Me.Controls.Add(Me.label1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "FormThemSachfromHoaDon"
		Me.Text = "Chi tiết hóa đơn"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormLapChiTietPhieuNhap_Load)
		DirectCast(Me.soluongban, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private TenSach As System.Windows.Forms.ComboBox
	Private MaSach As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private TheLoai As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private TacGia As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private soluongton_tb As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private dongia_tb As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private Them As System.Windows.Forms.Button
	Private label7 As System.Windows.Forms.Label
	Private soluongban As System.Windows.Forms.NumericUpDown
	Private label8 As System.Windows.Forms.Label
	Private thanhtien_tb As System.Windows.Forms.TextBox
	Private lable9 As System.Windows.Forms.Label
	Private dongiaban_tb As System.Windows.Forms.TextBox
End Class
