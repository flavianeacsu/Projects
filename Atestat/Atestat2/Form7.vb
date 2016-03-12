Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("0335005478_1_1_3.jpg")
        CheckBox1.Text = "Blugi prespalati"
        Label1.Text = "89"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("5041843401_1_1_3.jpg")
        CheckBox2.Text = "Blugi simpli"
        Label2.Text = "79"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("5181074811_1_1_3.jpg")
        CheckBox3.Text = "Blugi gri"
        Label3.Text = "59"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("0047843400_1_1_3.jpg")
        CheckBox1.Text = "Blugi indigo"
        Label1.Text = "79"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("0008323800_1_1_3.jpg")
        CheckBox2.Text = "Colanti piele"
        Label2.Text = "89"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("0195019480_1_1_3.jpg")
        CheckBox3.Text = "Blugi prespalati"
        Label3.Text = "80"
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

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class