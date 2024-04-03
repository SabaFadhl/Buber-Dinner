namespace BuberDinner.Contracts.Authentcation;

public record AuthentcationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);