namespace RobotSimulator.Models
{
    public interface IWorldMap
    {
        bool CheckPosition((int X, int Y) pos);
    }
}