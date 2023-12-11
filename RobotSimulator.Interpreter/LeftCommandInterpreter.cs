using RobotSimulator.Models;

namespace RobotSimulator.Interpreter
{
    public class LeftCommandInterpreter : ICommandInterpreter
    {
        private readonly IRobot robot;

        public LeftCommandInterpreter(IRobot robot)
        {
            this.robot = robot;
        }

        public bool CanExecute(string command)
        {
            return command == "LEFT";
        }

        public CommandResponse Execute(string command)
        {
            var result = robot.RotateLeft();
            return new CommandResponse(result);
        }
    }
}
