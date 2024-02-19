Public Class EmpresaService
    Public Function Cadastrar(empresa As EmpresaModel) As Boolean
        Try
            Dim empresaDAO As New EmpresaDAO
            empresaDAO.Insert(empresa)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
