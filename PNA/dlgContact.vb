Imports MySql.Data.MySqlClient
Public Class dlgContact

    Dim conn As New MySqlConnection

    Public state As Integer


    Private Sub convertFirstToUppercase(txt As TextBox)
        Dim characters() As Char = txt.Text.ToCharArray
        characters(0) = Char.ToUpper(characters(0))
        txt.Text = New String(characters)
    End Sub



    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim cmd As New MySqlCommand

        Dim isValid As Boolean = True

        ' check all fields
        If txtLast.Text = "" Or txtFirst.Text = "" Or txtPn.Text = "" Or
            txtSt.Text = "" Or txtCity.Text = "" Then
            MsgBox("Please fill up all fields.")
        Else
            ' convert all first letter to upper case
            convertFirstToUppercase(txtLast)
            convertFirstToUppercase(txtFirst)
            convertFirstToUppercase(txtSt)
            convertFirstToUppercase(txtCity)

            ' check if number is valid
            If Not ToolZ.isPhoneNumValid(txtPn.Text) Then
                MsgBox("Phone Number is Invalid!")
                isValid = False
            End If

            cmd.Connection = conn
            If isValid Then
                ' add || edit
                Select Case state
                    Case 0
                        cmd.CommandText = "INSERT INTO tblpa(lastname, firstname, phonenumber, street, city) VALUES ('" &
                        txtLast.Text & "', '" & txtFirst.Text & "', '" & txtPn.Text & "', '" & txtSt.Text & "', '" & txtCity.Text & "')"
                    Case 1
                        cmd.CommandText = "UPDATE tblpa SET lastname='" & txtLast.Text &
                            "', firstname='" & txtFirst.Text & "', phonenumber='" & txtPn.Text &
                            "', street='" & txtSt.Text & "', city='" & txtCity.Text & "' WHERE id=" & frmPNA.selectedID
                End Select


                cmd.ExecuteNonQuery()
                Me.DialogResult = DialogResult.OK
            End If

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub dlgContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection()
    End Sub
End Class