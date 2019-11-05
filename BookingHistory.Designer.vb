<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingHistory
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MyweebleDataSet8 = New Project1.myweebleDataSet8
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New Project1.myweebleDataSet8TableAdapters.BookingTableAdapter
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
        CType(Me.MyweebleDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CarnameDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.FueltypeDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DLDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PinDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.NoOfDayDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1036, 429)
        Me.DataGridView1.TabIndex = 0
        '
        'MyweebleDataSet8
        '
        Me.MyweebleDataSet8.DataSetName = "myweebleDataSet8"
        Me.MyweebleDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.MyweebleDataSet8
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
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project1.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1060, 473)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BookingHistory"
        Me.Text = "BookingHistory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyweebleDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MyweebleDataSet8 As Project1.myweebleDataSet8
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As Project1.myweebleDataSet8TableAdapters.BookingTableAdapter
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
