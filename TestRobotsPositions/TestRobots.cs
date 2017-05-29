using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarRobots;
using System.Collections.Generic;

namespace TestRobotsPositions
{
    [TestClass]
    public class TestRobots
    {
        private BattleField _battleField = BattleField.Instance;

        [TestMethod]
        public void TestRobotA()
        {
            //Define input
            _battleField.MaxX = 5;
            _battleField.MaxY = 5;
            Position startPositionRobotA = new Position(1, 2, Direction.N);
            List<Move> stepsRobotA = new List<Move>();
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.M);   
            Robot robotA = new Robot(startPositionRobotA, stepsRobotA, _battleField);
            _battleField.AddRobot(robotA);
            _battleField.Run();

            //Define output - acceptance criteria
            Assert.IsTrue(robotA.Position.X==1);
            Assert.IsTrue(robotA.Position.Y==3);
            Assert.IsTrue(robotA.Position.D==Direction.N);
        }

        [TestMethod]
        public void TestRobotB()
        {
            //Define input
            _battleField.MaxX = 5;
            _battleField.MaxY = 5;
            Position startPositionRobotB = new Position(3, 3, Direction.E);
            List<Move> stepsRobotB = new List<Move>();
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.M);
            Robot robotB = new Robot(startPositionRobotB, stepsRobotB, _battleField);
            _battleField.AddRobot(robotB);
            _battleField.Run();

            //Define output - acceptance criteria
            Assert.IsTrue(robotB.Position.X == 5);
            Assert.IsTrue(robotB.Position.Y == 1);
            Assert.IsTrue(robotB.Position.D == Direction.E);
        }
    }
}
