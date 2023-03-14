Public Class FORMCUSTOMER
    Public KONEKSISTRING As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public SQLSTR As String
    Public CMD As New OleDb.OleDbCommand
    Public DACS As New OleDb.OleDbDataAdapter
    Public DTCS As New DataTable
    Public LOKASI As String

    Private Sub FORMCUSTOMER_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
    End Sub
    Private Sub FORMCUSTOMER_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
    End Sub
    Sub KOSONG()
        TXTKODECS.Text = ""
        TXTNAMACS.Text = ""
        TXTALAMATCS.Text = ""
        TXTTELPONCS.Text = ""
        TXTKODECS.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM CUSTOMER"
        DACS = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTCS.Clear()
        DACS.Fill(DTCS)
        DGVCS.DataSource = DTCS
    End Sub

    Private Sub TXTKODECS_Leave(sender As Object, e As EventArgs) Handles TXTKODECS.Leave
        SQLSTR = "SELECT * FROM CUSTOMER WHERE KODECS = '" & TXTKODECS.Text & "'"
        DACS = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTCS.Clear()
        DACS.Fill(DTCS)
        DGVCS.DataSource = DTCS
        If DTCS.Rows.Count > 0 Then
            TXTNAMACS.Text = DGVCS.Rows.Item(DGVCS.CurrentRow.Index).Cells(1).Value
            TXTALAMATCS.Text = DGVCS.Rows.Item(DGVCS.CurrentRow.Index).Cells(2).Value
            TXTTELPONCS.Text = DGVCS.Rows.Item(DGVCS.CurrentRow.Index).Cells(3).Value
        End If
        DGV()
    End Sub

    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "SELECT * FROM CUSTOMER WHERE KODECS = '" & TXTKODECS.Text & "'"
        DACS = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTCS.Clear()
        DACS.Fill(DTCS)
        DGVCS.DataSource = DTCS
        If DTCS.Rows.Count > 0 Then
            SQLSTR = "UPDATE INTO CUSTOMER VALUES ('" & TXTKODECS.Text &
                "', NAMACS ='" & TXTNAMACS.Text & "', ALAMATCS ='" &
                TXTALAMATCS.Text & "', TELPONCS ='" & TXTTELPONCS.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO CUSTOMER VALUES ('" & TXTKODECS.Text & "','" &
                TXTNAMACS.Text & "','" & TXTALAMATCS.Text &
                "','" & TXTTELPONCS.Text & "')"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub

    Private Sub BTHAPUS_Click(sender As Object, e As EventArgs) Handles BTHAPUS.Click
        Dim XKODECS As String
        Dim X As String
        XKODECS = TXTKODECS.Text
        X = MsgBox("DATA CUSTOMER JADI DIHAPUS !", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM CUSTOMER WHERE KODECS = '" & XKODECS & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub
    Private Sub BTBLANKFORM_Click(sender As Object, e As EventArgs) Handles BTBLANKFORM.Click
        KOSONG()
    End Sub

    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        KONEKSI.Close()
        Close()
    End Sub

    Private Sub TXTTELPONCS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELPONCS.KeyPress
        ' Memeriksa apakah karakter yang diinput adalah angka atau bukan
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            ' Mencegah karakter non-angka ditampilkan pada TextBox
            e.Handled = True
            ' Menampilkan pesan error
            MsgBox("DATA NOMOR TELPON HANYA BISA DIISI ANGKA")
        End If
    End Sub
End Class