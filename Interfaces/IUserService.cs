using PruebaMensajes.Models;

namespace PruebaMensajes.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserRequest> GetAllUsers();
        void SaveUser(UserRequest user);
    }
}
