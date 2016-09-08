Public Class dlgSearch

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
                        commandText = "SELECT * FROM tbluser WHERE id=" & txt.Text
                    Else
                        MsgBox("Please enter number when searching ID")
                        isValid = False
                    End If
                Case 1
                    commandText = "SELECT * FROM tbluser WHERE user='" & txt.Text & "'"
                Case 2
                    commandText = "SELECT * FROM tbluser WHERE user LIKE '%" & txt.Text & "%'"
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