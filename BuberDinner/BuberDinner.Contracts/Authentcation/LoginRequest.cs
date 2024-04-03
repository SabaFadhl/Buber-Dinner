namespace BuberDinner.Contracts.Authentcation;

public record LoginRequest(
    string Email,
    string Password
);