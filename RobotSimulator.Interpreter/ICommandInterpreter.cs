namespace RobotSimulator.Interpreter
{
    public interface ICommandInterpreter
    {
        bool CanExecute(string command);
        CommandResponse Execute(string command);
    }
}
