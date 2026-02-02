using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion4_iti
{
    internal class Vehicle // base class
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}
