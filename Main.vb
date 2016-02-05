Public Class frm_Main


    Private Sub IngresosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem1.Click
        Dim frm_Ingreso As New frm_Ingreso()

        'Set the parent fo this form
        frm_Ingreso.MdiParent = Me

        frm_Ingreso.Show()
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
        Dim frm_Egreso As New frm_Egresos(IngMain)

        'Set the parent to this form
        frm_Egreso.MdiParent = Me
        frm_Egreso.Show()
    End Sub

    Private Sub TiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiendaToolStripMenuItem.Click
        Dim frm_Empresa As New frm_Empresa()

        'Set parent for this form
        frm_Empresa.MdiParent = Me
        frm_Empresa.Show()

    End Sub

    Private Sub TipoDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm_Categoria As New frm_Categoria()

        'Set parent for this form
        frm_Categoria.MdiParent = Me
        frm_Categoria.Show()
    End Sub

    Private Sub TipoDeIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeIngresoToolStripMenuItem.Click
        Dim frm_IngrCateg As New frm_Categoria()

        'Set parent for this form
        frm_IngrCateg.MdiParent = Me
        frm_IngrCateg.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tslBEgresos_Click(sender As Object, e As EventArgs) Handles tslBEgresos.Click
        Dim frm_lstEgresos As New IngMain()

        'Set parent for this form
        frm_lstEgresos.MdiParent = Me
        frm_lstEgresos.Show()
    End Sub

    Private Sub tlsIngreso_Click(sender As Object, e As EventArgs) Handles tlsIngreso.Click
        'test data access
        Dim frm_Ingresos As New frm_Ingreso()

        frm_Ingresos.MdiParent = Me
        frm_Ingreso.Show()
    End Sub
End Class
