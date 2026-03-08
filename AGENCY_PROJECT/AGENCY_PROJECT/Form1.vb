Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtlogin.Click
        login()


    End Sub
    Public Sub login()
        Dim teacher_id = txtteacherid.Text
        Dim usernames = txtusername.Text
        Dim passwords = txtpassword.Text

        If teacher_id = "1234" And usernames = "LIBRARY" And passwords = "LIBRARY123" Then
            MsgBox("Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            main_1.Show()
            txtteacherid.Clear()
            txtusername.Clear()
            txtpassword.Clear()

        Else

            MsgBox("Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        End If



    End Sub

End Class
