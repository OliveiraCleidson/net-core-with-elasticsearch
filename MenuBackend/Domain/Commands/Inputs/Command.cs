using Flunt.Notifications;

namespace Domain.Commands.Inputs;

public abstract class Command : Notifiable<Notification>, ICommand
{
    public abstract void Validate();
}