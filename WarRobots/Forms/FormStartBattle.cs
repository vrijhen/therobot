using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WarRobots
{
    public partial class WarRobots : Form
    {
        private iRobot RobotA;
        private iRobot RobotB;
        private BattleField BattleField;

        public WarRobots()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.InitializeBattlefield();
            this.InitializeRobots();

            this.BattleField.Run();

            this.ShowResults();
        }

        private void InitializeBattlefield()
        {
            BattleField = BattleField.Instance;
            BattleField.MaxX = 5;
            BattleField.MaxY = 5;
        }

        private void InitializeRobots()
        {
            Position startPositionRobotA = new Position(1, 2, Direction.N);
            Position startPositionRobotB = new Position(3, 3, Direction.E);

            List<Move> stepsRobotA = new List<Move>();
            stepsRobotA.Add(global::WarRobots.Move.L);
            stepsRobotA.Add(global::WarRobots.Move.M);
            stepsRobotA.Add(global::WarRobots.Move.L);
            stepsRobotA.Add(global::WarRobots.Move.M);
            stepsRobotA.Add(global::WarRobots.Move.L);
            stepsRobotA.Add(global::WarRobots.Move.M);
            stepsRobotA.Add(global::WarRobots.Move.L);
            stepsRobotA.Add(global::WarRobots.Move.M);
            stepsRobotA.Add(global::WarRobots.Move.M);

            List<Move> stepsRobotB = new List<Move>();
            stepsRobotB.Add(global::WarRobots.Move.M);
            stepsRobotB.Add(global::WarRobots.Move.M);
            stepsRobotB.Add(global::WarRobots.Move.R);
            stepsRobotB.Add(global::WarRobots.Move.M);
            stepsRobotB.Add(global::WarRobots.Move.M);
            stepsRobotB.Add(global::WarRobots.Move.R);
            stepsRobotB.Add(global::WarRobots.Move.M);
            stepsRobotB.Add(global::WarRobots.Move.R);
            stepsRobotB.Add(global::WarRobots.Move.R);
            stepsRobotB.Add(global::WarRobots.Move.M);

            RobotA = new Robot(startPositionRobotA, stepsRobotA, BattleField);
            RobotB = new Robot(startPositionRobotB, stepsRobotB, BattleField);

            BattleField.AddRobot(RobotA);
            BattleField.AddRobot(RobotB);
        }

        private void ShowResults()
        {
            Robot robotA = (Robot) this.RobotA;
            Robot robotB = (Robot) this.RobotB;
          
            string resultRobotA = "Position X {0}, Y {1}, D {2}";
            resultRobotA = string.Format(resultRobotA, robotA.Position.X, robotA.Position.Y, robotA.Position.D);
            string resultRobotB = "Position X {0}, Y {1}, D {2}";
            resultRobotB = string.Format(resultRobotB, robotB.Position.X, robotB.Position.Y, robotB.Position.D);

            this.txtRobotA.Text = resultRobotA;
            this.txtRobotB.Text = resultRobotB;
        }

    }
}
