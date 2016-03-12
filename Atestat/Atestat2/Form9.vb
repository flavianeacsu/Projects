Public Class Form9

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("4173023302_1_1_3.jpg")
        CheckBox1.Text = "Lantic infinit"
        Label4.Text = "20"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("4605862630_1_1_3.jpg")
        CheckBox2.Text = "Geanta roz"
        Label6.Text = "59"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("4252023302_1_1_3.jpg")
        CheckBox3.Text = "Set cercei"
        Label3.Text = "35"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("4210413302_1_1_3.jpg")
        CheckBox1.Text = "Set inele"
        Label4.Text = "35"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("4576856537_1_1_3.jpg")
        CheckBox2.Text = "Husa iPhone"
        Label6.Text = "25"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("4166856607_1_1_3.jpg")
        CheckBox3.Text = "Ceas"
        Label3.Text = "89"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("4275023302_1_1_3.jpg")
        CheckBox1.Text = "Bratara"
        Label4.Text = "30"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("4584856902_1_1_3.jpg")
        CheckBox2.Text = "Husa iPhone"
        Label6.Text = "25"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("4602986702_1_1_3.jpg")
        CheckBox3.Text = "Geanta"
        Label3.Text = "89"
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

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class