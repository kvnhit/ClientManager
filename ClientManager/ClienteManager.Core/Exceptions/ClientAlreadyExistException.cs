
namespace ClienteManager.Core.Exceptions
{
    public class ClientAlreadyExistException : Exception
    {
        public ClientAlreadyExistException() : base("CLient already exist")
        {
        }
    }
}
