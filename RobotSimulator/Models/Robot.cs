namespace RobotSimulator.Models
{
    public class Robot : IRobot
    {
        private readonly IWorldMap worldMap;

        public Robot(IWorldMap worldMap)
        {
            this.worldMap = worldMap;
        }

        public bool IsPlaced {  get; private set;}

        public bool Place((int X, int Y) position, string direction)
        {
            if (worldMap.CheckPosition(position))
            {
                Position = position;
                Direction = CardinalDirection.ToVector[direction];
                IsPlaced = true;
                return true;
            }
            return false;
        }

        public (int X, int Y) Position { get; private set; }

        public (int X, int Y) Direction { get; private set; }

        /// <summary>
        /// Move robot forward by adding the direction vector to the current position, then checking if the new position is valid.
        /// </summary>
        /// <returns>A bool indicating if the robot moved or not.</returns>
        public bool MoveForward()
        {
            if(!IsPlaced)
            {
                return false;
            }

            var newLocation = (Position.X + Direction.X, Position.Y + Direction.Y);
            if (worldMap.CheckPosition(newLocation))
            {
                Position = newLocation;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Rotate robot left by swapping X and Y then multiplying the new X by -1
        /// </summary>
        public bool RotateLeft()
        {
            if (IsPlaced)
            {
                Direction = (Direction.Y * -1, Direction.X);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Rotate robot right by swapping X and Y then multiplying the new Y by -1
        /// </summary>
        public bool RotateRight()
        {
            if (IsPlaced)
            {
                Direction = (Direction.Y, Direction.X * -1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Concatinates the X, Y position of the Robot as well as the direction in to a single string.
        /// </summary>
        /// <returns>A string concatination of the X, Y and direction of the robot.</returns>
        public string Report()
        {
            if (IsPlaced)
            {
                return $"{Position.X},{Position.Y},{CardinalDirection.ToCardinal[Direction]}";
            }
            else
            {
                return null;
            }
        }
    }
}