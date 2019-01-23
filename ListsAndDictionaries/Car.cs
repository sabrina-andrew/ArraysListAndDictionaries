using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndDictionaries
{
    public class Car
    {
        //This is a constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        // End of constructor

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int MilesPerGallon { get; set; }
    }
}
