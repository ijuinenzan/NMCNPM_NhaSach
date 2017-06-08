Partial Class FormThayDoiQuyDinh
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
		Me.sudungquidinh = New System.Windows.Forms.CheckBox()
		Me.slNhap_tb = New System.Windows.Forms.TextBox()
		Me.tienNo_tb = New System.Windows.Forms.TextBox()
		Me.slTonSauBan_tb = New System.Windows.Forms.TextBox()
		Me.slTonTruocNhap_tb = New System.Windows.Forms.TextBox()
		Me.capnhat_bt = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(24, 39)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(0, 13)
		Me.label1.TabIndex = 0
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(12, 39)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(153, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "SỐ LƯỢNG NHẬP TỐI THIỂU"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(12, 73)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(202, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "SỐ LƯỢNG TỒN TỐI ĐA TRƯỚC NHẬP"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(12, 142)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(217, 13)
		Me.label4.TabIndex = 3
		Me.label4.Text = "SỐ LƯỢNG TỒN TỐI THIỂU SAU KHI BÁN"
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(12, 106)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(90, 13)
		Me.label5.TabIndex = 4
		Me.label5.Text = "TIỀN NỢ TỐI ĐA"
		' 
		' sudungquidinh
		' 
		Me.sudungquidinh.AutoSize = True
		Me.sudungquidinh.Location = New System.Drawing.Point(15, 176)
		Me.sudungquidinh.Name = "sudungquidinh"
		Me.sudungquidinh.Size = New System.Drawing.Size(141, 17)
		Me.sudungquidinh.TabIndex = 5
		Me.sudungquidinh.Text = "SỬ DỤNG QUY ĐỊNH 4"
		Me.sudungquidinh.UseVisualStyleBackColor = True
		' 
		' slNhap_tb
		' 
		Me.slNhap_tb.Location = New System.Drawing.Point(249, 32)
		Me.slNhap_tb.Name = "slNhap_tb"
		Me.slNhap_tb.Size = New System.Drawing.Size(244, 20)
		Me.slNhap_tb.TabIndex = 6
		' 
		' tienNo_tb
		' 
		Me.tienNo_tb.Location = New System.Drawing.Point(249, 103)
		Me.tienNo_tb.Name = "tienNo_tb"
		Me.tienNo_tb.Size = New System.Drawing.Size(244, 20)
		Me.tienNo_tb.TabIndex = 7
		' 
		' slTonSauBan_tb
		' 
		Me.slTonSauBan_tb.Location = New System.Drawing.Point(249, 139)
		Me.slTonSauBan_tb.Name = "slTonSauBan_tb"
		Me.slTonSauBan_tb.Size = New System.Drawing.Size(244, 20)
		Me.slTonSauBan_tb.TabIndex = 8
		' 
		' slTonTruocNhap_tb
		' 
		Me.slTonTruocNhap_tb.Location = New System.Drawing.Point(249, 66)
		Me.slTonTruocNhap_tb.Name = "slTonTruocNhap_tb"
		Me.slTonTruocNhap_tb.Size = New System.Drawing.Size(244, 20)
		Me.slTonTruocNhap_tb.TabIndex = 9
		' 
		' capnhat_bt
		' 
		Me.capnhat_bt.Location = New System.Drawing.Point(382, 195)
		Me.capnhat_bt.Name = "capnhat_bt"
		Me.capnhat_bt.Size = New System.Drawing.Size(111, 23)
		Me.capnhat_bt.TabIndex = 10
		Me.capnhat_bt.Text = "Cập nhật"
		Me.capnhat_bt.UseVisualStyleBackColor = True
		AddHandler Me.capnhat_bt.Click, New System.EventHandler(AddressOf Me.capnhat_bt_Click)
		' 
		' FormThayDoiQuyDinh
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(521, 235)
		Me.Controls.Add(Me.capnhat_bt)
		Me.Controls.Add(Me.slTonTruocNhap_tb)
		Me.Controls.Add(Me.slTonSauBan_tb)
		Me.Controls.Add(Me.tienNo_tb)
		Me.Controls.Add(Me.slNhap_tb)
		Me.Controls.Add(Me.sudungquidinh)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "FormThayDoiQuyDinh"
		Me.Text = "Thay đổi quy định"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormThayDoiQuyDinh_Load)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private sudungquidinh As System.Windows.Forms.CheckBox
	Private slNhap_tb As System.Windows.Forms.TextBox
	Private tienNo_tb As System.Windows.Forms.TextBox
	Private slTonSauBan_tb As System.Windows.Forms.TextBox
	Private slTonTruocNhap_tb As System.Windows.Forms.TextBox
	Private capnhat_bt As System.Windows.Forms.Button
End Class
