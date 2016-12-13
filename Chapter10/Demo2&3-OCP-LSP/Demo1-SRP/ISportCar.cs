using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2_OCP
{
    interface ISportCar
    {
        bool Accelerate();
        System.Drawing.Bitmap Photo { get; }
        string Brand { get; }
        int Speed { get; }
        int MaxSpeed { get; }
        event EventHandler SpeedLimit;
    }
}
