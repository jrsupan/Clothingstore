<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndone = New Clothingstore.button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncrtcard = New Clothingstore.button()
        Me.txtncard = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Button3 = New Clothingstore.button()
        Me.Groupbox1 = New Clothingstore.Groupbox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Theme1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Theme1.Controls.Add(Me.GroupBox2)
        Me.Theme1.Controls.Add(Me.Button3)
        Me.Theme1.Controls.Add(Me.Groupbox1)
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
        Me.Theme1.Size = New System.Drawing.Size(380, 401)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndone)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btncrtcard)
        Me.GroupBox2.Controls.Add(Me.txtncard)
        Me.GroupBox2.Controls.Add(Me.Description)
        Me.GroupBox2.Controls.Add(Me.txtdesc)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 157)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'btndone
        '
        Me.btndone.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.btndone.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btndone.Image = Nothing
        Me.btndone.Location = New System.Drawing.Point(191, 117)
        Me.btndone.Name = "btndone"
        Me.btndone.NoRounding = False
        Me.btndone.Size = New System.Drawing.Size(122, 25)
        Me.btndone.TabIndex = 25
        Me.btndone.Text = "Done"
        Me.btndone.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Card ID"
        '
        'btncrtcard
        '
        Me.btncrtcard.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.btncrtcard.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btncrtcard.Image = Nothing
        Me.btncrtcard.Location = New System.Drawing.Point(33, 117)
        Me.btncrtcard.Name = "btncrtcard"
        Me.btncrtcard.NoRounding = False
        Me.btncrtcard.Size = New System.Drawing.Size(122, 25)
        Me.btncrtcard.TabIndex = 24
        Me.btncrtcard.Text = "Create"
        Me.btncrtcard.Transparent = False
        '
        'txtncard
        '
        Me.txtncard.Location = New System.Drawing.Point(69, 32)
        Me.txtncard.Name = "txtncard"
        Me.txtncard.ReadOnly = True
        Me.txtncard.Size = New System.Drawing.Size(179, 20)
        Me.txtncard.TabIndex = 20
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(66, 55)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(71, 13)
        Me.Description.TabIndex = 23
        Me.Description.Text = "Description"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(69, 71)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(179, 20)
        Me.txtdesc.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button3.Image = Nothing
        Me.Button3.Location = New System.Drawing.Point(235, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.NoRounding = False
        Me.Button3.Size = New System.Drawing.Size(133, 70)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Connect"
        Me.Button3.Transparent = False
        '
        'Groupbox1
        '
        Me.Groupbox1.Controls.Add(Me.TabPage1)
        Me.Groupbox1.Controls.Add(Me.TabPage2)
        Me.Groupbox1.Location = New System.Drawing.Point(45, 33)
        Me.Groupbox1.Name = "Groupbox1"
        Me.Groupbox1.SelectedIndex = 0
        Me.Groupbox1.Size = New System.Drawing.Size(188, 156)
        Me.Groupbox1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(180, 127)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Baud"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000"})
        Me.ComboBox2.Location = New System.Drawing.Point(27, 77)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(109, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(27, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(109, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(180, 127)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 401)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Groupbox1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As Clothingstore.Theme
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Groupbox1 As Clothingstore.Groupbox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As Clothingstore.button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btndone As Clothingstore.button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncrtcard As Clothingstore.button
    Friend WithEvents txtncard As System.Windows.Forms.TextBox
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
End Class
