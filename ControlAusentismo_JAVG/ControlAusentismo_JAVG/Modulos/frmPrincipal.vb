Public Class frmPrincipal

    Private Sub RegistrarAsistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAsistenciasToolStripMenuItem.Click
        frmCaptura.Show()
    End Sub

    Private Sub AdministrarAusentismosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarAusentismosToolStripMenuItem.Click
        frmControlAusentismos.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub CapturaEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaEquiposToolStripMenuItem.Click

    End Sub

    Private Sub CapturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaToolStripMenuItem.Click
        Catalogo.Show()
    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click
        Administracion.Show()
    End Sub
End Class