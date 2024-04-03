namespace BuberDinner.Application.Services.Authentcation
{
    public interface IAuthentcationService
    {
        AuthentcationResult Register(string firstName, string lastName, string email, string password);
        AuthentcationResult Login(string email, string password);
    }
}