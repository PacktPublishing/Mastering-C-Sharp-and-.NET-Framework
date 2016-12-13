using System;
using System.Drawing;
using System.Linq;

namespace Demo2_OCP
{
    public class SportsCar : ISportCar
    {
        string[] availableBrands = new string[] { "Ferrari", "Mercedes", "BMW" };
        const int SpeedIncr = 25;
        public const int MaxLegal = 80;
        public SportsCar(string brand)
        {
            if (!availableBrands.Contains(brand)) return;
            else Brand = brand;
            switch (brand)
            {
                case "Ferrari":
                    MaxSpeed = 350;
                    Photo = Properties.Resources.Ferrari;
                    break;
                case "Mercedes":
                    MaxSpeed = 300;
                    Photo = Properties.Resources.Mercedes;
                    break;
                case "BMW":
                    MaxSpeed = 270;
                    Photo = Properties.Resources.BMW;
                    break;
            }
        }

        public string Brand { get; }
        public int MaxSpeed { get; }
        public Bitmap Photo { get; }
        public int Speed { get; private set; }

        public virtual bool Accelerate()
        {
            bool speedExceeded = Speed + SpeedIncr > MaxSpeed;
            bool legalExceeded = Speed + SpeedIncr > MaxLegal;
            if (legalExceeded && LegalLimitCondition != null)
            {
                LegalLimitCondition(this, (Speed + SpeedIncr) - MaxLegal);
            }
            Speed = (speedExceeded) ? Speed: Speed + SpeedIncr;
            return speedExceeded;
        }
        public virtual bool Accelerate(bool advise)
        {
            bool speedExceeded = Speed + SpeedIncr > MaxSpeed;
            bool legalExceeded = Speed + SpeedIncr > MaxLegal;
            if (legalExceeded && LegalLimitCondition != null)
            {
                LegalLimitCondition(this, (Speed + SpeedIncr) - MaxLegal);
            }
            if (speedExceeded && advise && (SpeedLimit!= null))
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
        public event EventHandler<int> LegalLimitCondition;
    }
    public class SpeedLimitData : EventArgs
    {
        public DateTime moment { get; set; }
        public int resultingSpeed { get; set; }
    }

}