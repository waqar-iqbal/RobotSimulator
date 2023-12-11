using RobotSimulator.Interpreter;
using RobotSimulator.Models;

namespace RobotSimulatorCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commands = GetInterpreters();

            while (true)
            {
                Console.Write("Enter a command: ");
                // To upper the console line to remove issues arising from incorrect case usage.
                string command = Console.ReadLine().ToUpper();

                var interpreter = commands.FirstOrDefault(c => c.CanExecute(command));
                if (interpreter != null)
                {
                    var result = interpreter.Execute(command);
                    if (result.Success && result.HasMessage)
                    {
                        Console.WriteLine(result.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unrecognised command");
                }
            }
        }

        public static IEnumerable<ICommandInterpreter> GetInterpreters()
        {
            var worldMap = new SquareWorldMap();

            var robot = new Robot(worldMap);

            var commands = new List<ICommandInterpreter>() {
                new PlaceCommandInterpreter(robot),
                new MoveCommandInterpreter(robot),
                new LeftCommandInterpreter(robot),
                new RightCommandInterpreter(robot),
                new ReportCommandInterpreter(robot)
            };
            return commands;
        }
    }
}