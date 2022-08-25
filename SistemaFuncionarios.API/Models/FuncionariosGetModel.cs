namespace SistemaFuncionarios.Api.Models
{
    /// <summary>
    /// GET /api/Funcionarios
    /// Modelo de dados para o serviço de consulta de funcionários
    /// </summary>
    public class FuncionariosGetModel
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
    }
}