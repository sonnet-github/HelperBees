namespace HelperBess.WebApiCore.Services
{
    public class UserService : IUserService 
    {
        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("admin") && password.Equals("En6MkU8jv");
        }
    }
}
