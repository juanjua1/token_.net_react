using ApiAuthApp.Models;

namespace ApiAuthApp.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Username = "admin", Password = "admin" }
        };

        public User? Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(user => user.Username == username && user.Password == password);
        }
    }
}
