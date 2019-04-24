using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSavaşOyunu
{
    public interface IDusman  // target
    {
        void SilahKullan();
        void Hizlan();
        void DusmanAdi(Robot adi);
    }
}
