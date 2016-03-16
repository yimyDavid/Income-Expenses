
Public Class frm_Categoria
    Private dbAccess As New DBControl

    Private idAccount As String = -1
    Private selectedItemList As String


    Private Sub tlsNuevo_Click(sender As Object, e As EventArgs) Handles tlsNuevo.Click
        clearFields()
    End Sub

    Private Sub clearFields()
        txtAccount.Text = ""
        txtAccount.Focus()
    End Sub
    Private Sub addCategory()

        dbAccess.AddParam("@description", txtAccount.Text)
        dbAccess.AddParam("@type", cboType.SelectedValue)

        dbAccess.ExecQuery("INSERT INTO EACCNT (Description, typeID) " & _
                           "VALUES (@description, @type); ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        MsgBox("Saved Successfully")

    End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click
        
        If (checkRequiredFields() = False) Then Exit Sub
        ' Add New Record to Database Table
        addCategory()

        lstCategory.Items.Add(New ListViewItem(New String() {txtAccount.Text, cboType.Text, dbAccess.auto_increment_value}))

        clearFields()

        ' Else
        ' MsgBox("Fill the Required Fields before Saving!", MsgBoxStyle.Critical, "Empty Required Fields")
        ' End If

    End Sub

    Private Sub fillCboType()
        dbAccess.ExecQuery("SELECT * FROM ETYPE; ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        cboType.DataSource = dbAccess.DBDT

        cboType.DisplayMember = "Description"
        cboType.ValueMember = "typeID"

        'Enable to draw
        cboType.DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    Private Sub fillList()
        dbAccess.ExecQuery("SELECT EACCNT.AccountID, EACCNT.Description As AccDesc, ETYPE.Description As typeDesc " & _
                           "FROM EACCNT INNER JOIN ETYPE " & _
                           "ON EACCNT.TypeID = ETYPE.typeID; ")


        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        For Each R As DataRow In dbAccess.DBDT.Rows
            Dim new_row As New ListViewItem(R("AccDesc").ToString)
            new_row.SubItems.Add(R("typeDesc").ToString)
            new_row.SubItems.Add(R("AccountID").ToString)
            lstCategory.Items.Add(new_row)
        Next
    End Sub
    Private Function checkRequiredFields()
        Dim empty As Boolean
        If ((txtAccount.Text = "") Or
            (cboType.Text = "")) Then
            empty = False
            MsgBox("Some Fields are empty or" & vbCrLf & " the  Date/Number have incorrect format", MsgBoxStyle.Critical, "Empty/Format Required Fields")
            Return empty
        End If
        Return True
    End Function

    Private Sub frm_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillCboType()

        fillList()
    End Sub

    Private Sub cboType_DrawItem(ByVal sender As System.Object, _
                                 ByVal e As System.Windows.Forms.DrawItemEventArgs) _
                             Handles cboType.DrawItem
        'Draw de default background
        e.DrawBackground()

        'The Combobox is bound to a DataTable
        'so the items are DataRow objects
        Dim drv As DataRowView = CType(cboType.Items(e.Index), DataRowView)

        'Retrieve the value of each column
        Dim id As Integer = drv("typeID").ToString()
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
    Private Sub deleteRecord()
        dbAccess.AddParam("@accountId", idAccount)

        dbAccess.ExecQuery("DELETE FROM EACCNT WHERE AccountID = @accountId; ")
        ' This will make the following to execute if it fails to access the db.
        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim Answer As Integer
        If (idAccount >= 0) Then
            Answer = MsgBox("All Records Associated with this Account (" + idAccount + ") will also be Deleted" + vbCrLf + _
                            "Would you like to Continue?", MsgBoxStyle.YesNo + vbExclamation, "Delete Record")
        Else
            MsgBox("Select Record from the list first", MsgBoxStyle.Information, "Select Record")
        End If

        If (Answer = vbYes And idAccount >= 0) Then
            deleteRecord()
            lstCategory.Items.RemoveAt(selectedItemList)
            idAccount = -1
        End If


     

    End Sub

    Private Sub lstCategory_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstCategory.ItemSelectionChanged
        If e.IsSelected Then
            idAccount = lstCategory.FocusedItem.SubItems(2).Text
            selectedItemList = lstCategory.FocusedItem.Index

        End If
    End Sub
End Class