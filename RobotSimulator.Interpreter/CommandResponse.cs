namespace RobotSimulator.Interpreter
{
    public class CommandResponse
    {
        public CommandResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public CommandResponse(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
        public bool HasMessage => string.IsNullOrWhiteSpace(Message) == false;
    }
}
