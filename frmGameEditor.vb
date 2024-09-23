Imports System.IO

Public Class frmGameEditor
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb02 As System.Windows.Forms.PictureBox
    Friend WithEvents tb01 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGameEditor))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tb02 = New System.Windows.Forms.PictureBox
        Me.tb01 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tb02)
        Me.Panel1.Controls.Add(Me.tb01)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 45)
        Me.Panel1.TabIndex = 4
        Me.Panel1.Visible = False
        '
        'tb02
        '
        Me.tb02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb02.Image = CType(resources.GetObject("tb02.Image"), System.Drawing.Image)
        Me.tb02.Location = New System.Drawing.Point(48, 0)
        Me.tb02.Name = "tb02"
        Me.tb02.Size = New System.Drawing.Size(50, 45)
        Me.tb02.TabIndex = 1
        Me.tb02.TabStop = False
        '
        'tb01
        '
        Me.tb01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb01.Image = CType(resources.GetObject("tb01.Image"), System.Drawing.Image)
        Me.tb01.Location = New System.Drawing.Point(0, 0)
        Me.tb01.Name = "tb01"
        Me.tb01.Size = New System.Drawing.Size(50, 45)
        Me.tb01.TabIndex = 0
        Me.tb01.TabStop = False
        '
        'frmGameEditor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1192, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGameEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameEditor"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public curtile As String
    Private mytiles As frmTiles
    Private MyMap As clsMap
    Private posx, posy As Integer
    Public toolbar_visible As Boolean = False
    Public showgrid As Boolean = False


    Private Sub frmGameEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MyMap = New clsMap(Me)

    End Sub

    Protected Overrides Function ProcessCmdKey( _
    ByRef msg As Message, _
    ByVal keyData As Keys _
                            ) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Down
                    If MyMap.cury < MyMap.mapy - MyMap.mapdimensionsy(MyMap.mapsize) Then
                        MyMap.cury += 1
                        MyMap.ShowMap()
                        MyMap.ShowUnits()
                    End If

                Case Keys.Up
                    If MyMap.cury > 1 Then
                        MyMap.cury -= 1
                        MyMap.ShowMap()
                        MyMap.ShowUnits()
                    End If
                Case Keys.Left
                    If MyMap.curx > 1 Then
                        MyMap.curx -= 1
                        MyMap.ShowMap()
                        MyMap.ShowUnits()
                    End If

                Case Keys.Right
                    If MyMap.curx < MyMap.mapx - MyMap.mapdimensions(MyMap.mapsize) Then
                        MyMap.curx += 1
                        MyMap.ShowMap()
                        MyMap.ShowUnits()
                    End If

                Case Keys.Escape
                    mytiles = New frmTiles(Me)
                    mytiles.ShowDialog()
                    mytiles.Dispose()

                Case Keys.Tab
                    If toolbar_visible = False Then
                        Panel1.Visible = True
                        toolbar_visible = True
                    Else
                        Panel1.Visible = False
                        toolbar_visible = False
                    End If

            End Select
        End If

    End Function

    Private Sub frmGameEditor_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        MyMap.ShowMap()
        MyMap.ShowUnits()

    End Sub


    Private Sub frmGameEditor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        'Me.draw_tile(posx, posy, 1)
        'Me.draw_border(posx, posy)

    End Sub

    Private Sub frmGameEditor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        posx = e.X()
        posy = e.Y()
        'MsgBox(posy.ToString())


    End Sub


    Private Sub tb01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb01.Click
        If showgrid = False Then
            showgrid = True
            tb01.BorderStyle = BorderStyle.Fixed3D
        Else
            showgrid = False
            tb01.BorderStyle = BorderStyle.FixedSingle
        End If
        MyMap.ShowMap()
        MyMap.ShowUnits()

    End Sub

    Private Sub tb02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb02.Click
        MyMap.MyTacticalMap.Show()

    End Sub

    Private Sub frmGameEditor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        'MyMap.SaveGameMap(MyMap.GAME_MAP)

    End Sub
End Class
