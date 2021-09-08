Public Class Form1

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.src = OpenFileDialog1.FileName
    End Sub

    Private Sub AcercaDeSpeedPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeSpeedPDFToolStripMenuItem.Click
        MsgBox("Visor PDF Creado Por Pablo Daniel Facundo Ramos, con apoyo de Adobe PDF Reader, proyecto 100% original Gracias Por Descargar")
    End Sub

    Private Sub CerrarSpeedPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSpeedPDFToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
