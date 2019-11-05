<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newly_car
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Newly_car))
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MyweebleDataSet3 = New Project1.myweebleDataSet3
        Me.ADDnewCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADDnewCarTableAdapter = New Project1.myweebleDataSet3TableAdapters.ADDnewCarTableAdapter
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FueltypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrarifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransmissionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyweebleDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADDnewCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(12, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(266, 112)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Weeble"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 207)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(345, -3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(589, 112)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "New Added Car "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.FueltypeDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.RegNoDataGridViewTextBoxColumn, Me.SeterDataGridViewTextBoxColumn, Me.TrarifDataGridViewTextBoxColumn, Me.TransmissionDataGridViewTextBoxColumn, Me.ACDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ADDnewCarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(255, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(793, 348)
        Me.DataGridView1.TabIndex = 86
        '
        'MyweebleDataSet3
        '
        Me.MyweebleDataSet3.DataSetName = "myweebleDataSet3"
        Me.MyweebleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ADDnewCarBindingSource
        '
        Me.ADDnewCarBindingSource.DataMember = "ADDnewCar"
        Me.ADDnewCarBindingSource.DataSource = Me.MyweebleDataSet3
        '
        'ADDnewCarTableAdapter
        '
        Me.ADDnewCarTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarnameDataGridViewTextBoxColumn
        '
        Me.CarnameDataGridViewTextBoxColumn.DataPropertyName = "Carname"
        Me.CarnameDataGridViewTextBoxColumn.HeaderText = "Carname"
        Me.CarnameDataGridViewTextBoxColumn.Name = "CarnameDataGridViewTextBoxColumn"
        Me.CarnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FueltypeDataGridViewTextBoxColumn
        '
        Me.FueltypeDataGridViewTextBoxColumn.DataPropertyName = "fueltype"
        Me.FueltypeDataGridViewTextBoxColumn.HeaderText = "fueltype"
        Me.FueltypeDataGridViewTextBoxColumn.Name = "FueltypeDataGridViewTextBoxColumn"
        Me.FueltypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegNoDataGridViewTextBoxColumn
        '
        Me.RegNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.HeaderText = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.Name = "RegNoDataGridViewTextBoxColumn"
        Me.RegNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeterDataGridViewTextBoxColumn
        '
        Me.SeterDataGridViewTextBoxColumn.DataPropertyName = "Seter"
        Me.SeterDataGridViewTextBoxColumn.HeaderText = "Seter"
        Me.SeterDataGridViewTextBoxColumn.Name = "SeterDataGridViewTextBoxColumn"
        Me.SeterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrarifDataGridViewTextBoxColumn
        '
        Me.TrarifDataGridViewTextBoxColumn.DataPropertyName = "Trarif"
        Me.TrarifDataGridViewTextBoxColumn.HeaderText = "Trarif"
        Me.TrarifDataGridViewTextBoxColumn.Name = "TrarifDataGridViewTextBoxColumn"
        Me.TrarifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransmissionDataGridViewTextBoxColumn
        '
        Me.TransmissionDataGridViewTextBoxColumn.DataPropertyName = "Transmission"
        Me.TransmissionDataGridViewTextBoxColumn.HeaderText = "Transmission"
        Me.TransmissionDataGridViewTextBoxColumn.Name = "TransmissionDataGridViewTextBoxColumn"
        Me.TransmissionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ACDataGridViewTextBoxColumn
        '
        Me.ACDataGridViewTextBoxColumn.DataPropertyName = "AC"
        Me.ACDataGridViewTextBoxColumn.HeaderText = "AC"
        Me.ACDataGridViewTextBoxColumn.Name = "ACDataGridViewTextBoxColumn"
        Me.ACDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(883, 473)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 46)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Newly_car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project1.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1102, 531)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Newly_car"
        Me.Text = "Newly_car"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyweebleDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADDnewCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MyweebleDataSet3 As Project1.myweebleDataSet3
    Friend WithEvents ADDnewCarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ADDnewCarTableAdapter As Project1.myweebleDataSet3TableAdapters.ADDnewCarTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FueltypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrarifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransmissionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
