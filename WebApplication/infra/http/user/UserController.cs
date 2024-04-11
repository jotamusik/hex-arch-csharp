using Microsoft.AspNetCore.Mvc;
using WebApplication.application.user;
using WebApplication.infra.messaging.user;

namespace WebApplication.infra.http.user;

[Route("/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly CreateUserUseCase createUserUseCase;

    public UserController(CreateUserUseCase createUserUseCase)
    {
        this.createUserUseCase = createUserUseCase;
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
    {
        createUserUseCase.Execute(createUserDto.ToCommand());

        var bar = "";
        bar.RemoveWhitespacesFancy();
        
        return Ok();
    }
}
