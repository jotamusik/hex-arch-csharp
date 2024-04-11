using WebApplication.application.common;
using WebApplication.domain.user;

namespace WebApplication.application.user;

public class CreateUserUseCase : UseCase<CreateUserCommand, User>
{
    private readonly UserRepository userRepository;

    public CreateUserUseCase(UserRepository userRepository)
    {
        this.userRepository = userRepository;
    }
    
    public User Execute(CreateUserCommand createUserCommand)
    {
        var user = User.With(createUserCommand.username, createUserCommand.password);

        return userRepository.Save(user);
    }
}
