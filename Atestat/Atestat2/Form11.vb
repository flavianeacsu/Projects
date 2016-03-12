Public Class Form11

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("1521085505_1_1_3.jpg")
        CheckBox3.Text = "Geaca"
        Label5.Text = "140"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("3920208732_1_1_3.jpg")
        CheckBox1.Text = "Geaca piele"
        Label4.Text = "200"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("6410073711_1_1_3.jpg")
        CheckBox2.Text = "Jacheta"
        Label6.Text = "150"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("1419109800_1_1_3.jpg")
        CheckBox3.Text = "Geaca piele"
        Label5.Text = "150"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("1433085812_1_1_3.jpg")
        CheckBox1.Text = "Jacheta"
        Label4.Text = "89"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("1429863462_1_1_3.jpg")
        CheckBox2.Text = "Jacheta"
        Label6.Text = "100"
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

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class