Public Class frmCredits
    Private Sub Btnreturn_Click(sender As Object, e As EventArgs) Handles Btnreturn.Click
        'hides credit form'
        Me.Hide()
        'returns to customer detail form' 
        CustomerDetails.Show()
    End Sub
End Class