<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMSUPLIER
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
        Me.DGVSP = New System.Windows.Forms.DataGridView()
        Me.TXTTELPONSP = New System.Windows.Forms.TextBox()
        Me.TXTALAMATSP = New System.Windows.Forms.TextBox()
        Me.TXTNAMASP = New System.Windows.Forms.TextBox()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTBLANKFORM = New System.Windows.Forms.Button()
        Me.BTHAPUS = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.TXTKODESP = New System.Windows.Forms.TextBox()
        CType(Me.DGVSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVSP
        '
        Me.DGVSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSP.Location = New System.Drawing.Point(125, 264)
        Me.DGVSP.Name = "DGVSP"
        Me.DGVSP.RowHeadersWidth = 51
        Me.DGVSP.RowTemplate.Height = 29
        Me.DGVSP.Size = New System.Drawing.Size(522, 189)
        Me.DGVSP.TabIndex = 29
        '
        'TXTTELPONSP
        '
        Me.TXTTELPONSP.Location = New System.Drawing.Point(342, 165)
        Me.TXTTELPONSP.Name = "TXTTELPONSP"
        Me.TXTTELPONSP.Size = New System.Drawing.Size(119, 27)
        Me.TXTTELPONSP.TabIndex = 28
        '
        'TXTALAMATSP
        '
        Me.TXTALAMATSP.Location = New System.Drawing.Point(342, 137)
        Me.TXTALAMATSP.Name = "TXTALAMATSP"
        Me.TXTALAMATSP.Size = New System.Drawing.Size(219, 27)
        Me.TXTALAMATSP.TabIndex = 27
        '
        'TXTNAMASP
        '
        Me.TXTNAMASP.Location = New System.Drawing.Point(342, 109)
        Me.TXTNAMASP.Name = "TXTNAMASP"
        Me.TXTNAMASP.Size = New System.Drawing.Size(219, 27)
        Me.TXTNAMASP.TabIndex = 26
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTCLOSE.Location = New System.Drawing.Point(487, 229)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(94, 29)
        Me.BTCLOSE.TabIndex = 25
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTBLANKFORM
        '
        Me.BTBLANKFORM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTBLANKFORM.Location = New System.Drawing.Point(368, 229)
        Me.BTBLANKFORM.Name = "BTBLANKFORM"
        Me.BTBLANKFORM.Size = New System.Drawing.Size(113, 29)
        Me.BTBLANKFORM.TabIndex = 24
        Me.BTBLANKFORM.Text = "BLANKFORM"
        Me.BTBLANKFORM.UseVisualStyleBackColor = True
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTHAPUS.Location = New System.Drawing.Point(268, 229)
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Size = New System.Drawing.Size(94, 29)
        Me.BTHAPUS.TabIndex = 23
        Me.BTHAPUS.Text = "HAPUS"
        Me.BTHAPUS.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(168, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(141, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "NOMOR TELPON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(168, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(168, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "NAMA SUPLIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(168, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "KODE SUPLIER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(263, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(211, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FORM DATA SUPLIER"
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTSIMPAN.Location = New System.Drawing.Point(168, 229)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(94, 29)
        Me.BTSIMPAN.TabIndex = 17
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'TXTKODESP
        '
        Me.TXTKODESP.Location = New System.Drawing.Point(342, 80)
        Me.TXTKODESP.Name = "TXTKODESP"
        Me.TXTKODESP.Size = New System.Drawing.Size(52, 27)
        Me.TXTKODESP.TabIndex = 30
        '
        'FORMSUPLIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 470)
        Me.Controls.Add(Me.TXTKODESP)
        Me.Controls.Add(Me.DGVSP)
        Me.Controls.Add(Me.TXTTELPONSP)
        Me.Controls.Add(Me.TXTALAMATSP)
        Me.Controls.Add(Me.TXTNAMASP)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANKFORM)
        Me.Controls.Add(Me.BTHAPUS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Name = "FORMSUPLIER"
        Me.Text = "FORMSUPLIER"
        CType(Me.DGVSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVSP As DataGridView
    Friend WithEvents TXTTELPONSP As TextBox
    Friend WithEvents TXTALAMATSP As TextBox
    Friend WithEvents TXTNAMASP As TextBox
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTBLANKFORM As Button
    Friend WithEvents BTHAPUS As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents TXTKODESP As TextBox
End Class
