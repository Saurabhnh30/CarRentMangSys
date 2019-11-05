Imports System.Data.SqlClient
Public Class Car_3_6_AD_
    Dim con As New SqlConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox6.Text.Length
        ch = TextBox6.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox9.Text.Length
        ch = TextBox9.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        TextBox11.Text = Val(ComboBox11.Text) - Val(ComboBox10.Text)
        TextBox15.Text = Val(TextBox12.Text) * Val(TextBox11.Text) * 0.5
        TextBox13.Text = 0.1 * Val(TextBox15.Text)
        TextBox14.Text = Val(TextBox13.Text) + Val(TextBox12.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Dim date1 As Date
        Dim date2 As Date
        Dim diff As TimeSpan
        date1 = Convert.ToDateTime(DateTimePicker1.Value)
        date2 = Convert.ToDateTime(DateTimePicker2.Value)
        diff = date2.Subtract(date1)
        TextBox11.Text = Format(diff.TotalDays, 0)

        Dim num1, num2, vat, product As Single
        num1 = TextBox11.Text
        num2 = TextBox12.Text
        product = num1 * num2
        TextBox15.Text = product

        vat = 0.1 * TextBox15.Text
        TextBox13.Text = vat
        TextBox14.Text = vat + TextBox15.Text
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim slides As Integer
        slides += 15
        If slides <= 20 Then
            PictureBox2.Left += 10
        ElseIf slides > 20 AndAlso slides <= 40 Then
            PictureBox2.Top += 10
        ElseIf slides > 40 AndAlso slides <= 60 Then
            PictureBox2.Left -= 10
        ElseIf slides > 60 AndAlso slides <= 80 Then
            PictureBox2.Top -= 10
        Else
            slides = 0
        End If
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO Booking VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox14.Text & "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox(" Your Tata Safari has been Booked ")
    End Sub

    Private Sub Car_3_6_AD__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=SAURABH\SQLEXPRESS;Initial Catalog=myweeble;Integrated Security=True"
        Me.Refresh()
    End Sub
End Class