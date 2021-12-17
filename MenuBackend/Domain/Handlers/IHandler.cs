using Domain.Commands.Inputs;
using Domain.Commands.Outputs;

namespace Domain.Handlers;

public interface IHandler<T> where T : ICommand
{
    Task<ICommandResult> Handle(T command);
}