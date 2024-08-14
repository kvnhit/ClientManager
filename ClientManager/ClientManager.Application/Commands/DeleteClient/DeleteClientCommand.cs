using MediatR;

namespace ClientManager.Application.Commands.DeleteClient
{
    public class DeleteClientCommand : IRequest<Unit>
    {
        public DeleteClientCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}
