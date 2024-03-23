
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim Pc As New PcBuilder
    Dim Cust As New Customer
    Dim customerNo As String
    Dim check As New Calc

    ' Button click event handler for calculating PC build
    Private Sub btnCalcBuild_Click(sender As Object, e As EventArgs) Handles btnCalcBuild.Click
        Pc.Cart()
    End Sub

    ' Button click event handler for accessing PC builder panel
    Private Sub btnPcBuilder_Click(sender As Object, e As EventArgs) Handles btnPcBuilder.Click
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    ' Button click event handler for capturing customer details
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        customerdetails()
    End Sub

    ' Method to capture customer details
    Public Sub customerdetails()
        Try
            customerNo = Cust.CustName.ToString.Substring(2) & Cust.CustSurName.ToString.Substring(2) & Cust.PhoneNumber.ToString.Substring(5)
            lblCustNo.Text = customerNo
            MsgBox("customer details captured")
        Catch ex As Exception
            MsgBox("there was a difficulty processing the customer")
        End Try
    End Sub

    ' Button click event handler for accessing customer panel
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Panel3.Visible = True
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    ' Form load event handler for initializing visibility of panels
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    ' Button click event handler for accessing checkout panel
    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        check.Checkout()
    End Sub

    ' Button click event handler for saving receipt
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        save()
    End Sub

    ' Method to save receipt to file
    Public Sub save()
        Dim FILE_NAME As String = "reciept.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.WriteLine(lstCheckOut.Text)
            objWriter.Close()
            MessageBox.Show("Reciept Printed")
        Else
            MessageBox.Show("File Does Not Exist")
        End If
    End Sub
End Class

Public Class PcBuilder
    Private strMotherboard As String
    Private strCPU As String
    Private strRam As String
    Private strStorage As String

    ' Method to set motherboard based on user selection
    Public Sub SetMotherboard()
        Try
            If Form1.cmbMotherboard.SelectedIndex = 0 Then
                strMotherboard = "ASUS ROG Strix Z390-E Gaming"
            ElseIf Form1.cmbMotherboard.SelectedIndex = 1 Then
                strMotherboard = "MSI MPG B550 GAMING PLUS"
            ElseIf Form1.cmbMotherboard.SelectedIndex = 2 Then
                strMotherboard = "Gigabyte B450 AORUS ELITE"
            End If
            Form1.lstDispaly.Items.Add("Motherboard: " & strMotherboard)
        Catch ex As Exception
            MsgBox("Please choose a motherboard")
            Form1.cmbMotherboard.Focus()
        End Try
    End Sub

    ' Method to set storage based on user selection
    Public Sub SetStorage()
        Try
            If Form1.cmbStorage.SelectedIndex = 0 Then
                strStorage = "Samsung 970 EVO Plus 1TB NVMe SSD"
            ElseIf Form1.cmbStorage.SelectedIndex = 1 Then
                strStorage = "Western Digital Blue 2TB SATA SSD"
            ElseIf Form1.cmbStorage.SelectedIndex = 2 Then
                strStorage = "Seagate Barracuda 4TB HDD"
            End If
            Form1.lstDispaly.Items.Add("Storage: " & strStorage)
        Catch ex As Exception
            MsgBox("Please choose a storage device")
            Form1.cmbMotherboard.Focus()
        End Try
    End Sub

    ' Method to set CPU based on user selection
    Public Sub SetCPU()
        Try
            If Form1.cmbCPU.SelectedIndex = 0 Then
                strCPU = "Intel Core i9-9900K"
            ElseIf Form1.cmbCPU.SelectedIndex = 1 Then
                strCPU = "AMD Ryzen 7 5800X"
            ElseIf Form1.cmbCPU.SelectedIndex = 2 Then
                strCPU = "Intel Core i5-11600K"
            End If
            Form1.lstDispaly.Items.Add("CPU: " & strCPU)
        Catch ex As Exception
            MsgBox("Please choose a CPU")
            Form1.cmbCPU.Focus()
        End Try

    End Sub

    ' Method to set RAM based on user selection
    Public Sub SetRAM()
        Try
            If Form1.cmbRAM.SelectedIndex = 0 Then
                strRam = "Corsair Vengeance LPX 16GB (2x8GB) DDR4 3200MHz"
            ElseIf Form1.cmbRAM.SelectedIndex = 1 Then
                strRam = "G.Skill Ripjaws V Series 32GB (2 x 16GB) DDR4 3600MHz"
            ElseIf Form1.cmbRAM.SelectedIndex = 2 Then
                strRam = "Crucial Ballistix RGB 32GB (2 x 16GB) DDR4 3200MHz"
            End If
            Form1.lstDispaly.Items.Add("You have chosen: " & strRam)
        Catch ex As Exception
            MsgBox("Please choose a RAM")
            Form1.cmbRAM.Focus()
        End Try


    End Sub

    Public Sub Cart()

        ' Add selected components to display list
        Form1.lstDispaly.Items.Add("You have chosen: ")
        SetMotherboard()
        SetCPU()
        SetRAM()
        SetStorage()

    End Sub

    ' Read-only property for storage
    Public ReadOnly Property storage As String
        Get
            Return strStorage
        End Get
    End Property
