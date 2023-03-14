Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Public Class FORMCETAKBELIPERFAKTUR
    Public KONEKSISTRING As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public SQLSTR As String
    Public LOKASI As String
    Public CMD As New OleDb.OleDbCommand
    Public DA As New OleDb.OleDbDataAdapter
    Public DT As New DataTable
    Dim DR As OleDbDataReader
    Dim BARIS As Integer
    Dim FONTJUDUL As Font = New Font("CALIBRI", 14, FontStyle.Bold, GraphicsUnit.Point)
    Dim FONTDATA As Font = New Font("CALIBRI", 12, FontStyle.Regular, GraphicsUnit.Point)
    Dim KIRI As StringFormat = New StringFormat
    Dim TENGAH As StringFormat = New StringFormat
    Dim KANAN As StringFormat = New StringFormat
    Dim NOMOR As Integer
    Dim TOTAL As Double


    Private Sub FORMCETAKBELIPERFAKTUR_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()

        SQLSTR = "SELECT * FROM BELI ORDER BY FAKTUR"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTFAKTUR.Items.Clear()
        While DR.Read
            TXTFAKTUR.Items.Add(DR("FAKTUR"))
        End While
        DR.Close()
        DGV()
    End Sub
    Sub KOSONG()
        TXTFAKTUR.Text = ""
        TXTKODESP.Text = ""
        TXTNAMASP.Text = ""
        TXTTANGGAL.Text = ""
        SQLSTR = "DELETE FROM DETAILBELISEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DGVBELI.DataSource = DT
        TXTFAKTUR.Focus()
    End Sub

    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DGVBELI.DataSource = DT
    End Sub

    Private Sub FORMCETAKBELIPERFAKTUR_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DGV()
    End Sub



    Private Sub PDBELI_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDBELI.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        e.Graphics.DrawString("LAPORAN PEMBELIAN PERFAKTUR", FONTJUDUL, Brushes.Blue, 300, 25, TENGAH)
        e.Graphics.DrawString("NO. FAKTUR : " & TXTFAKTUR.Text, FONTDATA, Brushes.Black, 30, 70, KIRI)
        e.Graphics.DrawString("TANGGAL : " & TXTTANGGAL.Text, FONTDATA, Brushes.Black, 30, 90, KIRI)
        e.Graphics.DrawString("KODE SUPLIER : " & TXTKODESP.Text, FONTDATA, Brushes.Black, 240, 70, KIRI)
        e.Graphics.DrawString("NAMA SUPLIER : " & TXTNAMASP.Text, FONTDATA, Brushes.Black, 240, 90, KIRI)
        e.Graphics.DrawLine(Pens.Black, 30, 110, 600, 110)
        e.Graphics.DrawString("NOMOR", FONTDATA, Brushes.Black, 100, 115, KANAN)
        e.Graphics.DrawString("KODEBRG", FONTDATA, Brushes.Black, 125, 115, KIRI)
        e.Graphics.DrawString("NAMA BARANG", FONTDATA, Brushes.Black, 200, 115, KIRI)
        e.Graphics.DrawString("HRG BELI", FONTDATA, Brushes.Black, 400, 115, KANAN)
        e.Graphics.DrawString("JUMLAH", FONTDATA, Brushes.Black, 500, 115, KANAN)
        e.Graphics.DrawString("TOTAL", FONTDATA, Brushes.Black, 575, 115, KANAN)
        e.Graphics.DrawLine(Pens.Black, 30, 140, 600, 140)

        BARIS = 145
        NOMOR = 1
        TOTAL = 0
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader

        While DR.Read
            e.Graphics.DrawString(NOMOR, FONTDATA, Brushes.Black, 100, BARIS, KANAN)
            e.Graphics.DrawString(DR("KODEBRG"), FONTDATA, Brushes.Black, 125, BARIS, KIRI)
            e.Graphics.DrawString(DR("NAMABRG"), FONTDATA, Brushes.Black, 200, BARIS, KIRI)
            e.Graphics.DrawString(Format(DR("HRGBELI"), "#,#"), FONTDATA, Brushes.Black, 400, BARIS, KIRI)
            e.Graphics.DrawString(DR("JUMLAH"), FONTDATA, Brushes.Black, 475, BARIS, KANAN)
            e.Graphics.DrawString(Format(DR("TOTAL"), "#,#"), FONTDATA, Brushes.Black, 575, BARIS, KANAN)
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
            TOTAL = TOTAL + DR("TOTAL")
        End While
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 5, 600, BARIS + 5)
        e.Graphics.DrawString("TOTAL : ", FONTDATA, Brushes.Black, 575, BARIS, KANAN)
        e.Graphics.DrawString(Format(TOTAL, "#,#"), FONTDATA, Brushes.Black, 575, BARIS + 10, KANAN)
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 30, 600, BARIS + 30)
        DR.Close()
    End Sub

    Private Sub BTPREVIEW_Click(sender As Object, e As EventArgs) Handles BTPREVIEW.Click
        PDBELI.Print()
    End Sub

    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        KONEKSI.Close()
        Close()
    End Sub

    Private Sub TXTFAKTUR_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTFAKTUR.SelectedValueChanged
        SQLSTR = "SELECT * FROM QUERYBELI WHERE FAKTUR = '" & TXTFAKTUR.Text & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTTANGGAL.Text = DR("TANGGAL")
            TXTKODESP.Text = DR("KODESP")
            TXTNAMASP.Text = DR("NAMASP")
        End While
        DR.Close()

        SQLSTR = "DELETE * FROM DETAILBELISEMU"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "INSERT INTO DETAILBELISEMU (KODEBRG, NAMABRG, HRGBELI, JUMLAH, TOTAL) SELECT " &
            "QUERYBELI.KODEBRG, QUERYBELI.NAMABRG, QUERYBELI.HRGBELI, QUERYBELI.JUMLAH, QUERYBELI.TOTAL" &
            " FROM QUERYBELI WHERE FAKTUR = '" & TXTFAKTUR.Text & "'"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        DGV()
        BTPREVIEW.Focus()
    End Sub

End Class