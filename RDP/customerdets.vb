Public Class CustomerDetails
    'local variables are to only be used in this form'
    'set to public variables so that it can be used in more than one form'
    Public FirstName As String
    Public LastName As String
    Public Unit As String
    Public PostCode As String
    Public Address As String
    Public City As String
    Public Suburb As String
    Public PhoneNum As String = ""
    Dim Delivery As String
    Public DELIVERYFEE As Decimal = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hides these labels on form'
        'these labels are hidden because customer has not selected delivery' 
        lblAddress.Hide()
        lblSuburb.Hide()
        lblCity.Hide()
        lblRotorua.Hide()
        lblUnit.Hide()
        lblPostCode.Hide()
        lblOpt.Hide()
        lblOptional.Hide()
        lblDeliveryFee.Hide()
        txtAddress.Hide()
        txtSuburb.Hide()
        txtPostCode.Hide()
        txtUnit.Hide()
    End Sub

    Private Sub Copickordel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPickOrDel.SelectedIndexChanged
        Delivery = cboPickOrDel.Text
        'check to see if delivery option selected, if Yes display fee else hide fee'
        If Delivery = "Deliver" Then
            lblDeliveryFee.Show() 'shows delivery fee' 
            DELIVERYFEE = 3 'sets delivery fee as 3 to be added to the total cost 
            'shows all necessary textboxes to show'
            lblAddress.Show()
            lblSuburb.Show()
            lblCity.Show()
            lblRotorua.Show()
            lblUnit.Show()
            lblPostCode.Show()
            lblOptional.Show()
            lblOpt.Show()
            PizzaMenu.LblDelFeeInclude.Show()
            txtAddress.Show()
            txtSuburb.Show()
            txtPostCode.Show()
            txtUnit.Show()
        Else
            lblDeliveryFee.Hide() 'hides delivery fee'
            DELIVERYFEE = 0 'sets delivery fee as 0 to be added to the total cost'
            'shows all necessary textboxes to show'
            lblAddress.Hide()
            lblSuburb.Hide()
            lblCity.Hide()
            lblRotorua.Hide()
            lblUnit.Hide()
            lblPostCode.Hide()
            lblOpt.Hide()
            lblOptional.Hide()
            PizzaMenu.LblDelFeeInclude.Hide()
            txtAddress.Hide()
            txtSuburb.Hide()
            txtPostCode.Hide()
            txtUnit.Hide()
        End If
    End Sub

    Private Sub Btnconfirm_Click(sender As Object, e As EventArgs) Handles Btnconfirm.Click
        Dim DataError As Boolean = 0
        'checks required sections are entered'
        'makes sure firstname and lastname <> Required'
        'will not allow text of firstname and lastname to be empty spaces.' 
        If txtFirstName.Text = "Required" Or txtFirstName.Text.Trim.Length = 0 Then DataError = 1
        If txtLastName.Text = "Required" Or txtLastName.Text.Trim.Length = 0 Then DataError = 1
        'makes sure phone number entered'
        PhoneNum = txtPhoneNum.Text
        PhoneNum = PhoneNum.Remove(0, 1)  'Remove first bracket for better look'
        PhoneNum = PhoneNum.Remove(3, 2)  'Remove second bracket and space for better look'
        PhoneNum = PhoneNum.Remove(6, 1)  'Remove - for better look' 
        'checks if greater than 0 and convert remaining text to number'  
        'phone number to be minimum of 7 digits' 
        'otherwise error will display'
        If Val(PhoneNum.Length) < 7 Then DataError = 1 And
            MsgBox("Please enter a valid phone number of 7 digits")
        'performs a function or displays information'
        If DELIVERYFEE = 3 Then
            'or statement to perform a logical disjunction on two Boolean expressions'
            'if label is empty or inccorect, program will not continue' 
            'address and suburb cannot be empty spaces' 
            If txtAddress.Text.Trim.Length = 0 Or txtSuburb.Text.Trim.Length = 0 Or lblRotorua.Text = "" Then DataError = 1 'all information needed need to be obtained to continue'
        End If
        'if label or textbox is empty or unchanged, program will not continue'
        'all information required need to be obtained to continue'
        If txtFirstName.Text = "Required" Or txtFirstName.Text = "" Then DataError = 1
        If Val(PhoneNum) <= 0 Then DataError = 1
        If Delivery = "" Then DataError = 1
        'checks no errors' 
        If DataError = 0 Then
            'if there are no error to the assigned variables then pizza menu will display' 
            FirstName = txtFirstName.Text
            LastName = txtLastName.Text
            Address = txtAddress.Text
            Suburb = txtSuburb.Text
            City = lblRotorua.Text
            Unit = txtUnit.Text
            PostCode = txtPostCode.Text
            'hides form and shows the next form'
            Me.Hide()
            'continues onto next form and proceeds to show pizza menu' 
            PizzaMenu.Show()
            'statements of the called subroutine are executed'
            Call PizzaMenu.populatemenu()
            Call PizzaMenu.OrderValue()
        Else
            'this message will appear when data required have been left out' 
            MsgBox("Required Data Not Entered")
        End If
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        'restarts the program and clears all data before' 
        Application.Restart()   'reset program clearing variables and textbox. 
    End Sub

    Private Sub Btncreds_Click(sender As Object, e As EventArgs) Handles btncreds.Click
        'shows credit form'
        'credits form shows who this code is made by' 
        frmCredits.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'terminates and ends the program' 
        End
    End Sub
End Class
