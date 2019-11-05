Public Class Newly_car

    Private Sub Newly_car_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyweebleDataSet3.ADDnewCar' table. You can move, or remove it, as needed.
        Me.ADDnewCarTableAdapter.Fill(Me.MyweebleDataSet3.ADDnewCar)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub
End Class