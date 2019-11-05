<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetunAD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RetunAD))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.MyweebleDataSet10 = New Project1.myweebleDataSet10
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New Project1.myweebleDataSet10TableAdapters.BookingTableAdapter
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FueltypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoOfDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyweebleDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 76)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Weeble"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(359, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 76)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Return Car"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.FueltypeDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DLDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PinDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.NoOfDayDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1005, 236)
        Me.DataGridView1.TabIndex = 102
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(51, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(290, 122)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "RETURN CAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(365, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(644, 78)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "            Your Car Has Been Retuen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Thank you for using weeble car services"
        Me.Label1.Visible = False
        '
        'MyweebleDataSet10
        '
        Me.MyweebleDataSet10.DataSetName = "myweebleDataSet10"
        Me.MyweebleDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.MyweebleDataSet10
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
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
        Me.CarnameDataGridViewTextBoxColumn.DataPropertyName = "carname"
        Me.CarnameDataGridViewTextBoxColumn.HeaderText = "carname"
        Me.CarnameDataGridViewTextBoxColumn.Name = "CarnameDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'FueltypeDataGridViewTextBoxColumn
        '
        Me.FueltypeDataGridViewTextBoxColumn.DataPropertyName = "fueltype"
        Me.FueltypeDataGridViewTextBoxColumn.HeaderText = "fueltype"
        Me.FueltypeDataGridViewTextBoxColumn.Name = "FueltypeDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "fullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DLDataGridViewTextBoxColumn
        '
        Me.DLDataGridViewTextBoxColumn.DataPropertyName = "DL"
        Me.DLDataGridViewTextBoxColumn.HeaderText = "DL"
        Me.DLDataGridViewTextBoxColumn.Name = "DLDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PinDataGridViewTextBoxColumn
        '
        Me.PinDataGridViewTextBoxColumn.DataPropertyName = "Pin"
        Me.PinDataGridViewTextBoxColumn.HeaderText = "Pin"
        Me.PinDataGridViewTextBoxColumn.Name = "PinDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'NoOfDayDataGridViewTextBoxColumn
        '
        Me.NoOfDayDataGridViewTextBoxColumn.DataPropertyName = "NoOfDay"
        Me.NoOfDayDataGridViewTextBoxColumn.HeaderText = "NoOfDay"
        Me.NoOfDayDataGridViewTextBoxColumn.Name = "NoOfDayDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'RetunAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 511)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RetunAD"
        Me.Text = "RetunAD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyweebleDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyweebleDataSet10 As Project1.myweebleDataSet10
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As Project1.myweebleDataSet10TableAdapters.BookingTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FueltypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfDayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
