<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMCUSTOMER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TXTKODECS = New System.Windows.Forms.TextBox()
        Me.DGVCS = New System.Windows.Forms.DataGridView()
        Me.TXTTELPONCS = New System.Windows.Forms.TextBox()
        Me.TXTALAMATCS = New System.Windows.Forms.TextBox()
        Me.TXTNAMACS = New System.Windows.Forms.TextBox()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTBLANKFORM = New System.Windows.Forms.Button()
        Me.BTHAPUS = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        CType(Me.DGVCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTKODECS
        '
        Me.TXTKODECS.Location = New System.Drawing.Point(356, 64)
        Me.TXTKODECS.Name = "TXTKODECS"
        Me.TXTKODECS.Size = New System.Drawing.Size(52, 27)
        Me.TXTKODECS.TabIndex = 44
        '
        'DGVCS
        '
        Me.DGVCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCS.Location = New System.Drawing.Point(139, 248)
        Me.DGVCS.Name = "DGVCS"
        Me.DGVCS.RowHeadersWidth = 51
        Me.DGVCS.RowTemplate.Height = 29
        Me.DGVCS.Size = New System.Drawing.Size(522, 189)
        Me.DGVCS.TabIndex = 43
        '
        'TXTTELPONCS
        '
        Me.TXTTELPONCS.Location = New System.Drawing.Point(356, 149)
        Me.TXTTELPONCS.Name = "TXTTELPONCS"
        Me.TXTTELPONCS.Size = New System.Drawing.Size(119, 27)
        Me.TXTTELPONCS.TabIndex = 42
        '
        'TXTALAMATCS
        '
        Me.TXTALAMATCS.Location = New System.Drawing.Point(356, 121)
        Me.TXTALAMATCS.Name = "TXTALAMATCS"
        Me.TXTALAMATCS.Size = New System.Drawing.Size(219, 27)
        Me.TXTALAMATCS.TabIndex = 41
        '
        'TXTNAMACS
        '
        Me.TXTNAMACS.Location = New System.Drawing.Point(356, 93)
        Me.TXTNAMACS.Name = "TXTNAMACS"
        Me.TXTNAMACS.Size = New System.Drawing.Size(219, 27)
        Me.TXTNAMACS.TabIndex = 40
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTCLOSE.Location = New System.Drawing.Point(501, 213)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(94, 29)
        Me.BTCLOSE.TabIndex = 39
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTBLANKFORM
        '
        Me.BTBLANKFORM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTBLANKFORM.Location = New System.Drawing.Point(382, 213)
        Me.BTBLANKFORM.Name = "BTBLANKFORM"
        Me.BTBLANKFORM.Size = New System.Drawing.Size(113, 29)
        Me.BTBLANKFORM.TabIndex = 38
        Me.BTBLANKFORM.Text = "BLANKFORM"
        Me.BTBLANKFORM.UseVisualStyleBackColor = True
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTHAPUS.Location = New System.Drawing.Point(282, 213)
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Size = New System.Drawing.Size(94, 29)
        Me.BTHAPUS.TabIndex = 37
        Me.BTHAPUS.Text = "HAPUS"
        Me.BTHAPUS.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(182, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(141, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "NOMOR TELPON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(182, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(182, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(152, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "NAMA CUSTOMER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(182, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "KODE CUSTOMER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(277, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(240, 28)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "FORM DATA CUSTOMER"
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTSIMPAN.Location = New System.Drawing.Point(182, 213)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(94, 29)
        Me.BTSIMPAN.TabIndex = 31
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'FORMCUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TXTKODECS)
        Me.Controls.Add(Me.DGVCS)
        Me.Controls.Add(Me.TXTTELPONCS)
        Me.Controls.Add(Me.TXTALAMATCS)
        Me.Controls.Add(Me.TXTNAMACS)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANKFORM)
        Me.Controls.Add(Me.BTHAPUS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Name = "FORMCUSTOMER"
        Me.Text = "FORMCUSTOMER"
        CType(Me.DGVCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTKODECS As TextBox
    Friend WithEvents DGVCS As DataGridView
    Friend WithEvents TXTTELPONCS As TextBox
    Friend WithEvents TXTALAMATCS As TextBox
    Friend WithEvents TXTNAMACS As TextBox
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTBLANKFORM As Button
    Friend WithEvents BTHAPUS As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTSIMPAN As Button
End Class
