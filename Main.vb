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
        ' Dim frm_About As New test()
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
        openReport()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        openReport()
    End Sub

    Private Sub openReport()
        Dim frm_Report As New frmReports()

        'Set parent for this form
        frm_Report.MdiParent = Me
        frm_Report.Show()
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changeBG()
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        Dim cd As New ColorDialog()

        If cd.ShowDialog() = DialogResult.OK Then
            Me.BackColor = cd.Color
            changeBG()
        End If
    End Sub

    Private Sub changeBG()
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

        ' Display a child form to show this is still an MDI application.
    End Sub

    Private Sub changeBGImage()
        Dim bgImage As New OpenFileDialog
        bgImage.Filter = "JPEG|*.jpg|Bitmap|*.bmp"

        bgImage.Title = "Select Image file"

        If bgImage.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Try
            Dim bmp As New Bitmap(bgImage.FileName)
            If Not IsNothing(Me.BackgroundImage) Then Me.BackgroundImage.Dispose()
            Me.BackgroundImage = bmp
        Catch ex As Exception
            MsgBox("Not valid image file", vbCritical, "Image Error")
        End Try

    End Sub

    Private Sub BackgroundImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundImageToolStripMenuItem.Click
        changeBGImage()
    End Sub
End Class
