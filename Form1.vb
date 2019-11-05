Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        logAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        logincustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End
    End Sub
End Class
