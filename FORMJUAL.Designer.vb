<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMJUAL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVJUAL = New System.Windows.Forms.DataGridView()
        Me.DGVDETAILJUAL = New System.Windows.Forms.DataGridView()
        Me.TXTNAMABRG = New System.Windows.Forms.TextBox()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.TXTJUMLAH = New System.Windows.Forms.TextBox()
        Me.TXTHRGJUAL = New System.Windows.Forms.TextBox()
        Me.TXTKODEBRG = New System.Windows.Forms.ComboBox()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTBLANKFORM = New System.Windows.Forms.Button()
        Me.BTTAMBAH = New System.Windows.Forms.Button()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.TXTNAMACS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTTANGGAL = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTKODECS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNOTA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTTOTALJUAL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGVJUAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDETAILJUAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVJUAL
        '
        Me.DGVJUAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJUAL.Location = New System.Drawing.Point(3, 452)
        Me.DGVJUAL.Name = "DGVJUAL"
        Me.DGVJUAL.RowHeadersWidth = 51
        Me.DGVJUAL.RowTemplate.Height = 29
        Me.DGVJUAL.Size = New System.Drawing.Size(981, 294)
        Me.DGVJUAL.TabIndex = 72
        '
        'DGVDETAILJUAL
        '
        Me.DGVDETAILJUAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDETAILJUAL.Location = New System.Drawing.Point(175, 195)
        Me.DGVDETAILJUAL.Name = "DGVDETAILJUAL"
        Me.DGVDETAILJUAL.RowHeadersWidth = 51
        Me.DGVDETAILJUAL.RowTemplate.Height = 29
        Me.DGVDETAILJUAL.Size = New System.Drawing.Size(634, 219)
        Me.DGVDETAILJUAL.TabIndex = 71
        '
        'TXTNAMABRG
        '
        Me.TXTNAMABRG.Location = New System.Drawing.Point(304, 161)
        Me.TXTNAMABRG.Name = "TXTNAMABRG"
        Me.TXTNAMABRG.Size = New System.Drawing.Size(107, 27)
        Me.TXTNAMABRG.TabIndex = 70
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Location = New System.Drawing.Point(643, 162)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(107, 27)
        Me.TXTTOTAL.TabIndex = 69
        '
        'TXTJUMLAH
        '
        Me.TXTJUMLAH.Location = New System.Drawing.Point(530, 161)
        Me.TXTJUMLAH.Name = "TXTJUMLAH"
        Me.TXTJUMLAH.Size = New System.Drawing.Size(107, 27)
        Me.TXTJUMLAH.TabIndex = 68
        '
        'TXTHRGJUAL
        '
        Me.TXTHRGJUAL.Location = New System.Drawing.Point(417, 161)
        Me.TXTHRGJUAL.Name = "TXTHRGJUAL"
        Me.TXTHRGJUAL.Size = New System.Drawing.Size(107, 27)
        Me.TXTHRGJUAL.TabIndex = 67
        '
        'TXTKODEBRG
        '
        Me.TXTKODEBRG.FormattingEnabled = True
        Me.TXTKODEBRG.Location = New System.Drawing.Point(226, 160)
        Me.TXTKODEBRG.Name = "TXTKODEBRG"
        Me.TXTKODEBRG.Size = New System.Drawing.Size(72, 28)
        Me.TXTKODEBRG.TabIndex = 66
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTCLOSE.Location = New System.Drawing.Point(593, 126)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(94, 29)
        Me.BTCLOSE.TabIndex = 65
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTBLANKFORM
        '
        Me.BTBLANKFORM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTBLANKFORM.Location = New System.Drawing.Point(474, 126)
        Me.BTBLANKFORM.Name = "BTBLANKFORM"
        Me.BTBLANKFORM.Size = New System.Drawing.Size(113, 29)
        Me.BTBLANKFORM.TabIndex = 64
        Me.BTBLANKFORM.Text = "BLANKFORM"
        Me.BTBLANKFORM.UseVisualStyleBackColor = True
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTTAMBAH.Location = New System.Drawing.Point(274, 126)
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Size = New System.Drawing.Size(94, 29)
        Me.BTTAMBAH.TabIndex = 63
        Me.BTTAMBAH.Text = "TAMBAH"
        Me.BTTAMBAH.UseVisualStyleBackColor = True
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTSIMPAN.Location = New System.Drawing.Point(374, 126)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(94, 29)
        Me.BTSIMPAN.TabIndex = 62
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'TXTNAMACS
        '
        Me.TXTNAMACS.Location = New System.Drawing.Point(642, 84)
        Me.TXTNAMACS.Name = "TXTNAMACS"
        Me.TXTNAMACS.Size = New System.Drawing.Size(206, 27)
        Me.TXTNAMACS.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(474, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(152, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "NAMA CUSTOMER"
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTTANGGAL.Location = New System.Drawing.Point(333, 82)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(126, 27)
        Me.TXTTANGGAL.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(223, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "TANGGAL"
        '
        'TXTKODECS
        '
        Me.TXTKODECS.FormattingEnabled = True
        Me.TXTKODECS.Location = New System.Drawing.Point(643, 53)
        Me.TXTKODECS.Name = "TXTKODECS"
        Me.TXTKODECS.Size = New System.Drawing.Size(61, 28)
        Me.TXTKODECS.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(474, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(145, 23)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "KODE CUSTOMER"
        '
        'TXTNOTA
        '
        Me.TXTNOTA.Location = New System.Drawing.Point(333, 49)
        Me.TXTNOTA.Name = "TXTNOTA"
        Me.TXTNOTA.Size = New System.Drawing.Size(107, 27)
        Me.TXTNOTA.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(223, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "NO. NOTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(332, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(307, 28)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "FORM TRANSAKSI PENJUALAN"
        '
        'TXTTOTALJUAL
        '
        Me.TXTTOTALJUAL.Location = New System.Drawing.Point(605, 420)
        Me.TXTTOTALJUAL.Name = "TXTTOTALJUAL"
        Me.TXTTOTALJUAL.Size = New System.Drawing.Size(206, 27)
        Me.TXTTOTALJUAL.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(481, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "TOTAL HARGA"
        '
        'FORMJUAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 747)
        Me.Controls.Add(Me.TXTTOTALJUAL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVJUAL)
        Me.Controls.Add(Me.DGVDETAILJUAL)
        Me.Controls.Add(Me.TXTNAMABRG)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.TXTJUMLAH)
        Me.Controls.Add(Me.TXTHRGJUAL)
        Me.Controls.Add(Me.TXTKODEBRG)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANKFORM)
        Me.Controls.Add(Me.BTTAMBAH)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Controls.Add(Me.TXTNAMACS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTANGGAL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTKODECS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTNOTA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORMJUAL"
        Me.Text = "FORMJUAL"
        CType(Me.DGVJUAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDETAILJUAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVJUAL As DataGridView
    Friend WithEvents DGVDETAILJUAL As DataGridView
    Friend WithEvents TXTNAMABRG As TextBox
    Friend WithEvents TXTTOTAL As TextBox
    Friend WithEvents TXTJUMLAH As TextBox
    Friend WithEvents TXTHRGJUAL As TextBox
    Friend WithEvents TXTKODEBRG As ComboBox
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTBLANKFORM As Button
    Friend WithEvents BTTAMBAH As Button
    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents TXTNAMACS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTTANGGAL As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTKODECS As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTNOTA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTTOTALJUAL As TextBox
    Friend WithEvents Label6 As Label
End Class
