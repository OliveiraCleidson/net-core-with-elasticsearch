namespace Domain.Commands.Outputs;

public class CommandResult: ICommandResult
{
    public CommandResult()
    {
        Message = String.Empty;
        Success = false;
        Errors = new Dictionary<string, string[]>();
    }
    public bool Success { get; set; }
    public object Result { get; set; }
    public string Message { get; set; }
    public Dictionary<string, string[]> Errors { get; set; }
}