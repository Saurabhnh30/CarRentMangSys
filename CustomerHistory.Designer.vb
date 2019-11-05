<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerHistory
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
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyweebleDataSet2 = New Project1.myweebleDataSet2
        Me.AddcustomerTableAdapter = New Project1.myweebleDataSet2TableAdapters.addcustomerTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyweebleDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.DlDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.PinDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AddcustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(880, 444)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'DlDataGridViewTextBoxColumn
        '
        Me.DlDataGridViewTextBoxColumn.DataPropertyName = "dl"
        Me.DlDataGridViewTextBoxColumn.HeaderText = "dl"
        Me.DlDataGridViewTextBoxColumn.Name = "DlDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'PinDataGridViewTextBoxColumn
        '
        Me.PinDataGridViewTextBoxColumn.DataPropertyName = "pin"
        Me.PinDataGridViewTextBoxColumn.HeaderText = "pin"
        Me.PinDataGridViewTextBoxColumn.Name = "PinDataGridViewTextBoxColumn"
        '
        'AddcustomerBindingSource
        '
        Me.AddcustomerBindingSource.DataMember = "addcustomer"
        Me.AddcustomerBindingSource.DataSource = Me.MyweebleDataSet2
        '
        'MyweebleDataSet2
        '
        Me.MyweebleDataSet2.DataSetName = "myweebleDataSet2"
        Me.MyweebleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddcustomerTableAdapter
        '
        Me.AddcustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project1.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(902, 486)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CustomerHistory"
        Me.Text = "CustomerHistory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyweebleDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MyweebleDataSet2 As Project1.myweebleDataSet2
    Friend WithEvents AddcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddcustomerTableAdapter As Project1.myweebleDataSet2TableAdapters.addcustomerTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
