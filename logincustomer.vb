﻿Public Class logincustomer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adapter As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet

        connection.ConnectionString = ("Data Source=SAURABH\SQLEXPRESS;Initial Catalog=myweeble;Integrated Security=True")
        command.CommandText = "SELECT * FROM [addcustomer] WHERE username= '" & TextBox1.Text & " 'AND password='" & TextBox2.Text & "';"
        connection.Open()

        command.Connection = connection

        adapter.SelectCommand = command
        adapter.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
            menuCustomer.Show()


        Else
            My.Computer.Audio.Play(My.Resources.wrong_password, AudioPlayMode.Background)
            MsgBox("INCORRECT PASSWORD OR USERNAME")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adapter As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet

        connection.ConnectionString = ("Data Source=SAURABH\SQLEXPRESS;Initial Catalog=myweeble;Integrated Security=True")
        command.CommandText = "SELECT * FROM [addcustomer] WHERE username= '" & TextBox1.Text & " 'AND password='" & TextBox2.Text & "';"
        connection.Open()

        command.Connection = connection

        adapter.SelectCommand = command
        adapter.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
            menuCustomer.Show()
            Me.Hide()

        Else
            My.Computer.Audio.Play(My.Resources.wrong_password, AudioPlayMode.Background)
            MsgBox("INCORRECT PASSWORD OR USERNAME")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        RegistationCU.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form1.Show()
        TextBox2.Clear()
        TextBox1.Clear()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class