using Notebook.Domain.Commands.Contracts;

namespace Notebook.Domain.Handlers.Contracts;

public interface IHandler<T> where T : ICommand
{
    ICommandResult Handle(T command);
}