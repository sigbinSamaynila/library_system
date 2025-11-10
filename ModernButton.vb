Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Namespace library_system
    Public Class ModernButton
        Inherits Button

        Private _borderColor As Color = Color.MediumSlateBlue
        Private _borderSize As Integer = 2
        Private _borderRadius As Integer = 20
        Private _backgroundColor As Color = Color.MediumSlateBlue
        Private _textColor As Color = Color.White

        Public Sub New()
            MyBase.New()
            Me.FlatStyle = FlatStyle.Flat
            Me.FlatAppearance.BorderSize = 0
            Me.BackColor = _backgroundColor
            Me.ForeColor = _textColor
        End Sub

        <Category("Modern Style")>
        Public Property BorderColor As Color
            Get
                Return _borderColor
            End Get
            Set(value As Color)
                _borderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property BorderSize As Integer
            Get
                Return _borderSize
            End Get
            Set(value As Integer)
                _borderSize = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property BorderRadius As Integer
            Get
                Return _borderRadius
            End Get
            Set(value As Integer)
                _borderRadius = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property BackgroundColor As Color
            Get
                Return _backgroundColor
            End Get
            Set(value As Color)
                _backgroundColor = value
                Me.BackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property TextColor As Color
            Get
                Return _textColor
            End Get
            Set(value As Color)
                _textColor = value
                Me.ForeColor = value
                Me.Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            MyBase.OnPaint(pe)
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Using pen As New Pen(_borderColor, _borderSize)
                pe.Graphics.DrawRectangle(pen, 0, 0, Me.Width - 1, Me.Height - 1)
            End Using
        End Sub
    End Class
End Namespace
