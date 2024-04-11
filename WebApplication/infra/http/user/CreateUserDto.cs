using WebApplication.application.user;

namespace WebApplication.infra.http;

public class CreateUserDto
{
    public CreateUserDto(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public string username { get; set; }
    public string password { get; set; }


    public CreateUserCommand ToCommand()
    {
        return CreateUserCommand.With(username, password);
    }
}
