Public Class frmServicio
    Private Sub ServicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ServicioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ServiciosPrestadosDataSet)

    End Sub

    Private Sub frmServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.servicio)

    End Sub
End Class