using ClienteManager.Core.Repositories.Interfaces;
using ClientManager.Application.ViewModels;
using MediatR;

namespace ClientManager.Application.Queries.GetAllClients
{
    public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, ClientViewModel>
    {
        private readonly IClienteRepository _clienteRepository;
        public GetClientByIdQueryHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<ClientViewModel> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await _clienteRepository.GetByIdAsync(request.Id);

            if (client == null)
                return null;

            var clientViewModel = new ClientViewModel(
                client.Id,
                client.CPF,
                client.Nome,
                client.RG,
                client.DataExpedicao,
                client.OrgaoExpedicao,
                client.UfOrgao,
                client.DataNascimento,
                client.Sexo,
                client.EstadoCivil,
                client.Cep,
                client.Logradouro,
                client.Numero,
                client.Complemento,
                client.Bairro,
                client.Cidade,
                client.UfEndereco
                );

            return clientViewModel;
        }
    }
}
