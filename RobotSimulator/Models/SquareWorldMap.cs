namespace RobotSimulator.Models
{
    /// <summary>
    /// The world map class is used to define the size of the world map and to check if a position is valid.
    /// </summary>
    public class SquareWorldMap : IWorldMap
    {
        private const int YLength = 5;
        private const int XLength = 5;

        public bool CheckPosition((int X, int Y) pos)
        {
            return (pos.X >= 0 && pos.X < XLength && pos.Y >= 0 && pos.Y < YLength);
        }
    }
}