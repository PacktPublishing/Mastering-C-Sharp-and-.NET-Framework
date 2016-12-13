using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Demo1_SRP
{
    public class SportsCar : ISportCar
    {
        string[] availableBrands = new string[] { "Ferrari", "Mercedes", "BMW" };
        const int SpeedIncr = 25;
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
            Speed = (speedExceeded) ? Speed: Speed + SpeedIncr;
            return speedExceeded;
        }
    }
}