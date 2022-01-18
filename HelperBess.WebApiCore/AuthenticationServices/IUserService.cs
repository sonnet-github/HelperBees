namespace HelperBess.WebApiCore.Services
{
    public interface IUserService
    {
        bool ValidateCredentials(string username, string password);
    }
}
