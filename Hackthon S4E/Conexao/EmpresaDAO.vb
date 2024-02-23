Imports System.Data.Common
Imports System.Data.SqlClient

Public Class EmpresaDAO
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
    Public Sub Insert(empresa As EmpresaModel)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim sql As String = "INSERT INTO Empresa (NomeFantasia) VALUES (@NomeFantasia)"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia)
                    command.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial)
                    command.Parameters.AddWithValue("@CNPJ", empresa.CNPJ)
                    command.Parameters.AddWithValue("@InscricaoEstadual", empresa.InscricaoEstadual)
                    command.Parameters.AddWithValue("@DataAbertura", empresa.DataAbertura)
                    command.Parameters.AddWithValue("@Email", empresa.Email)
                    command.Parameters.AddWithValue("@Telefone", empresa.Telefone)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
