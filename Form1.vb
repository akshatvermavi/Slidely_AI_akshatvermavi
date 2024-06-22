Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewForm As New ViewForm()
        viewForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createForm As New CreateForm()
        createForm.Show()
    End Sub

End Class
