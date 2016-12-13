using System;
using System.Drawing;
using System.Linq;

namespace Demo5_DIP
{
    public class CarFactory
    {
        SportsCar carInstance;
        public SportsCar CreateCar(string car)
        {
            switch (car)
            {
                case "Ferrari":
                    carInstance = new SportsCar(car);
                    carInstance.MaxSpeed = 230;
                    carInstance.Photo = Properties.Resources.BMW;
                    break;
                case "BMW":
                    carInstance = new SportsCar(car);
                    carInstance.MaxSpeed = 180;
                    carInstance.Photo = Properties.Resources.BMW;
                    break;
                case "Mercedes":
                    carInstance = new SportsCarWithN(car);
                    carInstance.MaxSpeed = 200;
                    carInstance.Photo = Properties.Resources.Mercedes;
                    break;
                case "Ford":
                    carInstance = new SportsCarWithN(car);
                    carInstance.MaxSpeed = 210;
                    carInstance.Photo = Properties.Resources.Ford;
                    break;
                default:
                    break;
            }
            return carInstance;
        }
    }

    public class SportsCar : ISportCar
    {
        protected const int SpeedIncr = 25;
        public const int MaxLegal = 80;
        public SportsCar(string brand) { Brand = brand; }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public Bitmap Photo { get; set; }
        public int Speed { get; set; }

        public virtual bool Accelerate()
        {
            bool speedExceeded = Speed + SpeedIncr > MaxSpeed;
            bool legalExceeded = Speed + SpeedIncr > MaxLegal;
            if (legalExceeded && LegalLimitCondition != null)
            {
                LegalLimitCondition(this, (Speed + SpeedIncr) - MaxLegal);
            }
            Speed = (speedExceeded) ? Speed : Speed + SpeedIncr;
            return speedExceeded;
        }
        public event EventHandler<int> LegalLimitCondition;
    }

}