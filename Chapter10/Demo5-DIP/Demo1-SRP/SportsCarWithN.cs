using System;
using System.Drawing;
using System.Linq;

namespace Demo5_DIP
{
    public class SportsCarWithN : SportsCar, ISportCar
    {
        public SportsCarWithN(string brand): base(brand) {}
        public new bool Accelerate()
        {
            base.Accelerate();
            bool speedExceeded = Speed + SpeedIncr > MaxSpeed;
            if (speedExceeded && (SpeedLimit!= null))
            {
                SpeedLimitData data = new SpeedLimitData()
                {
                    moment = DateTime.Now,
                    resultingSpeed = Speed + SpeedIncr
                };
                SpeedLimit(this, data);
            }
            Speed = (speedExceeded) ? Speed : Speed + SpeedIncr;
            return speedExceeded;
        }
        public event EventHandler SpeedLimit;
    }
    public class SpeedLimitData : EventArgs
    {
        public DateTime moment { get; set; }
        public int resultingSpeed { get; set; }
    }

}