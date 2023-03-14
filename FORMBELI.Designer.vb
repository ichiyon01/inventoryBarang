<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMBELI
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
        Me.TXTFAKTUR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTKODESP = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTANGGAL = New System.Windows.Forms.DateTimePicker()
        Me.TXTNAMASP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTBLANKFORM = New System.Windows.Forms.Button()
        Me.BTTAMBAH = New System.Windows.Forms.Button()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.TXTHRGBELI = New System.Windows.Forms.TextBox()
        Me.TXTJUMLAH = New System.Windows.Forms.TextBox()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.TXTNAMABRG = New System.Windows.Forms.TextBox()
        Me.DGVDETAILBELI = New System.Windows.Forms.DataGridView()
        Me.DGVBELI = New System.Windows.Forms.DataGridView()
        Me.BTHAPUS = New System.Windows.Forms.Button()
        Me.TXTKODEBRG = New System.Windows.Forms.ComboBox()
        CType(Me.DGVDETAILBELI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBELI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTFAKTUR
        '
        Me.TXTFAKTUR.Location = New System.Drawing.Point(346, 65)
        Me.TXTFAKTUR.Name = "TXTFAKTUR"
        Me.TXTFAKTUR.Size = New System.Drawing.Size(107, 27)
        Me.TXTFAKTUR.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(236, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "NO. FAKTUR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(345, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(303, 28)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "FORM TRANSAKSI PEMBELIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(487, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "KODE SUPLIER"
        '
        'TXTKODESP
        '
        Me.TXTKODESP.FormattingEnabled = True
        Me.TXTKODESP.Location = New System.Drawing.Point(614, 69)
        Me.TXTKODESP.Name = "TXTKODESP"
        Me.TXTKODESP.Size = New System.Drawing.Size(95, 28)
        Me.TXTKODESP.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(236, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "TANGGAL"
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTTANGGAL.Location = New System.Drawing.Point(346, 98)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(126, 27)
        Me.TXTTANGGAL.TabIndex = 38
        '
        'TXTNAMASP
        '
        Me.TXTNAMASP.Location = New System.Drawing.Point(614, 100)
        Me.TXTNAMASP.Name = "TXTNAMASP"
        Me.TXTNAMASP.Size = New System.Drawing.Size(206, 27)
        Me.TXTNAMASP.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(487, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "NAMA SUPLIER"
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTCLOSE.Location = New System.Drawing.Point(656, 143)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(94, 29)
        Me.BTCLOSE.TabIndex = 44
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTBLANKFORM
        '
        Me.BTBLANKFORM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTBLANKFORM.Location = New System.Drawing.Point(537, 143)
        Me.BTBLANKFORM.Name = "BTBLANKFORM"
        Me.BTBLANKFORM.Size = New System.Drawing.Size(113, 29)
        Me.BTBLANKFORM.TabIndex = 43
        Me.BTBLANKFORM.Text = "BLANKFORM"
        Me.BTBLANKFORM.UseVisualStyleBackColor = True
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTTAMBAH.Location = New System.Drawing.Point(236, 143)
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Size = New System.Drawing.Size(94, 29)
        Me.BTTAMBAH.TabIndex = 42
        Me.BTTAMBAH.Text = "TAMBAH"
        Me.BTTAMBAH.UseVisualStyleBackColor = True
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTSIMPAN.Location = New System.Drawing.Point(437, 143)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(94, 29)
        Me.BTSIMPAN.TabIndex = 41
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'TXTHRGBELI
        '
        Me.TXTHRGBELI.Location = New System.Drawing.Point(430, 177)
        Me.TXTHRGBELI.Name = "TXTHRGBELI"
        Me.TXTHRGBELI.Size = New System.Drawing.Size(107, 27)
        Me.TXTHRGBELI.TabIndex = 46
        '
        'TXTJUMLAH
        '
        Me.TXTJUMLAH.Location = New System.Drawing.Point(543, 177)
        Me.TXTJUMLAH.Name = "TXTJUMLAH"
        Me.TXTJUMLAH.Size = New System.Drawing.Size(107, 27)
        Me.TXTJUMLAH.TabIndex = 47
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Location = New System.Drawing.Point(656, 178)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(107, 27)
        Me.TXTTOTAL.TabIndex = 48
        '
        'TXTNAMABRG
        '
        Me.TXTNAMABRG.Location = New System.Drawing.Point(317, 177)
        Me.TXTNAMABRG.Name = "TXTNAMABRG"
        Me.TXTNAMABRG.Size = New System.Drawing.Size(107, 27)
        Me.TXTNAMABRG.TabIndex = 49
        '
        'DGVDETAILBELI
        '
        Me.DGVDETAILBELI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDETAILBELI.Location = New System.Drawing.Point(186, 229)
        Me.DGVDETAILBELI.Name = "DGVDETAILBELI"
        Me.DGVDETAILBELI.RowHeadersWidth = 51
        Me.DGVDETAILBELI.RowTemplate.Height = 29
        Me.DGVDETAILBELI.Size = New System.Drawing.Size(634, 229)
        Me.DGVDETAILBELI.TabIndex = 50
        '
        'DGVBELI
        '
        Me.DGVBELI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBELI.Location = New System.Drawing.Point(12, 464)
        Me.DGVBELI.Name = "DGVBELI"
        Me.DGVBELI.RowHeadersWidth = 51
        Me.DGVBELI.RowTemplate.Height = 29
        Me.DGVBELI.Size = New System.Drawing.Size(981, 294)
        Me.DGVBELI.TabIndex = 51
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTHAPUS.Location = New System.Drawing.Point(337, 143)
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Size = New System.Drawing.Size(94, 29)
        Me.BTHAPUS.TabIndex = 52
        Me.BTHAPUS.Text = "HAPUS"
        Me.BTHAPUS.UseVisualStyleBackColor = True
        '
        'TXTKODEBRG
        '
        Me.TXTKODEBRG.FormattingEnabled = True
        Me.TXTKODEBRG.Location = New System.Drawing.Point(239, 178)
        Me.TXTKODEBRG.Name = "TXTKODEBRG"
        Me.TXTKODEBRG.Size = New System.Drawing.Size(72, 28)
        Me.TXTKODEBRG.TabIndex = 67
        '
        'FORMBELI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 770)
        Me.Controls.Add(Me.TXTKODEBRG)
        Me.Controls.Add(Me.BTHAPUS)
        Me.Controls.Add(Me.DGVBELI)
        Me.Controls.Add(Me.DGVDETAILBELI)
        Me.Controls.Add(Me.TXTNAMABRG)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.TXTJUMLAH)
        Me.Controls.Add(Me.TXTHRGBELI)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANKFORM)
        Me.Controls.Add(Me.BTTAMBAH)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Controls.Add(Me.TXTNAMASP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTANGGAL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTKODESP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTFAKTUR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORMBELI"
        Me.Text = "FORMBELI"
        CType(Me.DGVDETAILBELI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBELI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTFAKTUR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTKODESP As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTTANGGAL As DateTimePicker
    Friend WithEvents TXTNAMASP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTBLANKFORM As Button
    Friend WithEvents BTTAMBAH As Button
    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents TXTHRGBELI As TextBox
    Friend WithEvents TXTJUMLAH As TextBox
    Friend WithEvents TXTTOTAL As TextBox
    Friend WithEvents TXTNAMABRG As TextBox
    Friend WithEvents DGVDETAILBELI As DataGridView
    Friend WithEvents DGVBELI As DataGridView
    Friend WithEvents BTHAPUS As Button
    Friend WithEvents TXTKODEBRG As ComboBox
End Class
