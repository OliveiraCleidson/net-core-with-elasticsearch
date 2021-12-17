namespace Domain.Commands.Outputs;

public interface ICommandResult
{
    bool Success { get;}
    object Result { get; }
    string Message { get; }
    Dictionary<string, string[]> Errors { get; }
}