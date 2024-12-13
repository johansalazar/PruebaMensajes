using PruebaMensajes.Interfaces;
using PruebaMensajes.Models;

namespace PruebaMensajes.Repository
{
    public class UserService : IUserService
    {
        private readonly List<UserRequest> _users = new();
        public IEnumerable<UserRequest> GetAllUsers()
        {
            return _users;
        }

        public void SaveUser(UserRequest user)
        {
            _users.Add(user);
        }
    }
}
