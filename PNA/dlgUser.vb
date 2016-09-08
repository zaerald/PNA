Imports MySql.Data.MySqlClient
Public Class dlgUser

    Dim conn As New MySqlConnection

    Public state As Integer

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim cmd As New MySqlCommand

        ' check if all fields are filled up
        If txtUser.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill all fields.")
        Else
            Me.DialogResult = DialogResult.OK

            cmd.Connection = conn

            ' check state
            Select Case state
                Case DialogConstants.DLG_ADD
                    cmd.CommandText = "INSERT INTO tbluser(user, password) VALUES('" _
                        & txtUser.Text & "', '" & txtPassword.Text & "')"
                Case DialogConstants.DLG_EDIT
                    cmd.CommandText = "UPDATE tbluser SET user='" & txtUser.Text &
                        "', password='" & txtPassword.Text & "' WHERE id=" & frmUsers.selectedID
            End Select
            cmd.ExecuteNonQuery()
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub dlgUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection()
    End Sub
End Class