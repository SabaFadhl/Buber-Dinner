namespace BuberDinner.Application.Services.Authentcation;
public class AuthentcationService : IAuthentcationService
{
    public AuthentcationResult Login(string email, string password)
    {
        return new AuthentcationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
    }

    public AuthentcationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthentcationResult(Guid.NewGuid(), firstName, "lastName", email, "token");
    }
}
