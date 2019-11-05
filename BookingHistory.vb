Public Class BookingHistory

    Private Sub BookingHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyweebleDataSet8.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.MyweebleDataSet8.Booking)
      
    End Sub
End Class