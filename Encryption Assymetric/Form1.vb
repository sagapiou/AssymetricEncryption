
Public Class frmTest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim AssXMLEncryption As New cXMLLicenseEncryption
        AssXMLEncryption.AssymetricXMLEncryption("c:\virtualcontrols\test0.xml")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim xmlMacAddr As String()
        Dim AssXMLEncryption As New cXMLLicenseEncryption
        xmlMacAddr = AssXMLEncryption.ReadDataFromXML(1, "c:\VirtualControls\test.xml", 1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim txtString As String
        Dim RSEncrypt As RijndaelSimple = New RijndaelSimple()
        txtString = RSEncrypt.BeginStringEncryption(txtToEncrypt.Text)
        txtToEncrypt.Text = txtString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim txtString As String
        Dim RSEncrypt As RijndaelSimple = New RijndaelSimple()
        txtString = RSEncrypt.BeginStringDecryption(txtToEncrypt.Text)
        txtToEncrypt.Text = txtString
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim SymXMLEncryption As New cXMLLicenseEncryption
        SymXMLEncryption.SymetricXMLEncryption("c:\virtualcontrols\test.xml")
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim xmlMacAddr As String()
        Dim SymXMLEncryption As New cXMLLicenseEncryption
        xmlMacAddr = SymXMLEncryption.ReadDataFromXML(0, "c:\virtualcontrols\test1.xml", 2)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim frmxml As New frmEditProjects
        frmxml.Show()
    End Sub

    Private Sub cmdFillTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillTables.Click
        Dim frmFillTables As New frmFillProject
        frmFillTables.Show()
    End Sub
End Class
