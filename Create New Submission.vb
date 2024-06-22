
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = lblStopwatch.Text ' Assuming lblStopwatch contains the stopwatch time

        Dim submission = New With {
            Key .name = name,
            Key .email = email,
            Key .phone = phone,
            Key .github_link = githubLink,
            Key .stopwatch_time = stopwatchTime
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful")
            Else
                MessageBox.Show("Submission failed")
            End If
        End Using
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "Start"
        Else
            stopwatch.Start()
            btnStartStop.Text = "Stop"
        End If
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub
End Class
