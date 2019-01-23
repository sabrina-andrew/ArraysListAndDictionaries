using System;
using System.Collections.Generic;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var fordFiesta = new Car("Ford", "Fiesta", 2013);
            var subarLegacy = new Car("Subaru", "Legacy", 2017);
            var hondaCrv = new Car("Honda", "CRV", 2014);

            var parkedCars = new Car[5];
            Console.WriteLine(parkedCars.Length);

            // Puts Honda CRV in array
            parkedCars[0] = hondaCrv;

            var firstCar = parkedCars[0];
            Console.WriteLine(firstCar.Make);


            //List instead of array

            //Angle brackets are generics.  
            var luxuryCars = new List<Car>();
            var firstLuxuryCar = luxuryCars[0];

            luxuryCars[0] = hondaCrv;

            //Another way to add to a list
            luxuryCars.Add(firstLuxuryCar);

            Console.WriteLine(firstLuxuryCar);


            Console.ReadLine();
        }
    }
}
