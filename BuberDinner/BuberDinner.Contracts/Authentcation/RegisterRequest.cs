namespace BuberDinner.Contracts.Authentcation;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password
);