Namespace SACH
	Partial Class FormImportSach
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
			Me.label6 = New System.Windows.Forms.Label()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.import_button = New System.Windows.Forms.Button()
			Me.delete_button = New System.Windows.Forms.Button()
			Me.update_button = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.tensach = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.theloai = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tacgia = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dongia = New System.Windows.Forms.DataGridViewTextBoxColumn()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(12, 165)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(0, 13)
			Me.label6.TabIndex = 5
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tensach, Me.theloai, Me.tacgia, Me.dongia})
			Me.dataGridView1.Location = New System.Drawing.Point(15, 12)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(643, 302)
			Me.dataGridView1.TabIndex = 12
			' 
			' import_button
			' 
			Me.import_button.Location = New System.Drawing.Point(493, 320)
			Me.import_button.Name = "import_button"
			Me.import_button.Size = New System.Drawing.Size(75, 23)
			Me.import_button.TabIndex = 13
			Me.import_button.Text = "Thêm"
			Me.import_button.UseVisualStyleBackColor = True
			AddHandler Me.import_button.Click, New System.EventHandler(AddressOf Me.import_button_Click)
			' 
			' delete_button
			' 
			Me.delete_button.Location = New System.Drawing.Point(109, 320)
			Me.delete_button.Name = "delete_button"
			Me.delete_button.Size = New System.Drawing.Size(75, 23)
			Me.delete_button.TabIndex = 14
			Me.delete_button.Text = "Xóa"
			Me.delete_button.UseVisualStyleBackColor = True
			' 
			' update_button
			' 
			Me.update_button.Location = New System.Drawing.Point(15, 320)
			Me.update_button.Name = "update_button"
			Me.update_button.Size = New System.Drawing.Size(75, 23)
			Me.update_button.TabIndex = 15
			Me.update_button.Text = "Sửa"
			Me.update_button.UseVisualStyleBackColor = True
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(583, 320)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(75, 23)
			Me.button4.TabIndex = 16
			Me.button4.Text = "Thoát"
			Me.button4.UseVisualStyleBackColor = True
			' 
			' tensach
			' 
			Me.tensach.HeaderText = "Tên sách"
			Me.tensach.Name = "tensach"
			' 
			' theloai
			' 
			Me.theloai.HeaderText = "Thể loại"
			Me.theloai.Name = "theloai"
			' 
			' tacgia
			' 
			Me.tacgia.HeaderText = "Tác giả"
			Me.tacgia.Name = "tacgia"
			' 
			' dongia
			' 
			Me.dongia.HeaderText = "Đơn giá"
			Me.dongia.Name = "dongia"
			' 
			' FormImportSach
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(670, 350)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.update_button)
			Me.Controls.Add(Me.delete_button)
			Me.Controls.Add(Me.import_button)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.label6)
			Me.Name = "FormImportSach"
			Me.Text = "Thêm sách mới"
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private label6 As System.Windows.Forms.Label
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private import_button As System.Windows.Forms.Button
		Private delete_button As System.Windows.Forms.Button
		Private update_button As System.Windows.Forms.Button
		Private button4 As System.Windows.Forms.Button
		Private tensach As System.Windows.Forms.DataGridViewTextBoxColumn
		Private theloai As System.Windows.Forms.DataGridViewTextBoxColumn
		Private tacgia As System.Windows.Forms.DataGridViewTextBoxColumn
		Private dongia As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
