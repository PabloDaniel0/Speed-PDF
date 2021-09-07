Public Class Form1
    Private Sub PantallaCompletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PantallaCompletaToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MinimizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Speed PDF 1.3 update estable, lector PDF 100% Gratuito y opensource publicado Bajo la licencia GNU creador Por PabloDaniel0")
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.src = OpenFileDialog1.FileName
    End Sub
End Class
