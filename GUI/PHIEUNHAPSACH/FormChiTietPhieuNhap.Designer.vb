Partial Class FormChiTietPhieuNhap
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
		Me.DonGia = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.SoLuongTon = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.Them = New System.Windows.Forms.Button()
		Me.label7 = New System.Windows.Forms.Label()
		Me.SoLuongNhap = New System.Windows.Forms.NumericUpDown()
		DirectCast(Me.SoLuongNhap, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.TenSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TenSach.Name = "TenSach"
		Me.TenSach.Size = New System.Drawing.Size(82, 21)
		Me.TenSach.TabIndex = 1
		AddHandler Me.TenSach.SelectedIndexChanged, New System.EventHandler(AddressOf Me.TenSach_SelectedIndexChanged)
		' 
		' MaSach
		' 
		Me.MaSach.Location = New System.Drawing.Point(109, 14)
		Me.MaSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.MaSach.Name = "MaSach"
		Me.MaSach.[ReadOnly] = True
		Me.MaSach.Size = New System.Drawing.Size(82, 20)
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
		Me.TheLoai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TheLoai.Name = "TheLoai"
		Me.TheLoai.[ReadOnly] = True
		Me.TheLoai.Size = New System.Drawing.Size(82, 20)
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
		Me.TacGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TacGia.Name = "TacGia"
		Me.TacGia.[ReadOnly] = True
		Me.TacGia.Size = New System.Drawing.Size(82, 20)
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
		' DonGia
		' 
		Me.DonGia.Location = New System.Drawing.Point(109, 144)
		Me.DonGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.DonGia.Name = "DonGia"
		Me.DonGia.[ReadOnly] = True
		Me.DonGia.Size = New System.Drawing.Size(82, 20)
		Me.DonGia.TabIndex = 9
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(19, 148)
		Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(44, 13)
		Me.label5.TabIndex = 8
		Me.label5.Text = "Đơn giá"
		' 
		' SoLuongTon
		' 
		Me.SoLuongTon.Location = New System.Drawing.Point(109, 177)
		Me.SoLuongTon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.SoLuongTon.Name = "SoLuongTon"
		Me.SoLuongTon.[ReadOnly] = True
		Me.SoLuongTon.Size = New System.Drawing.Size(82, 20)
		Me.SoLuongTon.TabIndex = 11
		' 
		' label6
		' 
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(19, 181)
		Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(67, 13)
		Me.label6.TabIndex = 10
		Me.label6.Text = "Số lượng tồn"
		' 
		' Them
		' 
		Me.Them.Location = New System.Drawing.Point(76, 237)
		Me.Them.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
		Me.label7.Location = New System.Drawing.Point(19, 213)
		Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(76, 13)
		Me.label7.TabIndex = 16
		Me.label7.Text = "Số lượng nhập"
		' 
		' SoLuongNhap
		' 
		Me.SoLuongNhap.Location = New System.Drawing.Point(109, 209)
		Me.SoLuongNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.SoLuongNhap.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
		Me.SoLuongNhap.Name = "SoLuongNhap"
		Me.SoLuongNhap.Size = New System.Drawing.Size(80, 20)
		Me.SoLuongNhap.TabIndex = 17
		AddHandler Me.SoLuongNhap.ValueChanged, New System.EventHandler(AddressOf Me.SoLuongNhap_ValueChanged)
		' 
		' FormChiTietPhieuNhap
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(235, 272)
		Me.Controls.Add(Me.SoLuongNhap)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.Them)
		Me.Controls.Add(Me.SoLuongTon)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.DonGia)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.TacGia)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.TheLoai)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.MaSach)
		Me.Controls.Add(Me.TenSach)
		Me.Controls.Add(Me.label1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "FormChiTietPhieuNhap"
		Me.Text = "FormLapChiTietPhieuNhap"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormLapChiTietPhieuNhap_Load)
		DirectCast(Me.SoLuongNhap, System.ComponentModel.ISupportInitialize).EndInit()
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
	Private DonGia As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private SoLuongTon As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private Them As System.Windows.Forms.Button
	Private label7 As System.Windows.Forms.Label
	Private SoLuongNhap As System.Windows.Forms.NumericUpDown
End Class
