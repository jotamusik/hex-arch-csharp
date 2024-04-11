namespace WebApplication.application.common;

interface UseCase<InputT, OutputT>
{
    OutputT Execute(InputT input);
}

interface ActionUseCase<InputT>
{
    void Execute(InputT createUserCommand);
}
