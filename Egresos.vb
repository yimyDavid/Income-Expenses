Imports System.Data.OleDb

Public Class frm_Egresos
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Private _ingMain As IngMain
    Private _frm_Main As frm_Main

    Dim auto_increment As Integer
    Dim updateId As Integer
    Dim expDate As String
    Dim entityId As Integer
    Dim accountId As Integer
    Dim amount As Double
    Dim comments As String

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
      


        'Dim cmd_account As New OleDbCommand("SELECT * FROM EACCNT", cnnOLEDB)
        ' Dim dr_account As OleDbDataReader = cmd_account.ExecuteReader
        ' Dim dtTable As DataTable = New DataTable()
        'dtTable.Columns.Add("ID", GetType(Integer))
        'dtTable.Columns.Add("Description", GetType(String))

        ' While dr_account.Read
        'Dim new_item As New ListViewItem(dr_account.Item("Description").ToString)
        'checks the type of account. Since the EACCNT table only stores the number id of account I wanted
        'show the listview with the actual description "EXPENSE" or "INCOME"
        ' If (dr_account.Item("typeID").ToString = "1") Then
        ' new_item.SubItems.Add("INCOME")
        'Else
        ' new_item.SubItems.Add("EXPENSE")
        'End If
        'new_item.SubItems.Add(dr_account.Item("typeID").ToString)
        'lstCategory.Items.Add(new_item)
        ' End While

        ' dr_account.Close()
        'cnnOLEDB.Close()


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

    Private Sub frm_Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM ECOMP", cnnOLEDB)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim dtTable As DataTable = New DataTable()
        dtTable.Columns.Add("CompanyID", GetType(Integer))
        dtTable.Columns.Add("Description", GetType(String))

        While dr.Read
            dtTable.Rows.Add(dr(0), dr(1))
            'cboType.Items.Add(dr(0).ToString)
            'cboType.Items.Add(dr(1).ToString)
        End While

        cboEntity.DataSource = dtTable
        cboEntity.DisplayMember = "Description"
        cboEntity.ValueMember = "CompanyID"

        'Enable to draw
        cboEntity.DrawMode = DrawMode.OwnerDrawFixed

        'Fill cboAccount combobox
        Dim cmd_account As New OleDbCommand("SELECT * FROM EACCNT", cnnOLEDB)
        Dim dr_account As OleDbDataReader = cmd_account.ExecuteReader
        Dim dtTable_account As DataTable = New DataTable()
        dtTable_account.Columns.Add("AccountID", GetType(Integer))
        dtTable_account.Columns.Add("Description", GetType(String))

        While dr_account.Read
            dtTable_account.Rows.Add(dr_account(0), dr_account(1))
        End While

        cboAccount.DataSource = dtTable_account
        cboAccount.DisplayMember = "Description"
        cboAccount.ValueMember = "AccountID"

        'Enable to draw
        cboAccount.DrawMode = DrawMode.OwnerDrawFixed

        dr.Close()
        cnnOLEDB.Close()
    End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click
        Dim InsertQuery As String

        ' Dim auto_increment As Integer
        'Dim expDate As String
        ' Dim entityId As Integer
        ' Dim accountId As Integer
        ' Dim amount As Double
        ' Dim comments As String


        'If there are empty required fields don't to anything
        If (checkRequiredFields() = True) Then
            cnnOLEDB.Open()
            'Variables to insert to database 
            'Most examples have the following statement
            'cmd.Parameters.AddWithValue("@id", 1) but it didn't work for me sofar I decided to do 
            'the following
            getDataFromForm()

            InsertQuery = "INSERT INTO [EEXPEN] ([AccountID],[CompanyID],[ExpDate],[Amount],[Comments]) " _
            + " VALUES (" & accountId & "," & entityId & "," & "'" & expDate & "'" & "," & amount & "," & "'" & comments & "'" & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)


            cmdOLEDB = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmdOLEDB.ExecuteNonQuery()

            cmd.CommandText = "SELECT @@identity"
            auto_increment = cmd.ExecuteScalar()
            cnnOLEDB.Close()

            'update parent form
            Dim new_item As New ListViewItem(auto_increment.ToString)
            new_item.SubItems.Add(dtpDate.Text)
            new_item.SubItems.Add(cboAccount.Text)
            new_item.SubItems.Add(mtxtAmount.Text)
            new_item.SubItems.Add(cboEntity.Text)

            _ingMain.updateList(new_item)

            'Dim accountType As String
            ' If (accountTypeId = 1) Then
            ' accountType = "INCOME"
            'Else
            ' accountType = "EXPENSE"
            'End If
            'lstCategory.Items.Add(New ListViewItem(New String() {accountName, accountType}))

            MsgBox("Transaction Saved!", MsgBoxStyle.Information, "Saved")

            clearFields()
            mtxtDate.Focus()

        Else
            MsgBox("Some Fields are empty or" & vbCrLf & " the  Date/Number have incorrect format", MsgBoxStyle.Critical, "Empty/Format Required Fields")
        End If

    End Sub

    Private Function checkRequiredFields()
        Dim empty As Boolean
        If (mtxtDate.Text = "") Or
            (cboEntity.Text = "") Or
            (cboAccount.Text = "") Or
            (mtxtAmount.Text = "") Then
            empty = False
            'Return empty
        End If
        empty = IsDate(mtxtDate.Text)
        empty = IsNumeric(mtxtAmount.Text)
        Return empty
    End Function

    Private Sub clearFields()
        mtxtDate.Clear()
        cboEntity.Text = ""
        cboAccount.Text = ""
        mtxtAmount.Clear()
        txtComments.Text = ""
    End Sub

    Public Sub fillFieldsToUpdate()
        Dim fillId As String
        fillId = _ingMain.getId()
        'MsgBox("BEFORE QUERY " & updateId)
        Dim dateFormat As String = "MM/dd/yyyy"

        lblUpdateWarning.Visible = True
        lblUpdateId.Text = fillId.ToString
        lblUpdateId.Visible = True

        ' SELECT EEXPEN.ExpenseID, EEXPEN.ExpDate, EEXPEN.Amount
        'FROM EEXPEN
        'WHERE (([EEXPEN].[ExpenseID]=1));

        Try
            cnnOLEDB.Open()

            cmdOLEDB = New OleDbCommand("SELECT * FROM EEXPEN WHERE ExpenseID = " & fillId, cnnOLEDB)
            'cmd.ExecuteNonQuery()
            Dim dr As OleDbDataReader = cmdOLEDB.ExecuteReader

            While dr.Read
                'mtxtDate.Text = CDate(dr.Item("ExpDate")).ToString(dateFormat)
                dtpDate.Text = CDate(dr.Item("ExpDate")).ToString(dateFormat)
                cboEntity.SelectedValue = dr.Item("CompanyID").ToString()
                cboAccount.SelectedValue = dr.Item("AccountID").ToString()
                mtxtAmount.Text = FormatNumber(dr.Item("Amount"), 2)
                txtComments.Text = dr.Item("Comments").ToString()
                'mtxtDate.Text = FormatDateTime(txtDate, DateFormat.ShortDate)
                'mtxtAmount.Text = 
                'MsgBox(mtxtDate.Text)
                'Dim new_item As New ListViewItem(dr.Item("CompanyID").ToString)
                'new_item.SubItems.Add(dr.Item("Description").ToString)
            End While

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error Retrieving Record" & ex.Message, "Retrieve Record")
        Finally

            cnnOLEDB.Close()

        End Try
    End Sub

    Private Sub tls_btnUpdate_Click(sender As Object, e As EventArgs) Handles tls_btnUpdate.Click

        'Dim updateListViewData As ListViewItem
        Try
            getDataFromForm()
            cnnOLEDB.Open()

            cmdOLEDB = New OleDbCommand("UPDATE EEXPEN SET AccountID = " & accountId & ", CompanyID = " & entityId & ", ExpDate = " & "'" & expDate & "'" & ", Amount = " & amount & " WHERE ExpenseID=" & updateId, cnnOLEDB)
            cmdOLEDB.ExecuteNonQuery()

            'update parent form
            Dim updateItem As New ListViewItem(updateId.ToString)
            updateItem.SubItems.Add(dtpDate.Text)
            updateItem.SubItems.Add(cboAccount.Text)
            updateItem.SubItems.Add(mtxtAmount.Text)
            updateItem.SubItems.Add(cboEntity.Text)

            _ingMain.updateList(updateItem)
        Catch ex As Exception
            MessageBox.Show("Error Updating Record" & ex.Message, "Update Record")
        Finally
            cnnOLEDB.Close()
        End Try
    End Sub

    Public Sub getDataFromForm()
        updateId = Convert.ToInt32(lblUpdateId.Text)
        expDate = dtpDate.Value.ToString("MM/dd/yyyy")
        ' CDate(dr.Item("ExpDate")).ToString(DateFormat)
        'expDate = mtxtDate.Text
        entityId = Convert.ToInt32(cboEntity.SelectedValue.ToString)
        accountId = Convert.ToInt32(cboAccount.SelectedValue.ToString)
        amount = Convert.ToDouble(mtxtAmount.Text.ToString)
        comments = txtComments.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(dtpDate.Value)
    End Sub
End Class