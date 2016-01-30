﻿Imports System.Data.OleDb

Public Class frm_Egresos
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    
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
End Class