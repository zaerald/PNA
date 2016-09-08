Imports MySql.Data.MySqlClient
Module ToolZ

    Public Function getConnection() As MySqlConnection
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=; database=dbpna;"
        conn.Open()
        Return conn
    End Function

    Public Sub updateDataGridView(ByRef dgv As DataGridView, ByRef dataReader As MySqlDataReader, ByVal columns As String())
        dgv.Font = New Font("Arial", 10, FontStyle.Regular)

        ' reset dgv
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        ' add columns
        For i As Integer = 0 To columns.Length - 1
            dgv.Columns.Add(i, columns(i))
        Next

        ' add rows
        Dim row As Integer = 0
        While dataReader.Read()
            dgv.Rows.Add()
            For i As Integer = 0 To columns.Length - 1
                dgv.Item(i, row).Value = dataReader.Item(i)
            Next

            ' set colors 
            Dim rowColor As Color
            If row Mod 2 = 0 Then
                rowColor = Color.LightGray
            Else
                rowColor = Color.White
            End If
            dgv.Rows(row).DefaultCellStyle.BackColor = rowColor

            row = row + 1
        End While

        If dgv.RowCount > 0 Then
            dgv.Rows(0).Selected = True
        End If

        dataReader.Close()
    End Sub

    Public Function isPhoneNumValid(ByVal phone As String) As Boolean
        If Not IsNumeric(phone) Then
            Return False
        End If

        If phone.Length = 11 Then
            Dim chars() As Char = phone.ToCharArray
            If chars(0) = "0" And chars(1) = "9" Then
                Return True
            End If

        Else
            Return False
        End If
        Return False
    End Function


End Module
