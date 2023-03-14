Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Public Class MENUUTAMA
    Public SQLSTR As String
    Public KONEKSI As OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public KONEKSISTRING As String
    Public LOKASI As String
    Dim DR As OleDbDataReader
    Dim BARIS As Integer
    Dim FONTJUDUL As Font = New Font("CALIBRI", 14, FontStyle.Bold, GraphicsUnit.Point)
    Dim FONTDATA As Font = New Font("CALIBRI", 12, FontStyle.Regular, GraphicsUnit.Point)
    Dim KIRI As StringFormat = New StringFormat
    Dim TENGAH As StringFormat = New StringFormat
    Dim KANAN As StringFormat = New StringFormat
    Dim NOMOR As Integer
    Private Sub MENUUTAMA_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "PROVIDER = MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE = DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
    End Sub

    Private Sub PDBARANG_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDBARANG.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        e.Graphics.DrawString("LAPORAN DATA BARANG", FONTJUDUL, Brushes.Blue, 450, 25, TENGAH)
        e.Graphics.DrawLine(Pens.Black, 30, 70, 805, 70)
        e.Graphics.DrawString("NOMOR", FONTDATA, Brushes.Black, 100, 75, KANAN)
        e.Graphics.DrawString("KODEBRG", FONTDATA, Brushes.Black, 125, 75, KANAN)
        e.Graphics.DrawString("NAMA BARANG", FONTDATA, Brushes.Black, 200, 75, KIRI)
        e.Graphics.DrawString("HRG BELI", FONTDATA, Brushes.Black, 400, 75, KANAN)
        e.Graphics.DrawString("HRG JUAL", FONTDATA, Brushes.Black, 500, 75, KANAN)
        e.Graphics.DrawString("JML JUAL", FONTDATA, Brushes.Black, 575, 75, KANAN)
        e.Graphics.DrawString("JML BELI", FONTDATA, Brushes.Black, 650, 75, KANAN)
        e.Graphics.DrawString("JML JUAL", FONTDATA, Brushes.Black, 725, 75, KANAN)
        e.Graphics.DrawString("JML STOK", FONTDATA, Brushes.Black, 800, 75, KANAN)
        e.Graphics.DrawLine(Pens.Black, 30, 100, 805, 100)

        BARIS = 105
        NOMOR = 1
        SQLSTR = "SELECT * FROM BARANG"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            e.Graphics.DrawString(NOMOR, FONTDATA, Brushes.Black, 100, BARIS, KANAN)
            e.Graphics.DrawString(DR("KODEBRG"), FONTDATA, Brushes.Black, 125, BARIS, KIRI)
            e.Graphics.DrawString(DR("NAMABRG"), FONTDATA, Brushes.Black, 200, BARIS, KIRI)
            e.Graphics.DrawString(Format(DR("HRGBELI"), "#,#"), FONTDATA, Brushes.Black, 400, BARIS, KANAN)
            e.Graphics.DrawString(Format(DR("HRGJUAL"), "#,#"), FONTDATA, Brushes.Black, 500, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLAWAL"), FONTDATA, Brushes.Black, 575, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLBELI"), FONTDATA, Brushes.Black, 650, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLJUAL"), FONTDATA, Brushes.Black, 725, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLSTOK"), FONTDATA, Brushes.Black, 800, BARIS, KANAN)
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
        End While
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 5, 805, BARIS + 5)
        DR.Close()
    End Sub
    Private Sub CETAKBARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKBARANGToolStripMenuItem.Click
        PDBARANG.Print()
    End Sub

    Private Sub PDSUPLIER_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDSUPLIER.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        e.Graphics.DrawString("LAPORAN DATA SUPLIER", FONTJUDUL, Brushes.Blue, 450, 25, TENGAH)
        e.Graphics.DrawLine(Pens.Black, 30, 70, 805, 70)
        e.Graphics.DrawString("NOMOR", FONTDATA, Brushes.Black, 100, 75, KANAN)
        e.Graphics.DrawString("KODE", FONTDATA, Brushes.Black, 125, 75, KIRI)
        e.Graphics.DrawString("NAMA SUPLIER", FONTDATA, Brushes.Black, 200, 75, KIRI)
        e.Graphics.DrawString("ALAMAT", FONTDATA, Brushes.Black, 400, 75, KIRI)
        e.Graphics.DrawString("NO. TELPON", FONTDATA, Brushes.Black, 600, 75, KIRI)
        e.Graphics.DrawLine(Pens.Black, 30, 100, 805, 100)

        BARIS = 105
        NOMOR = 1
        SQLSTR = "SELECT * FROM SUPLIER"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            e.Graphics.DrawString(NOMOR, FONTDATA, Brushes.Black, 100, BARIS, KANAN)
            e.Graphics.DrawString(DR("KODESP"), FONTDATA, Brushes.Black, 125, BARIS, KIRI)
            e.Graphics.DrawString(DR("NAMASP"), FONTDATA, Brushes.Black, 200, BARIS, KIRI)
            e.Graphics.DrawString(DR("ALAMATSP"), FONTDATA, Brushes.Black, 400, BARIS, KIRI)
            e.Graphics.DrawString(DR("TELPONSP"), FONTDATA, Brushes.Black, 600, BARIS, KIRI)
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
        End While
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 5, 805, BARIS + 5)
        DR.Close()
    End Sub

    Private Sub CETAKSUPLIERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKSUPLIERToolStripMenuItem.Click
        PDSUPLIER.Print()
    End Sub

    Private Sub PDCUSTOMER_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDCUSTOMER.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        e.Graphics.DrawString("LAPORAN DATA CUSTOMER", FONTJUDUL, Brushes.Blue, 450, 25, TENGAH)
        e.Graphics.DrawLine(Pens.Black, 30, 70, 805, 70)
        e.Graphics.DrawString("NOMOR", FONTDATA, Brushes.Black, 100, 75, KANAN)
        e.Graphics.DrawString("KODE", FONTDATA, Brushes.Black, 125, 75, KIRI)
        e.Graphics.DrawString("NAMA CUSTOMER", FONTDATA, Brushes.Black, 200, 75, KIRI)
        e.Graphics.DrawString("ALAMAT", FONTDATA, Brushes.Black, 400, 75, KIRI)
        e.Graphics.DrawString("NO. TELPON", FONTDATA, Brushes.Black, 600, 75, KIRI)
        e.Graphics.DrawLine(Pens.Black, 30, 100, 805, 100)

        BARIS = 105
        NOMOR = 1
        SQLSTR = "SELECT * FROM CUSTOMER"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            e.Graphics.DrawString(NOMOR, FONTDATA, Brushes.Black, 100, BARIS, KANAN)
            e.Graphics.DrawString(DR("KODECS"), FONTDATA, Brushes.Black, 125, BARIS, KIRI)
            e.Graphics.DrawString(DR("NAMACS"), FONTDATA, Brushes.Black, 200, BARIS, KIRI)
            e.Graphics.DrawString(DR("ALAMATCS"), FONTDATA, Brushes.Black, 400, BARIS, KIRI)
            e.Graphics.DrawString(DR("TELPONCS"), FONTDATA, Brushes.Black, 600, BARIS, KIRI)
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
        End While
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 5, 805, BARIS + 5)
        DR.Close()
    End Sub

    Private Sub CETAKCUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKCUSTOMERToolStripMenuItem.Click
        PDCUSTOMER.Print()
    End Sub

    Private Sub DATABARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABARANGToolStripMenuItem.Click
        FORMBARANG.ShowDialog()
    End Sub

    Private Sub DATASUPLIERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATASUPLIERToolStripMenuItem.Click
        FORMSUPLIER.ShowDialog()
    End Sub

    Private Sub DATACUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATACUSTOMERToolStripMenuItem.Click
        FORMCUSTOMER.ShowDialog()
    End Sub

    Private Sub TRANSAKSIPEMBELIANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIPEMBELIANToolStripMenuItem.Click
        FORMBELI.ShowDialog()
    End Sub

    Private Sub TRANSAKSIPENJUALANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIPENJUALANToolStripMenuItem.Click
        FORMJUAL.ShowDialog()
    End Sub

    Private Sub KELUARDARIPROGRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARDARIPROGRAMToolStripMenuItem.Click
        Close()
    End Sub
End Class