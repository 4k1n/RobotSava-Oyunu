using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSavaşOyunu
{
    public class DusmanTank : Robot, IDusman
    {
        Robot adi;
        public void DusmanAdi(Robot adi)
        {
            this.adi = adi;
        }

        public void Hizlan()
        {
            Console.WriteLine("Robot hızlandı.");
        }

        public void SilahKullan()
        {
            Console.WriteLine(""+ robotAdi +" tarafından silah ateşlendi.");
        }
    }
}
