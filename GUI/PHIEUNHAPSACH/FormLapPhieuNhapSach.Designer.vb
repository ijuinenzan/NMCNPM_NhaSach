Partial Class FormLapPhieuNhapSach
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
		Me.MaPhieuNhap = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.NgayNhap = New System.Windows.Forms.DateTimePicker()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.SoLuongNhapItNhat = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.SoLuongTonToiDaTruocNhap = New System.Windows.Forms.TextBox()
		Me.ThemSach = New System.Windows.Forms.Button()
		Me.DataGridChiTietPhieuNhap = New System.Windows.Forms.DataGridView()
		Me.XoaSach = New System.Windows.Forms.Button()
		DirectCast(Me.DataGridChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' MaPhieuNhap
		' 
		Me.MaPhieuNhap.Location = New System.Drawing.Point(207, 52)
		Me.MaPhieuNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaPhieuNhap.Name = "MaPhieuNhap"
		Me.MaPhieuNhap.[ReadOnly] = True
		Me.MaPhieuNhap.Size = New System.Drawing.Size(148, 26)
		Me.MaPhieuNhap.TabIndex = 0
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(81, 57)
		Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(114, 20)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Mã phiếu nhập"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(81, 111)
		Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(85, 20)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Ngày nhập"
		' 
		' NgayNhap
		' 
		Me.NgayNhap.Location = New System.Drawing.Point(207, 102)
		Me.NgayNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.NgayNhap.Name = "NgayNhap"
		Me.NgayNhap.Size = New System.Drawing.Size(298, 26)
		Me.NgayNhap.TabIndex = 4
		' 
		' button1
		' 
		Me.button1.Location = New System.Drawing.Point(915, 451)
		Me.button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(201, 35)
		Me.button1.TabIndex = 6
		Me.button1.Text = "Lập phiếu nhập"
		Me.button1.UseVisualStyleBackColor = True
		AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(706, 57)
		Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(160, 20)
		Me.label3.TabIndex = 8
		Me.label3.Text = "Số lượng nhập ít nhất"
		' 
		' SoLuongNhapItNhat
		' 
		Me.SoLuongNhapItNhat.Location = New System.Drawing.Point(968, 52)
		Me.SoLuongNhapItNhat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.SoLuongNhapItNhat.Name = "SoLuongNhapItNhat"
		Me.SoLuongNhapItNhat.[ReadOnly] = True
		Me.SoLuongNhapItNhat.Size = New System.Drawing.Size(148, 26)
		Me.SoLuongNhapItNhat.TabIndex = 7
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(706, 111)
		Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(246, 20)
		Me.label4.TabIndex = 10
		Me.label4.Text = "Số lượng tồn tối đa trước khi nhập"
		' 
		' SoLuongTonToiDaTruocNhap
		' 
		Me.SoLuongTonToiDaTruocNhap.Location = New System.Drawing.Point(968, 106)
		Me.SoLuongTonToiDaTruocNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.SoLuongTonToiDaTruocNhap.Name = "SoLuongTonToiDaTruocNhap"
		Me.SoLuongTonToiDaTruocNhap.[ReadOnly] = True
		Me.SoLuongTonToiDaTruocNhap.Size = New System.Drawing.Size(148, 26)
		Me.SoLuongTonToiDaTruocNhap.TabIndex = 9
		' 
		' ThemSach
		' 
		Me.ThemSach.Location = New System.Drawing.Point(665, 451)
		Me.ThemSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ThemSach.Name = "ThemSach"
		Me.ThemSach.Size = New System.Drawing.Size(201, 35)
		Me.ThemSach.TabIndex = 11
		Me.ThemSach.Text = "Thêm sách"
		Me.ThemSach.UseVisualStyleBackColor = True
		AddHandler Me.ThemSach.Click, New System.EventHandler(AddressOf Me.ThemSach_Click)
		' 
		' DataGridChiTietPhieuNhap
		' 
		Me.DataGridChiTietPhieuNhap.AllowUserToAddRows = False
		Me.DataGridChiTietPhieuNhap.AllowUserToDeleteRows = False
		Me.DataGridChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridChiTietPhieuNhap.Location = New System.Drawing.Point(18, 178)
		Me.DataGridChiTietPhieuNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridChiTietPhieuNhap.Name = "DataGridChiTietPhieuNhap"
		Me.DataGridChiTietPhieuNhap.[ReadOnly] = True
		Me.DataGridChiTietPhieuNhap.Size = New System.Drawing.Size(1114, 231)
		Me.DataGridChiTietPhieuNhap.TabIndex = 5
		' 
		' XoaSach
		' 
		Me.XoaSach.Location = New System.Drawing.Point(413, 451)
		Me.XoaSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.XoaSach.Name = "XoaSach"
		Me.XoaSach.Size = New System.Drawing.Size(201, 35)
		Me.XoaSach.TabIndex = 12
		Me.XoaSach.Text = "Xóa sách"
		Me.XoaSach.UseVisualStyleBackColor = True
		AddHandler Me.XoaSach.Click, New System.EventHandler(AddressOf Me.XoaSach_Click)
		' 
		' FormLapPhieuNhapSach
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 20F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 505)
		Me.Controls.Add(Me.XoaSach)
		Me.Controls.Add(Me.ThemSach)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.SoLuongTonToiDaTruocNhap)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.SoLuongNhapItNhat)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.DataGridChiTietPhieuNhap)
		Me.Controls.Add(Me.NgayNhap)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.MaPhieuNhap)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormLapPhieuNhapSach"
		Me.Text = "Lập phiếu nhập sách"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormLapPhieuNhapSach_Load)
		DirectCast(Me.DataGridChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private MaPhieuNhap As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private NgayNhap As System.Windows.Forms.DateTimePicker
	Private button1 As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private SoLuongNhapItNhat As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private SoLuongTonToiDaTruocNhap As System.Windows.Forms.TextBox
	Private ThemSach As System.Windows.Forms.Button
	Private DataGridChiTietPhieuNhap As System.Windows.Forms.DataGridView
	Private XoaSach As System.Windows.Forms.Button
End Class

