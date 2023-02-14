<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFrench = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(51, 83)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(55, 28)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(173, 83)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(55, 28)
        Me.btnThree.TabIndex = 1
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(112, 83)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(55, 28)
        Me.btnTwo.TabIndex = 2
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(234, 83)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(55, 28)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(295, 83)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(55, 28)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(10, 10)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(370, 70)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Do you know the French words for the numbers 1 through 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons belo" &
    "w to see them." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 164)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 28)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFrench
        '
        Me.lblFrench.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblFrench.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFrench.Location = New System.Drawing.Point(173, 123)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(55, 28)
        Me.lblFrench.TabIndex = 7
        Me.lblFrench.Visible = False
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 204)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumbers"
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOne As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFrench As Label
End Class
