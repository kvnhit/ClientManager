using ClientManager.Application.ViewModels;
using MediatR;

namespace ClientManager.Application.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<List<ClientViewModel>>
    {
        public GetAllClientsQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
