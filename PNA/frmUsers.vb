Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class frmUsers

    Dim conn As New MySqlConnection

    Public selectedID As Integer
    Private Sub btnAddUser()
        Dim dlg As New dlgUser()
        dlg.Text = "Add User"
        dlg.btnOk.Text = "Add"
        dlg.state = DialogConstants.DLG_ADD
        dlg.ShowDialog()

        If dlg.DialogResult = DialogResult.OK Then
            updateDGV()
        End If
    End Sub

    Private Sub btnEditUser()
        Dim dlg As New dlgUser()
        dlg.Text = "Edit User"
        dlg.btnOk.Text = "Update"
        dlg.state = DialogConstants.DLG_EDIT

        'set vars
        Dim index As Integer = dgvUsers.CurrentRow.Index
        selectedID = dgvUsers.Item(0, index).Value
        dlg.txtUser.Text = dgvUsers.Item(1, index).Value.ToString
        dlg.txtPassword.Text = dgvUsers.Item(2, index).Value.ToString

        dlg.ShowDialog()

        If dlg.DialogResult = DialogResult.OK Then
            updateDGV()
        End If
    End Sub

    Private Sub btnDeleteUser()
        Dim cmd As New MySqlCommand
        Dim opt As String = MsgBox("Are you sure you want to delete user " &
            dgvUsers.Item(1, dgvUsers.CurrentRow.Index).Value.ToString &
            "?", vbYesNo + vbQuestion, "Delete")
        If opt = vbYes Then
            selectedID = dgvUsers.Item(0, dgvUsers.CurrentRow.Index).Value
            cmd.Connection = conn
            cmd.CommandText = "DELETE FROM tbluser WHERE id=" & selectedID
            cmd.ExecuteNonQuery()

            updateDGV()
        End If
    End Sub

    Private Sub btnSearchUser()
        Dim dlg As New dlgSearch()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        dlg.ShowDialog()
        If dlg.DialogResult = DialogResult.OK Then
            If dlg.commandText <> "" Then
                cmd.Connection = conn
                cmd.CommandText = dlg.commandText
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    Dim columns() As String = {"ID", "User Name", "Password"}
                    ToolZ.updateDataGridView(dgvUsers, dr, columns)
                    dgvUsers.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
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
            .CommandText = "SELECT * FROM tbluser"
        End With
        dr = cmd.ExecuteReader

        ' populate dgv
        Dim columns() As String = {"ID", "Users", "Password"}
        ToolZ.updateDataGridView(dgvUsers, dr, columns)
        dr.Close()

        dgvUsers.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' init connection
        conn = ToolZ.getConnection()

        updateDGV()

    End Sub

    Private Sub frmUsers_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim opt As String = MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Close")
        If opt = vbYes Then
            Me.Dispose()
            frmLogin.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    ' btn icons
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnAddUser()
    End Sub

    Private Sub btnAdd_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter
        btnAdd.Image = My.Resources.adduserhover
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.Image = My.Resources.adduser
    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        btnAddUser()
    End Sub
    Private Sub lblAdd_MouseEnter(sender As Object, e As EventArgs) Handles lblAdd.MouseEnter
        btnAdd.Image = My.Resources.adduserhover
    End Sub

    Private Sub lblAdd_MouseLeave(sender As Object, e As EventArgs) Handles lblAdd.MouseLeave
        btnAdd.Image = My.Resources.adduser
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEditUser()
    End Sub

    Private Sub btnEdit_MouseEnter(sender As Object, e As EventArgs) Handles btnEdit.MouseEnter
        btnEdit.Image = My.Resources.edituserhover
    End Sub

    Private Sub btnEdit_MouseLeave(sender As Object, e As EventArgs) Handles btnEdit.MouseLeave
        btnEdit.Image = My.Resources.edituser
    End Sub

    Private Sub lblEdit_Click(sender As Object, e As EventArgs) Handles lblEdit.Click
        btnEditUser()
    End Sub

    Private Sub lblEdit_MouseEnter(sender As Object, e As EventArgs) Handles lblEdit.MouseEnter
        btnEdit.Image = My.Resources.edituserhover
    End Sub

    Private Sub lblEdit_MouseLeave(sender As Object, e As EventArgs) Handles lblEdit.MouseLeave
        btnEdit.Image = My.Resources.edituser
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        btnDeleteUser()
    End Sub

    Private Sub btnDelete_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete.MouseEnter
        btnDelete.Image = My.Resources.deleteuserhover
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.Image = My.Resources.deleteuser
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        btnDeleteUser()
    End Sub

    Private Sub lblDelete_MouseEnter(sender As Object, e As EventArgs) Handles lblDelete.MouseEnter
        btnDelete.Image = My.Resources.deleteuserhover
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        btnDelete.Image = My.Resources.deleteuser
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnSearchUser()
    End Sub

    Private Sub btnSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter
        btnSearch.Image = My.Resources.searchuserhover
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.Image = My.Resources.searchuser
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        btnSearchUser()
    End Sub

    Private Sub lblSearch_MouseEnter(sender As Object, e As EventArgs) Handles lblSearch.MouseEnter
        btnSearch.Image = My.Resources.searchuserhover
    End Sub

    Private Sub lblSearch_MouseLeave(sender As Object, e As EventArgs) Handles lblSearch.MouseLeave
        btnSearch.Image = My.Resources.searchuser
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateDGV()
    End Sub

    Private Sub btnRefresh_MouseEnter(sender As Object, e As EventArgs) Handles btnRefresh.MouseEnter
        btnRefresh.Image = My.Resources.refreshrotated
    End Sub

    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        btnRefresh.Image = My.Resources.refresh
    End Sub

    Private Sub dgvUsers_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvUsers.MouseClick
        Dim index As Integer = dgvUsers.CurrentRow.Index
        dgvUsers.Rows(index).Selected = True
    End Sub

    Private Sub dgvUsers_Sorted(sender As Object, e As EventArgs) Handles dgvUsers.Sorted
        ' set colors 
        Dim rowColor As Color
        For i As Integer = 0 To dgvUsers.RowCount - 1
            If i Mod 2 = 0 Then
                rowColor = Color.LightGray
            Else
                rowColor = Color.White
            End If
            dgvUsers.Rows(i).DefaultCellStyle.BackColor = rowColor
        Next
    End Sub
End Class
