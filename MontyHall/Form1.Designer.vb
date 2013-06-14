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
        Me.leftOpt = New System.Windows.Forms.Button()
        Me.rightOpt = New System.Windows.Forms.Button()
        Me.middle = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.leftDoor = New System.Windows.Forms.PictureBox()
        Me.rightDoor = New System.Windows.Forms.PictureBox()
        Me.middleDoor = New System.Windows.Forms.PictureBox()
        Me.win = New System.Windows.Forms.Label()
        Me.winCount = New System.Windows.Forms.Label()
        Me.losesCount = New System.Windows.Forms.Label()
        Me.lose = New System.Windows.Forms.Label()
        Me.message = New System.Windows.Forms.Label()
        Me.letsPlay = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.leftDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.middleDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftOpt
        '
        Me.leftOpt.Location = New System.Drawing.Point(53, 277)
        Me.leftOpt.Name = "leftOpt"
        Me.leftOpt.Size = New System.Drawing.Size(75, 23)
        Me.leftOpt.TabIndex = 0
        Me.leftOpt.Text = "Left"
        Me.leftOpt.UseVisualStyleBackColor = True
        '
        'rightOpt
        '
        Me.rightOpt.Location = New System.Drawing.Point(310, 277)
        Me.rightOpt.Name = "rightOpt"
        Me.rightOpt.Size = New System.Drawing.Size(75, 23)
        Me.rightOpt.TabIndex = 1
        Me.rightOpt.Text = "Right"
        Me.rightOpt.UseVisualStyleBackColor = True
        '
        'middle
        '
        Me.middle.Location = New System.Drawing.Point(185, 277)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(75, 23)
        Me.middle.TabIndex = 2
        Me.middle.Text = "Middle"
        Me.middle.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(452, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'leftDoor
        '
        Me.leftDoor.Image = CType(resources.GetObject("leftDoor.Image"), System.Drawing.Image)
        Me.leftDoor.Location = New System.Drawing.Point(40, 142)
        Me.leftDoor.Name = "leftDoor"
        Me.leftDoor.Size = New System.Drawing.Size(100, 118)
        Me.leftDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.leftDoor.TabIndex = 4
        Me.leftDoor.TabStop = False
        '
        'rightDoor
        '
        Me.rightDoor.Image = CType(resources.GetObject("rightDoor.Image"), System.Drawing.Image)
        Me.rightDoor.Location = New System.Drawing.Point(297, 142)
        Me.rightDoor.Name = "rightDoor"
        Me.rightDoor.Size = New System.Drawing.Size(100, 118)
        Me.rightDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rightDoor.TabIndex = 5
        Me.rightDoor.TabStop = False
        '
        'middleDoor
        '
        Me.middleDoor.Image = CType(resources.GetObject("middleDoor.Image"), System.Drawing.Image)
        Me.middleDoor.Location = New System.Drawing.Point(172, 142)
        Me.middleDoor.Name = "middleDoor"
        Me.middleDoor.Size = New System.Drawing.Size(100, 118)
        Me.middleDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.middleDoor.TabIndex = 6
        Me.middleDoor.TabStop = False
        '
        'win
        '
        Me.win.AutoSize = True
        Me.win.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.win.Location = New System.Drawing.Point(49, 43)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(52, 24)
        Me.win.TabIndex = 7
        Me.win.Text = "Wins"
        '
        'winCount
        '
        Me.winCount.AutoSize = True
        Me.winCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winCount.Location = New System.Drawing.Point(107, 43)
        Me.winCount.Name = "winCount"
        Me.winCount.Size = New System.Drawing.Size(20, 24)
        Me.winCount.TabIndex = 8
        Me.winCount.Text = "a"
        '
        'losesCount
        '
        Me.losesCount.AutoSize = True
        Me.losesCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.losesCount.Location = New System.Drawing.Point(365, 43)
        Me.losesCount.Name = "losesCount"
        Me.losesCount.Size = New System.Drawing.Size(20, 24)
        Me.losesCount.TabIndex = 10
        Me.losesCount.Text = "a"
        '
        'lose
        '
        Me.lose.AutoSize = True
        Me.lose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lose.Location = New System.Drawing.Point(293, 43)
        Me.lose.Name = "lose"
        Me.lose.Size = New System.Drawing.Size(60, 24)
        Me.lose.TabIndex = 9
        Me.lose.Text = "Loses"
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message.Location = New System.Drawing.Point(176, 102)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(96, 24)
        Me.message.TabIndex = 11
        Me.message.Text = "Messages"
        Me.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'letsPlay
        '
        Me.letsPlay.Location = New System.Drawing.Point(185, 314)
        Me.letsPlay.Name = "letsPlay"
        Me.letsPlay.Size = New System.Drawing.Size(75, 23)
        Me.letsPlay.TabIndex = 12
        Me.letsPlay.Text = "Try Again"
        Me.letsPlay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 349)
        Me.Controls.Add(Me.letsPlay)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.losesCount)
        Me.Controls.Add(Me.lose)
        Me.Controls.Add(Me.winCount)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.middleDoor)
        Me.Controls.Add(Me.rightDoor)
        Me.Controls.Add(Me.leftDoor)
        Me.Controls.Add(Me.middle)
        Me.Controls.Add(Me.rightOpt)
        Me.Controls.Add(Me.leftOpt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.leftDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.middleDoor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leftOpt As System.Windows.Forms.Button
    Friend WithEvents rightOpt As System.Windows.Forms.Button
    Friend WithEvents middle As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents leftDoor As System.Windows.Forms.PictureBox
    Friend WithEvents rightDoor As System.Windows.Forms.PictureBox
    Friend WithEvents middleDoor As System.Windows.Forms.PictureBox
    Friend WithEvents win As System.Windows.Forms.Label
    Friend WithEvents winCount As System.Windows.Forms.Label
    Friend WithEvents losesCount As System.Windows.Forms.Label
    Friend WithEvents lose As System.Windows.Forms.Label
    Friend WithEvents message As System.Windows.Forms.Label
    Friend WithEvents letsPlay As System.Windows.Forms.Button

End Class
