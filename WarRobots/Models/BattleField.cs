using System.Collections.Generic;

namespace WarRobots
{
    public class BattleField
    {
        public short MaxY;
        public short MaxX;

        private static BattleField _instance;
        private List<iRobot> Robots = new List<iRobot>();
        private BattleField() { }

        public static BattleField Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BattleField();
                }
                return _instance;
            }
        }

        public void AddRobot(iRobot robot)
        {
            Robots.Add(robot);
        }

        public void Run()
        {
            foreach (var robot in Robots)
            {
                robot.Run();
            }
        }
    }
}
