Imports System.Data
Imports System.Data.OleDb

Public Class FORMBELI
    Public KONEKSISTRING As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public SQLSTR As String
    Public CMD As New OleDb.OleDbCommand
    Public DADETAILBELI As New OleDb.OleDbDataAdapter
    Public DTDETAILBELI As New DataTable
    Public DAQUERYBELI As New OleDb.OleDbDataAdapter
    Public DTQUERYBELI As New DataTable
    Public DS As New DataSet
    Public DR As OleDbDataReader
    Public XFAKTUR As String
    Public XKODESP As String
    Public XKODEBRG As String
    Public XNAMABRG As String
    Public XHRGBELI As Integer
    Public XJUMLAH As Integer
    Public XTOTAL As Integer
    Public LOKASI As String

    Private Sub FORMBELI_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
        DGVBL()
    End Sub
    Private Sub FORMBELI_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()

        SQLSTR = "SELECT * FROM SUPLIER ORDER BY NAMASP"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTKODESP.Items.Clear()
        While DR.Read
            TXTKODESP.Items.Add(DR("KODESP") & " " & DR("NAMASP"))
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
    Sub KOSONG()
        TXTFAKTUR.Text = ""
        TXTKODESP.Text = ""
        TXTNAMASP.Text = ""
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGBELI.Text = ""
        TXTJUMLAH.Text = ""
        TXTTOTAL.Text = ""
        SQLSTR = "DELETE FROM DETAILBELISEMU"
        DADETAILBELI = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTDETAILBELI.Clear()
        DADETAILBELI.Fill(DTDETAILBELI)
        DGVDETAILBELI.DataSource = DTDETAILBELI
        TXTFAKTUR.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        DADETAILBELI = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTDETAILBELI.Clear()
        DADETAILBELI.Fill(DTDETAILBELI)
        DGVDETAILBELI.DataSource = DTDETAILBELI
    End Sub
    Sub DGVBL()
        SQLSTR = "SELECT * FROM QUERYBELI"
        DAQUERYBELI = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTQUERYBELI.Clear()
        DAQUERYBELI.Fill(DTQUERYBELI)
        DGVBELI.DataSource = DTQUERYBELI
    End Sub
    Private Sub TXTKODESP_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKODESP.SelectedValueChanged
        XKODESP = Microsoft.VisualBasic.Left(TXTKODESP.Text, 5)
        SQLSTR = "SELECT KODESP,NAMASP FROM SUPLIER WHERE KODESP='" & XKODESP & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMASP.Text = DR("NAMASP")
        End While
        DR.Close()
        TXTKODEBRG.Focus()
    End Sub



    Private Sub TXTJUMLAH_TextChanged(sender As Object, e As EventArgs) Handles TXTJUMLAH.TextChanged
        If TXTJUMLAH.Text = "" Then TXTJUMLAH.Text = 0
        XTOTAL = XHRGBELI * TXTJUMLAH.Text
        TXTTOTAL.Text = Format(XTOTAL, "#,#")
    End Sub

    Private Sub BTTAMBAH_Click(sender As Object, e As EventArgs) Handles BTTAMBAH.Click
        XJUMLAH = TXTJUMLAH.Text
        SQLSTR = "INSERT INTO DETAILBELISEMU VALUES ('" & XKODEBRG &
            "','" & XNAMABRG & "'," & XHRGBELI & "," & XJUMLAH &
            "," & XTOTAL & ")"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()
        DGV()
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGBELI.Text = 0
        TXTJUMLAH.Text = 0
        TXTTOTAL.Text = 0
        TXTKODEBRG.Focus()
    End Sub

    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "INSERT INTO BELI VALUES ('" & TXTFAKTUR.Text &
            "','" & Format(TXTTANGGAL.Value, "yyyy-MM-dd") &
            "','" & XKODESP & "')"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "INSERT INTO DETAILBELI (KODEBRG, HRGBELI, JUMLAH)" &
            "SELECT DETAILBELISEMU.KODEBRG, DETAILBELISEMU.HRGBELI," &
            "DETAILBELISEMU.JUMLAH FROM DETAILBELISEMU"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE DETAILBELI SET FAKTUR = '" & TXTFAKTUR.Text &
            "' WHERE DETAILBELI.FAKTUR Is Null"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        KOSONG()
        DGVBL()
    End Sub

    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        KONEKSI.Close()
        Close()
    End Sub

    Private Sub BTHAPUS_Click(sender As Object, e As EventArgs) Handles BTHAPUS.Click
        Dim XKODEBRG As String
        Dim X As String
        XKODEBRG = TXTKODEBRG.Text
        X = MsgBox("DATA SUPLIER " & TXTNAMABRG.Text & " JADI DIHAPUS!", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM DETAILBELISEMU WHERE KODEBRG = '" & XKODEBRG & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub

    Private Sub BTBLANKFORM_Click(sender As Object, e As EventArgs) Handles BTBLANKFORM.Click
        KOSONG()
    End Sub

    Private Sub TXTKODEBRG_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKODEBRG.SelectedValueChanged
        XKODEBRG = Microsoft.VisualBasic.Left(TXTKODEBRG.Text, 6)
        SQLSTR = "SELECT NAMABRG,HRGBELI FROM BARANG WHERE KODEBRG = '" & XKODEBRG & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMABRG.Text = DR("NAMABRG")
            TXTHRGBELI.Text = Format(DR("HRGBELI"), "#,#")
            XNAMABRG = DR("NAMABRG")
            XHRGBELI = DR("HRGBELI")
        End While
        DR.Close()
        TXTJUMLAH.Focus()
    End Sub
End Class
