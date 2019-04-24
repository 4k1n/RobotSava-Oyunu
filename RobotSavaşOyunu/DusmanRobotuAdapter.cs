using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSavaşOyunu
{
    public class DusmanRobotuAdapter : Robot ,IDusman  // adater
    {
        DusmanRobotu dusmanRobotu;
        Robot adi;

        public DusmanRobotuAdapter(DusmanRobotu yeniRobot)
        {
            dusmanRobotu = yeniRobot;
        }

        public void DusmanAdi(Robot adi)
        {
           this.adi = adi;
        }

        public void Hizlan()
        {
            Console.WriteLine("Yeni DusmanRobotu hızlandı.");
        }

        public void SilahKullan()
        {
            Console.WriteLine("" + robotAdi + " tarafından silah ateşlendi.");
        }
    }
}
