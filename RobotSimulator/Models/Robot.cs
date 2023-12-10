namespace RobotSimulator.Models
{
    public class Robot
    {
        public Robot(int xPosition, int yPosition, CardinalDirection cardinalDirection)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            CardinalDirection = cardinalDirection;
        }

        public CardinalDirection CardinalDirection { get; private set; }
        public int XPosition { get; private set; }
        public int YPosition { get; private set; }

        public bool MoveForward()
        {
            if (CardinalDirection == CardinalDirection.North)
            {
                if (YPosition < WorldMap.YLength - 1)
                {
                    YPosition++;
                    return true;
                }

                return false;
            }
            else if (CardinalDirection == CardinalDirection.East)
            {
                if (XPosition < WorldMap.XLength - 1)
                {
                    XPosition++;
                    return true;
                }

                return false;
            }
            else if (CardinalDirection == CardinalDirection.South)
            {
                if (YPosition > 0)
                {
                    YPosition--;
                    return true;
                }

                return false;
            }
            else if (CardinalDirection == CardinalDirection.West)
            {
                if (XPosition > 0)
                {
                    XPosition--;
                    return true;
                }

                return false;
            }

            return false;
        }

        public void RotateLeft()
        {
            if ( CardinalDirection == CardinalDirection.North)
            {
                CardinalDirection = CardinalDirection.West;
            }
            else
            {
                CardinalDirection--;
            }
        }

        public void RotateRight()
        {
            if (CardinalDirection == CardinalDirection.West)
            {
                CardinalDirection = CardinalDirection.North;
            }
            else
            {
                CardinalDirection++;
            }
        }

        public string Report()
        {
            return $"{XPosition},{YPosition},{CardinalDirection}";
        }
    }
}