using RobotSimulator.Models;
using System;
using System.Text.RegularExpressions;
using System.Transactions;

namespace RobotSimulator
{
    internal class Program
    {
        private static Robot? _robot = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a command:");
                // To upper the console line to remove issues arising from incorrect case usage.
                string command = Console.ReadLine().ToUpper();

                // Use regex to check if a valid command has been issued.
                // If its a Place command it needs to be followed by a space then 2 numbers and a cardinal direction seperated by commas.
                if (!Regex.IsMatch(command, @"((PLACE) \d+,\d+,((NORTH)|(EAST)|(SOUTH)|(WEST)))|(REPORT)|(MOVE)|(LEFT)|(RIGHT)", RegexOptions.Singleline))
                {
                    Console.WriteLine("Invalid Command, Please try again");
                }
                else
                {
                    var parts = command.Split(' ');
                    // Simple switch statement that looks at the command and decides which method to run.
                    switch (parts[0])
                    {
                        case "EXIT":
                            return;
                        case "LEFT":
                            _robot?.RotateLeft();
                            break;
                        case "RIGHT":
                            _robot?.RotateRight();
                            break;
                        case "MOVE":
                            _robot?.MoveForward(); // We could use the MoveForward() return value to check 
                            break;
                        case "REPORT":
                            Console.WriteLine(_robot?.Report());
                            break;
                        default:
                            var placeCommands = parts[1].Split(',');
                            var x = int.Parse(placeCommands[0]); // Our regex only accepts the place command if its followed by 2 numbers.
                            var y = int.Parse(placeCommands[1]); // So we can safely parse the numbers here.
                            if (WorldMap.CheckPosition((x, y)))
                            {
                                _robot = new Robot(x, y, placeCommands[2]);
                            }
                            else
                            {
                                Console.WriteLine("Placement is out of bounds");
                            }
                            break;
                    }
                }
            }
        }
    }
}