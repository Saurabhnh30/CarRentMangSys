Public Class RetunAD

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        MsgBox("Thank you")
    End Sub

    Private Sub RetunAD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyweebleDataSet10.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.MyweebleDataSet10.Booking)
        Dim f3 As New RetunAD
        Me.Show()
        Me.Hide()
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Enabled = True Then
            Label1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class