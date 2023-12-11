using RobotSimulator.Models;
using System.Text.RegularExpressions;

namespace RobotSimulator.Interpreter
{
    public class PlaceCommandInterpreter : ICommandInterpreter
    {
        private readonly IRobot robot;
        Regex regex = new Regex(@"^PLACE (?<x>\d+),(?<y>\d+),(?<direction>NORTH|EAST|SOUTH|WEST)$");

        public PlaceCommandInterpreter(IRobot robot)
        {
            this.robot = robot;
        }

        public bool CanExecute(string command)
        {
            return regex.IsMatch(command);
        }

        public CommandResponse Execute(string command)
        {
            var parts = regex.Match(command).Groups;
            var x = int.Parse(parts["x"].Value);
            var y = int.Parse(parts["y"].Value);
            var direction = parts["direction"].Value;

            var result = robot.Place((x, y), direction);
            return new CommandResponse(result);
        }
    }
}
