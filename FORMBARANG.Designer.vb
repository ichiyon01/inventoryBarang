<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMBARANG
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
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTHAPUS = New System.Windows.Forms.Button()
        Me.BTBLANKFORM = New System.Windows.Forms.Button()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.TXTKODEBRG = New System.Windows.Forms.TextBox()
        Me.TXTNAMABRG = New System.Windows.Forms.TextBox()
        Me.TXTHRGBELI = New System.Windows.Forms.TextBox()
        Me.TXTHRGJUAL = New System.Windows.Forms.TextBox()
        Me.TXTJMLAWAL = New System.Windows.Forms.TextBox()
        Me.DGVBARANG = New System.Windows.Forms.DataGridView()
        CType(Me.DGVBARANG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTSIMPAN.Location = New System.Drawing.Point(286, 209)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(94, 29)
        Me.BTSIMPAN.TabIndex = 0
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(381, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(218, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM DATA BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(286, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KODE BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(286, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(132, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NAMA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(286, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HARGA BELI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(286, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(108, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "HARGA JUAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(286, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(123, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "JUMLAH AWAL"
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTHAPUS.Location = New System.Drawing.Point(386, 209)
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Size = New System.Drawing.Size(94, 29)
        Me.BTHAPUS.TabIndex = 7
        Me.BTHAPUS.Text = "HAPUS"
        Me.BTHAPUS.UseVisualStyleBackColor = True
        '
        'BTBLANKFORM
        '
        Me.BTBLANKFORM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTBLANKFORM.Location = New System.Drawing.Point(486, 209)
        Me.BTBLANKFORM.Name = "BTBLANKFORM"
        Me.BTBLANKFORM.Size = New System.Drawing.Size(113, 29)
        Me.BTBLANKFORM.TabIndex = 8
        Me.BTBLANKFORM.Text = "BLANKFORM"
        Me.BTBLANKFORM.UseVisualStyleBackColor = True
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTCLOSE.Location = New System.Drawing.Point(605, 209)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(94, 29)
        Me.BTCLOSE.TabIndex = 9
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'TXTKODEBRG
        '
        Me.TXTKODEBRG.Location = New System.Drawing.Point(460, 60)
        Me.TXTKODEBRG.Name = "TXTKODEBRG"
        Me.TXTKODEBRG.Size = New System.Drawing.Size(57, 27)
        Me.TXTKODEBRG.TabIndex = 0
        '
        'TXTNAMABRG
        '
        Me.TXTNAMABRG.Location = New System.Drawing.Point(460, 89)
        Me.TXTNAMABRG.Name = "TXTNAMABRG"
        Me.TXTNAMABRG.Size = New System.Drawing.Size(208, 27)
        Me.TXTNAMABRG.TabIndex = 11
        '
        'TXTHRGBELI
        '
        Me.TXTHRGBELI.Location = New System.Drawing.Point(460, 117)
        Me.TXTHRGBELI.Name = "TXTHRGBELI"
        Me.TXTHRGBELI.Size = New System.Drawing.Size(126, 27)
        Me.TXTHRGBELI.TabIndex = 12
        '
        'TXTHRGJUAL
        '
        Me.TXTHRGJUAL.Location = New System.Drawing.Point(460, 145)
        Me.TXTHRGJUAL.Name = "TXTHRGJUAL"
        Me.TXTHRGJUAL.Size = New System.Drawing.Size(126, 27)
        Me.TXTHRGJUAL.TabIndex = 13
        '
        'TXTJMLAWAL
        '
        Me.TXTJMLAWAL.Location = New System.Drawing.Point(460, 173)
        Me.TXTJMLAWAL.Name = "TXTJMLAWAL"
        Me.TXTJMLAWAL.Size = New System.Drawing.Size(126, 27)
        Me.TXTJMLAWAL.TabIndex = 14
        '
        'DGVBARANG
        '
        Me.DGVBARANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBARANG.Location = New System.Drawing.Point(12, 250)
        Me.DGVBARANG.Name = "DGVBARANG"
        Me.DGVBARANG.RowHeadersWidth = 51
        Me.DGVBARANG.RowTemplate.Height = 29
        Me.DGVBARANG.Size = New System.Drawing.Size(957, 188)
        Me.DGVBARANG.TabIndex = 15
        '
        'FORMBARANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 450)
        Me.Controls.Add(Me.DGVBARANG)
        Me.Controls.Add(Me.TXTJMLAWAL)
        Me.Controls.Add(Me.TXTHRGJUAL)
        Me.Controls.Add(Me.TXTHRGBELI)
        Me.Controls.Add(Me.TXTNAMABRG)
        Me.Controls.Add(Me.TXTKODEBRG)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANKFORM)
        Me.Controls.Add(Me.BTHAPUS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Name = "FORMBARANG"
        Me.Text = "Form1"
        CType(Me.DGVBARANG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTHAPUS As Button
    Friend WithEvents BTBLANKFORM As Button
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents TXTKODEBRG As TextBox
    Friend WithEvents TXTNAMABRG As TextBox
    Friend WithEvents TXTHRGBELI As TextBox
    Friend WithEvents TXTHRGJUAL As TextBox
    Friend WithEvents TXTJMLAWAL As TextBox
    Friend WithEvents DGVBARANG As DataGridView
End Class
