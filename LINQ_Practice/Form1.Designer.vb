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
        Me.buttonClick = New System.Windows.Forms.Button()
        Me.labelOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonClick
        '
        Me.buttonClick.Location = New System.Drawing.Point(300, 74)
        Me.buttonClick.Name = "buttonClick"
        Me.buttonClick.Size = New System.Drawing.Size(75, 23)
        Me.buttonClick.TabIndex = 0
        Me.buttonClick.Text = "Click"
        Me.buttonClick.UseVisualStyleBackColor = True
        '
        'labelOutput
        '
        Me.labelOutput.AutoSize = True
        Me.labelOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOutput.ForeColor = System.Drawing.Color.Red
        Me.labelOutput.Location = New System.Drawing.Point(122, 150)
        Me.labelOutput.Name = "labelOutput"
        Me.labelOutput.Size = New System.Drawing.Size(83, 25)
        Me.labelOutput.TabIndex = 1
        Me.labelOutput.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelOutput)
        Me.Controls.Add(Me.buttonClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonClick As Button
    Friend WithEvents labelOutput As Label
End Class
