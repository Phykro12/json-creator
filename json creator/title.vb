Public Class title
    Dim Target As String
    Dim Mode As String
    Dim JsonText As String
    Dim BOL, ITA, UND, STR, OBF As String
    Dim JsonTextStatus As String
    Dim Color, ColorSelect As String
    Dim TB3 As String

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tellraw.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tellraw.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Mode = ComboBox1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox2.Text = "/title " + Target + " " + Mode + " [" + JsonText + JsonTextStatus + Color + "}]"
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            BOL = ",""bold"":""true"""
        Else
            BOL = ""
        End If
        JsonTextStatus = BOL + ITA + UND + STR + OBF
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ITA = ",""italic"":""true"""
        Else
            ITA = ""
        End If
        JsonTextStatus = BOL + ITA + UND + STR + OBF
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            UND = ",""underlined"":""true"""
        Else
            UND = ""
        End If
        JsonTextStatus = BOL + ITA + UND + STR + OBF
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            STR = ",""strikethrough"":""true"""
        Else
            STR = ""
        End If
        JsonTextStatus = BOL + ITA + UND + STR + OBF
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            OBF = ",""obfuscated"":""true"""
        Else
            OBF = ""
        End If
        JsonTextStatus = BOL + ITA + UND + STR + OBF
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ComboBox1.SelectedItem = "" Then
            MsgBox("Select a title mode first!", vbCritical, "Command syntax error!")
        Else
            Timer1.Enabled = True
            JsonText = "{""text"":""" + TB3 + """"
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TB3 = Replace(TextBox3.Text, "\", "\\")
        TB3 = Replace(TB3, """", "\""")
    End Sub


    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Target = "@e"
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Target = TextBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ColorSelect = ComboBox2.Text
        Select Case ColorSelect
            Case "None"
                Color = ""
            Case "Dark Blue"
                Color = ",""color"":""dark_blue"""
            Case "Dark Green"
                Color = ",""color"":""dark_green"""
            Case "Dark Red"
                Color = ",""color"":""dark_red"""
            Case "Dark Aqua"
                Color = ",""color"":""dark_aqua"""
            Case "Dark Purple"
                Color = ",""color"":""dark_purple"""
            Case "Dark Gray"
                Color = ",""color"":""dark_gray"""
            Case "Light Purple"
                Color = ",""color"":""light_purple"""
            Case "Gold"
                Color = ",""color"":""gold"""
            Case "Gray"
                Color = ",""color"":""gray"""
            Case "Blue"
                Color = ",""color"":""blue"""
            Case "Green"
                Color = ",""color"":""green"""
            Case "Aqua"
                Color = ",""color"":""aqua"""
            Case "Red"
                Color = ",""color"":""red"""
            Case "Yellow"
                Color = ",""color"":""yellow"""
            Case "White"
                Color = ",""color"":""white"""
            Case "Black"
                Color = ",""color"":""black"""
        End Select
    End Sub

End Class