Imports System.IO

Public Class Empresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub BTN_Salvar_Click(sender As Object, e As EventArgs) Handles BTN_Salvar.Click
        Try
            Dim EmpresaService As New EmpresaService
            Dim Empresa As New EmpresaModel With {
            .NomeFantasia = TXT_NomeFantasia.Text,
            .RazaoSocial = TXT_RazaoSocial.Text,
            .CNPJ = TXT_CNPJ.Text,
            .InscricaoEstadual = TXT_InscricaoEstadual.Text,
            .DataAbertura = TXT_DataAbertura.Text,
            .Email = TXT_Email.Text,
            .Telefone = TXT_Telefone.Text
        }
            EmpresaService.Cadastrar(Empresa)
            LimparCampos()

        Catch ex As Exception
            Dim mensagemErro As String = "Erro ao salvar no banco de dados: " & ex.Message
            Dim script As String = $"alert('{mensagemErro}');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "ErroSalvar", script, True)

            ' Log do erro ocorrido
            GravarLog("Erro ao salvar no banco de dados: " & ex.Message)
            ' Tratar exceção, se necessário

        End Try
    End Sub

    Private Sub LimparCampos()
        TXT_NomeFantasia.Text = ""
        TXT_RazaoSocial.Text = ""
        TXT_CNPJ.Text = ""
        TXT_InscricaoEstadual.Text = ""
        TXT_DataAbertura.Text = ""
        TXT_Email.Text = ""
        TXT_Telefone.Text = ""
    End Sub

    Private Sub GravarLog(mensagem As String)
        ' Caminho do arquivo de log
        Dim logPath As String = Server.MapPath("~/Logs/log.txt")

        ' Escreve a mensagem de log no arquivo
        Using writer As StreamWriter = File.AppendText(logPath)
            writer.WriteLine($"{DateTime.Now} - {mensagem}")
        End Using
    End Sub

    'ScriptManager.RegisterClientScriptBlock(Me, GetType(Page), "", "<script language=""javascript"">alert('Falha ao carregar empresas.');</script>", False)



End Class