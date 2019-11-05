Imports System.Data.SqlClient
Public Class RegistationCU
    Dim con As New SqlConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        logincustomer.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox1.Text.Length
        ch = TextBox1.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox1.Text.Length
        ch = TextBox1.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox1.Text.Length
        ch = TextBox1.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO addcustomer VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Registation is done")
    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

        Dim ch(10) As Char
        Dim len As Integer
        len = TextBox4.Text.Length
        ch = TextBox4.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MsgBox("Value you insert is not numeric")
            End If
        Next
    End Sub

    Private Sub TextBox7_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

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

    Private Sub RegistationCU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=SAURABH\SQLEXPRESS;Initial Catalog=myweeble;Integrated Security=True"
    End Sub
End Class