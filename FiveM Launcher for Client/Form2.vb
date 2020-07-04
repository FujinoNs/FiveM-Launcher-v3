'FiveM Launcher V3.0.0'
'ลิ้งค์ต่างๆคุณสามารถแก้ได้ในนี้'
'รันเซอร์ตัวนี้สร้างโดย Kroekchai KC (Fujino N's) https://www.facebook.com/fujino.jp.th'
Public Class Form2
    'ตรงนี้ปุ่ม X'
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Form1.Close() 'ปิด Form1'
        Me.Close() 'ปิด Form ปัจจุบัน'
    End Sub
    'อย่าลบเครดิตผมได้มั้ย'
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Shell("Explorer.exe https://www.facebook.com/fujino.jp.th") 'อย่าลบเครดิตผมได้มั้ย T_T'
    End Sub
    'ตรงนี้ปุ่ม PLAY GAME'
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Shell("Explorer.exe fivem://connect/127.0.0.1:30120") 'แก้ไอพีได้ตรงนี้'
        Shell("Explorer.exe ts3server://127.0.0.1") 'แก้ไอพีได้ตรงนี้'
        Form1.Close() 'ปิด Form1'
        Me.Close() 'ปิด Form ปัจจุบัน'
    End Sub
    'ตรงนี้เป็นตัวนับเวลาเมื่อเปิดโปรแกรม'
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True 'อย่ายุ่ง'
    End Sub
    'ตรงนี้แถบแสดงวันที่และเวลา'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dd-MM-yyyy") 'อย่ายุ่ง'
        Label6.Text = Date.Now.ToString("hh:mm:ss tt") 'อย่ายุ่ง'
    End Sub
    'ตรงนี้ปุ่ม DISCORD'
    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Shell("Explorer.exe https://discord.gg/39YvS7e") 'แก้ลิงค์ตรงนนี้'
    End Sub
    'ตรงนี้ปุ่ม FACEBOOK'
    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Shell("Explorer.exe https://www.facebook.com/") 'แก้ลิงค์ตรงนนี้'
    End Sub
    'ตรงนี้ปุ่ม SERVER RULES'
    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Shell("Explorer.exe https://i.pinimg.com/originals/c9/22/68/c92268d92cf2dbf96e3195683d9e14fb.png") 'แก้ลิงค์ตรงนนี้'
    End Sub
    'ตรงนี้ปุ่ม TEAM SPEAK'
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Shell("Explorer.exe https://teamspeak.com/en/downloads/") 'แก้ลิงค์ตรงนนี้'
    End Sub
    'ตรงนี้ปุ่ม PLUGINS'
    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Shell("Explorer.exe https://github.com/Itokoyamato/TokoVOIP_TS3/releases/download/v1.2.5-v1.3.5/tokovoip_1_2_5.ts3_plugin") 'แก้ลิงค์ตรงนนี้'
    End Sub
    'ตรงนี้ปุ่ม UNINSTALL'
    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Shell("control.exe appwiz.cpl") 'จะทำการเปิด Control Panel แล้วไปที่  Programs and Features'
        Form1.Close() 'ปิด Form1'
        Me.Close() 'ปิด Form ปัจจุบัน'
    End Sub
End Class