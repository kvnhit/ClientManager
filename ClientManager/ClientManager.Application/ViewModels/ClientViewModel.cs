
using ClienteManager.Core.Entities;

namespace ClientManager.Application.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel(){}
        public ClientViewModel(int id, string cPF, string nome, string rG, DateTime dataExpedicao, string orgaoExpedicao, string ufOrgao, DateTime dataNascimento, string sexo, string estadoCivil, string cEP, string logradouro, string numero, string? complemento, string bairro, string cidade, string ufEndereco)
        {
            Id = id;
            CPF = cPF;
            Nome = nome;
            RG = rG;
            DataExpedicao = dataExpedicao;
            OrgaoExpedicao = orgaoExpedicao;
            UfOrgao = ufOrgao;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UfEndereco = ufEndereco;
        }
        public int Id { get; private set; }
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public string RG { get; private set; }
        public DateTime DataExpedicao { get; private set; }
        public string OrgaoExpedicao { get; private set; }
        public string UfOrgao { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Sexo { get; private set; }
        public string EstadoCivil { get; private set; }
        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string? Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UfEndereco { get; private set; }
    }
}
