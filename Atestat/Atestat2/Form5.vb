Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("7122168605_1_1_3.jpg")
        CheckBox1.Text = "Bluza rosie"
        Label4.Text = "59"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("2648666712_1_1_3.jpg")
        CheckBox2.Text = "Tricou mesaj"
        Label6.Text = "35"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("2682666712_1_1_3.jpg")
        CheckBox3.Text = "Tricou mesaj"
        Label3.Text = "35"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("7067321040_1_1_3.jpg")
        CheckBox1.Text = "Tricou scurt"
        Label4.Text = "35"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("6837118774_1_1_3.jpg")
        CheckBox2.Text = "Bluza"
        Label6.Text = "65"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("6877315712_1_1_3.jpg")
        CheckBox3.Text = "Tricou mesaj"
        Label3.Text = "35"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        PictureBox1.Image = System.Drawing.Bitmap.FromFile("7172089712_1_1_3.jpg")
        CheckBox1.Text = "Tricou mesaj"
        Label4.Text = "35"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("6912167812_1_1_3.jpg")
        CheckBox2.Text = "Bluza"
        Label6.Text = "65"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("6890033251_1_1_3.jpg")
        CheckBox3.Text = "Tricou Minnie"
        Label3.Text = "35"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("2407810800_1_1_3.jpg")
        CheckBox1.Text = "Tricou lup"
        Label4.Text = "45"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("1887666966_1_1_3.jpg")
        CheckBox2.Text = "Hanorac"
        Label6.Text = "65"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("2471058803_1_1_3.jpg")
        CheckBox3.Text = "Tricou scurt"
        Label3.Text = "35"
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

            s = s + Val(Label3.Text)

            Form16.ListBox1.Items.Add(Label3.Text)
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

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class