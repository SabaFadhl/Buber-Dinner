using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.Data;

[ApiController]
[Route("auth")]
public class AuthentcationController : ControllerBase
{
    [HttpPost("Register")]
    public IActionResult Register(RegisterRequest request){
        return Ok(request);
    }

    [HttpPost("Login")]
    public IActionResult Login(LoginRequest request){
        return Ok(request);
    }
}