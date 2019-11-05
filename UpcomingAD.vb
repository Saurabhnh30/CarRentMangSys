Public Class UpcomingAD

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Timer1.Enabled = False
        Timer2.Enabled = True
        Timer3.Enabled = False

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        Timer1.Enabled = True
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class