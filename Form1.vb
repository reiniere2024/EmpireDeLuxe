Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picSource As System.Windows.Forms.PictureBox
    Friend WithEvents G As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.picSource = New System.Windows.Forms.PictureBox
        Me.G = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'picSource
        '
        Me.picSource.BackColor = System.Drawing.Color.White
        Me.picSource.Location = New System.Drawing.Point(40, 48)
        Me.picSource.Name = "picSource"
        Me.picSource.Size = New System.Drawing.Size(648, 504)
        Me.picSource.TabIndex = 0
        Me.picSource.TabStop = False
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.G.Location = New System.Drawing.Point(440, 40)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(96, 23)
        Me.G.TabIndex = 1
        Me.G.Text = "Gradient 1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Gradient 2"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button2.Location = New System.Drawing.Point(440, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Gradient 3"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button3.Location = New System.Drawing.Point(440, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Gradient 4"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.PictureBox1.Location = New System.Drawing.Point(448, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(576, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Button4"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(720, 565)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.picSource)
        Me.Name = "Form1"
        Me.Text = "Test GDI+"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub picSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSource.Click

    End Sub

    Private Sub picSource_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picSource.Paint
        'paint straight figures
        e.Graphics.FillRectangle(New SolidBrush(Color.BlanchedAlmond), 10, 20, 13, 15)  'rechthoek
        e.Graphics.DrawArc(New Pen(Color.Red), 40, 40, 20, 20, 30, 60)      'boog
        e.Graphics.DrawBezier(New Pen(Color.Red), 80, 80, 90, 85, 95, 90, 98, 93) 'bezier curve
        Dim mypoints(2) As PointF
        mypoints(0) = New PointF(120, 180)
        mypoints(1) = New PointF(140, 180)
        mypoints(2) = New PointF(130, 200)

        'e.Graphics.DrawClosedCurve(New Pen(Color.Red), mypoints)
        'e.Graphics.DrawCurve(New Pen(Color.Red), mypoints)
        e.Graphics.DrawPolygon(New Pen(Color.Red), mypoints)

        e.Graphics.DrawEllipse(New Pen(Color.Red), New Rectangle(100, 100, 40, 20))
        e.Graphics.FillEllipse(New SolidBrush(Color.Red), New Rectangle(100, 100, 40, 20))

        e.Graphics.DrawPie(New Pen(Color.Blue), New Rectangle(150, 150, 60, 60), 0, 60)
        e.Graphics.FillPie(New SolidBrush(Color.Blue), New Rectangle(150, 150, 60, 60), 0, 60)

        'e.Graphics.DrawImage()





    End Sub

    Private Sub G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G.Click
        Dim graph As Graphics
        Dim lingradient As Drawing2D.LinearGradientBrush
        'Dim myimage As System.Drawing.Image
        Dim myimage As System.Drawing.Bitmap


        graph = Graphics.FromHwnd(picSource.Handle)
        myimage = Bitmap.FromFile("D:\projects\games\gdi+\Axis and Allies\bin\units\s4\abrams04.gif")
        'myimage = ImageList1.Images(1)
        myimage.MakeTransparent(myimage.GetPixel(0, 0))

        graph.DrawImage(myimage, New PointF(120, 280))




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim graph As Graphics
        Dim rectsquare As Rectangle
        Dim graphpath As New Drawing2D.GraphicsPath
        Dim brushsquare As Drawing2D.PathGradientBrush

        Dim mypoints(2) As PointF
        graph = Graphics.FromHwnd(picSource.Handle)
        mypoints(0) = New PointF(120, 280)
        mypoints(1) = New PointF(160, 280)
        mypoints(2) = New PointF(140, 320)
        brushsquare = New Drawing2D.PathGradientBrush(mypoints, Drawing2D.WrapMode.TileFlipX)
        brushsquare.CenterColor = Color.FromArgb(255, 255, 0, 0)
        brushsquare.SurroundColors = New Color() {Color.FromArgb(255, 150, 0, 0)}
        graphpath.AddPolygon(mypoints)
        graph.FillPath(brushsquare, graphpath)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim graph As Graphics
        Dim rectsquare As Rectangle
        Dim graphpath As New Drawing2D.GraphicsPath
        Dim brushsquare As Drawing2D.PathGradientBrush

        graph = Graphics.FromHwnd(picSource.Handle)
        rectsquare = New Rectangle(100, 250, 20, 20)

        graphpath.AddEllipse(rectsquare)
        brushsquare = New Drawing2D.PathGradientBrush(graphpath)
        brushsquare.CenterColor = Color.FromArgb(255, 0, 255, 0)
        brushsquare.SurroundColors = New Color() {Color.FromArgb(255, 0, 150, 0)}

        graph.FillPath(brushsquare, graphpath)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim graph As Graphics
        Dim rectsquare As Rectangle
        Dim graphpath As New Drawing2D.GraphicsPath
        Dim brushsquare As Drawing2D.PathGradientBrush

        graph = Graphics.FromHwnd(picSource.Handle)
        Dim mypoints(2) As PointF
        mypoints(0) = New PointF(120, 280)
        mypoints(1) = New PointF(140, 280)
        mypoints(2) = New PointF(130, 300)
        graphpath.AddPolygon(mypoints)

        brushsquare = New Drawing2D.PathGradientBrush(graphpath)
        brushsquare.CenterColor = Color.FromArgb(255, 255, 255, 0)
        brushsquare.SurroundColors = New Color() {Color.FromArgb(255, 255, 150, 0)}

        graph.FillPath(brushsquare, graphpath)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MsgBox("hallo")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim graph As Graphics
        Dim lingradient As Drawing2D.LinearGradientBrush
        'Dim brushsquare As Drawing2D.PathGradientBrush
        Dim brushsquare As Drawing2D.HatchBrush
        Dim graphpath As Drawing2D.GraphicsPath
        Dim x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, xd1, yd1 As Integer
        Dim mypoints(6) As PointF

        xd1 = 60   'tile breedte
        yd1 = 34.64 'tile hoogte

        x1 = 100
        x2 = 100 + (xd1 * (40 / 60))
        x3 = 100 + xd1
        x4 = 100 + (xd1 * (40 / 60))
        x5 = 100
        x6 = 100 + (-1 * xd1 * (20 / 60))
        y1 = 100 + (-1 * yd1)
        y2 = 100 + (-1 * yd1)
        y3 = 100
        y4 = 100 + yd1
        y5 = 100 + yd1
        y6 = 100
        mypoints(0) = New PointF(x1, y1)
        mypoints(1) = New PointF(x2, y2)
        mypoints(2) = New PointF(x3, y3)
        mypoints(3) = New PointF(x4, y4)
        mypoints(4) = New PointF(x5, y5)
        mypoints(5) = New PointF(x6, y6)
        mypoints(6) = New PointF(x1, y1)
        graph = Graphics.FromHwnd(picSource.Handle)
        graph.DrawPolygon(New Pen(Color.Black, 2), mypoints)
        graphpath = New Drawing2D.GraphicsPath
        graphpath.AddPolygon(mypoints)
        'brushsquare = New Drawing2D.PathGradientBrush(graphpath)
        brushsquare = New Drawing2D.HatchBrush(Drawing2D.HatchStyle.LargeConfetti, Color.FromArgb(255, 0, 255, 0))

        graph.FillPolygon(brushsquare, mypoints)
        graphpath.Dispose()
        brushsquare.Dispose()
        graph.Dispose()

    End Sub
End Class
