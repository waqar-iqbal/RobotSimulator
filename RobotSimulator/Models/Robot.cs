using System.Runtime.CompilerServices;

namespace RobotSimulator.Models
{
    public class Robot
    {
        public Robot(int xPosition, int yPosition, string direction)
        {
            Position = (xPosition, yPosition);
            Direction = CardinalDirection.ToVector[direction];
        }

        public (int X, int Y) Position { get; private set; }

        public (int X, int Y) Direction { get; private set; }

        /// <summary>
        /// Move robot forward by adding the direction vector to the current position, then checking if the new position is valid.
        /// </summary>
        /// <returns>A bool indicating if the robot moved or not.</returns>
        public bool MoveForward()
        {
            var newLocation = (Position.X + Direction.X, Position.Y + Direction.Y);
            if (WorldMap.CheckPosition(newLocation))
            {
                Position = newLocation;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Rotate robot left by swapping X and Y then multiplying the new X by -1
        /// </summary>
        public void RotateLeft()
        {
            Direction = (Direction.Y * -1, Direction.X); 

        }

        /// <summary>
        /// Rotate robot right by swapping X and Y then multiplying the new Y by -1
        /// </summary>
        public void RotateRight()
        {
            Direction = (Direction.Y, Direction.X * -1);
        }

        /// <summary>
        /// Concatinates the X, Y position of the Robot as well as the direction in to a single string.
        /// </summary>
        /// <returns>A string concatination of the X, Y and direction of the robot.</returns>
        public string Report()
        {
            return $"{Position.X},{Position.Y},{CardinalDirection.ToCardinal[Direction]}";
        }
    }
}