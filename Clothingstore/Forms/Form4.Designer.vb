<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Theme1 = New Clothingstore.Theme()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Groupbox1 = New Clothingstore.Groupbox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New Clothingstore.button()
        Me.Theme1.SuspendLayout()
        Me.Groupbox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.DiscardNull = True
        Me.SerialPort1.DtrEnable = True
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.TextBox1)
        Me.Theme1.Controls.Add(Me.Groupbox1)
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
        Me.Theme1.Size = New System.Drawing.Size(206, 237)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 194)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Groupbox1
        '
        Me.Groupbox1.Controls.Add(Me.TabPage1)
        Me.Groupbox1.Controls.Add(Me.TabPage2)
        Me.Groupbox1.Location = New System.Drawing.Point(12, 30)
        Me.Groupbox1.Name = "Groupbox1"
        Me.Groupbox1.SelectedIndex = 0
        Me.Groupbox1.Size = New System.Drawing.Size(183, 123)
        Me.Groupbox1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(175, 94)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000"})
        Me.ComboBox2.Location = New System.Drawing.Point(9, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(175, 94)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Button1
        '
        Me.Button1.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(25, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(145, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "connect"
        Me.Button1.Transparent = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 237)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.Theme1.PerformLayout()
        Me.Groupbox1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As Clothingstore.Theme
    Friend WithEvents Button1 As Clothingstore.button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Groupbox1 As Clothingstore.Groupbox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
