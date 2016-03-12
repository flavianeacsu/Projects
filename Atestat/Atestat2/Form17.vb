
Imports System.Net.Mail
Public Class Form17



    



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim e_mail As New MailMessage()
        Try

            e_mail.From = New MailAddress("magazinonline7@gmail.com")
            e_mail.To.Add(TextBox4.Text + ComboBox1.SelectedItem)
            e_mail.Subject = "Lista dumneavoastra de cumparaturi"
            e_mail.Body = ("Buna ziua, " + TextBox1.Text + " " + TextBox2.Text + "! Multumim ca ati cumparat de la noi. Comanda dumneavoastra va fi trimisa la adresa " + TextBox3.Text + ", maine dimineata. O zi buna!")
            Dim Smtp As New SmtpClient("smtp.gmail.com")

            Smtp.Port = 587
            Smtp.EnableSsl = True
            Smtp.Credentials = New Net.NetworkCredential("magazinonline7@gmail.com", "magazin7")

            Smtp.Send(e_mail)

        Catch ex As Exception

        End Try

        MsgBox("E-mail trimis!", MsgBoxStyle.Information, "E-mail")
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        d = Me
        Me.Hide()
        Form18.Show()
    End Sub
End Class