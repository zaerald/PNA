Public Class Splash

    Dim isExit As Boolean

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = BackColor
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        isExit = True
        tmr.Enabled = False
    End Sub

    Private Sub tmrAnim_Tick(sender As Object, e As EventArgs) Handles tmrAnim.Tick
        If isExit Then
            Me.Opacity = Me.Opacity - 0.2
            If Me.Opacity <= 0 Then
                ' exit
                Me.Dispose()
                frmLogin.Show()
            End If
        End If
    End Sub
End Class