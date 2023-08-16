Public Class PizzaMenu
    'local variables are to only be used in this form'
    'set to public variables so that it can be used in more than one form'
    'order array name quantity price' 
    Public Order(3, 11) As String
    'included a 0 to make price 2 decimal places, as well consider price precision'
    Dim TRADITIONALPRICE As Decimal = 8.5 & "0"
    Dim GOURMETPRICE As Decimal = TRADITIONALPRICE + 5
    Public Total As Decimal
    Public LineTotal As Decimal
    Public PizzaQuantity As Integer
    Dim Summary As String = "summary"
    Public Sub populatemenu()
        'stores pizza names into array to be used across forms
        'store pizza names - change names below when new pizza is added to menu' 
        'traditional pizzas' 
        Order(0, 0) = "Ham and Cheese"
        Order(0, 1) = "Beef and Onion"
        Order(0, 2) = "Cheesy Garlic"
        Order(0, 3) = "Pepperoni"
        Order(0, 4) = "Vegetarian"
        Order(0, 5) = "Hawaiian"
        Order(0, 6) = "Cheese"
        'Gourmet pizzas'
        Order(0, 7) = "BBQ Chicken"
        Order(0, 8) = "Garlic Prawn"
        Order(0, 9) = "Cheese Steak"
        Order(0, 10) = "Supreme"
        Order(0, 11) = "Margherita"

        'store prices'
        'add prices to array'
        'traditional price range' 
        Dim i As Integer
        For i = 0 To 6
            Order(3, i) = TRADITIONALPRICE
        Next
        'Gourmet price range'
        For i = 7 To 11
            Order(3, i) = GOURMETPRICE
        Next
        'loop to change the text of the placeholder labels to add the pizzas name'
        For i = 1 To 12
            Dim myLabel As Label = CType(Me.Controls("LblPizza" & i), Label)
            myLabel.Text = Order(0, i - 1)
        Next
    End Sub

    Public Sub OrderValue()
        'procedure to be call to refresh/update the variableas pizza quantity changes
        Dim TotalCost As Decimal = 0
        'loop adds up the line costs of each pizza
        For i = 0 To 11
            TotalCost = TotalCost + Val(Order(2, i))
        Next
        'displays delivery fee if the requirements are met from the previous form'
        If CustomerDetails.DeliveryFee = 3 Then
            TotalCost = TotalCost + CustomerDetails.DeliveryFee
        End If
        'display total'
        lblFinalTotal.Text = TotalCost.ToString("C")
        Total = lblFinalTotal.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza1.SelectedIndexChanged
        'finds the value selected in the combobox for quantity'
        PizzaQuantity = Val(cboPizza1.Text)
        'multiply by the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        lblPizzaTotal1.Text = LineTotal.ToString("C")
        'pass the values back to the order array
        'this is for the quantity
        Order(1, 0) = PizzaQuantity
        'this is for the price
        Order(2, 0) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza2.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza2.Text)
        'multiply the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency 
        Lblpizzatotal2.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 1) = PizzaQuantity
        'display for the price'
        Order(2, 1) = LineTotal
        'recalculate order value'
        Call OrderValue()
    End Sub

    Private Sub Cbopizza3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza3.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza3.Text)
        'multiply the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal3.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 2) = PizzaQuantity
        'display for the price'
        Order(2, 2) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza4.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza4.Text)
        'multiply the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal4.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 3) = PizzaQuantity
        'display for the price'
        Order(2, 3) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza5.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza5.Text)
        'multiply the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal5.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 4) = PizzaQuantity
        'display for the price'
        Order(2, 4) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza6.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza6.Text)
        'multiply the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal6.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 5) = PizzaQuantity
        'display for the price'
        Order(2, 5) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza7.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza7.Text)
        'multiply the price to find the line total
        LineTotal = TRADITIONALPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal7.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 6) = PizzaQuantity
        'display for the price'
        Order(2, 6) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza8.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza8.Text)
        'multiply the price to find the line total
        LineTotal = GOURMETPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal8.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 7) = PizzaQuantity
        'display for the price'
        Order(2, 7) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza9.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza9.Text)
        'multiply the price to find the line total
        LineTotal = GOURMETPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal9.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 8) = PizzaQuantity
        'display for the price'
        Order(2, 8) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza10.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza10.Text)
        'multiply the price to find the line total
        LineTotal = GOURMETPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal10.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 9) = PizzaQuantity
        'display for the price'
        Order(2, 9) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza11.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza11.Text)
        'multiply the price to find the line total
        LineTotal = GOURMETPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal11.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 10) = PizzaQuantity
        'display for the price'
        Order(2, 10) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub

    Private Sub Cbopizza12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPizza12.SelectedIndexChanged
        'finds the value selected in the combobox for quantity 
        PizzaQuantity = Val(cboPizza12.Text)
        'multiply the price to find the line total
        LineTotal = GOURMETPRICE * PizzaQuantity
        'assign the value to the label and format as currency
        Lblpizzatotal12.Text = LineTotal.ToString("C")
        'pass the values back to the order array'
        'display for the quantity'
        Order(1, 11) = PizzaQuantity
        'display for the price'
        Order(2, 11) = LineTotal
        'recalculate order value
        Call OrderValue()
    End Sub
    Public Sub ordersummary()
        'details for customer description' 
        'if customer chose delivery option'
        If CustomerDetails.DeliveryFee = 3 Then
            'this text will show on order summary at customer description'
            OrderSum.lblCustomerDes.Text = "Order Type: Delivery"
            'along with the information needed for delivery'
            Summary = "Name: " & CustomerDetails.FirstName & " " & CustomerDetails.LastName & vbCrLf & "Phone Number: " & CustomerDetails.PhoneNum & vbCrLf & "Address: " & CustomerDetails.Address & vbCrLf & "Suburb: " & CustomerDetails.Suburb & vbCrLf & "City: " & CustomerDetails.City & vbCrLf & "unit: " & CustomerDetails.Unit & vbCrLf & "postcode: " & CustomerDetails.PostCode
            OrderSum.LblDelFeeInclude.Show()
            'in this label will go all customers details'
            OrderSum.lblOrderDetails.Text = Summary
            'otherwise customer has the option to choose pick up'
        ElseIf CustomerDetails.DeliveryFee = 0 Then
            'this text will show on the order summary form at customer description'
            OrderSum.lblCustomerDes.Text = "Order Type: Pick Up"
            'along with all the information needed for pick up'
            Summary = "Name: " & CustomerDetails.FirstName & " " & CustomerDetails.LastName & vbCrLf & "Phone Number: " & CustomerDetails.PhoneNum
            OrderSum.LblDelFeeInclude.Hide()
            'in this label will go all customer details'
            OrderSum.lblOrderDetails.Text = Summary
        End If
    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        'Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true'
        If Val(Total) <= 3 Then
            'if customer has not selected any pizzas this message will show'
            MsgBox("You have not ordered any pizzas, please order at least one.")
            'Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true'
        ElseIf Val(Total) > 3 Then
            'otherwise form will hide if they have selected the pizzas they want'
            Me.Hide()
            'and order summary form will show'
            OrderSum.Show()
            'this makes sure that pizza order can be inputted, as well allows user to reset/change their order'
            OrderSum.lblPizzaAll.Text = ""
            OrderSum.lblQuantityAll.Text = ""
            OrderSum.lblAmountAll.Text = ""
            'calls procedure to run to the summary'
            Call ordersummary()
        End If
        'initialise p as an integer'
        Dim p As Integer
        For p = 0 To 11
            If Order(1, p) = 0 Then
                'statement that directs to a specified branch of the procedure' 
                GoTo ptotal
            End If
            'The value of the expression to the right of the operator is added to the value of the variable to the left of the operator'
            'menu information will push onto the summary form' 
            'pizza names needs to be converted to string as it is text'
            OrderSum.lblPizzaAll.Text += Order(0, p).ToString & vbCrLf
            'shows quantity of pizzas selected on pizza menu on summary form'
            OrderSum.lblQuantityAll.Text += Order(1, p) & vbCrLf
            'shows the amount of pizzas selected on pizza menu on summary form'
            OrderSum.lblAmountAll.Text += Order(2, p) & vbCrLf
            'GoTo statement directed to ptotal' 
ptotal:
        Next p
        'therefore will display the total price to complete the summary order'
        OrderSum.lblFinalTotal.Text = "$" & Total
    End Sub

    Private Sub Btnreturn_Click(sender As Object, e As EventArgs) Handles Btnreturn.Click
        'hides menu form'
        Me.Hide()
        'returns to previous form' 
        CustomerDetails.Show()
    End Sub
End Class