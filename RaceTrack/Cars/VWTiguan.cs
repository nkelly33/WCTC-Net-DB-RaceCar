using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    internal class VWTiguan : RaceCar
    {
        public VWTiguan() { 
            Name = "VW Tiguan";
            TopSpeed = 120;

        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} fires the cylinders!");
        }
    }
}
