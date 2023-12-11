using RobotSimulator.Models;

namespace RobotSimulator.Interpreter
{
    public class MoveCommandInterpreter : ICommandInterpreter
    {
        private readonly IRobot robot;

        public MoveCommandInterpreter(IRobot robot)
        {
            this.robot = robot;
        }

        public bool CanExecute(string command)
        {
            return command == "MOVE";
        }

        public CommandResponse Execute(string command)
        {
            var result = robot.MoveForward();
            return new CommandResponse(result);
        }
    }
}
