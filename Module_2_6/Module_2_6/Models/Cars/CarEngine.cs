using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars
{
    public abstract class CarEngine : EasyCar
    {
        protected CarEngine(double price, string name, double weight, double consumption, string colour)
            : base(price, name, weight, consumption, colour)
        {
        }

        public abstract TypeOfCar TypeOfCar { get; } 

        public abstract YearOfEcoCar Year { get; }
    }
}
