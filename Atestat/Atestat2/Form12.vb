﻿Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("3080034818_1_1_3.jpg")
        CheckBox1.Text = "Tricou Batman"
        Label4.Text = "49"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("3293033800_1_1_3.jpg")
        CheckBox3.Text = "Tricou mesaj"
        Label5.Text = "49"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("3303033800_1_1_3.jpg")
        CheckBox2.Text = "Maiou maimuta"
        Label6.Text = "35"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("3085418711_1_1_3.jpg")
        CheckBox1.Text = "Tricou pisica"
        Label4.Text = "49"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("3270922809_1_1_3.jpg")
        CheckBox3.Text = "Maiou mesaj"
        Label5.Text = "35"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("3080033800_1_1_3.jpg")
        CheckBox2.Text = "Tricou Superman"
        Label6.Text = "49"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        d1 = Me
        Me.Hide()
        Form16.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sw As Integer
        sw = 0
        If CheckBox1.Checked = True Then

            s = s + Val(Label4.Text)

            Form16.ListBox2.Items.Add(CheckBox1.Text)
            Form16.ListBox1.Items.Add(Label4.Text)
            sw = sw + 1
        End If

        If CheckBox2.Checked = True Then

            s = s + Val(Label6.Text)

            Form16.ListBox1.Items.Add(Label6.Text)
            Form16.ListBox2.Items.Add(CheckBox2.Text)
            sw = sw + 1
        End If

        If CheckBox3.Checked = True Then

            s = s + Val(Label5.Text)

            Form16.ListBox1.Items.Add(Label5.Text)
            Form16.ListBox2.Items.Add(CheckBox3.Text)
            sw = sw + 1
        End If
        If sw = 1 Then
            MsgBox("Produs adaugat!", MsgBoxStyle.Information, "Informatie")
        End If

        If sw > 1 Then
            MsgBox("Produse adaugate!", MsgBoxStyle.Information, "Informatie")
        End If

        If sw = 0 Then
            MsgBox("Niciun produs de adaugat!", MsgBoxStyle.Information, "Informatie")
        End If
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class