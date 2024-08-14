using Microsoft.EntityFrameworkCore;
using ClienteManager.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientManager.Infrastructure.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("T_CLIENTE");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(c => c.CPF)
                .HasColumnName("CPF")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.RG)
                .HasColumnName("RG")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.DataExpedicao)
                .HasColumnName("DATA_EXPEDICAO")
                .IsRequired();

            builder.Property(c => c.OrgaoExpedicao)
                .HasColumnName("ORGAO_EXPEDICAO")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.UfOrgao)
                .HasColumnName("UF_ORGAO")
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(c => c.DataNascimento)
                .HasColumnName("DATA_NASCIMENTO")
                .IsRequired();

            builder.Property(c => c.Sexo)
                .HasColumnName("SEXO")
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(c => c.EstadoCivil)
                .HasColumnName("ESTADO_CIVIL")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Cep)
                .HasColumnName("CEP")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(c => c.Logradouro)
                .HasColumnName("LOGRADOURO")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.Numero)
                .HasColumnName("NUMERO")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(c => c.Complemento)
                .HasColumnName("COMPLEMENTO")
                .HasMaxLength(100);

            builder.Property(c => c.Bairro)
                .HasColumnName("BAIRRO")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Cidade)
                .HasColumnName("CIDADE")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.UfEndereco)
                .HasColumnName("UF_ENDERECO")
                .HasMaxLength(2)
                .IsRequired();
        }
    }
}
