Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.Salmon Then
            MyBase.BackColor = Color.Aqua
        Else : MyBase.BackColor = Color.Salmon
        End If
    End Sub
End Class
