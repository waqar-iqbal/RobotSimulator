using RobotSimulator.Models;

namespace RobotSImulatorTest
{
    public class RobotTests
    {
        [TestCase(0)]
        [TestCase(3)]
        public void MoveForward_ValidMovementNorth_ReturnsTrue(int yPosition)
        {
            var robot = new Robot(0, yPosition, "NORTH");

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(0)]
        [TestCase(3)]
        public void MoveForward_ValidMovementEast_ReturnsTrue(int xPosition)
        {
            var robot = new Robot(xPosition, 0, "EAST");

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(1)]
        [TestCase(4)]
        public void MoveForward_ValidMovementSouth_ReturnsTrue(int yPosition)
        {
            var robot = new Robot(0, yPosition, "SOUTH");

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(1)]
        [TestCase(4)]
        public void MoveForward_ValidMovementWest_ReturnsTrue(int xPosition)
        {
            var robot = new Robot(xPosition, 0, "WEST");

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(4)]
        [TestCase(10)]
        public void MoveForward_InvalidMovemenNorth_ReturnsFalse(int yPosition)
        {
            var robot = new Robot(0, yPosition, "NORTH");

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(4)]
        [TestCase(10)]
        public void MoveForward_InvalidMovemenEast_ReturnsFalse(int xPosition)
        {
            var robot = new Robot(xPosition, 0, "EAST");

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void MoveForward_InvalidMovemenSouth_ReturnsFalse(int yPosition)
        {
            var robot = new Robot(0, yPosition, "SOUTH");

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void MoveForward_InvalidMovemenWest_ReturnsFalse(int xPosition)
        {
            var robot = new Robot(xPosition, 0, "WEST");

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase("NORTH", "EAST")]
        [TestCase("EAST", "SOUTH")]
        [TestCase("SOUTH", "WEST")]
        [TestCase("WEST", "NORTH")]
        public void RotateRight_ValidTurn(string initialDirection, string expectedDirection)
        {
            var robot = new Robot(0, 0, initialDirection);

            robot.RotateRight();

            Assert.That(CardinalDirection.ToCardinal[robot.Direction], Is.EqualTo(expectedDirection));
        }

        [TestCase("NORTH", "WEST")]
        [TestCase("EAST", "NORTH")]
        [TestCase("SOUTH", "EAST")]
        [TestCase("WEST", "SOUTH")]
        public void RotateLeft_ValidTurn(string initialDirection, string expectedDirection)
        {
            var robot = new Robot(0, 0, initialDirection);

            robot.RotateLeft();

            Assert.That(CardinalDirection.ToCardinal[robot.Direction], Is.EqualTo(expectedDirection));
        }

        [TestCase(0, 0, "NORTH", "0,0,NORTH")]
        [TestCase(4, 4, "WEST", "4,4,WEST")]
        public void Report_ValidReport_ReturnsCorrectString(int xPosition, int yPosition, string cardinalDirection, string expectedReport)
        {
            var robot = new Robot(xPosition, yPosition, cardinalDirection);

            var result = robot.Report();

            Assert.That(result, Is.EqualTo(expectedReport));
        }
    }
}