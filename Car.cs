using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion4_iti
{
    internal class Car : Vehicle  // Derived Class 
    {
        public int NumberOfDoors { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();  //  Brand , Speed
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }
}