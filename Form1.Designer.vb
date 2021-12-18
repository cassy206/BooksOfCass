<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHardAdult = New System.Windows.Forms.Label()
        Me.lblPaperAdult = New System.Windows.Forms.Label()
        Me.lblHardYA = New System.Windows.Forms.Label()
        Me.lblPaperYA = New System.Windows.Forms.Label()
        Me.lblManga = New System.Windows.Forms.Label()
        Me.txtHardAdult = New System.Windows.Forms.TextBox()
        Me.txtPaperAdult = New System.Windows.Forms.TextBox()
        Me.txtHardYA = New System.Windows.Forms.TextBox()
        Me.txtPaperYA = New System.Windows.Forms.TextBox()
        Me.txtManga = New System.Windows.Forms.TextBox()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.btnFinalTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtShipping = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.txtRead = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(322, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(133, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "BooksOfCass"
        '
        'lblHardAdult
        '
        Me.lblHardAdult.AutoSize = True
        Me.lblHardAdult.Location = New System.Drawing.Point(23, 143)
        Me.lblHardAdult.Name = "lblHardAdult"
        Me.lblHardAdult.Size = New System.Drawing.Size(203, 20)
        Me.lblHardAdult.TabIndex = 1
        Me.lblHardAdult.Text = "Hardback Adult Books : $5.99"
        '
        'lblPaperAdult
        '
        Me.lblPaperAdult.AutoSize = True
        Me.lblPaperAdult.Location = New System.Drawing.Point(23, 183)
        Me.lblPaperAdult.Name = "lblPaperAdult"
        Me.lblPaperAdult.Size = New System.Drawing.Size(203, 20)
        Me.lblPaperAdult.TabIndex = 2
        Me.lblPaperAdult.Text = "Paperback Adult Books: $3.99"
        '
        'lblHardYA
        '
        Me.lblHardYA.AutoSize = True
        Me.lblHardYA.Location = New System.Drawing.Point(23, 225)
        Me.lblHardYA.Name = "lblHardYA"
        Me.lblHardYA.Size = New System.Drawing.Size(180, 20)
        Me.lblHardYA.TabIndex = 3
        Me.lblHardYA.Text = "YA Hardback Books: $4.99"
        '
        'lblPaperYA
        '
        Me.lblPaperYA.AutoSize = True
        Me.lblPaperYA.Location = New System.Drawing.Point(23, 267)
        Me.lblPaperYA.Name = "lblPaperYA"
        Me.lblPaperYA.Size = New System.Drawing.Size(184, 20)
        Me.lblPaperYA.TabIndex = 4
        Me.lblPaperYA.Text = "YA Paperback Books: $2.99"
        '
        'lblManga
        '
        Me.lblManga.AutoSize = True
        Me.lblManga.Location = New System.Drawing.Point(23, 309)
        Me.lblManga.Name = "lblManga"
        Me.lblManga.Size = New System.Drawing.Size(97, 20)
        Me.lblManga.TabIndex = 5
        Me.lblManga.Text = "Manga: $5.99"
        '
        'txtHardAdult
        '
        Me.txtHardAdult.Location = New System.Drawing.Point(261, 140)
        Me.txtHardAdult.Name = "txtHardAdult"
        Me.txtHardAdult.Size = New System.Drawing.Size(125, 27)
        Me.txtHardAdult.TabIndex = 6
        Me.txtHardAdult.Text = "0"
        '
        'txtPaperAdult
        '
        Me.txtPaperAdult.Location = New System.Drawing.Point(261, 180)
        Me.txtPaperAdult.Name = "txtPaperAdult"
        Me.txtPaperAdult.Size = New System.Drawing.Size(125, 27)
        Me.txtPaperAdult.TabIndex = 7
        Me.txtPaperAdult.Text = "0"
        '
        'txtHardYA
        '
        Me.txtHardYA.Location = New System.Drawing.Point(261, 222)
        Me.txtHardYA.Name = "txtHardYA"
        Me.txtHardYA.Size = New System.Drawing.Size(125, 27)
        Me.txtHardYA.TabIndex = 8
        Me.txtHardYA.Text = "0"
        '
        'txtPaperYA
        '
        Me.txtPaperYA.Location = New System.Drawing.Point(261, 264)
        Me.txtPaperYA.Name = "txtPaperYA"
        Me.txtPaperYA.Size = New System.Drawing.Size(125, 27)
        Me.txtPaperYA.TabIndex = 9
        Me.txtPaperYA.Text = "0"
        '
        'txtManga
        '
        Me.txtManga.Location = New System.Drawing.Point(261, 306)
        Me.txtManga.Name = "txtManga"
        Me.txtManga.Size = New System.Drawing.Size(125, 27)
        Me.txtManga.TabIndex = 10
        Me.txtManga.Text = "0"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(424, 183)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(110, 20)
        Me.lblShipping.TabIndex = 11
        Me.lblShipping.Text = "Shipping: $5.99"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(424, 225)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(106, 20)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.Text = "Discount: 25% "
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(424, 267)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(99, 20)
        Me.lblTax.TabIndex = 13
        Me.lblTax.Text = "WA Tax: 8.6 %"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(424, 309)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(91, 20)
        Me.lblFinalTotal.TabIndex = 14
        Me.lblFinalTotal.Text = "Order Total: "
        '
        'btnFinalTotal
        '
        Me.btnFinalTotal.Location = New System.Drawing.Point(411, 101)
        Me.btnFinalTotal.Name = "btnFinalTotal"
        Me.btnFinalTotal.Size = New System.Drawing.Size(94, 29)
        Me.btnFinalTotal.TabIndex = 15
        Me.btnFinalTotal.Text = "Final Total"
        Me.btnFinalTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(557, 100)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(694, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(424, 147)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(72, 20)
        Me.lblSubtotal.TabIndex = 18
        Me.lblSubtotal.Text = "Subtotal: "
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(597, 140)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(125, 27)
        Me.txtSubtotal.TabIndex = 19
        '
        'txtShipping
        '
        Me.txtShipping.Location = New System.Drawing.Point(597, 180)
        Me.txtShipping.Name = "txtShipping"
        Me.txtShipping.Size = New System.Drawing.Size(125, 27)
        Me.txtShipping.TabIndex = 20
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(597, 222)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(125, 27)
        Me.txtDiscount.TabIndex = 21
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(597, 264)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(125, 27)
        Me.txtTax.TabIndex = 22
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Location = New System.Drawing.Point(597, 306)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Size = New System.Drawing.Size(125, 27)
        Me.txtFinalTotal.TabIndex = 23
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(68, 367)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(235, 29)
        Me.btnWrite.TabIndex = 24
        Me.btnWrite.Text = "Write Items to File"
        Me.btnWrite.UseVisualStyleBackColor = True
        Me.btnWrite.Visible = False
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(471, 367)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(193, 29)
        Me.btnRead.TabIndex = 25
        Me.btnRead.Text = "Read Items From File"
        Me.btnRead.UseVisualStyleBackColor = True
        Me.btnRead.Visible = False
        '
        'txtRead
        '
        Me.txtRead.Location = New System.Drawing.Point(37, 402)
        Me.txtRead.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtRead.Multiline = True
        Me.txtRead.Name = "txtRead"
        Me.txtRead.ReadOnly = True
        Me.txtRead.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRead.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRead.Size = New System.Drawing.Size(713, 201)
        Me.txtRead.TabIndex = 26
        Me.txtRead.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.Controls.Add(Me.txtRead)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.txtFinalTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtShipping)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFinalTotal)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.txtManga)
        Me.Controls.Add(Me.txtPaperYA)
        Me.Controls.Add(Me.txtHardYA)
        Me.Controls.Add(Me.txtPaperAdult)
        Me.Controls.Add(Me.txtHardAdult)
        Me.Controls.Add(Me.lblManga)
        Me.Controls.Add(Me.lblPaperYA)
        Me.Controls.Add(Me.lblHardYA)
        Me.Controls.Add(Me.lblPaperAdult)
        Me.Controls.Add(Me.lblHardAdult)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHardAdult As Label
    Friend WithEvents lblPaperAdult As Label
    Friend WithEvents lblHardYA As Label
    Friend WithEvents lblPaperYA As Label
    Friend WithEvents lblManga As Label
    Friend WithEvents txtHardAdult As TextBox
    Friend WithEvents txtPaperAdult As TextBox
    Friend WithEvents txtHardYA As TextBox
    Friend WithEvents txtPaperYA As TextBox
    Friend WithEvents txtManga As TextBox
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents btnFinalTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtShipping As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtFinalTotal As TextBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtRead As TextBox
End Class
