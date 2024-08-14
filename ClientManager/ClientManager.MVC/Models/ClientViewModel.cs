using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ClientManager.MVC.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("Data Expedição")]
        public DateTime DataExpedicao { get; set; }

        [DisplayName("Órgao Expedição")]
        public string OrgaoExpedicao { get; set; }

        [DisplayName("UF Órgão")]
        public string UfOrgao { get; set; }

        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }

        [DisplayName("Cep")]
        public string Cep { get; set; }

        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("Complemento")]
        public string? Complemento { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("UF Endereço")]
        public string UfEndereco { get; set; }
    }
}
