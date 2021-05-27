<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdFillTables = New System.Windows.Forms.Button
        Me.cmdDetails = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdTests = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdFillTables
        '
        Me.cmdFillTables.Location = New System.Drawing.Point(21, 169)
        Me.cmdFillTables.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFillTables.Name = "cmdFillTables"
        Me.cmdFillTables.Size = New System.Drawing.Size(99, 23)
        Me.cmdFillTables.TabIndex = 12
        Me.cmdFillTables.Text = "Project"
        Me.cmdFillTables.UseVisualStyleBackColor = True
        '
        'cmdDetails
        '
        Me.cmdDetails.Location = New System.Drawing.Point(152, 169)
        Me.cmdDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(99, 23)
        Me.cmdDetails.TabIndex = 11
        Me.cmdDetails.Text = "Project Details"
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(278, 169)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 23)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdTests
        '
        Me.cmdTests.Location = New System.Drawing.Point(379, 211)
        Me.cmdTests.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdTests.Name = "cmdTests"
        Me.cmdTests.Size = New System.Drawing.Size(24, 23)
        Me.cmdTests.TabIndex = 16
        Me.cmdTests.Text = "T"
        Me.cmdTests.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AssymetricKey.My.Resources.Resources.Virtual_controls_logo
        Me.PictureBox1.Location = New System.Drawing.Point(21, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 235)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdTests)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdFillTables)
        Me.Controls.Add(Me.cmdDetails)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdFillTables As System.Windows.Forms.Button
    Friend WithEvents cmdDetails As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdTests As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
