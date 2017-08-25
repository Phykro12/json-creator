Public Class tellraw
    Dim Target As String
    Dim JsonText As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String
        user = InputBox("Enter your Minecraft Username (Leave blank if you're not a member of PBS crafters)", "Username confirm")
        If user = "Phykro12" Then
            MsgBox("Welcome, Phykro12!", vbDefaultButton1, "Welcome")
        ElseIf user = "SourceCode_" Then
            MsgBox("Welcome, SourceCode_", vbDefaultButton1, "Welcome")
        Else
            MsgBox("Welcome to json-creator!", vbDefaultButton1, "Welcome")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        title.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Target = TextBox1.Text
        If TextBox1.Enabled = False Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox2.Text = "/tellraw " + Target + " [" + JsonText + "]"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Target = "@a"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Target = "@p"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Target = "@r"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Target = "@e"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Target = "@s"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Target = TextBox1.Text
    End Sub
End Class
