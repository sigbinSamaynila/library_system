Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace library_system
    <DefaultEvent("TextChanged")>
    Public Class RoundTextBox
        Inherits TextBox

        Private _borderRadius As Integer = 20
        Private _borderColor As Color = Color.MediumSlateBlue
        Private _borderSize As Integer = 2

        <Category("Round Style")>
        Public Property BorderRadius As Integer
            Get
                Return _borderRadius
            End Get
            Set(value As Integer)
                _borderRadius = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Round Style")>
        Public Property BorderColor As Color
            Get
                Return _borderColor
            End Get
            Set(value As Color)
                _borderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Round Style")>
        Public Property BorderSize As Integer
            Get
                Return _borderSize
            End Get
            Set(value As Integer)
                _borderSize = value
                Me.Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            MyBase.OnPaint(pe)
            Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Using path As GraphicsPath = GetRoundPath(rect, _borderRadius)
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                Me.Region = New Region(path)
                Using pen As New Pen(_borderColor, _borderSize)
                    pe.Graphics.DrawPath(pen, path)
                End Using
            End Using
        End Sub

        Private Function GetRoundPath(rect As Rectangle, radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()
            Dim r As Integer = radius * 2
            path.StartFigure()
            path.AddArc(rect.X, rect.Y, r, r, 180, 90)
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
            path.CloseFigure()
            Return path
        End Function
    End Class
End Namespace
