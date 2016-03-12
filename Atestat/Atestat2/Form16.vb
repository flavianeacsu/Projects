Public Class Form16

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As Integer


        ListBox1.SelectionMode = SelectionMode.MultiExtended

        Dim response = MsgBox("Doriti sa eliminati produsul selectat?", MsgBoxStyle.YesNo, "Eliminare")
        If response = MsgBoxResult.Yes Then

            x = ListBox2.SelectedIndex
            s = s - Val(ListBox1.Items(x))
            ListBox1.Items.RemoveAt(x)
            ListBox2.Items.RemoveAt(x)
        End If
        Label4.Text = s
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Text = s
        Label5.Text = "RON"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form17.Show()

    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        d = Me
        Me.Hide()
        Form18.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        d1.Show()

    End Sub
End Class