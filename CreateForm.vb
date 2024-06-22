Public Class CreateForm
    Dim stopwatch As New Stopwatch()
    Private lblStopwatch As Object
    Private txtName As Object
    Private txtGithub As Object
    Private txtPhone As Object
    Private txtEmail As Object

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data from the form
        Dim submission As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhone.Text},
            {"github_link", txtGithub.Text},
            {"stopwatch_time", stopwatch.Elapsed.ToString("hh\:mm\:ss")}
        }

        ' Call the /submit endpoint to save the submission
    End Sub
End Class
