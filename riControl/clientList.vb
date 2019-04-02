Public Class clientList
    Private Sub TbClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbClientesBindingSource.EndEdit()


    End Sub

    Private Sub clientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RiControl_dbDataSet1.tbClientes' table. You can move, or remove it, as needed.
        Me.TbClientesTableAdapter.Fill(Me.RiControl_dbDataSet1.tbClientes)


    End Sub
End Class