End Class

Public Class Customer
    Private strCustName As String
    Private strCustSurname As String
    Private intPhoneNo As Integer

    ' Property for customer name
    Public Property CustName As String
        Set(value As String)
            Form1.txtName.Text = strCustName
            strCustName = value
        End Set
        Get
            Return strCustName
        End Get
    End Property

    ' Property for customer surname
    Public Property CustSurName As String
        Set(value As String)
            Form1.txtSurname.Text = strCustSurname
            strCustSurname = value
        End Set
        Get
            Return strCustSurname
        End Get
    End Property

    ' Property for customer phone number
    Public Property PhoneNumber As Integer
        Set(value As Integer)
            If Form1.txtName.Text < 10 Then
                MsgBox("length of Phone number is too short")
                Exit Property
            ElseIf Form1.txtName.Text > 10 Then
                MsgBox("length of Phone number is too long")
                Exit Property
            Else
                Form1.txtName.Text = intPhoneNo
            End If
            intPhoneNo = value
        End Set
        Get
            Return intPhoneNo
        End Get
    End Property
End Class

Public Class Calc
    Dim Cust As New Customer
    Private intSubtotal As Integer
    Private intMotherboard As Integer
    Private intCPU As Integer
    Private intRam As Integer
    Private intStorage As Integer



    ' Method to calculate total cost of components
    Public Sub Checkout()
        If Form1.cmbMotherboard.SelectedIndex = 0 Then
            intMotherboard = 500
        ElseIf Form1.cmbMotherboard.SelectedIndex = 1 Then
            intMotherboard = 750
        ElseIf Form1.cmbMotherboard.SelectedIndex = 2 Then
            intMotherboard = 1050
        End If

        If Form1.cmbStorage.SelectedIndex = 0 Then
            intStorage = 600
        ElseIf Form1.cmbStorage.SelectedIndex = 1 Then
            intStorage = 700
        ElseIf Form1.cmbStorage.SelectedIndex = 2 Then
            intStorage = 800
        End If

        If Form1.cmbCPU.SelectedIndex = 0 Then
            intCPU = 500
        ElseIf Form1.cmbCPU.SelectedIndex = 1 Then
            intCPU = 800
        ElseIf Form1.cmbCPU.SelectedIndex = 2 Then
            intCPU = 1200
        End If

        If Form1.cmbRAM.SelectedIndex = 0 Then
            intRam = 250
        ElseIf Form1.cmbRAM.SelectedIndex = 1 Then
            intRam = 400
        ElseIf Form1.cmbRAM.SelectedIndex = 2 Then
            intRam = 550
        End If

        intSubtotal = intRam + intCPU + intStorage + intMotherboard
        Form1.lstCheckOut.Items.Clear()
        Form1.lstCheckOut.Items.Add("INVOICE FOR: " & Cust.CustName & Cust.CustSurName)
        Form1.lstCheckOut.Items.Add("_____________________________________________")
        Form1.lstCheckOut.Items.Add("Storage:" & vbTab & vbTab & FormatCurrency(intStorage))
        Form1.lstCheckOut.Items.Add("CPU:" & vbTab & vbTab & FormatCurrency(intCPU))
        Form1.lstCheckOut.Items.Add("Motherboard:" & vbTab & vbTab & FormatCurrency(intMotherboard))
        Form1.lstCheckOut.Items.Add("RAM:" & vbTab & vbTab & FormatCurrency(intRam))
        Form1.lstCheckOut.Items.Add("Subtotal:" & vbTab & vbTab & FormatCurrency(intSubtotal))
    End Sub
End Class
