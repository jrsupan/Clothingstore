<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form33
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
        Me.Theme1 = New Clothingstore.Theme()
        Me.Button1 = New Clothingstore.button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtserver = New System.Windows.Forms.TextBox()
        Me.Theme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.Button1)
        Me.Theme1.Controls.Add(Me.Label1)
        Me.Theme1.Controls.Add(Me.txtserver)
        Me.Theme1.Customization = "MjIy/0ZGRv/m5ub/5ubm/zw8PP8="
        Me.Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Theme1.Image = Nothing
        Me.Theme1.Location = New System.Drawing.Point(0, 0)
        Me.Theme1.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Theme1.Movable = True
        Me.Theme1.Name = "Theme1"
        Me.Theme1.NoRounding = False
        Me.Theme1.Rounding = Clothingstore.Theme.RoundingType.None
        Me.Theme1.Sizable = True
        Me.Theme1.Size = New System.Drawing.Size(318, 150)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'Button1
        '
        Me.Button1.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(89, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(145, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Connect"
        Me.Button1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Enter Ip Add"
        '
        'txtserver
        '
        Me.txtserver.Location = New System.Drawing.Point(12, 73)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(288, 20)
        Me.txtserver.TabIndex = 3
        '
        'Form33
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 150)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form33"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.Theme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As Clothingstore.Theme
    Friend WithEvents Button1 As Clothingstore.button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtserver As System.Windows.Forms.TextBox
End Class
