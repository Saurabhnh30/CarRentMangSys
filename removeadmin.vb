Public Class removeadmin

    Private Sub removeadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyweebleDataSet.addadmin' table. You can move, or remove it, as needed.
        Me.AddadminTableAdapter.Fill(Me.MyweebleDataSet.addadmin)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        If MessageBox.Show("do you want to delete this row", "delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class