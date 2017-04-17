
Public Class UserControl1
    'Notice that UserControls are actually a subclass of Forms    
    Inherits System.Windows.Forms.UserControl

    'Create the Font and Brush that we will print the time in and    
    'also set the default Foreground color to Black    
    Dim ArialFont As New Font("Arial", 12, FontStyle.Regular)
    Dim myBrush As New SolidBrush(Color.Black)
    Dim CurrentForeColor As Color = Color.Black

    Overrides Property ForeColor() As Color
        Get
            Return (CurrentForeColor)
        End Get
        Set(ByVal Value As Color)
            CurrentForeColor = Value
            Me.Invalidate()
        End Set
    End Property

    'Every time the timer ticks, refresh the control's context,     
    'which in effect will force the time to be updated    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub

    'DrawString the time onto the control's context    
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        'e.Graphics is the graphics context for the control        
        Dim myGfx As Graphics = e.Graphics

        'Set the brush to whatever the current foreground color is        
        myBrush.Color = CurrentForeColor

        'Print the time out        
        myGfx.DrawString(DateTime.Now.ToLongTimeString, ArialFont, myBrush, 10, 10)
    End Sub
End Class
