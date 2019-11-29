<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Highet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rectangle_Space = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuboid_Side_Space = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuboid_Space = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuboid_Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Length, Me.Width, Me.Highet, Me.Rectangle_Space, Me.Cuboid_Side_Space, Me.Cuboid_Space, Me.Cuboid_Size})
        Me.DataGridView1.Location = New System.Drawing.Point(39, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(622, 159)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(184, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 60)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate Rectangle Space"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Highet"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 60)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Calculate Cuboid Space"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(577, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 60)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Clear Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Length
        '
        Me.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Length.HeaderText = "Length"
        Me.Length.Name = "Length"
        Me.Length.ReadOnly = True
        Me.Length.Width = 65
        '
        'Width
        '
        Me.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Width.HeaderText = "Width"
        Me.Width.Name = "Width"
        Me.Width.ReadOnly = True
        Me.Width.Width = 60
        '
        'Highet
        '
        Me.Highet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Highet.HeaderText = "Highet"
        Me.Highet.Name = "Highet"
        Me.Highet.ReadOnly = True
        Me.Highet.Width = 63
        '
        'Rectangle_Space
        '
        Me.Rectangle_Space.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Rectangle_Space.HeaderText = "Rectangle Space"
        Me.Rectangle_Space.Name = "Rectangle_Space"
        Me.Rectangle_Space.ReadOnly = True
        Me.Rectangle_Space.Width = 105
        '
        'Cuboid_Side_Space
        '
        Me.Cuboid_Side_Space.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cuboid_Side_Space.HeaderText = "Cuboid Side Space"
        Me.Cuboid_Side_Space.Name = "Cuboid_Side_Space"
        Me.Cuboid_Side_Space.ReadOnly = True
        Me.Cuboid_Side_Space.Width = 113
        '
        'Cuboid_Space
        '
        Me.Cuboid_Space.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cuboid_Space.HeaderText = "Cuboid Space"
        Me.Cuboid_Space.Name = "Cuboid_Space"
        Me.Cuboid_Space.ReadOnly = True
        Me.Cuboid_Space.Width = 91
        '
        'Cuboid_Size
        '
        Me.Cuboid_Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cuboid_Size.HeaderText = "Cuboid Size"
        Me.Cuboid_Size.Name = "Cuboid_Size"
        Me.Cuboid_Size.ReadOnly = True
        Me.Cuboid_Size.Width = 81
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 300)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Length As DataGridViewTextBoxColumn
    Friend WithEvents Width As DataGridViewTextBoxColumn
    Friend WithEvents Highet As DataGridViewTextBoxColumn
    Friend WithEvents Rectangle_Space As DataGridViewTextBoxColumn
    Friend WithEvents Cuboid_Side_Space As DataGridViewTextBoxColumn
    Friend WithEvents Cuboid_Space As DataGridViewTextBoxColumn
    Friend WithEvents Cuboid_Size As DataGridViewTextBoxColumn
End Class
