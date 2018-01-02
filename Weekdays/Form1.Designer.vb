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
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 16
        Me.lstResult.Location = New System.Drawing.Point(12, 29)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(214, 180)
        Me.lstResult.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(57, 256)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(206, 256)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(244, 25)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(334, 23)
        Me.lblTotal.TabIndex = 4
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(247, 78)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(331, 23)
        Me.lblAverage.TabIndex = 5
        '
        'lblMaximum
        '
        Me.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaximum.Location = New System.Drawing.Point(247, 138)
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Size = New System.Drawing.Size(331, 23)
        Me.lblMaximum.TabIndex = 6
        '
        'lblMinimum
        '
        Me.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinimum.Location = New System.Drawing.Point(250, 187)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(328, 23)
        Me.lblMinimum.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 310)
        Me.Controls.Add(Me.lblMinimum)
        Me.Controls.Add(Me.lblMaximum)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lstResult)
        Me.Name = "Form1"
        Me.Text = "Weekday Classroom Project"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblMaximum As System.Windows.Forms.Label
    Friend WithEvents lblMinimum As System.Windows.Forms.Label

End Class
