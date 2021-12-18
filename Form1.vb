'Cassandra Mendoza
'41726991
'I pledge that I have neither given nor received help from anyone other than the instructor and TA 
'For all program components included her


Imports System.IO
Public Class Form1

    'Constants of values of books 
    Const dblHardAdult As Double = 5.99
    Const dblPaperAdult As Double = 3.99
    Const dblHardYA As Double = 4.99
    Const dblPaperYA As Double = 2.99
    Const dblManga As Double = 5.99
    Const dblDiscount As Decimal = 0.25

    'Other Constants
    Const dblShipping As Double = 5.99
    Const decTax As Decimal = 0.086

    'User input for # of each item 
    Dim intHardAdult As Integer
    Dim intPaperAdult As Integer
    Dim intHardYA As Integer
    Dim intPaperYA As Integer
    Dim intManga As Integer

    'other Conventions 
    Dim dblSubtotal As Double
    Dim intTotalBooks As Integer
    Dim dblTax As Double
    Dim dblFinalTotal As Double
    Dim decDiscount As Decimal
    Dim decShipping As Decimal

    'Write and Read things
    Dim strFileName As String = "order.txt"
    Dim strFileInfo As String = ""
    Dim strMsg As String = ""

    Function SubtotalEquation() As Double

        strFileInfo = "For the following bought items" & vbCrLf

        If (txtHardAdult.Text) > 0 Then
            intHardAdult = CInt(txtHardAdult.Text)
            intTotalBooks += intHardAdult

            strFileInfo &= "HardBack Adult Books: " & intHardAdult

        End If

        If (txtPaperAdult.Text) > 0 Then
            intPaperAdult = CInt(txtHardAdult.Text)
            intTotalBooks += intPaperAdult

            strFileInfo &= "Paperback Adult Books: " & intPaperAdult

        End If

        If (txtHardYA.Text) > 0 Then
            intHardYA = CInt(txtHardYA.Text)
            intTotalBooks += intHardYA

            strFileInfo &= "Hardback YA Books:  " & intHardYA

        End If

        If (txtPaperYA.Text) > 0 Then
            intPaperYA = CInt(txtHardYA.Text)
            intTotalBooks += intPaperYA

            strFileInfo &= " Paperback YA Books: " & intPaperYA

        End If

        If (txtManga.Text) > 0 Then
            intManga = CInt(txtManga.Text)
            intTotalBooks += intManga

            strFileInfo &= "Manga: " & intManga

        End If

        dblSubtotal = (dblHardAdult * intHardAdult) + (dblPaperAdult * intPaperAdult) + (dblHardYA * intHardYA) + (dblPaperYA * intPaperYA) +
        (dblManga * intManga)

        Return dblSubtotal



    End Function

    Function ShippingCharge() As Double

        strFileInfo &= "There is " & vbCrLf

        If SubtotalEquation() = 0 Then
            decShipping = 0

            strFileInfo &= "no Shipping charge"
        End If

        If SubtotalEquation() >= 50 Then
            decShipping = 0

            strFileInfo &= "no Shipping charge"
        End If

        If SubtotalEquation() < 50 Then
            decShipping = dblShipping

            strFileInfo &= "a $5.99 Shipping charge"
        End If
        Return decShipping


    End Function

    Function Discount() As Double
        strFileInfo &= "You have " & vbCrLf

        If intTotalBooks = 0 Then
            decDiscount = 0

            strFileInfo &= "No discount available"
        End If

        If intTotalBooks >= 15 Then
            decDiscount = (dblDiscount * dblSubtotal)

            strFileInfo &= "A 25% discount applied"

        End If

        If intTotalBooks < 15 AndAlso intTotalBooks > 1 Then
            decDiscount = 0

            strFileInfo &= "No discount available"
        End If
        Return decDiscount

    End Function

    Function TaxRate() As Double

        strFileInfo &= "There is" & vbCrLf

        If SubtotalEquation() = 0 Then
            dblTax = 0

            strFileInfo &= "No Tax Charge"
        End If

        If SubtotalEquation() > 0 Then
            dblTax = (dblSubtotal * decTax)

            strFileInfo &= "A Tax Charge of 8.6%"
        End If

        Return dblTax

    End Function

    Function FinalTotal() As Double

        strFileInfo &= "The final Charge for the Order is " & vbCrLf

        dblFinalTotal = dblSubtotal + ShippingCharge() - Discount() + dblTax
        Return dblFinalTotal

        strFileInfo &= dblFinalTotal
    End Function



    Private Sub btnFinalTotal_Click(sender As Object, e As EventArgs) Handles btnFinalTotal.Click
        txtSubtotal.Text = SubtotalEquation().ToString("C")
        txtShipping.Text = ShippingCharge().ToString("C")
        txtDiscount.Text = Discount().ToString("C")
        txtTax.Text = TaxRate().ToString("C")
        txtFinalTotal.Text = FinalTotal().ToString("C")
        btnWrite.Visible = True

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        Dim fileWriter As StreamWriter
        Try
            fileWriter = File.CreateText(strFileName)
            fileWriter.WriteLine(strFileInfo)
            fileWriter.Close()

            MessageBox.Show("The file has been written to file")
            btnRead.Visible = True
            btnWrite.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error : The file cannot be written")
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim fileReader As StreamReader
        Try
            fileReader = File.OpenText(strFileName)
            Dim strLine As String = "Info read from file: " & vbCrLf

            Do Until fileReader.EndOfStream()
                strLine &= fileReader.ReadLine() & vbCrLf

            Loop
            fileReader.Close()
            txtRead.Text = strLine
            txtRead.Visible = True
            btnRead.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error: The file cannot be opened")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHardAdult.Text = 0
        txtPaperAdult.Text = 0
        txtHardYA.Text = 0
        txtPaperYA.Text = 0
        txtManga.Text = 0
        txtSubtotal.Text = ""
        txtShipping.Text = ""
        txtDiscount.Text = ""
        txtTax.Text = ""
        txtFinalTotal.Text = ""

        btnWrite.Visible = False
        btnRead.Visible = False
        txtRead.Text = String.Empty
        txtRead.Visible = False


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
