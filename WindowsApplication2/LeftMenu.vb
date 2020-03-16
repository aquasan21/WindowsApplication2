Public Class LeftMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cr3 As New CR

        Cr3.Show()



    End Sub

    Private Sub LeftMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class