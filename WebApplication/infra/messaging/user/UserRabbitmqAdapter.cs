using WebApplication.application.user;

namespace WebApplication.infra.messaging.user;

public class UserRabbitmqAdapter
{
    private readonly CreateUserUseCase createUserUseCase;

    public UserRabbitmqAdapter(CreateUserUseCase createUserUseCase)
    {
        this.createUserUseCase = createUserUseCase;
    }
    
    public void CreateUser(CreateUserMessage createUserMessage)
    {
        createUserUseCase.Execute(createUserMessage.ToCommand());
    }

    public void Foo()
    {
        var bar = "";
        StringUtils.RemoveWhitespace(bar);
        bar.RemoveWhitespacesFancy();
    }
}

// Extension method only accessible in this file/ ?namespace?
public static class CreateUserMessageExtensions
{
    public static CreateUserCommand ToCommand(this CreateUserMessage createUserMessage)
    {
        return CreateUserCommand.With(createUserMessage.userMessageData.username, createUserMessage.userSecurityData.password);
    }
}

internal static class StringUtils
{
    public static string RemoveWhitespace(string stringWithWhitespaces)
    {
        return stringWithWhitespaces.Trim();
    }

    public static string RemoveWhitespacesFancy(this string stringWithWhitespaces)
    {
        return stringWithWhitespaces.Trim();
    }
}

