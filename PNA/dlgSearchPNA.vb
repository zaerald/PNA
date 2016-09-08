Public Class dlgSearchPNA

    Public commandText As String = ""

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txt.Text = "" Or cboSearch.SelectedIndex = -1 Then
            MsgBox("Please fill up all fields.")
        Else


            Dim isValid As Boolean = True

            Select Case cboSearch.SelectedIndex
                Case 0
                    ' check if number
                    If IsNumeric(txt.Text) Then
                        commandText = "SELECT * FROM tblpa WHERE id=" & txt.Text
                    Else
                        MsgBox("Please enter number when searching ID")
                        isValid = False
                    End If
                Case 1
                    commandText = "SELECT * FROM tblpa WHERE lastname='" & txt.Text & "'"
                Case 2
                    commandText = "SELECT * FROM tblpa WHERE firstname='" & txt.Text & "'"
                Case 3
                    ' check if number is valid
                    If Not ToolZ.isPhoneNumValid(txt.Text) Then
                        MsgBox("Phone Number is Invalid!")
                        isValid = False
                    End If
                    commandText = "SELECT * FROM tblpa WHERE phonenumber='" & txt.Text & "'"
                Case 4
                    commandText = "SELECT * FROM tblpa WHERE street='" & txt.Text & "'"
                Case 5
                    commandText = "SELECT * FROM tblpa WHERE city='" & txt.Text & "'"
                Case 6
                    commandText = "SELECT * FROM tblpa WHERE lastname LIKE '%" & txt.Text & "%'"
                Case 7
                    commandText = "SELECT * FROM tblpa WHERE firstname LIKE '%" & txt.Text & "%'"
                Case 8
                    commandText = "SELECT * FROM tblpa WHERE phonenumber LIKE '%" & txt.Text & "%'"
            End Select
            If isValid Then
                Me.DialogResult = DialogResult.OK
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class