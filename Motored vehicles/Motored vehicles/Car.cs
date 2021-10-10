using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored_vehicles
{
    class Car: Motored_vehicle
    {
        public bool IsOn;

        public Car(string make, string model, string prodYear, bool isOn) : base(make, model, prodYear)
        {
            this.IsOn = isOn;
        }

        public bool TurnOn()
        {
            return IsOn = true;
        }

        public bool TurnOff()
        {
            return IsOn = false;

        }
        public override string GetDetailedInfo()
        {

            return base.GetDetailedInfo();
        }

        public void Go()
        {
            if (IsOn = true && FuelAmount % FuelUsedPerKm > 0)
            {
                int mesafe = FuelAmount / FuelUsedPerKm;
                Console.WriteLine($"{mesafe} km mesafe qet edildi.");
            }

            else
            {
                Console.WriteLine("Kifayet qeder yanacaq yoxdur.");
            }
        }
    }
}
