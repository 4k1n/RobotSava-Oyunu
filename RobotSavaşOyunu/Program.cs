using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSavaşOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            DusmanTank dusmanTank = new DusmanTank();
            dusmanTank.robotAdi = "v216";
            dusmanTank.SilahKullan();
            DusmanRobotu dusmanRobotu = new DusmanRobotu();
            dusmanRobotu.robotAdi = "1000 X";
            dusmanRobotu.YumrukAt();
            DusmanRobotuAdapter yeniRobot = new DusmanRobotuAdapter(dusmanRobotu);
            yeniRobot.robotAdi = "AS 971";
            yeniRobot.Hizlan();


            Console.ReadLine();
        }
    }
}
