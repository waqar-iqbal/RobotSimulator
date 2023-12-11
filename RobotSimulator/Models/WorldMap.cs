namespace RobotSimulator.Models
{
    /// <summary>
    /// The world map class is used to define the size of the world map and to check if a position is valid.
    /// The class is static because there is only one world map.
    /// </summary>
    public static class WorldMap
    {
        public static int YLength = 5;
        public static int XLength = 5;

        public static bool CheckPosition((int X, int Y) pos)
        {
            return (pos.X >= 0 && pos.X < XLength && pos.Y >= 0 && pos.Y < YLength);
        }
    }
}