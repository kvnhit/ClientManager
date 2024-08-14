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

        [Required]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required]
        [DisplayName("RG")]
        public string RG { get; set; }

        [Required]
        [DisplayName("Data Expedição")]
        public DateTime DataExpedicao { get; set; }

        [Required]
        [DisplayName("Órgao Expeditor")]
        public string OrgaoExpedicao { get; set; }

        [Required]
        [DisplayName("UF")]
        public string UfOrgao { get; set; }

        [Required]
        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [Required]
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }

        [Required]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required]
        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("Complemento")]
        public string? Complemento { get; set; }

        [Required]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [Required]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required]
        [DisplayName("UF")]
        public string UfEndereco { get; set; }
    }
}
