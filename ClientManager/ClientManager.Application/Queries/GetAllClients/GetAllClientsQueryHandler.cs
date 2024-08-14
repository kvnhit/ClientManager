using ClienteManager.Core.Repositories.Interfaces;
using ClientManager.Application.ViewModels;
using MediatR;

namespace ClientManager.Application.Queries.GetAllClients
{
    public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, List<ClientViewModel>>
    {
        private readonly IClienteRepository _clienteRepository;
        public GetAllClientsQueryHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<List<ClientViewModel>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _clienteRepository.GetAllAsync();

            var clientsViewModel = clients
                .Select(c => new ClientViewModel(
                    c.Id,
                    c.CPF,
                    c.Nome,
                    c.RG,
                    c.DataExpedicao,
                    c.OrgaoExpedicao,
                    c.UfOrgao,
                    c.DataNascimento,
                    c.Sexo,
                    c.EstadoCivil,
                    c.Cep,
                    c.Logradouro,
                    c.Numero,
                    c.Complemento,
                    c.Bairro,
                    c.Cidade,
                    c.UfEndereco))
                .ToList();

            return clientsViewModel;
        }
    }
}
