namespace WebApplication.infra.messaging.user;

public class UserMessageData
{
    public string username { get; set; }
}

public class UserSecurityData
{
    public string password { get; set; }
}

public class CreateUserMessage
{
    public UserMessageData userMessageData { get; set; }
    public UserSecurityData userSecurityData { get; set; }
}
