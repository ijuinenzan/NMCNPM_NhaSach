Partial Class FormDanhSachSach
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
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.masach_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tensach_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.theloai_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tacgia_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dongia_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.soluongton_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.masach_tb = New System.Windows.Forms.TextBox()
		Me.search_button = New System.Windows.Forms.Button()
		Me.update_button = New System.Windows.Forms.Button()
		Me.del_button = New System.Windows.Forms.Button()
		Me.masach_checkbox = New System.Windows.Forms.CheckBox()
		Me.ten_checkbox = New System.Windows.Forms.CheckBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.theloai_checkbox = New System.Windows.Forms.CheckBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.tacgia_checkbox = New System.Windows.Forms.CheckBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.soluongton_checkbox = New System.Windows.Forms.CheckBox()
		Me.dongia_checkbox = New System.Windows.Forms.CheckBox()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' dataGridView1
		' 
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.masach_col, Me.tensach_col, Me.theloai_col, Me.tacgia_col, Me.dongia_col, Me.soluongton_col})
		Me.dataGridView1.Location = New System.Drawing.Point(31, 116)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(641, 205)
		Me.dataGridView1.TabIndex = 0
		' 
		' masach_col
		' 
		Me.masach_col.HeaderText = "Mã sách"
		Me.masach_col.Name = "masach_col"
		' 
		' tensach_col
		' 
		Me.tensach_col.HeaderText = "Tên sách"
		Me.tensach_col.Name = "tensach_col"
		' 
		' theloai_col
		' 
		Me.theloai_col.HeaderText = "Thể loại"
		Me.theloai_col.Name = "theloai_col"
		' 
		' tacgia_col
		' 
		Me.tacgia_col.HeaderText = "Tác giả"
		Me.tacgia_col.Name = "tacgia_col"
		' 
		' dongia_col
		' 
		Me.dongia_col.HeaderText = "Đơn giá"
		Me.dongia_col.Name = "dongia_col"
		' 
		' soluongton_col
		' 
		Me.soluongton_col.HeaderText = "Số lượng tồn"
		Me.soluongton_col.Name = "soluongton_col"
		' 
		' masach_tb
		' 
		Me.masach_tb.Location = New System.Drawing.Point(108, 26)
		Me.masach_tb.Name = "masach_tb"
		Me.masach_tb.Size = New System.Drawing.Size(96, 20)
		Me.masach_tb.TabIndex = 1
		' 
		' search_button
		' 
		Me.search_button.Location = New System.Drawing.Point(615, 24)
		Me.search_button.Name = "search_button"
		Me.search_button.Size = New System.Drawing.Size(57, 48)
		Me.search_button.TabIndex = 3
		Me.search_button.Text = "Search"
		Me.search_button.UseVisualStyleBackColor = True
		' 
		' update_button
		' 
		Me.update_button.Location = New System.Drawing.Point(117, 87)
		Me.update_button.Name = "update_button"
		Me.update_button.Size = New System.Drawing.Size(75, 23)
		Me.update_button.TabIndex = 5
		Me.update_button.Text = "Update"
		Me.update_button.UseVisualStyleBackColor = True
		' 
		' del_button
		' 
		Me.del_button.Location = New System.Drawing.Point(31, 87)
		Me.del_button.Name = "del_button"
		Me.del_button.Size = New System.Drawing.Size(75, 23)
		Me.del_button.TabIndex = 6
		Me.del_button.Text = "Delete"
		Me.del_button.UseVisualStyleBackColor = True
		' 
		' masach_checkbox
		' 
		Me.masach_checkbox.AutoSize = True
		Me.masach_checkbox.Location = New System.Drawing.Point(31, 28)
		Me.masach_checkbox.Name = "masach_checkbox"
		Me.masach_checkbox.Size = New System.Drawing.Size(67, 17)
		Me.masach_checkbox.TabIndex = 7
		Me.masach_checkbox.Text = "Mã sách"
		Me.masach_checkbox.UseVisualStyleBackColor = True
		AddHandler Me.masach_checkbox.CheckedChanged, New System.EventHandler(AddressOf Me.masach_checkbox_CheckedChanged)
		' 
		' ten_checkbox
		' 
		Me.ten_checkbox.AutoSize = True
		Me.ten_checkbox.Location = New System.Drawing.Point(31, 54)
		Me.ten_checkbox.Name = "ten_checkbox"
		Me.ten_checkbox.Size = New System.Drawing.Size(71, 17)
		Me.ten_checkbox.TabIndex = 9
		Me.ten_checkbox.Text = "Tên sách"
		Me.ten_checkbox.UseVisualStyleBackColor = True
		' 
		' textBox1
		' 
		Me.textBox1.Location = New System.Drawing.Point(108, 51)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(96, 20)
		Me.textBox1.TabIndex = 8
		' 
		' theloai_checkbox
		' 
		Me.theloai_checkbox.AutoSize = True
		Me.theloai_checkbox.Location = New System.Drawing.Point(226, 28)
		Me.theloai_checkbox.Name = "theloai_checkbox"
		Me.theloai_checkbox.Size = New System.Drawing.Size(64, 17)
		Me.theloai_checkbox.TabIndex = 11
		Me.theloai_checkbox.Text = "Thể loại"
		Me.theloai_checkbox.UseVisualStyleBackColor = True
		' 
		' textBox2
		' 
		Me.textBox2.Location = New System.Drawing.Point(296, 25)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(95, 20)
		Me.textBox2.TabIndex = 10
		' 
		' tacgia_checkbox
		' 
		Me.tacgia_checkbox.AutoSize = True
		Me.tacgia_checkbox.Location = New System.Drawing.Point(226, 53)
		Me.tacgia_checkbox.Name = "tacgia_checkbox"
		Me.tacgia_checkbox.Size = New System.Drawing.Size(62, 17)
		Me.tacgia_checkbox.TabIndex = 13
		Me.tacgia_checkbox.Text = "Tác giả"
		Me.tacgia_checkbox.UseVisualStyleBackColor = True
		' 
		' textBox3
		' 
		Me.textBox3.Location = New System.Drawing.Point(296, 50)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(96, 20)
		Me.textBox3.TabIndex = 12
		' 
		' soluongton_checkbox
		' 
		Me.soluongton_checkbox.AutoSize = True
		Me.soluongton_checkbox.Location = New System.Drawing.Point(412, 26)
		Me.soluongton_checkbox.Name = "soluongton_checkbox"
		Me.soluongton_checkbox.Size = New System.Drawing.Size(86, 17)
		Me.soluongton_checkbox.TabIndex = 15
		Me.soluongton_checkbox.Text = "Số lượng tồn"
		Me.soluongton_checkbox.UseVisualStyleBackColor = True
		' 
		' dongia_checkbox
		' 
		Me.dongia_checkbox.AutoSize = True
		Me.dongia_checkbox.Location = New System.Drawing.Point(412, 53)
		Me.dongia_checkbox.Name = "dongia_checkbox"
		Me.dongia_checkbox.Size = New System.Drawing.Size(63, 17)
		Me.dongia_checkbox.TabIndex = 17
		Me.dongia_checkbox.Text = "Đơn giá"
		Me.dongia_checkbox.UseVisualStyleBackColor = True
		' 
		' textBox5
		' 
		Me.textBox5.Location = New System.Drawing.Point(504, 50)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(96, 20)
		Me.textBox5.TabIndex = 16
		' 
		' FormDanhSachSach
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(713, 370)
		Me.Controls.Add(Me.dongia_checkbox)
		Me.Controls.Add(Me.textBox5)
		Me.Controls.Add(Me.soluongton_checkbox)
		Me.Controls.Add(Me.tacgia_checkbox)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.theloai_checkbox)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.ten_checkbox)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.masach_checkbox)
		Me.Controls.Add(Me.del_button)
		Me.Controls.Add(Me.update_button)
		Me.Controls.Add(Me.search_button)
		Me.Controls.Add(Me.masach_tb)
		Me.Controls.Add(Me.dataGridView1)
		Me.Name = "FormDanhSachSach"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text = "Tra cứu sách"
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private masach_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private tensach_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private theloai_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private tacgia_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dongia_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private soluongton_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private masach_tb As System.Windows.Forms.TextBox
	Private search_button As System.Windows.Forms.Button
	Private update_button As System.Windows.Forms.Button
	Private del_button As System.Windows.Forms.Button
	Private masach_checkbox As System.Windows.Forms.CheckBox
	Private ten_checkbox As System.Windows.Forms.CheckBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private theloai_checkbox As System.Windows.Forms.CheckBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private tacgia_checkbox As System.Windows.Forms.CheckBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private soluongton_checkbox As System.Windows.Forms.CheckBox
	Private dongia_checkbox As System.Windows.Forms.CheckBox
	Private textBox5 As System.Windows.Forms.TextBox
End Class
