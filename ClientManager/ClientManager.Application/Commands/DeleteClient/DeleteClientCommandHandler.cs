using ClienteManager.Core.Repositories.Interfaces;
using MediatR;


namespace ClientManager.Application.Commands.DeleteClient
{
    public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, Unit>
    {
        private readonly IClienteRepository _clienteRepository;
        public DeleteClientCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _clienteRepository.GetByIdAsync(request.Id);

            if (client != null)
                await _clienteRepository.DeleteAsync(client);

            return Unit.Value;
        }
    }
}
