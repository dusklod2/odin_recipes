<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPcBuilder = New Button()
        Panel1 = New Panel()
        btnCart = New Button()
        btnCustomer = New Button()
        Panel2 = New Panel()
        Label8 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Motherboard = New Label()
        btnCalcBuild = New Button()
        cmbMotherboard = New ComboBox()
        lstDispaly = New ListBox()
        cmbStorage = New ComboBox()
        cmbRAM = New ComboBox()
        cmbCPU = New ComboBox()
        Panel4 = New Panel()
        lstCheckOut = New ListBox()
        Label10 = New Label()
        btnCheckOut = New Button()
        Panel3 = New Panel()
        Label9 = New Label()
        lblCustNo = New Label()
        Label7 = New Label()
        txtPhoneNumber = New TextBox()
        txtSurname = New TextBox()
        txtName = New TextBox()
        btnInput = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label11 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPcBuilder
        ' 
        btnPcBuilder.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        btnPcBuilder.FlatStyle = FlatStyle.Popup
        btnPcBuilder.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        btnPcBuilder.Location = New Point(46, 145)
        btnPcBuilder.Name = "btnPcBuilder"
        btnPcBuilder.Size = New Size(112, 47)
        btnPcBuilder.TabIndex = 0
        btnPcBuilder.Text = "Build PC"
        btnPcBuilder.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(20), CByte(19), CByte(43))
        Panel1.Controls.Add(btnCart)
        Panel1.Controls.Add(btnPcBuilder)
        Panel1.Controls.Add(btnCustomer)
        Panel1.Location = New Point(29, 144)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(209, 358)
        Panel1.TabIndex = 4
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        btnCart.FlatStyle = FlatStyle.Popup
        btnCart.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        btnCart.Location = New Point(46, 216)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(112, 47)
        btnCart.TabIndex = 2
        btnCart.Text = "Cart"
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnCustomer
        ' 
        btnCustomer.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        btnCustomer.FlatStyle = FlatStyle.Popup
        btnCustomer.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        btnCustomer.Location = New Point(46, 78)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Size = New Size(112, 47)
        btnCustomer.TabIndex = 1
        btnCustomer.Text = "Customer Details"
        btnCustomer.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(20), CByte(19), CByte(43))
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Motherboard)
        Panel2.Controls.Add(btnCalcBuild)
        Panel2.Controls.Add(cmbMotherboard)
        Panel2.Controls.Add(lstDispaly)
        Panel2.Controls.Add(cmbStorage)
        Panel2.Controls.Add(cmbRAM)
        Panel2.Controls.Add(cmbCPU)
        Panel2.Location = New Point(332, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(636, 481)
        Panel2.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(233, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(182, 34)
        Label8.TabIndex = 15
        Label8.Text = "Build Your PC"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 25)
        Label3.TabIndex = 14
        Label3.Text = "Storage"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 25)
        Label2.TabIndex = 13
        Label2.Text = "RAM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 25)
        Label1.TabIndex = 12
        Label1.Text = "CPU"
        ' 
        ' Motherboard
        ' 
        Motherboard.AutoSize = True
        Motherboard.Location = New Point(53, 130)
        Motherboard.Name = "Motherboard"
        Motherboard.Size = New Size(118, 25)
        Motherboard.TabIndex = 11
        Motherboard.Text = "Motherboard"
        ' 
        ' btnCalcBuild
        ' 
        btnCalcBuild.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        btnCalcBuild.FlatStyle = FlatStyle.Popup
        btnCalcBuild.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        btnCalcBuild.Location = New Point(532, 357)
        btnCalcBuild.Name = "btnCalcBuild"
        btnCalcBuild.Size = New Size(66, 38)
        btnCalcBuild.TabIndex = 10
        btnCalcBuild.Text = "Build"
        btnCalcBuild.UseVisualStyleBackColor = False
        ' 
        ' cmbMotherboard
        ' 
        cmbMotherboard.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        cmbMotherboard.FlatStyle = FlatStyle.Popup
        cmbMotherboard.FormattingEnabled = True
        cmbMotherboard.Items.AddRange(New Object() {"ASUS ROG Strix Z390-E Gaming", "MSI MPG B550 GAMING PLUS", "Gigabyte B450 AORUS ELITE"})
        cmbMotherboard.Location = New Point(218, 127)
        cmbMotherboard.Name = "cmbMotherboard"
        cmbMotherboard.Size = New Size(337, 33)
        cmbMotherboard.TabIndex = 4
        ' 
        ' lstDispaly
        ' 
        lstDispaly.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        lstDispaly.BorderStyle = BorderStyle.FixedSingle
        lstDispaly.FormattingEnabled = True
        lstDispaly.ItemHeight = 25
        lstDispaly.Location = New Point(53, 294)
        lstDispaly.Name = "lstDispaly"
        lstDispaly.Size = New Size(473, 152)
        lstDispaly.TabIndex = 3
        ' 
        ' cmbStorage
        ' 
        cmbStorage.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        cmbStorage.FlatStyle = FlatStyle.Popup
        cmbStorage.FormattingEnabled = True
        cmbStorage.Items.AddRange(New Object() {"Samsung 970 EVO Plus 1TB NVMe SSD", "Western Digital Blue 2TB SATA SSD", "Seagate Barracuda 4TB HDD"})
        cmbStorage.Location = New Point(218, 244)
        cmbStorage.Name = "cmbStorage"
        cmbStorage.Size = New Size(337, 33)
        cmbStorage.TabIndex = 2
        ' 
        ' cmbRAM
        ' 
        cmbRAM.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        cmbRAM.FlatStyle = FlatStyle.Popup
        cmbRAM.FormattingEnabled = True
        cmbRAM.Items.AddRange(New Object() {"Corsair Vengeance LPX 16GB (2x8GB) DDR4 3200MHz", "G.Skill Ripjaws V Series 32GB (2 x 16GB) DDR4 3600MHz", "Crucial Ballistix RGB 32GB (2 x 16GB) DDR4 3200MHz"""})
        cmbRAM.Location = New Point(218, 205)
        cmbRAM.Name = "cmbRAM"
        cmbRAM.Size = New Size(337, 33)
        cmbRAM.TabIndex = 1
        ' 
        ' cmbCPU
        ' 
        cmbCPU.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        cmbCPU.FlatStyle = FlatStyle.Popup
        cmbCPU.FormattingEnabled = True
        cmbCPU.Items.AddRange(New Object() {"Intel Core i9-9900K", "AMD Ryzen 7 5800X", "Intel Core i5-11600K"})
        cmbCPU.Location = New Point(218, 166)
        cmbCPU.Name = "cmbCPU"
        cmbCPU.Size = New Size(337, 33)
        cmbCPU.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(20), CByte(19), CByte(43))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(lstCheckOut)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(btnCheckOut)
        Panel4.Location = New Point(332, 85)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(636, 481)
        Panel4.TabIndex = 17
        ' 
        ' lstCheckOut
        ' 
        lstCheckOut.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        lstCheckOut.BorderStyle = BorderStyle.FixedSingle
        lstCheckOut.FormattingEnabled = True
        lstCheckOut.ItemHeight = 25
        lstCheckOut.Location = New Point(127, 106)
        lstCheckOut.Name = "lstCheckOut"
        lstCheckOut.Size = New Size(405, 227)
        lstCheckOut.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(245, 36)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 34)
        Label10.TabIndex = 16
        Label10.Text = "CheckOut"
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        btnCheckOut.FlatStyle = FlatStyle.Popup
        btnCheckOut.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        btnCheckOut.Location = New Point(259, 358)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(121, 58)
        btnCheckOut.TabIndex = 4
        btnCheckOut.Text = "CheckOut"
        btnCheckOut.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(20), CByte(19), CByte(43))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lblCustNo)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(txtPhoneNumber)
        Panel3.Controls.Add(txtSurname)
        Panel3.Controls.Add(txtName)
        Panel3.Controls.Add(btnInput)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(332, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(636, 481)
        Panel3.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(150, 29)
        Label9.Name = "Label9"
        Label9.Size = New Size(301, 34)
        Label9.TabIndex = 16
        Label9.Text = "Enter Customer Details"
        ' 
        ' lblCustNo
        ' 
        lblCustNo.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        lblCustNo.BorderStyle = BorderStyle.FixedSingle
        lblCustNo.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        lblCustNo.ImageAlign = ContentAlignment.BottomRight
        lblCustNo.Location = New Point(293, 288)
        lblCustNo.Name = "lblCustNo"
        lblCustNo.Size = New Size(158, 33)
        lblCustNo.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(138, 289)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 25)
        Label7.TabIndex = 8
        Label7.Text = "Customer No"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        txtPhoneNumber.Location = New Point(294, 202)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(150, 31)
        txtPhoneNumber.TabIndex = 7
        ' 
        ' txtSurname
        ' 
        txtSurname.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        txtSurname.BorderStyle = BorderStyle.FixedSingle
        txtSurname.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        txtSurname.Location = New Point(294, 163)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(150, 31)
        txtSurname.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        txtName.Location = New Point(294, 126)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 5
        ' 
        ' btnInput
        ' 
        btnInput.BackColor = Color.FromArgb(CByte(164), CByte(160), CByte(217))
        btnInput.FlatStyle = FlatStyle.Popup
        btnInput.ForeColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        btnInput.Location = New Point(259, 358)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(121, 58)
        btnInput.TabIndex = 4
        btnInput.Text = "Input" & vbCrLf & "Customer"
        btnInput.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(161, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 25)
        Label6.TabIndex = 2
        Label6.Text = "PhoneNumber"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(161, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 1
        Label5.Text = "SurName"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(161, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 25)
        Label4.TabIndex = 0
        Label4.Text = "Name"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(239, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(254, 38)
        Label11.TabIndex = 18
        Label11.Text = "PC Tech Haven"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(7), CByte(33))
        ClientSize = New Size(1027, 587)
        Controls.Add(Label11)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(235), CByte(233), CByte(250))
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPcBuilder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCart As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbRAM As ComboBox
    Friend WithEvents cmbCPU As ComboBox
    Friend WithEvents lstDispaly As ListBox
    Friend WithEvents cmbStorage As ComboBox
    Friend WithEvents cmbMotherboard As ComboBox
    Friend WithEvents btnCalcBuild As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Motherboard As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCustNo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents lstCheckOut As ListBox
    Friend WithEvents Label11 As Label

End Class
