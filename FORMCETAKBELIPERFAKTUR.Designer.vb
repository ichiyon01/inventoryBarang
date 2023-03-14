<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMCETAKBELIPERFAKTUR
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
        Me.TXTNAMASP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTKODESP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTPREVIEW = New System.Windows.Forms.Button()
        Me.DGVBELI = New System.Windows.Forms.DataGridView()
        Me.PDBELI = New System.Drawing.Printing.PrintDocument()
        Me.TXTFAKTUR = New System.Windows.Forms.ComboBox()
        Me.TXTTANGGAL = New System.Windows.Forms.TextBox()
        CType(Me.DGVBELI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTNAMASP
        '
        Me.TXTNAMASP.Location = New System.Drawing.Point(501, 81)
        Me.TXTNAMASP.Name = "TXTNAMASP"
        Me.TXTNAMASP.Size = New System.Drawing.Size(206, 27)
        Me.TXTNAMASP.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(374, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "NAMA SUPLIER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(123, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "TANGGAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(374, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "KODE SUPLIER"
        '
        'TXTKODESP
        '
        Me.TXTKODESP.Location = New System.Drawing.Point(501, 46)
        Me.TXTKODESP.Name = "TXTKODESP"
        Me.TXTKODESP.Size = New System.Drawing.Size(107, 27)
        Me.TXTKODESP.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(123, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "NO. FAKTUR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(191, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(371, 28)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "FORM CETAK PEMBELIAN PERFAKTUR"
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTCLOSE.Location = New System.Drawing.Point(392, 122)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(94, 29)
        Me.BTCLOSE.TabIndex = 51
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTPREVIEW
        '
        Me.BTPREVIEW.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTPREVIEW.Location = New System.Drawing.Point(273, 122)
        Me.BTPREVIEW.Name = "BTPREVIEW"
        Me.BTPREVIEW.Size = New System.Drawing.Size(113, 29)
        Me.BTPREVIEW.TabIndex = 50
        Me.BTPREVIEW.Text = "PREVIEW"
        Me.BTPREVIEW.UseVisualStyleBackColor = True
        '
        'DGVBELI
        '
        Me.DGVBELI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBELI.Location = New System.Drawing.Point(12, 157)
        Me.DGVBELI.Name = "DGVBELI"
        Me.DGVBELI.RowHeadersWidth = 51
        Me.DGVBELI.RowTemplate.Height = 29
        Me.DGVBELI.Size = New System.Drawing.Size(776, 318)
        Me.DGVBELI.TabIndex = 52
        '
        'PDBELI
        '
        '
        'TXTFAKTUR
        '
        Me.TXTFAKTUR.FormattingEnabled = True
        Me.TXTFAKTUR.Location = New System.Drawing.Point(233, 48)
        Me.TXTFAKTUR.Name = "TXTFAKTUR"
        Me.TXTFAKTUR.Size = New System.Drawing.Size(62, 28)
        Me.TXTFAKTUR.TabIndex = 53
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Location = New System.Drawing.Point(232, 80)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(91, 27)
        Me.TXTTANGGAL.TabIndex = 54
        '
        'FORMCETAKBELIPERFAKTUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.TXTTANGGAL)
        Me.Controls.Add(Me.TXTFAKTUR)
        Me.Controls.Add(Me.DGVBELI)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTPREVIEW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTNAMASP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTKODESP)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FORMCETAKBELIPERFAKTUR"
        Me.Text = "Form1"
        CType(Me.DGVBELI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTNAMASP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTKODESP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTPREVIEW As Button
    Friend WithEvents DGVBELI As DataGridView
    Friend WithEvents PDBELI As Drawing.Printing.PrintDocument
    Friend WithEvents TXTFAKTUR As ComboBox
    Friend WithEvents TXTTANGGAL As TextBox
End Class
