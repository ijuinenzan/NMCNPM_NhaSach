Partial Class FormThongTinKhachHang
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
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.maKhachHang_tb = New System.Windows.Forms.TextBox()
		Me.hoTenKH_tb = New System.Windows.Forms.TextBox()
		Me.diachi_tb = New System.Windows.Forms.TextBox()
		Me.sdt_tb = New System.Windows.Forms.TextBox()
		Me.email_tb = New System.Windows.Forms.TextBox()
		Me.tienno_tb = New System.Windows.Forms.TextBox()
		Me.thoat_button = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 27)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(82, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Mã khách hàng"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(13, 58)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(43, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Họ Tên"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(13, 90)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(40, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Địa chỉ"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(13, 123)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(29, 13)
		Me.label4.TabIndex = 3
		Me.label4.Text = "SĐT"
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(13, 155)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(32, 13)
		Me.label5.TabIndex = 4
		Me.label5.Text = "Email"
		' 
		' label6
		' 
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(13, 192)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(55, 13)
		Me.label6.TabIndex = 5
		Me.label6.Text = "Số tiền nợ"
		' 
		' maKhachHang_tb
		' 
		Me.maKhachHang_tb.Location = New System.Drawing.Point(111, 24)
		Me.maKhachHang_tb.Name = "maKhachHang_tb"
		Me.maKhachHang_tb.[ReadOnly] = True
		Me.maKhachHang_tb.Size = New System.Drawing.Size(161, 20)
		Me.maKhachHang_tb.TabIndex = 6
		' 
		' hoTenKH_tb
		' 
		Me.hoTenKH_tb.Location = New System.Drawing.Point(111, 55)
		Me.hoTenKH_tb.Name = "hoTenKH_tb"
		Me.hoTenKH_tb.[ReadOnly] = True
		Me.hoTenKH_tb.Size = New System.Drawing.Size(161, 20)
		Me.hoTenKH_tb.TabIndex = 7
		' 
		' diachi_tb
		' 
		Me.diachi_tb.Location = New System.Drawing.Point(59, 87)
		Me.diachi_tb.Name = "diachi_tb"
		Me.diachi_tb.[ReadOnly] = True
		Me.diachi_tb.Size = New System.Drawing.Size(213, 20)
		Me.diachi_tb.TabIndex = 8
		' 
		' sdt_tb
		' 
		Me.sdt_tb.Location = New System.Drawing.Point(111, 120)
		Me.sdt_tb.Name = "sdt_tb"
		Me.sdt_tb.[ReadOnly] = True
		Me.sdt_tb.Size = New System.Drawing.Size(161, 20)
		Me.sdt_tb.TabIndex = 9
		' 
		' email_tb
		' 
		Me.email_tb.Location = New System.Drawing.Point(62, 152)
		Me.email_tb.Name = "email_tb"
		Me.email_tb.[ReadOnly] = True
		Me.email_tb.Size = New System.Drawing.Size(210, 20)
		Me.email_tb.TabIndex = 10
		' 
		' tienno_tb
		' 
		Me.tienno_tb.Location = New System.Drawing.Point(111, 185)
		Me.tienno_tb.Name = "tienno_tb"
		Me.tienno_tb.[ReadOnly] = True
		Me.tienno_tb.Size = New System.Drawing.Size(161, 20)
		Me.tienno_tb.TabIndex = 11
		' 
		' thoat_button
		' 
		Me.thoat_button.Location = New System.Drawing.Point(158, 226)
		Me.thoat_button.Name = "thoat_button"
		Me.thoat_button.Size = New System.Drawing.Size(75, 23)
		Me.thoat_button.TabIndex = 12
		Me.thoat_button.Text = "Thoát"
		Me.thoat_button.UseVisualStyleBackColor = True
		AddHandler Me.thoat_button.Click, New System.EventHandler(AddressOf Me.thoat_button_Click)
		' 
		' FormThongTinKhachHang
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.thoat_button)
		Me.Controls.Add(Me.tienno_tb)
		Me.Controls.Add(Me.email_tb)
		Me.Controls.Add(Me.sdt_tb)
		Me.Controls.Add(Me.diachi_tb)
		Me.Controls.Add(Me.hoTenKH_tb)
		Me.Controls.Add(Me.maKhachHang_tb)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "FormThongTinKhachHang"
		Me.Text = "Thông tin khách hàng"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormThongTinKhachHang_Load)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private maKhachHang_tb As System.Windows.Forms.TextBox
	Private hoTenKH_tb As System.Windows.Forms.TextBox
	Private diachi_tb As System.Windows.Forms.TextBox
	Private sdt_tb As System.Windows.Forms.TextBox
	Private email_tb As System.Windows.Forms.TextBox
	Private tienno_tb As System.Windows.Forms.TextBox
	Private thoat_button As System.Windows.Forms.Button
End Class
