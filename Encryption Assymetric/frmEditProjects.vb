Public Class frmEditProjects

    Dim aProjects, aProjTypes As Integer()
    Dim vSelectedProject, vSelectedLisenceID As Integer


    Private Sub frmEditProjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TProjectTypesTableAdapter.Fill(Me.Licenses.tProjectTypes)
        Me.TProjectsTableAdapter.Fill(Me.Licenses.tProjects)
        Me.TLicenseDetailsTableAdapter.Fill(Me.Licenses.tLicenseDetails)
        fillCombo(cbxProjects)
        fillCombo(cbxProjectType)
    End Sub

    Private Sub fillCombo(ByVal ComboToLoad As ComboBox)
        Dim tempDataTable As DataTable
        Dim tempDataRow As DataRow
        Dim intIndex As Integer = 0

        ComboToLoad.Items.Clear()
        ComboToLoad.SelectedIndex = -1
        ComboToLoad.Text = ""

        Select Case ComboToLoad.Name
            Case cbxProjects.Name
                tempDataTable = TProjectsTableAdapter.GetData()
                If tempDataTable.Rows.Count > 0 Then
                    ReDim aProjects(tempDataTable.Rows.Count - 1)
                    For Each tempDataRow In tempDataTable.Rows
                        ComboToLoad.Items.Add(tempDataRow.Item("ProjectDescription"))
                        aProjects(intIndex) = tempDataRow.Item("ProjectID")
                        intIndex += 1
                    Next
                End If
            Case cbxProjectType.Name
                tempDataTable = TProjectTypesTableAdapter.GetData()
                If tempDataTable.Rows.Count > 0 Then
                    ReDim aProjTypes(tempDataTable.Rows.Count - 1)
                    For Each tempDataRow In tempDataTable.Rows
                        ComboToLoad.Items.Add(tempDataRow.Item("TypeDescription"))
                        aProjTypes(intIndex) = tempDataRow.Item("TypeID")
                        intIndex += 1
                    Next
                End If
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub cmdCreateXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateXML.Click
        fileDialog.ShowDialog()
    End Sub

    Private Sub fileDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fileDialog.FileOk
        MessageBox.Show(fileDialog.FileName.ToLower)
        Me.VDgvMacAddressesTableAdapter.FillByLisenceID(Me.Licenses.vDgvMacAddresses, vSelectedLisenceID)
        ProjectScripts.WriteXML(fileDialog.FileName.ToLower, vSelectedProject, Me.VDgvMacAddressesTableAdapter.GetDataByLisenceID(vSelectedLisenceID), Me.TProjectTypesTableAdapter.GetData())
        If MessageBox.Show("Encrypt the XMLFile?", "Encryption", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim cEncr As New cXMLLicenseEncryption
            cEncr.SymetricXMLEncryption(fileDialog.FileName.ToLower)
        End If
    End Sub

    Private Sub RefreshDGV()
        Me.VDgvMacAddressesTableAdapter.FillByLisenceID(Me.Licenses.vDgvMacAddresses, vSelectedLisenceID)
        Me.dgvMacs.Refresh()
    End Sub


    Private Sub cbxProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProjects.SelectedIndexChanged
        If cbxProjects.SelectedIndex > -1 Then
            vSelectedProject = aProjects(cbxProjects.SelectedIndex)
            Dim tempdatatable As DataTable
            tempdatatable = Me.TProjectsTableAdapter.GetDataByProjectID(vSelectedProject)
            If tempdatatable.Rows.Count = 1 Then
                vSelectedLisenceID = tempdatatable.Rows(0).Item("LicenseID")
                Me.VDgvMacAddressesTableAdapter.FillByLisenceID(Me.Licenses.vDgvMacAddresses, vSelectedLisenceID)
                RefreshDGV()
            Else
                Throw New Exception("Unexpected error. invalid lisence assigned to specific project.")
            End If
        End If
    End Sub

    Private Sub cmdInsertMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertMac.Click
        Dim vAllOk As Integer
        Dim vNoOfChnnels As Integer
        Try
            If vSelectedProject < 0 And vSelectedLisenceID < 1 Then
                Throw New Exception("Porject or Lisence Missing")
            End If
            If Trim(Me.txtMac.Text).Length <> 12 Then
                Throw New Exception("Invalid Mac Address Length")
            End If
            If Me.cbxProjectType.SelectedIndex < 0 Then
                Throw New Exception("Invalid Mac Address Length")
            End If
            If Me.cbxProjectType.SelectedIndex < 0 Then
                Throw New Exception("Invalid Channel Count")
            End If
            Integer.TryParse(Me.cbxChannels.Text, vNoOfChnnels)
            Me.TLicenseDetailsTableAdapter.Insert(Trim(txtMac.Text), vSelectedLisenceID, aProjTypes(cbxProjectType.SelectedIndex), vNoOfChnnels, vAllOk)
            If vAllOk <> 1 Then
                Throw New Exception("Lisence for Mac Already exists")
            Else
                MessageBox.Show("Completed Successfully")
                cbxProjectType.SelectedIndex = -1
                txtMac.Text = ""
                RefreshDGV()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvMacs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMacs.CellContentClick
        If e.ColumnIndex() = 7 Then
            Dim vActive As Boolean
            If dgvMacs.Rows(e.RowIndex).Cells(5).Value = "True" Then
                vActive = False
            Else
                vActive = True
            End If
            Me.TLicenseDetailsTableAdapter.Update(dgvMacs.Rows(e.RowIndex).Cells(3).Value, dgvMacs.Rows(e.RowIndex).Cells(0).Value, dgvMacs.Rows(e.RowIndex).Cells(1).Value, vActive)
            RefreshDGV()
        End If

    End Sub

    Private Sub dgvMacs_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMacs.CellContentDoubleClick
        If e.ColumnIndex() = 4 Then
            Dim vNewCount As String
            Dim vIntCount As Integer
            vNewCount = InputBox("Please Insert new Count (value 1-16) :", "Number of Channels", "1")
            Try
                Integer.TryParse(vNewCount, vIntCount)
                If vIntCount >= 0 And vIntCount < 17 Then
                    Me.TLicenseDetailsTableAdapter.EditLicenseCount(dgvMacs.Rows(e.RowIndex).Cells(3).Value, dgvMacs.Rows(e.RowIndex).Cells(0).Value, dgvMacs.Rows(e.RowIndex).Cells(1).Value, vIntCount)
                Else
                    Throw New Exception("invalid Channel Count")
                End If
                RefreshDGV()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
End Class