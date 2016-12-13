using System;
using System.Drawing;
using System.Linq;

namespace Demo4_ISP
{
    public class SportsCar : ISportCar
    {
        string[] availableBrands = new string[] { "Ferrari", "Mercedes", "BMW" };
        protected const int SpeedIncr = 25;
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
        public int Speed { get; protected set; }

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
        public event EventHandler<int> LegalLimitCondition;
    }
    
}