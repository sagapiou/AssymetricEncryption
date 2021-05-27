<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFillProject
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
        Me.TCSatelite = New System.Windows.Forms.TabControl
        Me.tpProject = New System.Windows.Forms.TabPage
        Me.cmdChangeLicense = New System.Windows.Forms.Button
        Me.cmdClearproject = New System.Windows.Forms.Button
        Me.cmdSaveProject = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtProjectLic = New System.Windows.Forms.TextBox
        Me.cbxProjectClient = New System.Windows.Forms.ComboBox
        Me.txtProjectDesc = New System.Windows.Forms.TextBox
        Me.cbxProject = New System.Windows.Forms.ComboBox
        Me.tpClient = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCLFax = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCLPhone = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCLAddr = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCLCont = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCLSite = New System.Windows.Forms.TextBox
        Me.cmdClClear = New System.Windows.Forms.Button
        Me.cmdClSave = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtClDesc = New System.Windows.Forms.TextBox
        Me.cbxClientTb = New System.Windows.Forms.ComboBox
        Me.tpTypes = New System.Windows.Forms.TabPage
        Me.cmdProjTypesClear = New System.Windows.Forms.Button
        Me.cmdProjTypesSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtProjTypeDesc = New System.Windows.Forms.TextBox
        Me.cbxProjTypes = New System.Windows.Forms.ComboBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Licenses = New AssymetricKey.Licenses
        Me.TClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TClientsTableAdapter = New AssymetricKey.LicensesTableAdapters.tClientsTableAdapter
        Me.TProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TProjectsTableAdapter = New AssymetricKey.LicensesTableAdapters.tProjectsTableAdapter
        Me.TProjectTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TProjectTypesTableAdapter = New AssymetricKey.LicensesTableAdapters.tProjectTypesTableAdapter
        Me.TCSatelite.SuspendLayout()
        Me.tpProject.SuspendLayout()
        Me.tpClient.SuspendLayout()
        Me.tpTypes.SuspendLayout()
        CType(Me.Licenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TProjectTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCSatelite
        '
        Me.TCSatelite.Controls.Add(Me.tpProject)
        Me.TCSatelite.Controls.Add(Me.tpClient)
        Me.TCSatelite.Controls.Add(Me.tpTypes)
        Me.TCSatelite.Location = New System.Drawing.Point(9, 10)
        Me.TCSatelite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TCSatelite.Name = "TCSatelite"
        Me.TCSatelite.SelectedIndex = 0
        Me.TCSatelite.Size = New System.Drawing.Size(396, 421)
        Me.TCSatelite.TabIndex = 0
        '
        'tpProject
        '
        Me.tpProject.BackColor = System.Drawing.SystemColors.Control
        Me.tpProject.Controls.Add(Me.cmdChangeLicense)
        Me.tpProject.Controls.Add(Me.cmdClearproject)
        Me.tpProject.Controls.Add(Me.cmdSaveProject)
        Me.tpProject.Controls.Add(Me.Label4)
        Me.tpProject.Controls.Add(Me.Label2)
        Me.tpProject.Controls.Add(Me.Label1)
        Me.tpProject.Controls.Add(Me.txtProjectLic)
        Me.tpProject.Controls.Add(Me.cbxProjectClient)
        Me.tpProject.Controls.Add(Me.txtProjectDesc)
        Me.tpProject.Controls.Add(Me.cbxProject)
        Me.tpProject.Location = New System.Drawing.Point(4, 22)
        Me.tpProject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpProject.Name = "tpProject"
        Me.tpProject.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpProject.Size = New System.Drawing.Size(388, 395)
        Me.tpProject.TabIndex = 0
        Me.tpProject.Text = "Project"
        '
        'cmdChangeLicense
        '
        Me.cmdChangeLicense.Location = New System.Drawing.Point(118, 280)
        Me.cmdChangeLicense.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdChangeLicense.Name = "cmdChangeLicense"
        Me.cmdChangeLicense.Size = New System.Drawing.Size(24, 19)
        Me.cmdChangeLicense.TabIndex = 11
        Me.cmdChangeLicense.Text = "..."
        Me.cmdChangeLicense.UseVisualStyleBackColor = True
        '
        'cmdClearproject
        '
        Me.cmdClearproject.Location = New System.Drawing.Point(198, 346)
        Me.cmdClearproject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdClearproject.Name = "cmdClearproject"
        Me.cmdClearproject.Size = New System.Drawing.Size(84, 27)
        Me.cmdClearproject.TabIndex = 10
        Me.cmdClearproject.Text = "Clear"
        Me.cmdClearproject.UseVisualStyleBackColor = True
        '
        'cmdSaveProject
        '
        Me.cmdSaveProject.Location = New System.Drawing.Point(58, 346)
        Me.cmdSaveProject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSaveProject.Name = "cmdSaveProject"
        Me.cmdSaveProject.Size = New System.Drawing.Size(84, 27)
        Me.cmdSaveProject.TabIndex = 9
        Me.cmdSaveProject.Text = "Save"
        Me.cmdSaveProject.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LicenseID (initially proposed)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Project Client"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Project Name"
        '
        'txtProjectLic
        '
        Me.txtProjectLic.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtProjectLic.Location = New System.Drawing.Point(5, 280)
        Me.txtProjectLic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtProjectLic.Name = "txtProjectLic"
        Me.txtProjectLic.Size = New System.Drawing.Size(104, 20)
        Me.txtProjectLic.TabIndex = 4
        '
        'cbxProjectClient
        '
        Me.cbxProjectClient.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbxProjectClient.FormattingEnabled = True
        Me.cbxProjectClient.Location = New System.Drawing.Point(5, 124)
        Me.cbxProjectClient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxProjectClient.Name = "cbxProjectClient"
        Me.cbxProjectClient.Size = New System.Drawing.Size(251, 20)
        Me.cbxProjectClient.TabIndex = 2
        '
        'txtProjectDesc
        '
        Me.txtProjectDesc.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtProjectDesc.Location = New System.Drawing.Point(5, 86)
        Me.txtProjectDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtProjectDesc.Name = "txtProjectDesc"
        Me.txtProjectDesc.Size = New System.Drawing.Size(251, 20)
        Me.txtProjectDesc.TabIndex = 1
        '
        'cbxProject
        '
        Me.cbxProject.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbxProject.FormattingEnabled = True
        Me.cbxProject.Location = New System.Drawing.Point(4, 24)
        Me.cbxProject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxProject.Name = "cbxProject"
        Me.cbxProject.Size = New System.Drawing.Size(252, 20)
        Me.cbxProject.TabIndex = 0
        '
        'tpClient
        '
        Me.tpClient.BackColor = System.Drawing.SystemColors.Control
        Me.tpClient.Controls.Add(Me.Label12)
        Me.tpClient.Controls.Add(Me.txtCLFax)
        Me.tpClient.Controls.Add(Me.Label11)
        Me.tpClient.Controls.Add(Me.txtCLPhone)
        Me.tpClient.Controls.Add(Me.Label10)
        Me.tpClient.Controls.Add(Me.txtCLAddr)
        Me.tpClient.Controls.Add(Me.Label8)
        Me.tpClient.Controls.Add(Me.txtCLCont)
        Me.tpClient.Controls.Add(Me.Label6)
        Me.tpClient.Controls.Add(Me.txtCLSite)
        Me.tpClient.Controls.Add(Me.cmdClClear)
        Me.tpClient.Controls.Add(Me.cmdClSave)
        Me.tpClient.Controls.Add(Me.Label9)
        Me.tpClient.Controls.Add(Me.txtClDesc)
        Me.tpClient.Controls.Add(Me.cbxClientTb)
        Me.tpClient.Location = New System.Drawing.Point(4, 22)
        Me.tpClient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpClient.Name = "tpClient"
        Me.tpClient.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpClient.Size = New System.Drawing.Size(388, 395)
        Me.tpClient.TabIndex = 1
        Me.tpClient.Text = "Clients"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 241)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Client Fax"
        '
        'txtCLFax
        '
        Me.txtCLFax.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCLFax.Location = New System.Drawing.Point(13, 258)
        Me.txtCLFax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCLFax.Name = "txtCLFax"
        Me.txtCLFax.Size = New System.Drawing.Size(129, 20)
        Me.txtCLFax.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 204)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Client telephone"
        '
        'txtCLPhone
        '
        Me.txtCLPhone.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCLPhone.Location = New System.Drawing.Point(10, 220)
        Me.txtCLPhone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCLPhone.Name = "txtCLPhone"
        Me.txtCLPhone.Size = New System.Drawing.Size(132, 20)
        Me.txtCLPhone.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 167)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Client Address"
        '
        'txtCLAddr
        '
        Me.txtCLAddr.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCLAddr.Location = New System.Drawing.Point(10, 183)
        Me.txtCLAddr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCLAddr.Name = "txtCLAddr"
        Me.txtCLAddr.Size = New System.Drawing.Size(251, 20)
        Me.txtCLAddr.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 129)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Client Contact"
        '
        'txtCLCont
        '
        Me.txtCLCont.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCLCont.Location = New System.Drawing.Point(10, 145)
        Me.txtCLCont.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCLCont.Name = "txtCLCont"
        Me.txtCLCont.Size = New System.Drawing.Size(251, 20)
        Me.txtCLCont.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Client Site"
        '
        'txtCLSite
        '
        Me.txtCLSite.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCLSite.Location = New System.Drawing.Point(10, 108)
        Me.txtCLSite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCLSite.Name = "txtCLSite"
        Me.txtCLSite.Size = New System.Drawing.Size(251, 20)
        Me.txtCLSite.TabIndex = 23
        '
        'cmdClClear
        '
        Me.cmdClClear.Location = New System.Drawing.Point(199, 346)
        Me.cmdClClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdClClear.Name = "cmdClClear"
        Me.cmdClClear.Size = New System.Drawing.Size(84, 27)
        Me.cmdClClear.TabIndex = 22
        Me.cmdClClear.Text = "Clear"
        Me.cmdClClear.UseVisualStyleBackColor = True
        '
        'cmdClSave
        '
        Me.cmdClSave.Location = New System.Drawing.Point(57, 346)
        Me.cmdClSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdClSave.Name = "cmdClSave"
        Me.cmdClSave.Size = New System.Drawing.Size(84, 27)
        Me.cmdClSave.TabIndex = 21
        Me.cmdClSave.Text = "Save"
        Me.cmdClSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 54)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Client Name"
        '
        'txtClDesc
        '
        Me.txtClDesc.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtClDesc.Location = New System.Drawing.Point(10, 70)
        Me.txtClDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClDesc.Name = "txtClDesc"
        Me.txtClDesc.Size = New System.Drawing.Size(251, 20)
        Me.txtClDesc.TabIndex = 13
        '
        'cbxClientTb
        '
        Me.cbxClientTb.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbxClientTb.FormattingEnabled = True
        Me.cbxClientTb.Location = New System.Drawing.Point(12, 13)
        Me.cbxClientTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxClientTb.Name = "cbxClientTb"
        Me.cbxClientTb.Size = New System.Drawing.Size(252, 20)
        Me.cbxClientTb.TabIndex = 12
        '
        'tpTypes
        '
        Me.tpTypes.BackColor = System.Drawing.SystemColors.Control
        Me.tpTypes.Controls.Add(Me.cmdProjTypesClear)
        Me.tpTypes.Controls.Add(Me.cmdProjTypesSave)
        Me.tpTypes.Controls.Add(Me.Label5)
        Me.tpTypes.Controls.Add(Me.txtProjTypeDesc)
        Me.tpTypes.Controls.Add(Me.cbxProjTypes)
        Me.tpTypes.Location = New System.Drawing.Point(4, 22)
        Me.tpTypes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTypes.Name = "tpTypes"
        Me.tpTypes.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTypes.Size = New System.Drawing.Size(388, 395)
        Me.tpTypes.TabIndex = 2
        Me.tpTypes.Text = "Project Types"
        '
        'cmdProjTypesClear
        '
        Me.cmdProjTypesClear.Location = New System.Drawing.Point(206, 315)
        Me.cmdProjTypesClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdProjTypesClear.Name = "cmdProjTypesClear"
        Me.cmdProjTypesClear.Size = New System.Drawing.Size(84, 27)
        Me.cmdProjTypesClear.TabIndex = 13
        Me.cmdProjTypesClear.Text = "Clear"
        Me.cmdProjTypesClear.UseVisualStyleBackColor = True
        '
        'cmdProjTypesSave
        '
        Me.cmdProjTypesSave.Location = New System.Drawing.Point(65, 315)
        Me.cmdProjTypesSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdProjTypesSave.Name = "cmdProjTypesSave"
        Me.cmdProjTypesSave.Size = New System.Drawing.Size(84, 27)
        Me.cmdProjTypesSave.TabIndex = 12
        Me.cmdProjTypesSave.Text = "Save"
        Me.cmdProjTypesSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 76)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Project Type Description"
        '
        'txtProjTypeDesc
        '
        Me.txtProjTypeDesc.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtProjTypeDesc.Location = New System.Drawing.Point(5, 93)
        Me.txtProjTypeDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtProjTypeDesc.Name = "txtProjTypeDesc"
        Me.txtProjTypeDesc.Size = New System.Drawing.Size(251, 20)
        Me.txtProjTypeDesc.TabIndex = 2
        '
        'cbxProjTypes
        '
        Me.cbxProjTypes.FormattingEnabled = True
        Me.cbxProjTypes.Location = New System.Drawing.Point(5, 22)
        Me.cbxProjTypes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxProjTypes.Name = "cbxProjTypes"
        Me.cbxProjTypes.Size = New System.Drawing.Size(168, 21)
        Me.cbxProjTypes.TabIndex = 0
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(326, 444)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 19)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Licenses
        '
        Me.Licenses.DataSetName = "Licenses"
        Me.Licenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TClientsBindingSource
        '
        Me.TClientsBindingSource.DataMember = "tClients"
        Me.TClientsBindingSource.DataSource = Me.Licenses
        '
        'TClientsTableAdapter
        '
        Me.TClientsTableAdapter.ClearBeforeFill = True
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
        'TProjectTypesBindingSource
        '
        Me.TProjectTypesBindingSource.DataMember = "tProjectTypes"
        Me.TProjectTypesBindingSource.DataSource = Me.Licenses
        '
        'TProjectTypesTableAdapter
        '
        Me.TProjectTypesTableAdapter.ClearBeforeFill = True
        '
        'frmFillProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 473)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.TCSatelite)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmFillProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFillProject"
        Me.TCSatelite.ResumeLayout(False)
        Me.tpProject.ResumeLayout(False)
        Me.tpProject.PerformLayout()
        Me.tpClient.ResumeLayout(False)
        Me.tpClient.PerformLayout()
        Me.tpTypes.ResumeLayout(False)
        Me.tpTypes.PerformLayout()
        CType(Me.Licenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TProjectTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCSatelite As System.Windows.Forms.TabControl
    Friend WithEvents tpProject As System.Windows.Forms.TabPage
    Friend WithEvents tpClient As System.Windows.Forms.TabPage
    Friend WithEvents tpTypes As System.Windows.Forms.TabPage
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cbxProject As System.Windows.Forms.ComboBox
    Friend WithEvents Licenses As AssymetricKey.Licenses
    Friend WithEvents TClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TClientsTableAdapter As AssymetricKey.LicensesTableAdapters.tClientsTableAdapter
    Friend WithEvents TProjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TProjectsTableAdapter As AssymetricKey.LicensesTableAdapters.tProjectsTableAdapter
    Friend WithEvents TProjectTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TProjectTypesTableAdapter As AssymetricKey.LicensesTableAdapters.tProjectTypesTableAdapter
    Friend WithEvents txtProjectDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectLic As System.Windows.Forms.TextBox
    Friend WithEvents cbxProjectClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClearproject As System.Windows.Forms.Button
    Friend WithEvents cmdSaveProject As System.Windows.Forms.Button
    Friend WithEvents cmdChangeLicense As System.Windows.Forms.Button
    Friend WithEvents cmdProjTypesClear As System.Windows.Forms.Button
    Friend WithEvents cmdProjTypesSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProjTypeDesc As System.Windows.Forms.TextBox
    Friend WithEvents cbxProjTypes As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCLSite As System.Windows.Forms.TextBox
    Friend WithEvents cmdClClear As System.Windows.Forms.Button
    Friend WithEvents cmdClSave As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtClDesc As System.Windows.Forms.TextBox
    Friend WithEvents cbxClientTb As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCLFax As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCLPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCLAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCLCont As System.Windows.Forms.TextBox
End Class
