namespace BuberDinner.Application.Services.Authentcation;

public record AuthentcationResult
(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);