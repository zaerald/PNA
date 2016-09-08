Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmPNA

    Dim conn As MySqlConnection

    Public selectedID As Integer

    ' btns
    Private Sub btnAddContact()
        Dim dlg As New dlgContact()
        dlg.Text = "Add Contact"
        dlg.btnOk.Text = "Add"
        dlg.state = DialogConstants.DLG_ADD
        dlg.ShowDialog()

        If dlg.DialogResult = DialogResult.OK Then
            MsgBox("Record Successfuly Added!")
            updateDGV()
        End If
    End Sub

    Private Sub btnEditContact()
        Dim dlg As New dlgContact()
        dlg.Text = "Edit Contact"
        dlg.btnOk.Text = "Update"
        dlg.state = DialogConstants.DLG_EDIT

        ' set values
        Dim index As Integer = dgv.CurrentRow.Index
        selectedID = dgv.Item(0, index).Value
        dlg.txtLast.Text = dgv.Item(1, index).Value
        dlg.txtFirst.Text = dgv.Item(2, index).Value
        dlg.txtPn.Text = dgv.Item(3, index).Value
        dlg.txtSt.Text = dgv.Item(4, index).Value
        dlg.txtCity.Text = dgv.Item(5, index).Value

        dlg.ShowDialog()

        If dlg.DialogResult = DialogResult.OK Then
            MsgBox("Record Successfuly Edited!")
            updateDGV()
        End If

    End Sub

    Private Sub btnDeleteContact()
        Dim cmd As New MySqlCommand
        Dim opt As String = MsgBox("Are you sure you want to delete contact?", vbYesNo + vbQuestion, "Delete")
        If opt = vbYes Then
            selectedID = dgv.Item(0, dgv.CurrentRow.Index).Value

            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM tblpa WHERE id=" & selectedID
            cmd.ExecuteNonQuery()

            updateDGV()
        End If
    End Sub

    Private Sub btnSearchContact()
        Dim dlg As New dlgSearchPNA()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        dlg.ShowDialog()
        If dlg.DialogResult = DialogResult.OK Then
            If dlg.commandText <> "" Then
                cmd.Connection = conn
                cmd.CommandText = dlg.commandText
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    Dim columns() As String = {"ID", "Last Name", "First Name", "Phone Number", "Street", "City"}
                    ToolZ.updateDataGridView(dgv, dr, columns)
                    dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    dr.Close()
                Else
                    MsgBox("No Results Found.")
                    dr.Close()
                    updateDGV()
                End If
            End If
        End If

    End Sub

    Private Sub updateDGV()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM tblpa"
        End With
        dr = cmd.ExecuteReader

        ' populate dgv
        Dim columns() As String = {"ID", "Last Name", "First Name", "Phone Number", "Street", "City"}
        ToolZ.updateDataGridView(dgv, dr, columns)
        dr.Close()

        dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader


    End Sub


    Private Sub frmPNA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' init connection
        conn = ToolZ.getConnection()
        updateDGV()
    End Sub

    Private Sub frmPNA_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim opt As String = MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Close")
        If opt = vbYes Then
            Me.Dispose()
            frmLogin.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgv_Sorted(sender As Object, e As EventArgs) Handles dgv.Sorted
        ' set colors 
        Dim rowColor As Color
        For i As Integer = 0 To dgv.RowCount - 1
            If i Mod 2 = 0 Then
                rowColor = Color.LightGray
            Else
                rowColor = Color.White
            End If
            dgv.Rows(i).DefaultCellStyle.BackColor = rowColor
        Next
    End Sub



    ' btns mouse events
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateDGV()
    End Sub

    Private Sub btnRefresh_MouseEnter(sender As Object, e As EventArgs) Handles btnRefresh.MouseEnter
        btnRefresh.Image = My.Resources.refreshrotated
    End Sub

    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        btnRefresh.Image = My.Resources.refresh
    End Sub

    Private Sub dgv_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv.MouseClick
        Dim index As Integer = dgv.CurrentRow.Index
        dgv.Rows(index).Selected = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAddContact()
    End Sub

    Private Sub btnAdd_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter
        btnAdd.Image = My.Resources.addcontacthover
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.Image = My.Resources.addcontact
    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        btnAddContact()
    End Sub

    Private Sub lblAdd_MouseEnter(sender As Object, e As EventArgs) Handles lblAdd.MouseEnter
        btnAdd.Image = My.Resources.addcontacthover
    End Sub

    Private Sub lblAdd_MouseLeave(sender As Object, e As EventArgs) Handles lblAdd.MouseLeave
        btnAdd.Image = My.Resources.addcontact
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEditContact()
    End Sub

    Private Sub btnEdit_MouseEnter(sender As Object, e As EventArgs) Handles btnEdit.MouseEnter
        btnEdit.Image = My.Resources.editcontacthover
    End Sub

    Private Sub btnEdit_MouseLeave(sender As Object, e As EventArgs) Handles btnEdit.MouseLeave
        btnEdit.Image = My.Resources.editcontact
    End Sub

    Private Sub lblEdit_Click(sender As Object, e As EventArgs) Handles lblEdit.Click
        btnEditContact()
    End Sub

    Private Sub lblEdit_MouseEnter(sender As Object, e As EventArgs) Handles lblEdit.MouseEnter
        btnEdit.Image = My.Resources.editcontacthover
    End Sub

    Private Sub lblEdit_MouseLeave(sender As Object, e As EventArgs) Handles lblEdit.MouseLeave
        btnEdit.Image = My.Resources.editcontact
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        btnDeleteContact()
    End Sub

    Private Sub btnDelete_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete.MouseEnter
        btnDelete.Image = My.Resources.deletecontacthover
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.Image = My.Resources.deletecontact
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        btnDeleteContact()
    End Sub

    Private Sub lblDelete_MouseEnter(sender As Object, e As EventArgs) Handles lblDelete.MouseEnter
        btnDelete.Image = My.Resources.deletecontacthover
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        btnDelete.Image = My.Resources.deletecontact
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnSearchContact()
    End Sub

    Private Sub btnSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter
        btnSearch.Image = My.Resources.searchcontacthover
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.Image = My.Resources.searchcontact
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        btnSearchContact()
    End Sub

    Private Sub lblSearch_MouseEnter(sender As Object, e As EventArgs) Handles lblSearch.MouseEnter
        btnSearch.Image = My.Resources.searchcontact
    End Sub

    Private Sub lblSearch_MouseLeave(sender As Object, e As EventArgs) Handles lblSearch.MouseLeave
        btnSearch.Image = My.Resources.searchcontacthover
    End Sub


End Class