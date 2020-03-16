Public Class CR
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox31_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox34_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox35_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox36_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub CR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f As TextBox
        Dim i As Integer
        Dim l As Integer = 1
        For i = 1 To 10
            Me.TableLayoutPanel1.Controls.Add(New TextBox)


        Next
        For Each f In TableLayoutPanel1.Controls
            f.Text = "name" & l.ToString()
            f.BackColor = Color.Red

            l += 1
        Next



    End Sub

    Private Sub Label94_Click(sender As Object, e As EventArgs) Handles Label94.Click

    End Sub
End Class