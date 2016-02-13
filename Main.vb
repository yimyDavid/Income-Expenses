Public Class frm_Main


    Private Sub IngresosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem1.Click
         Dim frm_Expense As New frm_Egresos(Me)
        'set main form to be parent of frm_expense
        frm_Expense.MdiParent = Me
        frm_Expense.Show()

    End Sub

    Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
        Dim frm_lstEgresos As New IngMain()

        'Set parent for this form
        frm_lstEgresos.MdiParent = Me
        frm_lstEgresos.Show()
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

    Private Sub tlsRecords_Click(sender As Object, e As EventArgs) Handles tlsRecords.Click
        Dim frm_lstEgresos As New IngMain()

        'Set parent for this form
        frm_lstEgresos.MdiParent = Me
        frm_lstEgresos.Show()
    End Sub

    Private Sub tlsAccounts_Click(sender As Object, e As EventArgs) Handles tlsAccounts.Click
        Dim frm_IngrCateg As New frm_Categoria()

        'Set parent for this form
        frm_IngrCateg.MdiParent = Me
        frm_IngrCateg.Show()
    End Sub

    Private Sub tlsEntity_Click(sender As Object, e As EventArgs) Handles tlsEntity.Click
        Dim frm_Empresa As New frm_Empresa()

        'Set parent for this form
        frm_Empresa.MdiParent = Me
        frm_Empresa.Show()
    End Sub

    Private Sub tlsClose_Click(sender As Object, e As EventArgs) Handles tlsClose.Click
        Dim close As Integer
        close = MsgBox("Are you sure Closing the Program?", MsgBoxStyle.YesNo + vbQuestion, "About to Close")
        If (close = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub ProgramadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramadorToolStripMenuItem.Click
        Dim frm_About As New frmAbout()

        'Set parent for this form
        frm_About.MdiParent = Me
        frm_About.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim close As Integer
        close = MsgBox("Are you sure Closing the Program?", MsgBoxStyle.YesNo + vbQuestion, "About to Close")
        If (close = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub ByDateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm_Report As New frmReports()

        'Set parent for this form
        frm_Report.MdiParent = Me
        frm_Report.Show()

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim frm_Report As New frmReports()

        'Set parent for this form
        frm_Report.MdiParent = Me
        frm_Report.Show()
    End Sub

End Class
