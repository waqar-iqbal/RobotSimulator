using System.Collections.Generic;
using System.Linq;

namespace RobotSimulator.Models
{
    public static class CardinalDirection
    {
        public static Dictionary<string, (int X, int Y)> ToVector = new Dictionary<string, (int X, int Y)>
        {
            { "NORTH", (0, 1)},
            { "EAST", (1, 0)},
            { "SOUTH", (0, -1)},
            { "WEST", (-1, 0)},
        };

        public static Dictionary<(int X, int Y), string> ToCardinal = ToVector.ToDictionary(x => x.Value, x => x.Key);
    }
}