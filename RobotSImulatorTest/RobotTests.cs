using NUnit.Framework;
using RobotSimulator.Models;

namespace RobotSImulatorTest
{
    public class RobotTests
    {
        [TestCase(0)]
        [TestCase(3)]
        public void MoveForward_ValidMovementNorth_ReturnsTrue(int yPosition)
        {
            var robot = new Robot(0, yPosition, CardinalDirection.North);

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(0)]
        [TestCase(3)]
        public void MoveForward_ValidMovementEast_ReturnsTrue(int xPosition)
        {
            var robot = new Robot(xPosition, 0, CardinalDirection.East);

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(1)]
        [TestCase(4)]
        public void MoveForward_ValidMovementSouth_ReturnsTrue(int yPosition)
        {
            var robot = new Robot(0, yPosition, CardinalDirection.South);

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(1)]
        [TestCase(4)]
        public void MoveForward_ValidMovementWest_ReturnsTrue(int xPosition)
        {
            var robot = new Robot(xPosition, 0, CardinalDirection.West);

            var result = robot.MoveForward();

            Assert.IsTrue(result);
        }

        [TestCase(4)]
        [TestCase(10)]
        public void MoveForward_InvalidMovemenNorth_ReturnsFalse(int yPosition)
        {
            var robot = new Robot(0, yPosition, CardinalDirection.North);

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(4)]
        [TestCase(10)]
        public void MoveForward_InvalidMovemenEast_ReturnsFalse(int xPosition)
        {
            var robot = new Robot(xPosition, 0, CardinalDirection.East);

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void MoveForward_InvalidMovemenSouth_ReturnsFalse(int yPosition)
        {
            var robot = new Robot(0, yPosition, CardinalDirection.South);

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void MoveForward_InvalidMovemenWest_ReturnsFalse(int xPosition)
        {
            var robot = new Robot(xPosition, 0, CardinalDirection.South);

            var result = robot.MoveForward();

            Assert.IsFalse(result);
        }

        [TestCase(CardinalDirection.North, CardinalDirection.East)]
        [TestCase(CardinalDirection.East, CardinalDirection.South)]
        [TestCase(CardinalDirection.South, CardinalDirection.West)]
        [TestCase(CardinalDirection.West, CardinalDirection.North)]
        public void RotateRight_ValidTurn(CardinalDirection initialDirection, CardinalDirection expectedDirection)
        {
            var robot = new Robot(0, 0, initialDirection);

            robot.RotateRight();

            Assert.AreEqual(expectedDirection, robot.CardinalDirection);
        }

        [TestCase(CardinalDirection.North, CardinalDirection.West)]
        [TestCase(CardinalDirection.East, CardinalDirection.North)]
        [TestCase(CardinalDirection.South, CardinalDirection.East)]
        [TestCase(CardinalDirection.West, CardinalDirection.South)]
        public void RotateLeft_ValidTurn(CardinalDirection initialDirection, CardinalDirection expectedDirection)
        {
            var robot = new Robot(0, 0, initialDirection);

            robot.RotateLeft();

            Assert.AreEqual(expectedDirection, robot.CardinalDirection);
        }

        [TestCase(0, 0, CardinalDirection.North, "0,0,North")]
        [TestCase(4, 4, CardinalDirection.West, "4,4,West")]
        public void Report_ValidReport_ReturnsCorrectString(int xPosition, int yPosition, CardinalDirection cardinalDirection, string expectedReport)
        {
            var robot = new Robot(xPosition, yPosition, cardinalDirection);

            var result = robot.Report();

            Assert.AreEqual(expectedReport, result);
        }
    }
}