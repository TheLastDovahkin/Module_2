using Module_2_6.Enums;
using Module_2_6.Models;
using Module_2_6.Models.Cars;
using Module_2_6.Models.Cars.Electric;
using Module_2_6.Models.Cars.Standart;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Service
{
    class ParkService : IParkService
    {
        public ParkService()
        {
        }

        public ParkService CreateCar()
        {
            var easyCar = new EasyCar[]
            {
                new ASX(1000, "Mitsubishi", 2.2, "Yellow"),
                new Camry(1111,"Toyota", 1.7, "black"),
                new TeslaX(1222, "Tesla", 2.5, "White"),
                new TeslaS(1333, "Tesla",2.2,"Green")
            };

            var consumption = 0d;
            for (var i = 0; i< easyCar.Length; i++)
            {
                consumption += easyCar[i].Consumption;
            }

            return new AutoPark { EstandartCars = easyCar, EecoCars = consumption };
        }
    }
}
