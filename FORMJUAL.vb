Imports System.Data
Imports System.Data.OleDb
Public Class FORMJUAL
    Public KONEKSISTRING As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public SQLSTR As String
    Public CMD As New OleDb.OleDbCommand
    Public DADETAILJUAL As New OleDb.OleDbDataAdapter
    Public DTDETAILJUAL As New DataTable
    Public DAQUERYJUAL As New OleDb.OleDbDataAdapter
    Public DTQUERYJUAL As New DataTable
    Public DS As New DataSet
    Public DR As OleDbDataReader
    Public XNOTA As String
    Public XKODECS As String
    Public XKODEBRG As String
    Public XNAMABRG As String
    Public XHRGJUAL As Integer
    Public XJUMLAH As Integer
    Public XTOTAL As Integer
    Public LOKASI As String

    Private Sub FORMJUAL_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()

        SQLSTR = "SELECT * FROM CUSTOMER ORDER BY NAMACS"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTKODECS.Items.Clear()
        While DR.Read
            TXTKODECS.Items.Add(DR("KODECS") & " " & DR("NAMACS"))
        End While
        DR.Close()

        SQLSTR = "SELECT * FROM BARANG ORDER BY NAMABRG"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTKODEBRG.Items.Clear()
        While DR.Read
            TXTKODEBRG.Items.Add(DR("KODEBRG") & " " & DR("NAMABRG"))
        End While
        DR.Close()
    End Sub
    Private Sub FORMJUAL_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
        DGVJL()
    End Sub
    Sub KOSONG()
        TXTNOTA.Text = ""
        TXTKODECS.Text = ""
        TXTNAMACS.Text = ""
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGJUAL.Text = 0
        TXTJUMLAH.Text = 0
        TXTTOTAL.Text = 0
        TXTTOTALJUAL.Text = 0
        SQLSTR = "DELETE FROM DETAILJUALSEMU"
        DADETAILJUAL = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTDETAILJUAL.Clear()
        DADETAILJUAL.Fill(DTDETAILJUAL)
        DGVDETAILJUAL.DataSource = DTDETAILJUAL
        TXTNOTA.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILJUALSEMU"
        DADETAILJUAL = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTDETAILJUAL.Clear()
        DADETAILJUAL.Fill(DTDETAILJUAL)
        DGVDETAILJUAL.DataSource = DTDETAILJUAL
    End Sub
    Sub DGVJL()
        SQLSTR = "SELECT * FROM QUERYJUAL"
        DAQUERYJUAL = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTQUERYJUAL.Clear()
        DAQUERYJUAL.Fill(DTQUERYJUAL)
        DGVJUAL.DataSource = DTQUERYJUAL
    End Sub

    Private Sub TXTKODECS_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKODECS.SelectedValueChanged
        XKODECS = Microsoft.VisualBasic.Left(TXTKODECS.Text, 5)
        SQLSTR = "SELECT KODECS,NAMACS FROM CUSTOMER WHERE KODECS ='" & XKODECS & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMACS.Text = DR("NAMACS")
        End While
        DR.Close()
        TXTKODEBRG.Focus()
    End Sub

    Private Sub TXTKODEBRG_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKODEBRG.SelectedValueChanged
        XKODEBRG = Microsoft.VisualBasic.Left(TXTKODEBRG.Text, 6)
        SQLSTR = "SELECT NAMABRG,HRGJUAL FROM BARANG WHERE KODEBRG = '" & XKODEBRG & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMABRG.Text = DR("NAMABRG")
            TXTHRGJUAL.Text = Format(DR("HRGJUAL"), "#,#")
            XNAMABRG = DR("NAMABRG")
            XHRGJUAL = DR("HRGJUAL")
        End While
        DR.Close()
        TXTJUMLAH.Focus()
    End Sub

    Private Sub TXTJUMLAH_TextChanged(sender As Object, e As EventArgs) Handles TXTJUMLAH.TextChanged
        If TXTJUMLAH.Text = "" Then TXTJUMLAH.Text = 0
        XTOTAL = XHRGJUAL * TXTJUMLAH.Text
        TXTTOTAL.Text = Format(XTOTAL, "#,#")
    End Sub

    Private Sub BTTAMBAH_Click(sender As Object, e As EventArgs) Handles BTTAMBAH.Click
        XJUMLAH = TXTJUMLAH.Text
        SQLSTR = "INSERT INTO DETAILJUALSEMU VALUES ('" & XKODEBRG &
            "','" & XNAMABRG & "'," & XHRGJUAL & "," & XJUMLAH &
            "," & XTOTAL & ")"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        DGV()
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGJUAL.Text = 0
        TXTJUMLAH.Text = 0
        TXTTOTAL.Text = 0
        TXTKODEBRG.Focus()
    End Sub

    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "INSERT INTO JUAL VALUES ('" & TXTNOTA.Text &
            "','" & Format(TXTTANGGAL.Value, "yyyy-MM-dd") &
            "','" & XKODECS & "')"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "INSERT INTO DETAILJUAL (KODEBRG, HRGJUAL, JUMLAH)" &
            "SELECT DETAILJUALSEMU.KODEBRG, DETAILJUALSEMU.HRGJUAL," &
            "DETAILJUALSEMU.JUMLAH FROM DETAILJUALSEMU"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE DETAILJUAL SET NOTA = '" & TXTNOTA.Text &
            "' WHERE DETAILJUAL.NOTA Is Null"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        KOSONG()
        DGVJL()
    End Sub
    Private Sub BTBLANKFORM_Click(sender As Object, e As EventArgs) Handles BTBLANKFORM.Click
        KOSONG()
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        KONEKSI.Close()
        Close()
    End Sub

    Private Sub DGVDETAILJUAL_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DGVDETAILJUAL.CellStateChanged
        SQLSTR = "SELECT SUM(TOTAL) AS TotalPenjualan FROM DETAILJUALSEMU"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            Dim totalHRG As Integer = DR("TotalPenjualan")
            TXTTOTALJUAL.Text = Format(totalHRG, "#,#")
        End While
        DR.Close()
    End Sub
End Class