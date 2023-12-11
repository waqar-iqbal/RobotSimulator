namespace RobotSimulator.Models
{
    public interface IRobot
    {
        (int X, int Y) Direction { get; }
        (int X, int Y) Position { get; }
        bool IsPlaced { get; }

        bool MoveForward();
        bool Place((int X, int Y) position, string direction);
        string Report();
        bool RotateLeft();
        bool RotateRight();
    }
}