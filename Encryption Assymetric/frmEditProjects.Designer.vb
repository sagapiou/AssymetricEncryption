<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProjects
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
        Me.cmdCreateXML = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.fileDialog = New System.Windows.Forms.SaveFileDialog
        Me.cbxProjects = New System.Windows.Forms.ComboBox
        Me.dgvMacs = New System.Windows.Forms.DataGridView
        Me.VDgvMacAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Licenses = New AssymetricKey.Licenses
        Me.cbxProjectType = New System.Windows.Forms.ComboBox
        Me.txtMac = New System.Windows.Forms.TextBox
        Me.cmdInsertMac = New System.Windows.Forms.Button
        Me.lblMac = New System.Windows.Forms.Label
        Me.lblpt = New System.Windows.Forms.Label
        Me.cbxChannels = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TLicenseDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TLicenseDetailsTableAdapter = New AssymetricKey.LicensesTableAdapters.tLicenseDetailsTableAdapter
        Me.TProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TProjectsTableAdapter = New AssymetricKey.LicensesTableAdapters.tProjectsTableAdapter
        Me.VDgvMacAddressesTableAdapter = New AssymetricKey.LicensesTableAdapters.vDgvMacAddressesTableAdapter
        Me.TProjectTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TProjectTypesTableAdapter = New AssymetricKey.LicensesTableAdapters.tProjectTypesTableAdapter
        Me.TypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LicenseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MACAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.changeActive = New System.Windows.Forms.DataGridViewButtonColumn
        CType(Me.dgvMacs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDgvMacAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Licenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLicenseDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TProjectTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCreateXML
        '
        Me.cmdCreateXML.Location = New System.Drawing.Point(793, 343)
        Me.cmdCreateXML.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCreateXML.Name = "cmdCreateXML"
        Me.cmdCreateXML.Size = New System.Drawing.Size(86, 28)
        Me.cmdCreateXML.TabIndex = 0
        Me.cmdCreateXML.Text = "Create XML"
        Me.cmdCreateXML.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(904, 343)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(86, 28)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'fileDialog
        '
        Me.fileDialog.DefaultExt = "xml"
        Me.fileDialog.Title = "Select Name For XML"
        '
        'cbxProjects
        '
        Me.cbxProjects.FormattingEnabled = True
        Me.cbxProjects.Location = New System.Drawing.Point(9, 10)
        Me.cbxProjects.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProjects.Name = "cbxProjects"
        Me.cbxProjects.Size = New System.Drawing.Size(252, 21)
        Me.cbxProjects.TabIndex = 4
        '
        'dgvMacs
        '
        Me.dgvMacs.AllowUserToAddRows = False
        Me.dgvMacs.AllowUserToDeleteRows = False
        Me.dgvMacs.AutoGenerateColumns = False
        Me.dgvMacs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMacs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeIDDataGridViewTextBoxColumn, Me.LicenseIDDataGridViewTextBoxColumn, Me.TypeDescriptionDataGridViewTextBoxColumn, Me.MACAddressDataGridViewTextBoxColumn, Me.Count, Me.IsActiveDataGridViewCheckBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn, Me.changeActive})
        Me.dgvMacs.DataSource = Me.VDgvMacAddressesBindingSource
        Me.dgvMacs.Location = New System.Drawing.Point(9, 125)
        Me.dgvMacs.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMacs.Name = "dgvMacs"
        Me.dgvMacs.ReadOnly = True
        Me.dgvMacs.RowTemplate.Height = 24
        Me.dgvMacs.Size = New System.Drawing.Size(981, 197)
        Me.dgvMacs.TabIndex = 5
        '
        'VDgvMacAddressesBindingSource
        '
        Me.VDgvMacAddressesBindingSource.DataMember = "vDgvMacAddresses"
        Me.VDgvMacAddressesBindingSource.DataSource = Me.Licenses
        '
        'Licenses
        '
        Me.Licenses.DataSetName = "Licenses"
        Me.Licenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxProjectType
        '
        Me.cbxProjectType.FormattingEnabled = True
        Me.cbxProjectType.Location = New System.Drawing.Point(230, 72)
        Me.cbxProjectType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProjectType.Name = "cbxProjectType"
        Me.cbxProjectType.Size = New System.Drawing.Size(160, 21)
        Me.cbxProjectType.TabIndex = 6
        '
        'txtMac
        '
        Me.txtMac.Location = New System.Drawing.Point(9, 72)
        Me.txtMac.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMac.Name = "txtMac"
        Me.txtMac.Size = New System.Drawing.Size(189, 20)
        Me.txtMac.TabIndex = 8
        '
        'cmdInsertMac
        '
        Me.cmdInsertMac.Location = New System.Drawing.Point(544, 65)
        Me.cmdInsertMac.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdInsertMac.Name = "cmdInsertMac"
        Me.cmdInsertMac.Size = New System.Drawing.Size(66, 34)
        Me.cmdInsertMac.TabIndex = 9
        Me.cmdInsertMac.Text = "Add"
        Me.cmdInsertMac.UseVisualStyleBackColor = True
        '
        'lblMac
        '
        Me.lblMac.AutoSize = True
        Me.lblMac.Location = New System.Drawing.Point(9, 57)
        Me.lblMac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMac.Name = "lblMac"
        Me.lblMac.Size = New System.Drawing.Size(30, 13)
        Me.lblMac.TabIndex = 10
        Me.lblMac.Text = "MAC"
        '
        'lblpt
        '
        Me.lblpt.AutoSize = True
        Me.lblpt.Location = New System.Drawing.Point(232, 57)
        Me.lblpt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpt.Name = "lblpt"
        Me.lblpt.Size = New System.Drawing.Size(67, 13)
        Me.lblpt.TabIndex = 11
        Me.lblpt.Text = "Project Type"
        '
        'cbxChannels
        '
        Me.cbxChannels.FormattingEnabled = True
        Me.cbxChannels.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxChannels.Location = New System.Drawing.Point(413, 73)
        Me.cbxChannels.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxChannels.Name = "cbxChannels"
        Me.cbxChannels.Size = New System.Drawing.Size(93, 21)
        Me.cbxChannels.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No Of Channels"
        '
        'TLicenseDetailsBindingSource
        '
        Me.TLicenseDetailsBindingSource.DataMember = "tLicenseDetails"
        Me.TLicenseDetailsBindingSource.DataSource = Me.Licenses
        '
        'TLicenseDetailsTableAdapter
        '
        Me.TLicenseDetailsTableAdapter.ClearBeforeFill = True
        '
        'TProjectsBindingSource
        '
        Me.TProjectsBindingSource.DataMember = "tProjects"
        Me.TProjectsBindingSource.DataSource = Me.Licenses
        '
        'TProjectsTableAdapter
        '
        Me.TProjectsTableAdapter.ClearBeforeFill = True
        '
        'VDgvMacAddressesTableAdapter
        '
        Me.VDgvMacAddressesTableAdapter.ClearBeforeFill = True
        '
        'TProjectTypesBindingSource
        '
        Me.TProjectTypesBindingSource.DataMember = "tProjectTypes"
        Me.TProjectTypesBindingSource.DataSource = Me.Licenses
        '
        'TProjectTypesTableAdapter
        '
        Me.TProjectTypesTableAdapter.ClearBeforeFill = True
        '
        'TypeIDDataGridViewTextBoxColumn
        '
        Me.TypeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.HeaderText = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.Name = "TypeIDDataGridViewTextBoxColumn"
        Me.TypeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LicenseIDDataGridViewTextBoxColumn
        '
        Me.LicenseIDDataGridViewTextBoxColumn.DataPropertyName = "LicenseID"
        Me.LicenseIDDataGridViewTextBoxColumn.HeaderText = "LicenseID"
        Me.LicenseIDDataGridViewTextBoxColumn.Name = "LicenseIDDataGridViewTextBoxColumn"
        Me.LicenseIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDescriptionDataGridViewTextBoxColumn
        '
        Me.TypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TypeDescription"
        Me.TypeDescriptionDataGridViewTextBoxColumn.HeaderText = "TypeDescription"
        Me.TypeDescriptionDataGridViewTextBoxColumn.Name = "TypeDescriptionDataGridViewTextBoxColumn"
        Me.TypeDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDescriptionDataGridViewTextBoxColumn.Width = 150
        '
        'MACAddressDataGridViewTextBoxColumn
        '
        Me.MACAddressDataGridViewTextBoxColumn.DataPropertyName = "MACAddress"
        Me.MACAddressDataGridViewTextBoxColumn.HeaderText = "MACAddress"
        Me.MACAddressDataGridViewTextBoxColumn.Name = "MACAddressDataGridViewTextBoxColumn"
        Me.MACAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.MACAddressDataGridViewTextBoxColumn.Width = 150
        '
        'Count
        '
        Me.Count.DataPropertyName = "Count"
        Me.Count.HeaderText = "Count"
        Me.Count.Name = "Count"
        Me.Count.ReadOnly = True
        Me.Count.ToolTipText = "Double Click on Existing count Number to change it"
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        Me.IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        Me.DateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateCreatedDataGridViewTextBoxColumn.Width = 150
        '
        'changeActive
        '
        Me.changeActive.HeaderText = "Status"
        Me.changeActive.Name = "changeActive"
        Me.changeActive.ReadOnly = True
        Me.changeActive.Text = "Change"
        Me.changeActive.UseColumnTextForButtonValue = True
        Me.changeActive.Width = 70
        '
        'frmEditProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 403)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxChannels)
        Me.Controls.Add(Me.lblpt)
        Me.Controls.Add(Me.lblMac)
        Me.Controls.Add(Me.cmdInsertMac)
        Me.Controls.Add(Me.txtMac)
        Me.Controls.Add(Me.cbxProjectType)
        Me.Controls.Add(Me.dgvMacs)
        Me.Controls.Add(Me.cbxProjects)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCreateXML)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEditProjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Projects"
        CType(Me.dgvMacs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDgvMacAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Licenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLicenseDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TProjectTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCreateXML As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents fileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxProjects As System.Windows.Forms.ComboBox
    Friend WithEvents Licenses As AssymetricKey.Licenses
    Friend WithEvents TLicenseDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TLicenseDetailsTableAdapter As AssymetricKey.LicensesTableAdapters.tLicenseDetailsTableAdapter
    Friend WithEvents TProjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TProjectsTableAdapter As AssymetricKey.LicensesTableAdapters.tProjectsTableAdapter
    Friend WithEvents dgvMacs As System.Windows.Forms.DataGridView
    Friend WithEvents VDgvMacAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VDgvMacAddressesTableAdapter As AssymetricKey.LicensesTableAdapters.vDgvMacAddressesTableAdapter
    Friend WithEvents cbxProjectType As System.Windows.Forms.ComboBox
    Friend WithEvents txtMac As System.Windows.Forms.TextBox
    Friend WithEvents cmdInsertMac As System.Windows.Forms.Button
    Friend WithEvents lblMac As System.Windows.Forms.Label
    Friend WithEvents lblpt As System.Windows.Forms.Label
    Friend WithEvents TProjectTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TProjectTypesTableAdapter As AssymetricKey.LicensesTableAdapters.tProjectTypesTableAdapter
    Friend WithEvents cbxChannels As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TypeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LicenseIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MACAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents changeActive As System.Windows.Forms.DataGridViewButtonColumn
End Class
