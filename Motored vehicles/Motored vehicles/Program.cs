using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored_vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car2 = new Car("Toyota", "Camry", "2021", true);

            Console.WriteLine(car2.GetDetailedInfo());

            Console.ReadKey();
        }
    }
}
