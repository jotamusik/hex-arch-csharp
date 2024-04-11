namespace WebApplication.application.user;

public class CreateUserCommand
{
    public readonly string username;
    public readonly string password;

    private CreateUserCommand(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
    
    // Factory Method
    public static CreateUserCommand With(string username, string password)
    {
        return new CreateUserCommand(username, password);
    }
}
