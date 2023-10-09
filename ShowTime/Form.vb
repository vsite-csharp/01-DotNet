Public Class FormShowTime

    Private Sub ButtonGetTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetTime.Click
        TextBoxTime.Text = ProvideTime.GetDateTime()
    End Sub
End Class
