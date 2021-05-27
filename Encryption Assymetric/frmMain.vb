Public Class frmMain

    Private Sub cmdFillTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillTables.Click
        Dim frmFillTables As New frmFillProject
        frmFillTables.Show()
    End Sub

    Private Sub cmdDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetails.Click
        Dim frmxml As New frmEditProjects
        frmxml.Show()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdTests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTests.Click
        Dim frmTests As New frmTest
        frmTests.Show()
    End Sub
End Class