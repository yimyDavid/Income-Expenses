Imports System.Data.OleDb
Public Class frm_Categoria

    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand

    Private Sub tlsNuevo_Click(sender As Object, e As EventArgs) Handles tlsNuevo.Click
        clearFields()
    End Sub

    Private Sub clearFields()
        txtAccount.Text = ""
        txtAccount.Focus()
    End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click
        Dim InsertQuery As String


        Dim accountName As String
        Dim accountTypeId As Integer
       

        'If there are empty required fields don't to anything
        If (checkRequiredFields() = True) Then
            cnnOLEDB.Open()
            'Variables to insert to database
            accountName = txtAccount.Text
            accountTypeId = Convert.ToInt32(cboType.SelectedValue.ToString)

            'Most examples have the following statement
            'cmd.Parameters.AddWithValue("@id", 1) but it didn't work for me sofar I decided to do 
            'the following

            InsertQuery = "INSERT INTO [EACCNT] ([Description],[typeID]) VALUES (" & "'" & accountName & "'" & "," & accountTypeId & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)


            cmdOLEDB = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmdOLEDB.ExecuteNonQuery()
            cnnOLEDB.Close()

            Dim accountType As String
            If (accountTypeId = 1) Then
                accountType = "INCOME"
            Else
                accountType = "EXPENSE"
            End If
            lstCategory.Items.Add(New ListViewItem(New String() {accountName, accountType}))

            MsgBox("Account Saved!", MsgBoxStyle.Information, "Saved")

            clearFields()
            txtAccount.Focus()

        Else
            MsgBox("Fill the Required Fields before Saving!", MsgBoxStyle.Critical, "Empty Required Fields")
        End If

    End Sub

    Private Function checkRequiredFields()
        Dim empty As Boolean
        If ((txtAccount.Text = "") Or
            (cboType.Text = "")) Then
            empty = False
            Return empty
        End If
        Return True
    End Function

    Private Sub frm_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM ETYPE", cnnOLEDB)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim dtTable As DataTable = New DataTable()
        dtTable.Columns.Add("ID", GetType(Integer))
        dtTable.Columns.Add("Name", GetType(String))

        While dr.Read
            dtTable.Rows.Add(dr(0), dr(1))
            'cboType.Items.Add(dr(0).ToString)
            'cboType.Items.Add(dr(1).ToString)
        End While

        cboType.DataSource = dtTable
        cboType.DisplayMember = "Name"
        cboType.ValueMember = "ID"

        'Enable to draw
        cboType.DrawMode = DrawMode.OwnerDrawFixed

        dr.Close()


        Dim cmd_account As New OleDbCommand("SELECT * FROM EACCNT", cnnOLEDB)
        Dim dr_account As OleDbDataReader = cmd_account.ExecuteReader
        ' Dim dtTable As DataTable = New DataTable()
        'dtTable.Columns.Add("ID", GetType(Integer))
        'dtTable.Columns.Add("Description", GetType(String))

        While dr_account.Read
            Dim new_item As New ListViewItem(dr_account.Item("Description").ToString)
            'checks the type of account. Since the EACCNT table only stores the number id of account I wanted
            'show the listview with the actual description "EXPENSE" or "INCOME"
            If (dr_account.Item("typeID").ToString = "1") Then
                new_item.SubItems.Add("INCOME")
            Else
                new_item.SubItems.Add("EXPENSE")
            End If
            'new_item.SubItems.Add(dr_account.Item("typeID").ToString)
            lstCategory.Items.Add(new_item)
        End While

        dr_account.Close()
        cnnOLEDB.Close()
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
        Dim id As Integer = drv("ID").ToString()
        Dim name As String = drv("Name").ToString()

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


End Class