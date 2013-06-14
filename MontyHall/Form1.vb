Public Class Form1
    'declare global var to keep track of score and clicks
    'track clicks globally to allow for change of mind
    Dim wins, loses, clicks As UShort
    'set bounds for random number generator
    Dim upperbound As Integer = 3
    Dim lowerbound As Integer = 1
    'declare var to store random number to select door
    Dim randomvalue As Integer
    'keep track of clicks globally to allow for mind change
    'Dim clicks As Integer = 0
    'less typing when manipulating image files
  Dim door As String = "g:\things\MontyHall\door.jpg"
  Dim doorLost As String = "g:\things\MontyHall\doorOpenLose.png"
  Dim doorWon As String = "g:\things\MontyHall\doorOpenWin.png"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'even though we're only using the numbers 1-3 we don't want things to be predictable
        Randomize()
        'initiallize the randomvalue var with a nubmer between 1 and 3
        randomvalue = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
        'initialize clicks var'
        clicks = 0
        'set message text to null string (Mostly because it wasn't set to null string in the GUI editor)
        message.Text = ""
        'initialize wins and loses vars
        wins = 0
        loses = 0
        'load images
        leftDoor.Image = System.Drawing.Image.FromFile(door)
        middleDoor.Image = System.Drawing.Image.FromFile(door)
        rightDoor.Image = System.Drawing.Image.FromFile(door)
        'display scores
        winCount.Text = wins
        losesCount.Text = loses
    End Sub

    Private Sub letsPlay_Click(sender As System.Object, e As System.EventArgs) Handles letsPlay.Click
        'reset the random value. It'd be boring to play the game with the same value every turn
        randomvalue = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
        'reset the clicks var
        clicks = 0
        'clear the win/lose message
        message.Text = ""
        'reset images
        leftDoor.Image = System.Drawing.Image.FromFile(door)
        middleDoor.Image = System.Drawing.Image.FromFile(door)
        rightDoor.Image = System.Drawing.Image.FromFile(door)
        'show all buttons
        leftOpt.Visible = True
        middle.Visible = True
        rightOpt.Visible = True
    End Sub

    Private Sub leftOpt_Click(sender As System.Object, e As System.EventArgs) Handles leftOpt.Click
        Dim Result As Integer
        'check if any button has been clicked
        If clicks < 1 Then
        'if not open losing door
            If randomvalue = 1 Then
                middleDoor.Image = System.Drawing.Image.FromFile(doorLost)
            ElseIf randomvalue = 2 Then
                rightDoor.Image = System.Drawing.Image.FromFile(doorLost)
            Else
                middleDoor.Image = System.Drawing.Image.FromFile(doorLost)
            End If
            'and allow player to change their mind
            Result = MsgBox("Do you want to change your mind?", MsgBoxStyle.YesNo)
        Else 'if any button has been clicked
            If randomvalue = 1 Then
            ' player wins
                message.Text = "You won"
                leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                wins = wins + 1
                winCount.Text = wins
            Else
            'player loses
                message.Text = "You lost"
                loses = loses + 1
                losesCount.Text = loses
                'show win door
                If randomvalue = 1 Then
                    leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                ElseIf randomvalue = 2 Then
                    middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                Else
                    rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                End If 'end check for loses
            End If 'end if randomvalue=1'
        End If 'end if clicks < 1
        'handle change of mind
        If Result = MsgBoxResult.No Then
        'player doesn't want to change their mind
            If randomvalue = 1 Then
            'they win
                message.Text = "You won"
                leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                wins = wins + 1
                winCount.Text = wins
            Else
            'they lose
                loses = loses + 1
                losesCount.Text = loses
                message.Text = "You lost"
                'show the right door
                If randomvalue = 1 Then
                    leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                ElseIf randomvalue = 2 Then
                    middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                Else
                    rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                End If
            End If ' end value check
        End If 'end message box check
        
        'increment global click counter'
        clicks = clicks + 1
        
        'reset click counter automatically'
        If clicks > 1 Then
            clicks = 0
        End If
        
        'duh... hide the button so they can't click it again
        leftOpt.Visible = False
    End Sub

    Private Sub middle_Click(sender As System.Object, e As System.EventArgs) Handles middle.Click
        Dim Result As Integer
        'check for prior clicks to allow player to change their mind
        If clicks < 1 Then
        'if no proir clicks show a wrong door
            If randomvalue = 1 Then
                rightDoor.Image = System.Drawing.Image.FromFile(doorLost)
            ElseIf randomvalue = 2 Then
                rightDoor.Image = System.Drawing.Image.FromFile(doorLost)
            Else
                leftDoor.Image = System.Drawing.Image.FromFile(doorLost)
            End If
            'and prompt user to change mind or not
            Result = MsgBox("Do you want to change your mind?", MsgBoxStyle.YesNo)
        Else 'if prior clicks
            If randomvalue = 2 Then
            'player wins
                message.Text = "You won"
                middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                wins = wins + 1
                winCount.Text = wins
            Else
            'player loses
                message.Text = "You lost"
                loses = loses + 1
                losesCount.Text = loses
                If randomvalue = 1 Then
                    leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                ElseIf randomvalue = 2 Then
                    middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                Else
                    rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                End If 'end if to show winning door
            End If 'end if to chech for win
        End If 'end if clicks < 1
        
        'handle change of mind
        If Result = MsgBoxResult.No Then
        'they don't change their mind
            If randomvalue = 2 Then
            'they win
                message.Text = "You won"
                middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                wins = wins + 1
                winCount.Text = wins
            Else
            'they lose
                loses = loses + 1
                losesCount.Text = loses
                message.Text = "You lost"
                If randomvalue = 1 Then
                    leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                ElseIf randomvalue = 2 Then
                    middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                Else
                    rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                End If 'end show winning door
            End If 'end value check
        End If 'end message box check
        
        'increment clicks
        clicks = clicks + 1
        
        'reset clicks if clicks is greater than 1
        If clicks > 1 Then
            clicks = 0
        End If
        'don't let them click it again
        middle.Visible = False
    End Sub

    Private Sub rightOpt_Click(sender As System.Object, e As System.EventArgs) Handles rightOpt.Click
        Dim Result As Integer
        'check for clicks to allow mind change
        If clicks < 1 Then
        'if no prior clicks show losing door...
            If randomvalue = 1 Then
                middleDoor.Image = System.Drawing.Image.FromFile(doorLost)
            ElseIf randomvalue = 2 Then
                rightDoor.Image = System.Drawing.Image.FromFile(doorLost)
            Else
                middleDoor.Image = System.Drawing.Image.FromFile(doorLost)
            End If
            'and allow player to change their mind.
            Result = MsgBox("Do you want to change your mind?", MsgBoxStyle.YesNo)
        Else
        'if prior clicks...
            If randomvalue = 3 Then
            'they win or..
                message.Text = "You won"
                rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                wins = wins + 1
                winCount.Text = wins
            Else
            'they lose.
                message.Text = "You lost"
                loses = loses + 1
                losesCount.Text = loses
                'show winning door
                If randomvalue = 1 Then
                    leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                ElseIf randomvalue = 2 Then
                    middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                Else
                    rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                End If 'end show winning door
            End If 'end check for win
        End If 'end if clicks < 1


        If Result=MsgBoxResult.No Then
            If randomvalue = 3 Then
                message.Text = "You won"
                rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                wins = wins + 1
                winCount.Text = wins
            Else
                loses = loses + 1
                losesCount.Text = loses
                message.Text = "You lost"
                If randomvalue = 1 Then
                    leftDoor.Image = System.Drawing.Image.FromFile(doorWon)
                ElseIf randomvalue = 2 Then
                    middleDoor.Image = System.Drawing.Image.FromFile(doorWon)
                Else
                    rightDoor.Image = System.Drawing.Image.FromFile(doorWon)
                End If
            End If 'end value check
        End If 'message box if
        
        'count the clicks
        clicks = clicks + 1
        
        'reset the counter automatically
        If clicks > 1 Then
            clicks = 0
        End If
        'don't allow a second click on this button
        rightOpt.Visible = False
    End Sub
    
    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
    'new game button
    'reset wins and losses
        wins = 0
        loses = 0
        'pick new door
        randomvalue = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
        'reset clicks
        clicks = 0
        'and mesages
        message.Text = ""
        'show the right doors
        leftDoor.Image = System.Drawing.Image.FromFile(door)
        middleDoor.Image = System.Drawing.Image.FromFile(door)
        rightDoor.Image = System.Drawing.Image.FromFile(door)
        'display the right scores
        winCount.Text = wins
        losesCount.Text = loses
        'show all buttons
        leftOpt.Visible = True
        middle.Visible = True
        rightOpt.Visible = True
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        'kill it! KILL IT WITH FIRE!!!
        End
    End Sub

End Class
