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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.picRed = New System.Windows.Forms.Button()
        Me.picYellow = New System.Windows.Forms.Button()
        Me.picGreen = New System.Windows.Forms.Button()
        Me.picBlue = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStart.Location = New System.Drawing.Point(52, 10)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(87, 25)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(138, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 25)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.Location = New System.Drawing.Point(186, 286)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(70, 25)
        Me.lblScore.TabIndex = 7
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Round:"
        '
        'lblRound
        '
        Me.lblRound.Location = New System.Drawing.Point(253, 12)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(70, 20)
        Me.lblRound.TabIndex = 9
        Me.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picRed
        '
        Me.picRed.BackColor = System.Drawing.Color.Red
        Me.picRed.ForeColor = System.Drawing.SystemColors.Control
        Me.picRed.Location = New System.Drawing.Point(64, 80)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(119, 80)
        Me.picRed.TabIndex = 10
        Me.picRed.Tag = "0"
        Me.picRed.UseVisualStyleBackColor = False
        '
        'picYellow
        '
        Me.picYellow.BackColor = System.Drawing.Color.Yellow
        Me.picYellow.Location = New System.Drawing.Point(189, 80)
        Me.picYellow.Name = "picYellow"
        Me.picYellow.Size = New System.Drawing.Size(119, 80)
        Me.picYellow.TabIndex = 11
        Me.picYellow.Tag = "1"
        Me.picYellow.UseVisualStyleBackColor = False
        '
        'picGreen
        '
        Me.picGreen.BackColor = System.Drawing.Color.Green
        Me.picGreen.Location = New System.Drawing.Point(64, 166)
        Me.picGreen.Name = "picGreen"
        Me.picGreen.Size = New System.Drawing.Size(119, 80)
        Me.picGreen.TabIndex = 12
        Me.picGreen.Tag = "2"
        Me.picGreen.UseVisualStyleBackColor = False
        '
        'picBlue
        '
        Me.picBlue.BackColor = System.Drawing.Color.Blue
        Me.picBlue.Location = New System.Drawing.Point(189, 166)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(119, 80)
        Me.picBlue.TabIndex = 13
        Me.picBlue.Tag = "3"
        Me.picBlue.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 234)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(395, 379)
        Me.Controls.Add(Me.picBlue)
        Me.Controls.Add(Me.picGreen)
        Me.Controls.Add(Me.picYellow)
        Me.Controls.Add(Me.picRed)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Form1"
        Me.Text = "Simon Says"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRound As Label
    Friend WithEvents picRed As Button
    Friend WithEvents picYellow As Button
    Friend WithEvents picGreen As Button
    Friend WithEvents picBlue As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
