namespace ApiAuthApp.Services
{
    public interface IUserService
    {
        User? Authenticate(string username, string password);
    }
}
