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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName_Tax = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.btnCalculateTax = New System.Windows.Forms.Button()
        Me.btnClearInput = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Your First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter Your Income"
        '
        'lblName_Tax
        '
        Me.lblName_Tax.AutoSize = True
        Me.lblName_Tax.BackColor = System.Drawing.Color.OldLace
        Me.lblName_Tax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName_Tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName_Tax.Location = New System.Drawing.Point(170, 341)
        Me.lblName_Tax.Name = "lblName_Tax"
        Me.lblName_Tax.Size = New System.Drawing.Size(475, 24)
        Me.lblName_Tax.TabIndex = 1
        Me.lblName_Tax.Text = "Your Name and Tax Amount Will Be Displayed Here"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(551, 80)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(176, 26)
        Me.txtFirst.TabIndex = 2
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(548, 172)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(179, 26)
        Me.txtLast.TabIndex = 3
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(547, 252)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(180, 26)
        Me.txtIncome.TabIndex = 4
        '
        'btnCalculateTax
        '
        Me.btnCalculateTax.BackColor = System.Drawing.Color.Tan
        Me.btnCalculateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateTax.Location = New System.Drawing.Point(170, 443)
        Me.btnCalculateTax.Name = "btnCalculateTax"
        Me.btnCalculateTax.Size = New System.Drawing.Size(159, 53)
        Me.btnCalculateTax.TabIndex = 5
        Me.btnCalculateTax.Text = "Calculate Tax"
        Me.btnCalculateTax.UseVisualStyleBackColor = False
        '
        'btnClearInput
        '
        Me.btnClearInput.BackColor = System.Drawing.Color.Tan
        Me.btnClearInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearInput.Location = New System.Drawing.Point(361, 443)
        Me.btnClearInput.Name = "btnClearInput"
        Me.btnClearInput.Size = New System.Drawing.Size(159, 53)
        Me.btnClearInput.TabIndex = 5
        Me.btnClearInput.Text = "Clear Input"
        Me.btnClearInput.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Tan
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(547, 443)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 53)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 527)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearInput)
        Me.Controls.Add(Me.btnCalculateTax)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblName_Tax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Marki Alvarez - Assignment 3 - Tax Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName_Tax As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents btnCalculateTax As Button
    Friend WithEvents btnClearInput As Button
    Friend WithEvents btnExit As Button
End Class
