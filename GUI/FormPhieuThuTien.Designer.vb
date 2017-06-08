Partial Class FormPhieuThuTien
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
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.maphieu_tb = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.makh_tb = New System.Windows.Forms.TextBox()
		Me.ten_tb = New System.Windows.Forms.TextBox()
		Me.diachi_tb = New System.Windows.Forms.TextBox()
		Me.sdt_tb = New System.Windows.Forms.TextBox()
		Me.email_tb = New System.Windows.Forms.TextBox()
		Me.sotienthu_tb = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.lapphieu_button = New System.Windows.Forms.Button()
		Me.refresh = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(44, 43)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(69, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Mã phiếu thu"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(44, 106)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(82, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Mã khách hàng"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(44, 72)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(49, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Ngày lập"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(45, 225)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(32, 13)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Email"
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(45, 135)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(39, 13)
		Me.label5.TabIndex = 4
		Me.label5.Text = "Họ tên"
		' 
		' label6
		' 
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(44, 163)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(40, 13)
		Me.label6.TabIndex = 5
		Me.label6.Text = "Địa chỉ"
		' 
		' label7
		' 
		Me.label7.AutoSize = True
		Me.label7.Location = New System.Drawing.Point(43, 193)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(70, 13)
		Me.label7.TabIndex = 6
		Me.label7.Text = "Số điện thoại"
		' 
		' label8
		' 
		Me.label8.AutoSize = True
		Me.label8.Location = New System.Drawing.Point(44, 256)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(58, 13)
		Me.label8.TabIndex = 7
		Me.label8.Text = "Số tiền thu"
		' 
		' maphieu_tb
		' 
		Me.maphieu_tb.Location = New System.Drawing.Point(145, 40)
		Me.maphieu_tb.Name = "maphieu_tb"
		Me.maphieu_tb.[ReadOnly] = True
		Me.maphieu_tb.Size = New System.Drawing.Size(200, 20)
		Me.maphieu_tb.TabIndex = 8
		' 
		' label9
		' 
		Me.label9.AutoSize = True
		Me.label9.Location = New System.Drawing.Point(280, 155)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(0, 13)
		Me.label9.TabIndex = 9
		' 
		' dateTimePicker1
		' 
		Me.dateTimePicker1.Location = New System.Drawing.Point(145, 69)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.dateTimePicker1.TabIndex = 10
		' 
		' makh_tb
		' 
		Me.makh_tb.Location = New System.Drawing.Point(145, 101)
		Me.makh_tb.Name = "makh_tb"
		Me.makh_tb.Size = New System.Drawing.Size(200, 20)
		Me.makh_tb.TabIndex = 11
		' 
		' ten_tb
		' 
		Me.ten_tb.Location = New System.Drawing.Point(145, 132)
		Me.ten_tb.Name = "ten_tb"
		Me.ten_tb.[ReadOnly] = True
		Me.ten_tb.Size = New System.Drawing.Size(200, 20)
		Me.ten_tb.TabIndex = 12
		' 
		' diachi_tb
		' 
		Me.diachi_tb.Location = New System.Drawing.Point(145, 161)
		Me.diachi_tb.Name = "diachi_tb"
		Me.diachi_tb.[ReadOnly] = True
		Me.diachi_tb.Size = New System.Drawing.Size(200, 20)
		Me.diachi_tb.TabIndex = 13
		' 
		' sdt_tb
		' 
		Me.sdt_tb.Location = New System.Drawing.Point(145, 190)
		Me.sdt_tb.Name = "sdt_tb"
		Me.sdt_tb.[ReadOnly] = True
		Me.sdt_tb.Size = New System.Drawing.Size(200, 20)
		Me.sdt_tb.TabIndex = 14
		' 
		' email_tb
		' 
		Me.email_tb.Location = New System.Drawing.Point(145, 222)
		Me.email_tb.Name = "email_tb"
		Me.email_tb.[ReadOnly] = True
		Me.email_tb.Size = New System.Drawing.Size(200, 20)
		Me.email_tb.TabIndex = 15
		' 
		' sotienthu_tb
		' 
		Me.sotienthu_tb.Location = New System.Drawing.Point(145, 253)
		Me.sotienthu_tb.Name = "sotienthu_tb"
		Me.sotienthu_tb.Size = New System.Drawing.Size(200, 20)
		Me.sotienthu_tb.TabIndex = 16
		' 
		' label10
		' 
		Me.label10.AutoSize = True
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label10.Location = New System.Drawing.Point(113, 9)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(150, 20)
		Me.label10.TabIndex = 17
		Me.label10.Text = "PHIẾU THU TIỀN"
		' 
		' lapphieu_button
		' 
		Me.lapphieu_button.Location = New System.Drawing.Point(80, 297)
		Me.lapphieu_button.Name = "lapphieu_button"
		Me.lapphieu_button.Size = New System.Drawing.Size(75, 23)
		Me.lapphieu_button.TabIndex = 18
		Me.lapphieu_button.Text = "Lập phiếu"
		Me.lapphieu_button.UseVisualStyleBackColor = True
		' 
		' refresh
		' 
		Me.refresh.Location = New System.Drawing.Point(224, 297)
		Me.refresh.Name = "refresh"
		Me.refresh.Size = New System.Drawing.Size(75, 23)
		Me.refresh.TabIndex = 19
		Me.refresh.Text = "Clear"
		Me.refresh.UseVisualStyleBackColor = True
		AddHandler Me.refresh.Click, New System.EventHandler(AddressOf Me.refresh_Click)
		' 
		' FormPhieuThuTien
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(391, 343)
		Me.Controls.Add(Me.refresh)
		Me.Controls.Add(Me.lapphieu_button)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.sotienthu_tb)
		Me.Controls.Add(Me.email_tb)
		Me.Controls.Add(Me.sdt_tb)
		Me.Controls.Add(Me.diachi_tb)
		Me.Controls.Add(Me.ten_tb)
		Me.Controls.Add(Me.makh_tb)
		Me.Controls.Add(Me.dateTimePicker1)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.maphieu_tb)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "FormPhieuThuTien"
		Me.Text = "Phiếu thu tiền"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormPhieuThuTien_Load)
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
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private maphieu_tb As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private makh_tb As System.Windows.Forms.TextBox
	Private ten_tb As System.Windows.Forms.TextBox
	Private diachi_tb As System.Windows.Forms.TextBox
	Private sdt_tb As System.Windows.Forms.TextBox
	Private email_tb As System.Windows.Forms.TextBox
	Private sotienthu_tb As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private lapphieu_button As System.Windows.Forms.Button
	Private Shadows refresh As System.Windows.Forms.Button
End Class
