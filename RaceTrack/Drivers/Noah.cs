﻿using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    internal class Noah : Driver
    {
        public Noah(RaceCar car) : base(car)
        {
            Name = "Noah";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
        public  void Brake()
        {
            Console.WriteLine("the car has stopped");
        }
    }
}