using Microsoft.AspNetCore.Mvc;
using BuberDinner.Application.Services.Authentcation;
using BuberDinner.Contracts.Authentcation;

[ApiController]
[Route("auth")]
public class AuthentcationController : ControllerBase
{
    private readonly IAuthentcationService _authentcationService;

    public AuthentcationController(IAuthentcationService authentcationService)
    {
        _authentcationService = authentcationService;
    }
    [HttpPost("Register")]
    public IActionResult Register(RegisterRequest request){
        var authReult = _authentcationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        var response = new AuthentcationResponse(
            authReult.Id,
            authReult.FirstName,
            authReult.LastName,
            authReult.Email,
            authReult.Token
        );
        return Ok(response);
    }

    [HttpPost("Login")]
    public IActionResult Login(LoginRequest request){
        var authReult = _authentcationService.Login(request.Email, request.Password);
        var response = new AuthentcationResponse(
            authReult.Id,
            authReult.FirstName,
            authReult.LastName,
            authReult.Email,
            authReult.Token
        );
        return Ok(response);
    }
}
