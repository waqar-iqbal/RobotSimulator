using RobotSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    internal class Program
    {
        private static bool _isRobotPlaced = false;

        private 
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a command:");
                var command = Console.ReadLine();
                if (string.Equals(command, "exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered: " + command);
                    if (command.StartsWith("PLACE ", StringComparison.CurrentCultureIgnoreCase))
                    {
                        var commandParts = command.Split(' ');
                        
                    }

                    if (!_isRobotPlaced)
                    {
                        Console.WriteLine("Please place the robot using the PLACE command");
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
