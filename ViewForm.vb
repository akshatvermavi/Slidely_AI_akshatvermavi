Public Class ViewForm
    Dim currentIndex As Integer = 0

    Friend Sub Show()
        Throw New NotImplementedException()
    End Sub

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmission(currentIndex)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        ' Call the /read endpoint with the current index and load the data into the text fields
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious_Click.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' Assuming a method to get the total count of submissions
        If currentIndex < GetTotalSubmissions() - 1 Then
            currentIndex += 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Function GetTotalSubmissions() As Integer
        Throw New NotImplementedException()
    End Function
End Class
