Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Languagename.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NameofLanguage As String

        NameofLanguage = Languagename.Text



        If NameofLanguage = "Zulu" Then

            MsgBox("Sawubona")

        ElseIf NameofLanguage = "Xhosa" Then

            MsgBox("Molweni")

        ElseIf NameofLanguage = "Sotho" Then
            MsgBox("Dumelang")

        Else
            MsgBox("hi")


        End If


    End Sub
End Class
