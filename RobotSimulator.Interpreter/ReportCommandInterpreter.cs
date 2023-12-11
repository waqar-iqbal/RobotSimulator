using RobotSimulator.Models;

namespace RobotSimulator.Interpreter
{
    public class ReportCommandInterpreter : ICommandInterpreter
    {
        private readonly IRobot robot;

        public ReportCommandInterpreter(IRobot robot)
        {
            this.robot = robot;
        }

        public bool CanExecute(string command)
        {
            return command == "REPORT";
        }

        public CommandResponse Execute(string command)
        {
            var report = robot.Report();
            return new CommandResponse(string.IsNullOrWhiteSpace(report) == false, report);
        }
    }
}
