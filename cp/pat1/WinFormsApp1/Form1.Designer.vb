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
        btnCalcBmi = New Button()
        lblDisplay = New Label()
        txtGender = New TextBox()
        txtAge = New TextBox()
        txtWeight = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtHeight = New TextBox()
        btnClear = New Button()
        btnExtit = New Button()
        SuspendLayout()
        ' 
        ' btnCalcBmi
        ' 
        btnCalcBmi.Location = New Point(98, 347)
        btnCalcBmi.Name = "btnCalcBmi"
        btnCalcBmi.Size = New Size(112, 34)
        btnCalcBmi.TabIndex = 0
        btnCalcBmi.Text = "BMI"
        btnCalcBmi.UseVisualStyleBackColor = True
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BackColor = SystemColors.ButtonHighlight
        lblDisplay.BorderStyle = BorderStyle.FixedSingle
        lblDisplay.Location = New Point(479, 104)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(222, 202)
        lblDisplay.TabIndex = 1
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(173, 99)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(150, 31)
        txtGender.TabIndex = 2
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(173, 155)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(150, 31)
        txtAge.TabIndex = 3
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(173, 214)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(150, 31)
        txtWeight.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 25)
        Label2.TabIndex = 5
        Label2.Text = "gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 25)
        Label3.TabIndex = 6
        Label3.Text = "age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 25)
        Label4.TabIndex = 7
        Label4.Text = "weight"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 25)
        Label5.TabIndex = 9
        Label5.Text = "height"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(173, 268)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(150, 31)
        txtHeight.TabIndex = 8
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(348, 347)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExtit
        ' 
        btnExtit.Location = New Point(589, 347)
        btnExtit.Name = "btnExtit"
        btnExtit.Size = New Size(112, 34)
        btnExtit.TabIndex = 11
        btnExtit.Text = "Exit"
        btnExtit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExtit)
        Controls.Add(btnClear)
        Controls.Add(Label5)
        Controls.Add(txtHeight)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtWeight)
        Controls.Add(txtAge)
        Controls.Add(txtGender)
        Controls.Add(lblDisplay)
        Controls.Add(btnCalcBmi)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalcBmi As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExtit As Button

End Class
