Public Class frmFillProject

    Dim aProjects As Integer()
    Dim aProjectClients As Integer()
    Dim aProjectTypes As Integer()
    Dim forInsert As Boolean = False
    Dim vMaxLicenseNumber As Integer = 0

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmFillProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Licenses.Clear()
        Me.TProjectTypesTableAdapter.Fill(Me.Licenses.tProjectTypes)
        Me.TProjectsTableAdapter.Fill(Me.Licenses.tProjects)
        Me.TClientsTableAdapter.Fill(Me.Licenses.tClients)
        ClearFields()
        resetCombos()
    End Sub

    Private Sub fillCombo(ByVal ComboToLoad As ComboBox)
        Dim tempDataTable As DataTable
        Dim tempDataRow As DataRow
        Dim intIndex As Integer = 0

        ComboToLoad.Items.Clear()
        ComboToLoad.SelectedIndex = -1
        ComboToLoad.Text = ""

        Select Case ComboToLoad.Name
            Case cbxProject.Name
                tempDataTable = TProjectsTableAdapter.GetData()
                If tempDataTable.Rows.Count > 0 Then
                    ReDim aProjects(tempDataTable.Rows.Count)
                    ComboToLoad.Items.Add("New ...")
                    aProjects(0) = 0
                    intIndex = 1
                    For Each tempDataRow In tempDataTable.Rows
                        ComboToLoad.Items.Add(tempDataRow.Item("ProjectDescription"))
                        aProjects(intIndex) = tempDataRow.Item("ProjectID")
                        intIndex += 1
                    Next
                Else
                    ReDim aProjects(0)
                    ComboToLoad.Items.Add("New ...")
                    aProjects(0) = 0
                End If
            Case cbxProjectClient.Name
                tempDataTable = TClientsTableAdapter.GetData()
                If tempDataTable.Rows.Count > 0 Then
                    ReDim aProjectClients(tempDataTable.Rows.Count - 1)
                    For Each tempDataRow In tempDataTable.Rows
                        ComboToLoad.Items.Add(tempDataRow.Item("ClientName") & " - " & tempDataRow.Item("ClientSite"))
                        aProjectClients(intIndex) = tempDataRow.Item("ClientID")
                        intIndex += 1
                    Next
                End If
            Case cbxProjTypes.Name
                tempDataTable = TProjectTypesTableAdapter.GetData()
                If tempDataTable.Rows.Count > 0 Then
                    ReDim aProjectTypes(tempDataTable.Rows.Count)
                    ComboToLoad.Items.Add("New ...")
                    aProjectTypes(0) = 0
                    intIndex = 1
                    For Each tempDataRow In tempDataTable.Rows
                        ComboToLoad.Items.Add(tempDataRow.Item("TypeDescription"))
                        aProjectTypes(intIndex) = tempDataRow.Item("TypeID")
                        intIndex += 1
                    Next
                Else
                    ReDim aProjectTypes(0)
                    ComboToLoad.Items.Add("New ...")
                    aProjectTypes(0) = 0
                End If
            Case cbxClientTb.Name
                tempDataTable = TClientsTableAdapter.GetData()
                If tempDataTable.Rows.Count > 0 Then
                    ReDim aProjectClients(tempDataTable.Rows.Count)
                    ComboToLoad.Items.Add("New ...")
                    aProjectClients(0) = 0
                    intIndex = 1
                    For Each tempDataRow In tempDataTable.Rows
                        ComboToLoad.Items.Add(tempDataRow.Item("ClientName"))
                        aProjectClients(intIndex) = tempDataRow.Item("ClientID")
                        intIndex += 1
                    Next
                Else
                    ReDim aProjectClients(0)
                    ComboToLoad.Items.Add("New ...")
                    aProjectClients(0) = 0
                End If
        End Select

    End Sub

    Private Sub resetCombos()
        fillCombo(cbxProject)
        fillCombo(cbxProjectClient)
        fillCombo(cbxProjTypes)
        fillCombo(cbxClientTb)
    End Sub

    Private Sub ClearFields()
        Me.txtProjectDesc.Text = ""
        Me.cbxProjectClient.SelectedIndex = -1
        Me.txtProjectLic.Text = ""
        ClearClientTab()
        Me.cbxClientTb.SelectedIndex = -1
        Me.cbxProject.SelectedIndex = -1
        ResetLicense()
        Me.cmdSaveProject.Enabled = False
        Me.cmdProjTypesSave.Enabled = False
        Me.cmdClSave.Enabled = False
    End Sub

    Private Sub clearClientTab()
        Me.txtCLSite.Text = ""
        Me.txtCLPhone.Text = ""
        Me.txtCLFax.Text = ""
        Me.txtClDesc.Text = ""
        Me.txtCLCont.Text = ""
        Me.txtCLAddr.Text = ""
    End Sub

    Private Sub ResetLicense()
        If (Me.TProjectsTableAdapter.SQMaxLicenseNumber()).HasValue Then
            vMaxLicenseNumber = Me.TProjectsTableAdapter.SQMaxLicenseNumber() + 1
        Else
            vMaxLicenseNumber = 0
        End If
        Me.txtProjectLic.Enabled = False
        Me.txtProjectLic.Text = vMaxLicenseNumber
    End Sub

    Private Sub retrieveValuesForProject()

    End Sub

    Private Sub cbxProject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProject.SelectedIndexChanged
        Select Case cbxProject.SelectedIndex
            Case 0
                ClearFields()
                forInsert = True
                Me.cmdSaveProject.Enabled = True
            Case Is > 0
                retrieveValuesForProject()
                forInsert = False
                Me.cmdSaveProject.Enabled = True
                Dim tempDatatable As DataTable
                If IsDBNull(Me.TProjectsTableAdapter.GetDataByProjectID(aProjects(cbxProject.SelectedIndex))) Then
                    Throw New Exception("Unexpected failure. project ID Not In Database")
                Else
                    tempDatatable = Me.TProjectsTableAdapter.GetDataByProjectID(aProjects(cbxProject.SelectedIndex))
                    If tempDatatable.Rows.Count = 1 Then
                        Me.txtProjectDesc.Text = tempDatatable.Rows(0).Item("ProjectDescription").ToString
                        Me.txtProjectLic.Text = tempDatatable.Rows(0).Item("LicenseID").ToString
                        Me.cbxProjectClient.SelectedIndex = tempDatatable.Rows(0).Item("ClientID").ToString
                    Else
                        Throw New Exception("Unexpected failure. More than 1 projects with the same project ID")
                    End If
                End If
            Case Else
                Exit Sub
        End Select
    End Sub


    Private Sub cmdSaveProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveProject.Click
        Dim vAllOk As Integer
        Try
            If Me.txtProjectDesc.Text <> "" And Me.txtProjectLic.Text <> "" And Me.cbxProjectClient.SelectedIndex > -1 Then
                If IsNumeric(Me.txtProjectLic.Text) Then
                    'all ok
                Else
                    Throw New Exception("Not Numeric license")
                End If
            Else
                Throw New Exception("Not all Data OK")
            End If
            If forInsert Then
                TProjectsTableAdapter.Insert(Trim(txtProjectDesc.Text), aProjectClients(cbxProjectClient.SelectedIndex), Trim(txtProjectLic.Text), vAllOk)
                If vAllOk = 0 Then
                    MessageBox.Show("Insert Failed Because License number already exists")
                End If
            Else
                TProjectsTableAdapter.Update(Trim(txtProjectDesc.Text), aProjectClients(cbxProjectClient.SelectedIndex), txtProjectLic.Text, aProjects(cbxProject.SelectedIndex))
            End If
            MessageBox.Show("Completed Successfully")
            Me.cmdSaveProject.Enabled = False
            resetCombos()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdClearproject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearproject.Click
        ClearFields()
    End Sub

    Private Sub cmdChangeLicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeLicense.Click
        Me.txtProjectLic.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProjTypesClear.Click
        Me.txtProjTypeDesc.Text = ""
        Me.cbxProjTypes.SelectedIndex = -1
    End Sub

    Private Sub cbxProjTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProjTypes.SelectedIndexChanged
        Select Case cbxProjTypes.SelectedIndex
            Case 0
                Me.txtProjTypeDesc.Text = ""
                Me.cmdProjTypesSave.Enabled = True
                forInsert = True
            Case Is > 0
                Me.cmdProjTypesSave.Enabled = True
                Me.txtProjTypeDesc.Text = Me.cbxProjTypes.Text
                forInsert = False
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub cmdProjTypesSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProjTypesSave.Click
        Try
            If cbxProjTypes.SelectedIndex < 0 Then
                Throw New Exception("Invalid selection of Project Type")
            End If
            Select Case forInsert
                Case True
                    If Trim(Me.txtProjTypeDesc.Text).Length < 1 Then
                        Throw New Exception("Invalid Description of Project Type")
                    End If
                    Me.TProjectTypesTableAdapter.Insert(Trim(Me.txtProjTypeDesc.Text))
                Case False
                    Me.TProjectTypesTableAdapter.Update(aProjectTypes(cbxProjTypes.SelectedIndex), Trim(Me.txtProjTypeDesc.Text))
            End Select
            fillCombo(cbxProjTypes)
            MessageBox.Show("Completed Successfully")
            Me.cmdProjTypesSave.Enabled = False
            Me.txtProjTypeDesc.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TCSatelite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCSatelite.SelectedIndexChanged
        resetCombos()
    End Sub

    Private Sub cbxClientTb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxClientTb.SelectedIndexChanged
        Select Case cbxClientTb.SelectedIndex
            Case 0
                forInsert = True
                clearClientTab()
                Me.cmdClSave.Enabled = True
            Case Is > 0
                forInsert = False
                Me.cmdClSave.Enabled = True
                Dim tempDatatable As DataTable
                If IsDBNull(Me.TClientsTableAdapter.GetDataByClientID(aProjectClients(cbxClientTb.SelectedIndex))) Then
                    Throw New Exception("Unexpected failure. Selected Client ID Not In Database")
                Else
                    tempDatatable = Me.TClientsTableAdapter.GetDataByClientID(aProjectClients(cbxClientTb.SelectedIndex))
                    If tempDatatable.Rows.Count = 1 Then
                        Me.txtCLSite.Text = tempDatatable.Rows(0).Item("ClientSite").ToString
                        Me.txtCLPhone.Text = tempDatatable.Rows(0).Item("ClientTelephone").ToString
                        Me.txtCLFax.Text = tempDatatable.Rows(0).Item("ClientFax").ToString
                        Me.txtClDesc.Text = tempDatatable.Rows(0).Item("ClientName").ToString
                        Me.txtCLCont.Text = tempDatatable.Rows(0).Item("ClientContact").ToString
                        Me.txtCLAddr.Text = tempDatatable.Rows(0).Item("ClientAddress").ToString
                    Else
                        Throw New Exception("Unexpected failure. More than 1 Client with the same Client ID")
                    End If
                End If
            Case Else
                Exit Sub
        End Select

    End Sub

    Private Sub cmdClSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClSave.Click
        Try
            If Trim(Me.txtClDesc.Text) = "" Or Trim(Me.txtCLSite.Text) = "" Then
                Throw New Exception("Complete Name And Site")
            End If
            Select Case forInsert
                Case True
                    Me.TClientsTableAdapter.Insert(Trim(Me.txtClDesc.Text), Trim(Me.txtCLSite.Text), _
                                                    Trim(Me.txtCLPhone.Text), Trim(Me.txtCLCont.Text), _
                                                    Trim(Me.txtCLAddr.Text), Trim(Me.txtCLFax.Text))
                Case False
                    Me.TClientsTableAdapter.Update(Trim(Me.txtClDesc.Text), Trim(Me.txtCLSite.Text), _
                                                    Trim(Me.txtCLPhone.Text), Trim(Me.txtCLCont.Text), _
                                                    Trim(Me.txtCLAddr.Text), Trim(Me.txtCLFax.Text), _
                                                    aProjectClients(cbxClientTb.SelectedIndex))
            End Select
            MessageBox.Show("Completed Successfully")
            Me.cmdClSave.Enabled = True
            ClearFields()
            resetCombos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdClClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClClear.Click
        ClearFields()
    End Sub
End Class