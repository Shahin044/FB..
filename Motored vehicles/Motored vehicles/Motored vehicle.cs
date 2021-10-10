using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored_vehicles
{
    class Motored_vehicle
    {
        public string Model;
        public string Make;
        public string Colour;
        public string ProductionYear;
        public int FuelTankSize;
        public int FuelUsedPerKm;
        public int FuelAmount;
        public string Transmission;
        public int PassengerCount;
        public string Horsepower;
        public string MotorSize;

        public Motored_vehicle()
        {
            Console.WriteLine("Bir MotoredVehicle yaradildi");
        }

        public Motored_vehicle(string make, string model, string productionYear)
        {
            this.Make = make;
            this.Model = model;
            this.ProductionYear = productionYear;
        }
        public virtual string GetDetailedInfo()
        {

            return $"{Make} /{Model} /{ProductionYear} /{Colour} /{Transmission} /{MotorSize} /{Horsepower} /{FuelTankSize} /{FuelAmount} /{FuelUsedPerKm}/{PassengerCount}";

        }

        public string GetInfo()
        {

            return $"{Make} /{Model} / {ProductionYear}";

        }
    }
}
