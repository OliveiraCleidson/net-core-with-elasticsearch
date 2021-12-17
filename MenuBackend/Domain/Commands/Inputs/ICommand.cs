using Flunt.Notifications;

namespace Domain.Commands.Inputs;

public interface ICommand
{
    void Validate();
    IReadOnlyCollection<Notification> Notifications { get; }
}