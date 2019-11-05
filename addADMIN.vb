Imports System.Data.SqlClient
Public Class addADMIN
    Dim con As New SqlConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub addADMIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=SAURABH\SQLEXPRESS;Initial Catalog=myweeble;Integrated Security=True"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO addadmin VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Registation is done")
    End Sub

   
    Private Sub TextBox3_keypress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

       
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox5.Text.Length
        ch = TextBox5.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox7.Text.Length
        ch = TextBox7.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox10.Text.Length
        ch = TextBox10.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub
End Class