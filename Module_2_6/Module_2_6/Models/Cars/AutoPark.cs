using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars
{
    public class AutoPark : EasyCar
    {
        protected AutoPark(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public EecoCar[] EecoCars { get; }

        public EstandartCar[] EstandartCars { get; }   
    }
}
