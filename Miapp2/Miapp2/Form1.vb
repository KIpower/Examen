Imports System.Data
Imports System.Data.SqlClient


Public Class Form1

    Dim cadconex As New SqlConnection("Data Source=IHR80PBBF21\MSSQLSERVER1;Network Library=DBMSSOCN;Initial Catalog=Almacen;User ID=Cueva_Fernandez2;Password=1234; ")
    Dim connectionString As String = "Data Source=IHR80PBBF21\MSSQLSERVER1;Initial Catalog=Almacen;User ID=Cueva_Fernandez2;Password=1234"

    Sub cargartabla()
        Dim da As New SqlDataAdapter("Sp_ListaProveedor", cadconex)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        da.Dispose()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles txt.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, label3.Click, Label9.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call cargartabla()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            codigo.Text = DataGridView1.CurrentRow.Cells(0).Value
            rsocial.Text = DataGridView1.CurrentRow.Cells(1).Value
            ruc.Text = DataGridView1.CurrentRow.Cells(2).Value
            direccion.Text = DataGridView1.CurrentRow.Cells(3).Value
            email.Text = DataGridView1.CurrentRow.Cells(4).Value
            telefono.Text = DataGridView1.CurrentRow.Cells(5).Value
            fax.Text = DataGridView1.CurrentRow.Cells(6).Value
            web.Text = DataGridView1.CurrentRow.Cells(7).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each Control In Controls
            If TypeOf Control Is TextBox Then
                Control.clear()
            End If
            If TypeOf Control Is MaskedTextBox Then
                Control.clear()
            End If
            If TypeOf Control Is ComboBox Then
                Control.Selectedvalue = -1
            End If
        Next
        rsocial.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = cadconex
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_InsertarProveedor"
            cmd.Parameters.Add("@rsocial", SqlDbType.VarChar, 100).Value = rsocial.Text
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 15).Value = ruc.Text
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = direccion.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email.Text
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = telefono.Text
            cmd.Parameters.Add("@fax", SqlDbType.VarChar, 15).Value = fax.Text
            cmd.Parameters.Add("@web", SqlDbType.VarChar, 100).Value = web.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            da.Dispose()
            Call cargartabla()
            MsgBox("registro insertado exitosamente")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = cadconex
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_ActualizarProveedor"
            cmd.Parameters.Add("@codproveedor", SqlDbType.Int).Value = CInt(codigo.Text)
            cmd.Parameters.Add("@rsocial", SqlDbType.VarChar, 100).Value = rsocial.Text
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 15).Value = ruc.Text
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = direccion.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email.Text
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value = telefono.Text
            cmd.Parameters.Add("@fax", SqlDbType.VarChar, 15).Value = fax.Text
            cmd.Parameters.Add("@web", SqlDbType.VarChar, 100).Value = web.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            da.Dispose()
            Call cargartabla()
            MsgBox("registro actualizado exitosamente")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim terminoBusqueda As String = busqueda.Text.Trim()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand("Sp_Buscar", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@terminoBusqueda", terminoBusqueda)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            End Using
        End Using
    End Sub
End Class
