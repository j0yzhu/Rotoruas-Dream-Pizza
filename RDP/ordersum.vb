Public Class OrderSum
    Private Sub Btnreturn_Click(sender As Object, e As EventArgs) Handles Btnreturn.Click
        'hides order summary form'
        Me.Hide()
        'returns to menu form'
        PizzaMenu.Show()
    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        'function to restart the program after customer has completed order 
        Application.Restart()
    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        'restarts the program'
        'takes customer back to Customer Details form to start next order' 
        Application.Restart()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Terminates execution immediately, to stop it from running'
        End
    End Sub
End Class