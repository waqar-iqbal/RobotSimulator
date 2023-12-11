using RobotSimulator.Models;

namespace RobotSimulator.Interpreter
{
    public class RightCommandInterpreter : ICommandInterpreter
    {
        private readonly IRobot robot;

        public RightCommandInterpreter(IRobot robot)
        {
            this.robot = robot;
        }

        public bool CanExecute(string command)
        {
            return command == "RIGHT";
        }

        public CommandResponse Execute(string command)
        {
            var result = robot.RotateRight();
            return new CommandResponse(result);
        }
    }
}
