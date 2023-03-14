Imports System.Data
Imports System.Data.OleDb
Public Class FORMBARANG
    Public KONEKSISTRING As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public SQLSTR As String
    Public CMD As New OleDb.OleDbCommand
    Public DABRG As New OleDb.OleDbDataAdapter
    Public DTBRG As New DataTable
    Public LOKASI As String

    Private Sub FORMBARANG_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BLANKFORM()
        DGV()
    End Sub

    Private Sub FORMBARANG_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
    End Sub

    Sub BLANKFORM()
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGBELI.Text = 0
        TXTHRGJUAL.Text = 0
        TXTJMLAWAL.Text = 0
        TXTKODEBRG.Focus()
    End Sub

    Sub DGV()
        SQLSTR = "UPDATE BARANG SET JMLBELI = 0, JMLJUAL = 0, JMLSTOK = 0"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE BARANG INNER JOIN DETAILBELI ON BARANG.KODEBRG = DETAILBELI.KODEBRG SET JMLBELI = JMLBELI + JUMLAH"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE BARANG INNER JOIN DETAILJUAL ON BARANG.KODEBRG = DETAILJUAL.KODEBRG SET JMLJUAL = JMLJUAL + JUMLAH"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE BARANG SET JMLSTOK = JMLAWAL + JMLBELI - JMLJUAL"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "SELECT * FROM BARANG"
        DABRG = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTBRG.Clear()
        DABRG.Fill(DTBRG)
        DGVBARANG.DataSource = DTBRG
    End Sub

    Private Sub TXTKODEBRG_Leave(sender As Object, e As EventArgs) Handles TXTKODEBRG.Leave
        SQLSTR = "SELECT * FROM BARANG WHERE KODEBRG = '" & TXTKODEBRG.Text & "'"
        DABRG = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTBRG.Clear()
        DABRG.Fill(DTBRG)
        DGVBARANG.DataSource = DTBRG
        If DTBRG.Rows.Count > 0 Then
            TXTNAMABRG.Text = DGVBARANG.Rows.Item(DGVBARANG.CurrentRow.Index).Cells(1).Value
            TXTHRGBELI.Text = DGVBARANG.Rows.Item(DGVBARANG.CurrentRow.Index).Cells(2).Value
            TXTHRGJUAL.Text = DGVBARANG.Rows.Item(DGVBARANG.CurrentRow.Index).Cells(3).Value
            TXTJMLAWAL.Text = DGVBARANG.Rows.Item(DGVBARANG.CurrentRow.Index).Cells(4).Value
        End If
        DGV()
    End Sub

    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "SELECT * FROM BARANG WHERE KODEBRG = '" & TXTKODEBRG.Text & "'"
        DABRG = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTBRG.Clear()
        DABRG.Fill(DTBRG)
        DGVBARANG.DataSource = DTBRG
        If DTBRG.Rows.Count > 0 Then
            SQLSTR = "UPDATE BARANG SET KODEBRG = '" _
                & TXTKODEBRG.Text _
                & "', NAMABRG= '" _
                & TXTNAMABRG.Text _
                & "', HRGBELI = " _
                & TXTHRGBELI.Text _
                & ", HRGJUAL = " _
                & TXTHRGJUAL.Text _
                & ", JMLAWAL = " _
                & TXTJMLAWAL.Text _
                & " WHERE KODEBRG = '" _
                & TXTKODEBRG.Text _
                & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO BARANG VALUES ('" _
                & TXTKODEBRG.Text & "','" _
                & TXTNAMABRG.Text & "'," _
                & TXTHRGBELI.Text & "," _
                & TXTHRGJUAL.Text & "," _
                & TXTJMLAWAL.Text & ", 0, 0, 0)"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        BLANKFORM()
        DGV()
    End Sub

    Private Sub BTHAPUS_Click(sender As Object, e As EventArgs) Handles BTHAPUS.Click
        Dim X As String
        Dim XKODEBRG As String
        XKODEBRG = TXTKODEBRG.Text
        X = MsgBox("DATA BARANG " & TXTNAMABRG.Text & "JADI DIHAPUS!", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM BARANG WHERE KODEBRG = '" & XKODEBRG & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        BLANKFORM()
        DGV()
    End Sub

    Private Sub BTBLANKFORM_Click(sender As Object, e As EventArgs) Handles BTBLANKFORM.Click
        BLANKFORM()
    End Sub

    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        KONEKSI.Close()
        Close()
    End Sub
End Class
