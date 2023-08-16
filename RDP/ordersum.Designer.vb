<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblordersum = New System.Windows.Forms.Label()
        Me.lblOrderDetails = New System.Windows.Forms.Label()
        Me.lblPizzaAll = New System.Windows.Forms.Label()
        Me.Btnconfirm = New System.Windows.Forms.Button()
        Me.Btnreturn = New System.Windows.Forms.Button()
        Me.lblCustomerDes = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.Lbltotalcost = New System.Windows.Forms.Label()
        Me.lblQuantityAll = New System.Windows.Forms.Label()
        Me.lblAmountAll = New System.Windows.Forms.Label()
        Me.lblpizza = New System.Windows.Forms.Label()
        Me.Lblquan = New System.Windows.Forms.Label()
        Me.Lblamount = New System.Windows.Forms.Label()
        Me.Btnrestart = New System.Windows.Forms.Button()
        Me.LblDelFeeInclude = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblordersum
        '
        Me.lblordersum.AutoSize = True
        Me.lblordersum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblordersum.Location = New System.Drawing.Point(214, 9)
        Me.lblordersum.Name = "lblordersum"
        Me.lblordersum.Size = New System.Drawing.Size(379, 55)
        Me.lblordersum.TabIndex = 0
        Me.lblordersum.Text = "Order Summary"
        '
        'lblOrderDetails
        '
        Me.lblOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrderDetails.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDetails.Location = New System.Drawing.Point(42, 115)
        Me.lblOrderDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderDetails.Name = "lblOrderDetails"
        Me.lblOrderDetails.Size = New System.Drawing.Size(706, 242)
        Me.lblOrderDetails.TabIndex = 3
        '
        'lblPizzaAll
        '
        Me.lblPizzaAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPizzaAll.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaAll.Location = New System.Drawing.Point(42, 414)
        Me.lblPizzaAll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPizzaAll.Name = "lblPizzaAll"
        Me.lblPizzaAll.Size = New System.Drawing.Size(282, 419)
        Me.lblPizzaAll.TabIndex = 5
        '
        'Btnconfirm
        '
        Me.Btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconfirm.Location = New System.Drawing.Point(540, 938)
        Me.Btnconfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnconfirm.Name = "Btnconfirm"
        Me.Btnconfirm.Size = New System.Drawing.Size(218, 52)
        Me.Btnconfirm.TabIndex = 102
        Me.Btnconfirm.Text = "Confirm "
        Me.Btnconfirm.UseVisualStyleBackColor = True
        '
        'Btnreturn
        '
        Me.Btnreturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreturn.Location = New System.Drawing.Point(15, 938)
        Me.Btnreturn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnreturn.Name = "Btnreturn"
        Me.Btnreturn.Size = New System.Drawing.Size(218, 52)
        Me.Btnreturn.TabIndex = 191
        Me.Btnreturn.Text = "Return "
        Me.Btnreturn.UseVisualStyleBackColor = True
        '
        'lblCustomerDes
        '
        Me.lblCustomerDes.AutoSize = True
        Me.lblCustomerDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerDes.Location = New System.Drawing.Point(34, 69)
        Me.lblCustomerDes.Name = "lblCustomerDes"
        Me.lblCustomerDes.Size = New System.Drawing.Size(355, 37)
        Me.lblCustomerDes.TabIndex = 192
        Me.lblCustomerDes.Text = "Customer Description "
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalTotal.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.Location = New System.Drawing.Point(612, 852)
        Me.lblFinalTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(146, 38)
        Me.lblFinalTotal.TabIndex = 194
        Me.lblFinalTotal.Text = "$0.00"
        '
        'Lbltotalcost
        '
        Me.Lbltotalcost.AutoSize = True
        Me.Lbltotalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotalcost.Location = New System.Drawing.Point(411, 854)
        Me.Lbltotalcost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltotalcost.Name = "Lbltotalcost"
        Me.Lbltotalcost.Size = New System.Drawing.Size(184, 37)
        Me.Lbltotalcost.TabIndex = 193
        Me.Lbltotalcost.Text = "Total Cost:"
        '
        'lblQuantityAll
        '
        Me.lblQuantityAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantityAll.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityAll.Location = New System.Drawing.Point(322, 414)
        Me.lblQuantityAll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantityAll.Name = "lblQuantityAll"
        Me.lblQuantityAll.Size = New System.Drawing.Size(210, 419)
        Me.lblQuantityAll.TabIndex = 195
        '
        'lblAmountAll
        '
        Me.lblAmountAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountAll.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountAll.Location = New System.Drawing.Point(525, 414)
        Me.lblAmountAll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountAll.Name = "lblAmountAll"
        Me.lblAmountAll.Size = New System.Drawing.Size(232, 419)
        Me.lblAmountAll.TabIndex = 196
        '
        'lblpizza
        '
        Me.lblpizza.AutoSize = True
        Me.lblpizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpizza.Location = New System.Drawing.Point(36, 371)
        Me.lblpizza.Name = "lblpizza"
        Me.lblpizza.Size = New System.Drawing.Size(90, 32)
        Me.lblpizza.TabIndex = 197
        Me.lblpizza.Text = "Pizza"
        '
        'Lblquan
        '
        Me.Lblquan.AutoSize = True
        Me.Lblquan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblquan.Location = New System.Drawing.Point(316, 371)
        Me.Lblquan.Name = "Lblquan"
        Me.Lblquan.Size = New System.Drawing.Size(138, 32)
        Me.Lblquan.TabIndex = 198
        Me.Lblquan.Text = "Quantity "
        '
        'Lblamount
        '
        Me.Lblamount.AutoSize = True
        Me.Lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblamount.Location = New System.Drawing.Point(519, 371)
        Me.Lblamount.Name = "Lblamount"
        Me.Lblamount.Size = New System.Drawing.Size(164, 32)
        Me.Lblamount.TabIndex = 199
        Me.Lblamount.Text = "Amount ($)"
        '
        'Btnrestart
        '
        Me.Btnrestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrestart.Location = New System.Drawing.Point(278, 938)
        Me.Btnrestart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnrestart.Name = "Btnrestart"
        Me.Btnrestart.Size = New System.Drawing.Size(218, 52)
        Me.Btnrestart.TabIndex = 200
        Me.Btnrestart.Text = "Cancel Order"
        Me.Btnrestart.UseVisualStyleBackColor = True
        '
        'LblDelFeeInclude
        '
        Me.LblDelFeeInclude.AutoSize = True
        Me.LblDelFeeInclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDelFeeInclude.Location = New System.Drawing.Point(414, 902)
        Me.LblDelFeeInclude.Name = "LblDelFeeInclude"
        Me.LblDelFeeInclude.Size = New System.Drawing.Size(208, 25)
        Me.LblDelFeeInclude.TabIndex = 201
        Me.LblDelFeeInclude.Text = "*Delivery Fee Included"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(681, 9)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 48)
        Me.btnExit.TabIndex = 202
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'OrderSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 998)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.LblDelFeeInclude)
        Me.Controls.Add(Me.Btnrestart)
        Me.Controls.Add(Me.Lblamount)
        Me.Controls.Add(Me.Lblquan)
        Me.Controls.Add(Me.lblpizza)
        Me.Controls.Add(Me.lblAmountAll)
        Me.Controls.Add(Me.lblQuantityAll)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.Lbltotalcost)
        Me.Controls.Add(Me.lblCustomerDes)
        Me.Controls.Add(Me.Btnreturn)
        Me.Controls.Add(Me.Btnconfirm)
        Me.Controls.Add(Me.lblPizzaAll)
        Me.Controls.Add(Me.lblOrderDetails)
        Me.Controls.Add(Me.lblordersum)
        Me.Name = "OrderSum"
        Me.Text = "OrderSummary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblordersum As Label
    Friend WithEvents lblOrderDetails As Label
    Friend WithEvents lblPizzaAll As Label
    Friend WithEvents Btnconfirm As Button
    Friend WithEvents Btnreturn As Button
    Friend WithEvents lblCustomerDes As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents Lbltotalcost As Label
    Friend WithEvents lblQuantityAll As Label
    Friend WithEvents lblAmountAll As Label
    Friend WithEvents lblpizza As Label
    Friend WithEvents Lblquan As Label
    Friend WithEvents Lblamount As Label
    Friend WithEvents Btnrestart As Button
    Friend WithEvents LblDelFeeInclude As Label
    Friend WithEvents btnExit As Button
End Class
