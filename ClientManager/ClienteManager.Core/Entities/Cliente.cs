using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteManager.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente() { }

        public Cliente(string cPF, string nome, string rG, DateTime dataExpedicao, string orgaoExpedicao, string ufOrgao, DateTime dataNascimento, string sexo, string estadoCivil, string cep, string logradouro, string numero, string? complemento, string bairro, string cidade, string ufEndereco)
        {
            CPF = cPF;
            Nome = nome;
            RG = rG;
            DataExpedicao = dataExpedicao;
            OrgaoExpedicao = orgaoExpedicao;
            UfOrgao = ufOrgao;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UfEndereco = ufEndereco;
        }

        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public string RG { get; private set; }
        public DateTime DataExpedicao { get; private set; }
        public string OrgaoExpedicao { get; private set; }
        public string UfOrgao { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Sexo { get; private set; }
        public string EstadoCivil { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string? Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UfEndereco { get; private set; }

        public void Update(string cPF, string nome, string rG, DateTime dataExpedicao, string orgaoExpedicao, string ufOrgao, DateTime dataNascimento, string sexo, string estadoCivil, string cep, string logradouro, string numero, string? complemento, string bairro, string cidade, string ufEndereco) 
        {
            this.CPF = cPF;
            this.Nome = nome;
            this.RG = rG;
            this.DataExpedicao = dataExpedicao;
            this.OrgaoExpedicao = orgaoExpedicao;
            this.UfOrgao = ufOrgao;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.EstadoCivil = estadoCivil;
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.UfEndereco = ufEndereco;
        }
    }
}
