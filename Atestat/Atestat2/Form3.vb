Public Class Form3

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("1467073211_1_1_3.jpg")
        CheckBox2.Text = "Parka"
        Label2.Text = "180"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("1546161800_1_1_3.jpg")
        CheckBox1.Text = "Palton"
        Label1.Text = "220"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("1500073710_1_1_3.jpg")
        CheckBox3.Text = "Parka"
        Label3.Text = "300"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("1634318740_1_1_3.jpg")
        CheckBox2.Text = "Jacheta"
        Label2.Text = "110"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("6446833709_1_1_3.jpg")
        CheckBox1.Text = "Parka"
        Label1.Text = "180"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("8870208800_1_1_3.jpg")
        CheckBox3.Text = "Geaca piele"
        Label3.Text = "150"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("1243833811_1_1_3.jpg")
        CheckBox2.Text = "Vesta"
        Label2.Text = "150"
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("1199900657_1_1_3.jpg")
        CheckBox1.Text = "Blazer"
        Label1.Text = "89"
        PictureBox3.Image = System.Drawing.Bitmap.FromFile("1302200252_1_1_3.jpg")
        CheckBox3.Text = "Parka"
        Label3.Text = "200"
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

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class