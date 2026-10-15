Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' 使用 Me.Invoke 确保安全在 UI 线程上更新进度条
        If Me.IsHandleCreated Then
            Me.Invoke(Sub()
                          If ProgressBar1.Value + 2 <= ProgressBar1.Maximum Then
                              ProgressBar1.Value += 4
                          Else
                              ProgressBar1.Value = ProgressBar1.Maximum
                              Timer1.Stop()
                          End If
                      End Sub)
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class


