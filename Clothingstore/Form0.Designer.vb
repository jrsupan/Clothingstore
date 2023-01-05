<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form0
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
        Me.Button2 = New Clothingstore.button()
        Me.Button1 = New Clothingstore.button()
        Me.Theme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.Button2)
        Me.Theme1.Controls.Add(Me.Button1)
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
        Me.Theme1.Size = New System.Drawing.Size(279, 150)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'Button2
        '
        Me.Button2.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button2.Image = Nothing
        Me.Button2.Location = New System.Drawing.Point(70, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.NoRounding = False
        Me.Button2.Size = New System.Drawing.Size(145, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Customer"
        Me.Button2.Transparent = False
        '
        'Button1
        '
        Me.Button1.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(70, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(145, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Employee"
        Me.Button1.Transparent = False
        '
        'Form0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 150)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use The System for?"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As Clothingstore.Theme
    Friend WithEvents Button2 As Clothingstore.button
    Friend WithEvents Button1 As Clothingstore.button
End Class
