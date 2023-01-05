<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
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
        Me.Theme1 = New Clothingstore.Theme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New Clothingstore.button()
        Me.Button2 = New Clothingstore.button()
        Me.cmbdesc = New System.Windows.Forms.ComboBox()
        Me.itemshowdatagrid = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Theme1.SuspendLayout()
        CType(Me.itemshowdatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme1
        '
        Me.Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Controls.Add(Me.Label1)
        Me.Theme1.Controls.Add(Me.Button1)
        Me.Theme1.Controls.Add(Me.Button2)
        Me.Theme1.Controls.Add(Me.cmbdesc)
        Me.Theme1.Controls.Add(Me.itemshowdatagrid)
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
        Me.Theme1.Size = New System.Drawing.Size(646, 427)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Theme1"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(489, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(145, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Logout"
        Me.Button1.Transparent = False
        '
        'Button2
        '
        Me.Button2.Customization = "PDw8/0FBQf9GRkb/PDw8//////8eHh7/"
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button2.Image = Nothing
        Me.Button2.Location = New System.Drawing.Point(540, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.NoRounding = False
        Me.Button2.Size = New System.Drawing.Size(94, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Show"
        Me.Button2.Transparent = False
        '
        'cmbdesc
        '
        Me.cmbdesc.FormattingEnabled = True
        Me.cmbdesc.Location = New System.Drawing.Point(403, 46)
        Me.cmbdesc.Name = "cmbdesc"
        Me.cmbdesc.Size = New System.Drawing.Size(121, 21)
        Me.cmbdesc.TabIndex = 1
        '
        'itemshowdatagrid
        '
        Me.itemshowdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemshowdatagrid.Location = New System.Drawing.Point(12, 35)
        Me.itemshowdatagrid.Name = "itemshowdatagrid"
        Me.itemshowdatagrid.Size = New System.Drawing.Size(385, 312)
        Me.itemshowdatagrid.TabIndex = 0
        '
        'Timer1
        '
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 427)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form22"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        Me.Theme1.PerformLayout()
        CType(Me.itemshowdatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As Clothingstore.Theme
    Friend WithEvents Button1 As Clothingstore.button
    Friend WithEvents Button2 As Clothingstore.button
    Friend WithEvents cmbdesc As System.Windows.Forms.ComboBox
    Friend WithEvents itemshowdatagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
