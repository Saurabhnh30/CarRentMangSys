Imports System.Data.SqlClient
Public Class addcars
    Dim con As New SqlConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO ADDnewCar VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox(" Car is Added to Weeble Car ")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub addcars_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=SAURABH\SQLEXPRESS;Initial Catalog=myweeble;Integrated Security=True"
    End Sub
End Class