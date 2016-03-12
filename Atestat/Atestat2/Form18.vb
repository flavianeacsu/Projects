Public Class Form18

  
   
    

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ComboBox1.SelectedIndex = 0 Then
            msp.SoundLocation = "love me again.wav"
            msp.Play()
        End If

        If ComboBox1.SelectedIndex = 1 Then
            msp.SoundLocation = "tortura.wav"
            msp.Play()
        End If

        If ComboBox1.SelectedIndex = 2 Then
            msp.SoundLocation = "river.wav"
            msp.Play()
        End If

        If ComboBox1.SelectedIndex = 3 Then
            msp.SoundLocation = "not a bad thing.wav"
            msp.Play()
        End If

        If ComboBox1.SelectedIndex = 4 Then
            msp.SoundLocation = "let it be.wav"
            msp.Play()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        msp.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim m = ComboBox1.SelectedIndex + 1
        If m = 1 Then
            msp.SoundLocation = "tortura.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If

        If m = 2 Then
            msp.SoundLocation = "river.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If

        If m = 3 Then
            msp.SoundLocation = "not a bad thing.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If

        If m = 4 Then
            msp.SoundLocation = "let it be.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If
  
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m = ComboBox1.SelectedIndex - 1
        If m = 1 Then
            msp.SoundLocation = "tortura.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If

        If m = 2 Then
            msp.SoundLocation = "river.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If

        If m = 3 Then
            msp.SoundLocation = "not a bad thing.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If

        If m = 0 Then
            msp.SoundLocation = "love me again.wav"
            msp.Play()
            ComboBox1.SelectedIndex = m
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        d.Show()
    End Sub
End Class