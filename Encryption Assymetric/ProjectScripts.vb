Imports System.Xml

Module ProjectScripts

    Friend Sub WriteXML(ByVal XmlLocation As String, ByVal PojId As Integer, ByVal LicData As DataTable, ByVal ProjectTypes As DataTable)
        Dim writer As New XmlTextWriter(XmlLocation, System.Text.Encoding.UTF8)
        Dim LicRow, ProjTypeRow As DataRow
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("LicenseFile")
        writer.WriteStartElement("Project")
        writer.WriteAttributeString("PrID", PojId.ToString)

        For Each ProjTypeRow In ProjectTypes.Rows
            If LicData.Select("IsActive=true AND TypeID = " & ProjTypeRow.Item("TypeID"), "TypeID ASC").Length > 0 Then
                writer.WriteStartElement("ProjectType")
                writer.WriteAttributeString("val", ProjTypeRow.Item("TypeID"))
                For Each LicRow In LicData.Select("IsActive=true AND TypeID = " & ProjTypeRow.Item("TypeID"), "TypeID ASC")
                    createNode(LicRow.Item("MACAddress"), writer, LicRow.Item("count"))
                Next
                writer.WriteEndElement()
            End If
        Next
        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub

    Private Sub createNode(ByVal Mac As String, ByVal writer As XmlTextWriter, ByVal vMacCount As Integer)
        writer.WriteStartElement("Mac")
        writer.WriteAttributeString("count", vMacCount.ToString)
        writer.WriteString(Mac)
        writer.WriteEndElement()
    End Sub

End Module
