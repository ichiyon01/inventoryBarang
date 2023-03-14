Imports System.Data
Imports System.Data.OleDb
Public Class FORMSUPLIER
    Public KONEKSISTRING As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public SQLSTR As String
    Public CMD As New OleDb.OleDbCommand
    Public DASP As New OleDb.OleDbDataAdapter
    Public DTSP As New DataTable
    Public LOKASI As String

    Private Sub FORMSUPLIER_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DGV()
        BLANKFORM()
    End Sub

    Private Sub FORMSUPLIER_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
    End Sub

    Sub BLANKFORM()
        TXTKODESP.Text = ""
        TXTNAMASP.Text = ""
        TXTALAMATSP.Text = ""
        TXTTELPONSP.Text = ""
        TXTKODESP.Focus()
    End Sub

    Sub DGV()
        SQLSTR = "SELECT * FROM SUPLIER"
        DASP = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTSP.Clear()
        DASP.Fill(DTSP)
        DGVSP.DataSource = DTSP
        DGVSP.Columns(0).Width = 75
        DGVSP.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGVSP.Columns(1).Width = 150
        DGVSP.Columns(2).Width = 150
        DGVSP.Columns(3).Width = 100
    End Sub



    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "SELECT * FROM SUPLIER WHERE KODESP = '" & TXTKODESP.Text & "'"
        DASP = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTSP.Clear()
        DASP.Fill(DTSP)
        DGVSP.DataSource = DTSP
        If DTSP.Rows.Count > 0 Then
            SQLSTR = "UPDATE SUPLIER SET KODESP = '" _
                & TXTKODESP.Text _
                & "', NAMASP= '" _
                & TXTNAMASP.Text _
                & "', ALAMATSP = '" _
                & TXTALAMATSP.Text _
                & "', TELPONSP = '" _
                & TXTTELPONSP.Text _
                & "' WHERE KODESP = '" _
                & TXTKODESP.Text _
                & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO SUPLIER VALUES ('" _
                & TXTKODESP.Text & "','" _
                & TXTNAMASP.Text & "','" _
                & TXTALAMATSP.Text & "','" _
                & TXTTELPONSP.Text & "')"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        BLANKFORM()
        DGV()
    End Sub
    Private Sub BTHAPUS_Click(sender As Object, e As EventArgs) Handles BTHAPUS.Click
        Dim XKODESP As String
        Dim X As String
        XKODESP = TXTKODESP.Text
        X = MsgBox("DATA SUPLIER " & TXTNAMASP.Text & "JADI DIHAPUS!", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM SUPLIER WHERE KODESP = '" & XKODESP & "'"
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

    Private Sub TXTKODESP_Leave(sender As Object, e As EventArgs) Handles TXTKODESP.Leave
        SQLSTR = "SELECT * FROM SUPLIER WHERE KODESP = '" & TXTKODESP.Text & "'"
        DASP = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTSP.Clear()
        DASP.Fill(DTSP)
        DGVSP.DataSource = DTSP
        If DTSP.Rows.Count > 0 Then
            TXTNAMASP.Text = DGVSP.Rows.Item(DGVSP.CurrentRow.Index).Cells(1).Value
            TXTALAMATSP.Text = DGVSP.Rows.Item(DGVSP.CurrentRow.Index).Cells(2).Value
            TXTTELPONSP.Text = DGVSP.Rows.Item(DGVSP.CurrentRow.Index).Cells(3).Value
        End If
        DGV()
    End Sub
End Class