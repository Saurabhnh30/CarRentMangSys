Public Class CustomerHistory

    Private Sub CustomerHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyweebleDataSet2.addcustomer' table. You can move, or remove it, as needed.
        Me.AddcustomerTableAdapter.Fill(Me.MyweebleDataSet2.addcustomer)

    End Sub
End Class