Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("5471260800_1_1_3.jpg")
        CheckBox2.Text = "Rochie rosie"
        Label2.Text = "130"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("5534286641_1_1_3.jpg")
        CheckBox1.Text = "Rochie bretele"
        Label1.Text = "110"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("5517301800_1_1_3.jpg")
        CheckBox3.Text = "Rochie neagra"
        Label3.Text = "110"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("5529301800_1_1_3.jpg")
        CheckBox2.Text = "Rochie aurie"
        Label2.Text = "130"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("5535286613_1_1_3.jpg")
        CheckBox1.Text = "Rochie lunga"
        Label1.Text = "140"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("6144966800_1_1_3.jpg")
        CheckBox3.Text = "Rochie seara"
        Label3.Text = "125"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("5401966800_1_1_3.jpg")
        CheckBox2.Text = "Rochie casual"
        Label2.Text = "89"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("5418110800_1_1_3.jpg")
        CheckBox1.Text = "Rochie lunga"
        Label1.Text = "149"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("5499966470_1_1_3.jpg")
        CheckBox3.Text = "Rochie neagra"
        Label3.Text = "119"
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

            s = s + Val(Label2.Text)

            Form16.ListBox1.Items.Add(Label2.Text)
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

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class