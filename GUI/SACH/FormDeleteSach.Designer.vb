Namespace SACH
	Partial Class FormDeleteSach
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
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.tim_button = New System.Windows.Forms.Button()
			Me.xoa_button = New System.Windows.Forms.Button()
			Me.close_button = New System.Windows.Forms.Button()
			Me.masach_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tensach_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.theloai_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tacgia_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dongia_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.soluongton_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(25, 27)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(48, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Mã sách"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(89, 24)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(136, 20)
			Me.textBox1.TabIndex = 1
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.masach_col, Me.tensach_col, Me.theloai_col, Me.tacgia_col, Me.dongia_col, Me.soluongton_col})
			Me.dataGridView1.Location = New System.Drawing.Point(28, 78)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(819, 229)
			Me.dataGridView1.TabIndex = 2
			' 
			' tim_button
			' 
			Me.tim_button.Location = New System.Drawing.Point(240, 22)
			Me.tim_button.Name = "tim_button"
			Me.tim_button.Size = New System.Drawing.Size(49, 23)
			Me.tim_button.TabIndex = 3
			Me.tim_button.Text = "Search"
			Me.tim_button.UseVisualStyleBackColor = True
			' 
			' xoa_button
			' 
			Me.xoa_button.Location = New System.Drawing.Point(798, 49)
			Me.xoa_button.Name = "xoa_button"
			Me.xoa_button.Size = New System.Drawing.Size(49, 23)
			Me.xoa_button.TabIndex = 4
			Me.xoa_button.Text = "Delete"
			Me.xoa_button.UseVisualStyleBackColor = True
			' 
			' close_button
			' 
			Me.close_button.Location = New System.Drawing.Point(416, 320)
			Me.close_button.Name = "close_button"
			Me.close_button.Size = New System.Drawing.Size(49, 23)
			Me.close_button.TabIndex = 5
			Me.close_button.Text = "Close"
			Me.close_button.UseVisualStyleBackColor = True
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
			' FormDeleteSach
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(874, 355)
			Me.Controls.Add(Me.close_button)
			Me.Controls.Add(Me.xoa_button)
			Me.Controls.Add(Me.tim_button)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label1)
			Me.Name = "FormDeleteSach"
			Me.Text = "Xóa sách"
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private masach_col As System.Windows.Forms.DataGridViewTextBoxColumn
		Private tensach_col As System.Windows.Forms.DataGridViewTextBoxColumn
		Private theloai_col As System.Windows.Forms.DataGridViewTextBoxColumn
		Private tacgia_col As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dongia_col As System.Windows.Forms.DataGridViewTextBoxColumn
		Private soluongton_col As System.Windows.Forms.DataGridViewTextBoxColumn
		Private tim_button As System.Windows.Forms.Button
		Private xoa_button As System.Windows.Forms.Button
		Private close_button As System.Windows.Forms.Button
	End Class
End Namespace
