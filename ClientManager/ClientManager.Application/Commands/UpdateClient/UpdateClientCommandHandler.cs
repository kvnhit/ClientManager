using ClienteManager.Core.Repositories.Interfaces;
using MediatR;

namespace ClientManager.Application.Commands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, Unit>
    {
        private readonly IClienteRepository _clienteRepository;
        public UpdateClientCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _clienteRepository.GetByIdAsync(request.Id);

            client.Update(
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

            await _clienteRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
