Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmLogin

    Dim conn As MySqlConnection


    ' vars for navigations
    Dim isLogin As Boolean
    Dim isBack As Boolean

    Private Sub btnUserManagement()
        Me.Hide()
        frmUsers.Show()
    End Sub

    Private Sub btnPNAManagement()
        Me.Hide()
        frmPNA.Show()
    End Sub



    Private Sub frmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim opt As String = MsgBox("Do you want to Exit?", vbYesNo + vbQuestion, "Exit")
        If opt = vbNo Then
            e.Cancel = True
        Else
            Environment.Exit(0)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' init conn
        conn = ToolZ.getConnection()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        ' check login
        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM tbluser WHERE user='" & txtUser.Text &
                "' AND password='" & txtPassword.Text & "'"
        End With
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            ' compare
            If txtUser.Text = dr.Item(1).ToString And txtPassword.Text = dr.Item(2).ToString Then
                ' animate
                isLogin = True
                tmrAnim.Enabled = True

                ' reset txtboxes
                txtUser.Text = ""
                txtPassword.Text = ""
            Else
                MsgBox("Please check your Username and Password.")
            End If
        Else
            MsgBox("The username and password is invalid!")
        End If
        dr.Close()
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        ' show view btn
        btnEye.Visible = True
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        ' hide view btn
        btnEye.Visible = False
    End Sub

    Private Sub btnEye_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEye.MouseDown
        btnEye.Image = My.Resources.eyelight
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub btnEye_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEye.MouseUp
        btnEye.Image = My.Resources.eye
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub tmrAnim_Tick(sender As Object, e As EventArgs) Handles tmrAnim.Tick
        If isLogin Then
            pan.Location = New Point(pan.Location.X - 35, 0)
            If pan.Location.X <= -Me.Width Then
                tmrAnim.Enabled = False
                isLogin = False
                Me.Text = "Main Menu"

                ' animate welcome
                tmrWelcome.Enabled = True

            End If
        ElseIf isBack Then
            pan.Location = New Point(pan.Location.X + 35, 0)
            If pan.Location.X >= 0 Then
                tmrAnim.Enabled = False
                isBack = False
                Me.Text = "Login"
                panWelcome.Visible = True
            End If
        End If
    End Sub

    Private Sub tmrWelcome_Tick(sender As Object, e As EventArgs) Handles tmrWelcome.Tick
        tmrWelcome.Enabled = False
        panWelcome.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim opt As String = MsgBox("Are you sure you want to go back and sign out?", vbYesNo + vbQuestion, "Sign Out")
        If opt = vbYes Then
            isBack = True
            tmrAnim.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim opt As String = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Exit")
        If opt = vbYes Then
            Environment.Exit(0)
        End If
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.Image = My.Resources.btnBackHover
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.Image = My.Resources.btnBackDefault
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        btnUserManagement()
    End Sub

    Private Sub btnManageUsers_MouseEnter(sender As Object, e As EventArgs) Handles btnManageUsers.MouseEnter
        btnManageUsers.Image = My.Resources.usermgmthover
    End Sub

    Private Sub btnManageUsers_MouseLeave(sender As Object, e As EventArgs) Handles btnManageUsers.MouseLeave
        btnManageUsers.Image = My.Resources.usermgmt
    End Sub

    Private Sub btnManagePNA_Click(sender As Object, e As EventArgs) Handles btnManagePNA.Click
        btnPNAManagement()
    End Sub

    Private Sub btnManagePNA_MouseEnter(sender As Object, e As EventArgs) Handles btnManagePNA.MouseEnter
        btnManagePNA.Image = My.Resources.pnamgmthover
    End Sub

    Private Sub btnManagePNA_MouseLeave(sender As Object, e As EventArgs) Handles btnManagePNA.MouseLeave
        btnManagePNA.Image = My.Resources.pnamgmt
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        btnUserManagement()
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        btnManageUsers.Image = My.Resources.usermgmthover
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        btnManageUsers.Image = My.Resources.usermgmt
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        btnPNAManagement()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        btnManagePNA.Image = My.Resources.pnamgmthover
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        btnManagePNA.Image = My.Resources.pnamgmt
    End Sub


End Class