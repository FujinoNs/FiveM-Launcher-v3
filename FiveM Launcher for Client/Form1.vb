'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
'ในนี้อย่ายุ่ง''ในนี้อย่ายุ่ง'
Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Increment(1)
        Label2.Text = GunaProgressBar1.ProgressPercentText
        If GunaProgressBar1.Value = GunaProgressBar1.Maximum Then Me.Hide()
        If GunaProgressBar1.Value = GunaProgressBar1.Maximum Then Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
