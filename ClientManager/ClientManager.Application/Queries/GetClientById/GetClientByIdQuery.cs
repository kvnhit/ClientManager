using ClientManager.Application.ViewModels;
using MediatR;

namespace ClientManager.Application.Queries.GetAllClients
{
    public class GetClientByIdQuery : IRequest<ClientViewModel>
    {
        public GetClientByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
