
Public Class frm_Egresos
    Private dbAccess As New DBControl

    Private _ingMain As IngMain
    Private _frm_Main As frm_Main

    Dim updateId As Integer
  
    Sub New(ByVal mainEgr As IngMain)
        InitializeComponent()
        _ingMain = mainEgr

    End Sub

    Sub New(frm_Main As frm_Main)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _frm_Main = frm_Main
    End Sub
    Private Sub tlsNuevo_Click(sender As Object, e As EventArgs) Handles tlsNuevo.Click
        clearFields()
    End Sub
    Private Sub cboEntity_DrawItem(ByVal sender As System.Object, _
                                 ByVal e As System.Windows.Forms.DrawItemEventArgs) _
                             Handles cboEntity.DrawItem
        'Draw de default background
        e.DrawBackground()

        'The Combobox is bound to a DataTable
        'so the items are DataRow objects
        Dim drv As DataRowView = CType(cboEntity.Items(e.Index), DataRowView)

        'Retrieve the value of each column
        Dim id As Integer = drv("CompanyID").ToString()
        Dim name As String = drv("Description").ToString()

        'Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 4 'small of id column

        'Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        'Draw a line to isolate the columns
        Using P As New Pen(Color.Black)
            e.Graphics.DrawLine(P, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        'Get the bound for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        'Draw the text on the second column 
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
    End Sub

    Private Sub cboAccount_DrawItem(ByVal sender As System.Object, _
                                ByVal e As System.Windows.Forms.DrawItemEventArgs) _
                            Handles cboAccount.DrawItem
        'Draw de default background
        e.DrawBackground()

        'The Combobox is bound to a DataTable
        'so the items are DataRow objects
        Dim drv As DataRowView = CType(cboAccount.Items(e.Index), DataRowView)

        'Retrieve the value of each column
        Dim id As Integer = drv("AccountID").ToString()
        Dim name As String = drv("Description").ToString()

        'Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 4 'small of id column

        'Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        'Draw a line to isolate the columns
        Using P As New Pen(Color.Black)
            e.Graphics.DrawLine(P, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        'Get the bound for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        'Draw the text on the second column 
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
    End Sub
    Private Sub fillCboEntity()
        dbAccess.ExecQuery("SELECT * FROM ECOMP; ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        cboEntity.DataSource = dbAccess.DBDT

        cboEntity.DisplayMember = "Description"
        cboEntity.ValueMember = "CompanyID"

        'Enable to draw
        cboEntity.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Private Sub fillCboAccount()
        dbAccess.ExecQuery("SELECT * FROM EACCNT; ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        cboAccount.DataSource = dbAccess.DBDT

        cboAccount.DisplayMember = "Description"
        cboAccount.ValueMember = "AccountID"

        'Enable to draw
        cboAccount.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Private Sub frm_Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillCboAccount()
        fillCboEntity()

    End Sub

    Private Sub addTransaction()
        dbAccess.AddParam("@accountId", cboAccount.SelectedValue)
        dbAccess.AddParam("@companyId", cboEntity.SelectedValue)
        dbAccess.AddParam("@expDate", dtpDate.Text)
        dbAccess.AddParam("@amout", mtxtAmount.Text)
        dbAccess.AddParam("@comments", txtComments.Text)

        dbAccess.ExecQuery("INSERT INTO EEXPEN (AccountID, CompanyID, ExpDate, Amount, Comments) " & _
                           "VALUES (@accountId, @companyId, @expDate,@amount, @comments); ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub
    End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click
      
        If (checkRequiredFields() = False) Then Exit Sub

        addTransaction()

        ' getDataFromForm()

        Dim new_item As New ListViewItem(dbAccess.auto_increment_value)
        new_item.SubItems.Add(dtpDate.Text)
        new_item.SubItems.Add(cboAccount.Text)
        new_item.SubItems.Add(mtxtAmount.Text)
        new_item.SubItems.Add(cboEntity.Text)

        _ingMain.updateList(new_item)

        clearFields()
    End Sub

    Private Function checkRequiredFields()
        Dim empty As Boolean
        empty = True
        If (cboEntity.Text = "") Or
            (cboAccount.Text = "") Or
            (mtxtAmount.Text = "" Or IsNumeric(mtxtAmount.Text) = False) Then
            empty = False
            MsgBox("Some Fields are empty or" & vbCrLf & " the  Date/Number have incorrect format", MsgBoxStyle.Critical, "Empty/Format Required Fields")
            'Return empty
        End If
        Return empty
    End Function

    Private Sub clearFields()
        dtpDate.Text = ""
        cboEntity.Text = ""
        cboAccount.Text = ""
        mtxtAmount.Clear()
        txtComments.Text = ""
        dtpDate.Focus()
    End Sub

    Public Sub fillFieldsToUpdate()

        Dim fillId As String
        fillId = _ingMain.getId()

        dbAccess.AddParam("@fillId", fillId)

        dbAccess.ExecQuery("SELECT * FROM EEXPEN WHERE ExpenseID = @fillId; ")

        If dbAccess.DBDT.Rows.Count < 1 Then Exit Sub

        lblUpdateWarning.Visible = True
        lblUpdateId.Text = fillId.ToString
        lblUpdateId.Visible = True
      
        Dim r As DataRow = dbAccess.DBDT.Rows(0)

        dtpDate.Text = r("expDate").ToString
        cboEntity.SelectedValue = r("CompanyID").ToString
        cboAccount.SelectedValue = r("AccountID").ToString
        mtxtAmount.Text = r("Amount").ToString
        txtComments.Text = r("Comments").ToString

    End Sub

    Private Sub tls_btnUpdate_Click(sender As Object, e As EventArgs) Handles tls_btnUpdate.Click

          If (checkRequiredFields() = False) Then Exit Sub

        updateRecord()

    End Sub

    Private Sub updateRecord()

        updateId = _ingMain.getId()
        dbAccess.AddParam("@accountId", cboAccount.SelectedValue)
        dbAccess.AddParam("@companyId", cboEntity.SelectedValue)
        dbAccess.AddParam("@expDate", dtpDate.Text)
        dbAccess.AddParam("@amount", mtxtAmount.Text)
        dbAccess.AddParam("@comments", txtComments.Text)
        dbAccess.AddParam("@updateId", updateId)

        dbAccess.ExecQuery("UPDATE EEXPEN " & _
                           "SET AccountID = @accountId, CompanyID = @companyId, expDate = @expDate, Amount = @amount, Comments = @comments " & _
                           "WHERE ExpenseID = @updateId; ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        fillParentList()
    End Sub

    Private Sub fillParentList()
        ' update parent form
        Dim updateItem As New ListViewItem(updateId.ToString)
        updateItem.SubItems.Add(dtpDate.Text)
        updateItem.SubItems.Add(cboAccount.Text)
        updateItem.SubItems.Add(mtxtAmount.Text)
        updateItem.SubItems.Add(cboEntity.Text)

        _ingMain.updateList(updateItem)

    End Sub
End Class