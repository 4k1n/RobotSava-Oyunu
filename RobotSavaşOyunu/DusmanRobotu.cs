using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSavaşOyunu
{
    public class DusmanRobotu : Robot  // Adaptee
    {
        Robot adi;
        public void RobotIsim(Robot adi)
        {
            this.adi = adi;
        }

        public void YumrukAt()
        {
            Console.WriteLine(""+ robotAdi +" tarafından karşı saldırıya geçildi.");
        }

        public void Yuru()
        {
            Console.WriteLine("Harekete geçildi.");
        }
    }
}
