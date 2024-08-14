using ClienteManager.Core.Entities;
using ClienteManager.Core.Repositories.Interfaces;
using MediatR;

namespace ClientManager.Application.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, int>
    {
        private readonly IClienteRepository _clienteRepository;
        public CreateClientCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Cliente(
                request.CPF,
                request.Nome,
                request.RG,
                request.DataExpedicao,
                request.OrgaoExpedicao,
                request.UfOrgao,
                request.DataNascimento,
                request.Sexo,
                request.EstadoCivil,
                request.CEP,
                request.Logradouro,
                request.Numero,
                request.Complemento,
                request.Bairro,
                request.Cidade,
                request.UfEndereco);

            await _clienteRepository.AddAsync(client);

            return client.Id;
        }
    }
}
