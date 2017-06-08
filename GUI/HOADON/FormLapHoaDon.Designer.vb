Partial Class FormLapHoaDon
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
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.label5 = New System.Windows.Forms.Label()
		Me.maHoaDon_tb = New System.Windows.Forms.TextBox()
		Me.maKhachHang_tb = New System.Windows.Forms.TextBox()
		Me.slTonToiThieuSauBan_tb = New System.Windows.Forms.TextBox()
		Me.tongTien_tb = New System.Windows.Forms.TextBox()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.xem_button = New System.Windows.Forms.Button()
		Me.themsach_button = New System.Windows.Forms.Button()
		Me.lapPhieuthutien_button = New System.Windows.Forms.Button()
		Me.lapHoadon_button = New System.Windows.Forms.Button()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 23)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(65, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Mã hóa đơn"
		AddHandler Me.label1.Click, New System.EventHandler(AddressOf Me.label1_Click)
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(12, 47)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(82, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Mã khách hàng"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(12, 70)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(92, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Ngày lập hóa đơn"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(367, 23)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(148, 13)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Số lượng tồn tối thiểu sau bán"
		' 
		' dataGridView1
		' 
		Me.dataGridView1.AllowUserToAddRows = False
		Me.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(15, 125)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(653, 183)
		Me.dataGridView1.TabIndex = 4
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(42, 330)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(52, 13)
		Me.label5.TabIndex = 5
		Me.label5.Text = "Tổng tiền"
		' 
		' maHoaDon_tb
		' 
		Me.maHoaDon_tb.Location = New System.Drawing.Point(108, 16)
		Me.maHoaDon_tb.Name = "maHoaDon_tb"
		Me.maHoaDon_tb.Size = New System.Drawing.Size(200, 20)
		Me.maHoaDon_tb.TabIndex = 6
		' 
		' maKhachHang_tb
		' 
		Me.maKhachHang_tb.Location = New System.Drawing.Point(108, 40)
		Me.maKhachHang_tb.Name = "maKhachHang_tb"
		Me.maKhachHang_tb.Size = New System.Drawing.Size(200, 20)
		Me.maKhachHang_tb.TabIndex = 7
		AddHandler Me.maKhachHang_tb.TextChanged, New System.EventHandler(AddressOf Me.maKhachHang_tb_TextChanged)
		' 
		' slTonToiThieuSauBan_tb
		' 
		Me.slTonToiThieuSauBan_tb.Location = New System.Drawing.Point(521, 16)
		Me.slTonToiThieuSauBan_tb.Name = "slTonToiThieuSauBan_tb"
		Me.slTonToiThieuSauBan_tb.Size = New System.Drawing.Size(137, 20)
		Me.slTonToiThieuSauBan_tb.TabIndex = 9
		' 
		' tongTien_tb
		' 
		Me.tongTien_tb.Location = New System.Drawing.Point(108, 326)
		Me.tongTien_tb.Name = "tongTien_tb"
		Me.tongTien_tb.[ReadOnly] = True
		Me.tongTien_tb.Size = New System.Drawing.Size(200, 20)
		Me.tongTien_tb.TabIndex = 10
		Me.tongTien_tb.Text = "0"
		' 
		' dateTimePicker1
		' 
		Me.dateTimePicker1.Location = New System.Drawing.Point(108, 66)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.dateTimePicker1.TabIndex = 11
		' 
		' xem_button
		' 
		Me.xem_button.Location = New System.Drawing.Point(314, 40)
		Me.xem_button.Name = "xem_button"
		Me.xem_button.Size = New System.Drawing.Size(53, 20)
		Me.xem_button.TabIndex = 12
		Me.xem_button.Text = "Kiểm tra"
		Me.xem_button.UseVisualStyleBackColor = True
		AddHandler Me.xem_button.Click, New System.EventHandler(AddressOf Me.xem_button_Click)
		' 
		' themsach_button
		' 
		Me.themsach_button.Location = New System.Drawing.Point(593, 96)
		Me.themsach_button.Name = "themsach_button"
		Me.themsach_button.Size = New System.Drawing.Size(75, 23)
		Me.themsach_button.TabIndex = 13
		Me.themsach_button.Text = "Thêm sách"
		Me.themsach_button.UseVisualStyleBackColor = True
		AddHandler Me.themsach_button.Click, New System.EventHandler(AddressOf Me.themsach_button_Click)
		' 
		' lapPhieuthutien_button
		' 
		Me.lapPhieuthutien_button.Location = New System.Drawing.Point(460, 324)
		Me.lapPhieuthutien_button.Name = "lapPhieuthutien_button"
		Me.lapPhieuthutien_button.Size = New System.Drawing.Size(80, 23)
		Me.lapPhieuthutien_button.TabIndex = 14
		Me.lapPhieuthutien_button.Text = "Lập phiếu thu"
		Me.lapPhieuthutien_button.UseVisualStyleBackColor = True
		AddHandler Me.lapPhieuthutien_button.Click, New System.EventHandler(AddressOf Me.lapPhieuthutien_button_Click)
		' 
		' lapHoadon_button
		' 
		Me.lapHoadon_button.Location = New System.Drawing.Point(557, 324)
		Me.lapHoadon_button.Name = "lapHoadon_button"
		Me.lapHoadon_button.Size = New System.Drawing.Size(111, 23)
		Me.lapHoadon_button.TabIndex = 15
		Me.lapHoadon_button.Text = "Lập hóa đơn"
		Me.lapHoadon_button.UseVisualStyleBackColor = True
		AddHandler Me.lapHoadon_button.Click, New System.EventHandler(AddressOf Me.lapHoadon_button_Click)
		' 
		' FormLapHoaDon
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(693, 365)
		Me.Controls.Add(Me.lapHoadon_button)
		Me.Controls.Add(Me.lapPhieuthutien_button)
		Me.Controls.Add(Me.themsach_button)
		Me.Controls.Add(Me.xem_button)
		Me.Controls.Add(Me.dateTimePicker1)
		Me.Controls.Add(Me.tongTien_tb)
		Me.Controls.Add(Me.slTonToiThieuSauBan_tb)
		Me.Controls.Add(Me.maKhachHang_tb)
		Me.Controls.Add(Me.maHoaDon_tb)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "FormLapHoaDon"
		Me.Text = "HoaDon"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormLapHoaDon_Load)
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private label5 As System.Windows.Forms.Label
	Private maHoaDon_tb As System.Windows.Forms.TextBox
	Private maKhachHang_tb As System.Windows.Forms.TextBox
	Private slTonToiThieuSauBan_tb As System.Windows.Forms.TextBox
	Private tongTien_tb As System.Windows.Forms.TextBox
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private xem_button As System.Windows.Forms.Button
	Private themsach_button As System.Windows.Forms.Button
	Private lapPhieuthutien_button As System.Windows.Forms.Button
	Private lapHoadon_button As System.Windows.Forms.Button
End Class
