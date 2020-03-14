Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        Dim frm2 As New Login
        frm2.Show()
        frm2.MdiParent = Me

    End Sub
End Class
