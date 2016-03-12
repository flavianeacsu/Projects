Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("1037019433_1_1_3.jpg")
        CheckBox3.Text = "Camasa blugi"
        Label2.Text = "50"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("0977397641_1_1_3.jpg")
        CheckBox1.Text = "Camasa carouri"
        Label1.Text = "80"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("0980361461_1_1_3.jpg")
        CheckBox2.Text = "Camasa subtire"
        Label6.Text = "60"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("0979666800_1_1_3.jpg")
        CheckBox3.Text = "Camasa buline"
        Label2.Text = "75"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("0871190730_1_1_3.jpg")
        CheckBox1.Text = "Camasa leopard"
        Label1.Text = "69"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("5830190148_1_1_3.jpg")
        CheckBox2.Text = "Camasa scurta"
        Label6.Text = "50"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("0866448601_1_1_3.jpg")
        CheckBox3.Text = "Camasa rosie"
        Label2.Text = "56"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("0934409400_1_1_3.jpg")
        CheckBox1.Text = "Camasa blugi"
        Label1.Text = "60"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("0890110251_1_1_3.jpg")
        CheckBox2.Text = "Camasa fluturi"
        Label6.Text = "89"
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

            s = s + Val(Label1.Text)

            Form16.ListBox2.Items.Add(CheckBox1.Text)
            Form16.ListBox1.Items.Add(Label1.Text)
            sw = sw + 1
        End If

        If CheckBox2.Checked = True Then

            s = s + Val(Label6.Text)

            Form16.ListBox1.Items.Add(Label6.Text)
            Form16.ListBox2.Items.Add(CheckBox2.Text)
            sw = sw + 1
        End If

        If CheckBox3.Checked = True Then

            s = s + Val(Label2.Text)

            Form16.ListBox1.Items.Add(Label2.Text)
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

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class