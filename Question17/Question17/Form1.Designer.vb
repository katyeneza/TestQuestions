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
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.txtNumberTickets = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(186, 63)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(85, 42)
        Me.btnPurchase.TabIndex = 0
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'txtNumberTickets
        '
        Me.txtNumberTickets.Location = New System.Drawing.Point(12, 63)
        Me.txtNumberTickets.Name = "txtNumberTickets"
        Me.txtNumberTickets.Size = New System.Drawing.Size(87, 20)
        Me.txtNumberTickets.TabIndex = 1
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 24)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(259, 26)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Each ticket is $8.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Purchase tickets by entering number of tickets in box." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtNumberTickets)
        Me.Controls.Add(Me.btnPurchase)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents txtNumberTickets As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label

End Class
