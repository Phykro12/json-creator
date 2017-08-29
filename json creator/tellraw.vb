Public Class tellraw
    Dim Target As String
    Dim JsonText As String
    Dim Bold, Italic, Underlined, Strikethrough, Obfuscated, TextFormat As String
    Dim BoldStatus, ItalicStaus, UnderlinedStatus, StrikethroughStatus, ObfuscatedStatus, ColorSelect, ColorStatus As String
    Dim TB3 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        title.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox2.Text = "/tellraw " + Target + " [" + JsonText + TextFormat + "]"
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

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TB3 = Replace(TextBox3.Text, "\", "\\")
        TB3 = Replace(TB3, """", "\""")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Target = "@s"
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Target = TextBox1.Text
        If TextBox1.Enabled = False Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Bold = "true"
            BoldStatus = ",""bold"":""true"""
        Else
            Bold = "false"
            BoldStatus = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Italic = "true"
            ItalicStaus = ",""italic"":""true"""
        Else
            Italic = "false"
            ItalicStaus = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Underlined = "true"
            UnderlinedStatus = ",""underlined"":""true"""
        Else
            Underlined = "false"
            UnderlinedStatus = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Strikethrough = "true"
            StrikethroughStatus = ",""strikethrough"":""true"""
        Else
            Strikethrough = "false"
            StrikethroughStatus = ""
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Obfuscated = "true"
            ObfuscatedStatus = ",""obfuscated"":""true"""
        Else
            Obfuscated = "false"
            ObfuscatedStatus = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        JsonText = "{""text"":""" + TB3 + """"
        Timer2.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Target = TextBox1.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ColorSelect = ComboBox1.Text
        Select Case ColorSelect
            Case "None"
                ColorStatus = ""
            Case "Dark Blue"
                ColorStatus = ",""color"":""dark_blue"""
            Case "Dark Green"
                ColorStatus = ",""color"":""dark_green"""
            Case "Dark Red"
                ColorStatus = ",""color"":""dark_red"""
            Case "Dark Aqua"
                ColorStatus = ",""color"":""dark_aqua"""
            Case "Dark Purple"
                ColorStatus = ",""color"":""dark_purple"""
            Case "Dark Gray"
                ColorStatus = ",""color"":""dark_gray"""
            Case "Light Purple"
                ColorStatus = ",""color"":""light_purple"""
            Case "Gold"
                ColorStatus = ",""color"":""gold"""
            Case "Gray"
                ColorStatus = ",""color"":""gray"""
            Case "Blue"
                ColorStatus = ",""color"":""blue"""
            Case "Green"
                ColorStatus = ",""color"":""green"""
            Case "Aqua"
                ColorStatus = ",""color"":""aqua"""
            Case "Red"
                ColorStatus = ",""color"":""red"""
            Case "Yellow"
                ColorStatus = ",""color"":""yellow"""
            Case "White"
                ColorStatus = ",""color"":""white"""
            Case "Black"
                ColorStatus = ",""color"":""black"""
        End Select
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextFormat = ColorStatus + BoldStatus + ItalicStaus + UnderlinedStatus + StrikethroughStatus + ObfuscatedStatus + "}"
    End Sub

End Class
