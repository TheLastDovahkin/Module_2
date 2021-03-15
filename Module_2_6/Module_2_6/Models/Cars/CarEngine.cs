using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars
{
    public abstract class CarEngine : EasyCar
    {
        protected CarEngine(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public abstract TypeOfEngine TypeOfCar { get; } 

        public abstract YearOfEcoCar EcoYear { get; }

        public abstract YearOfStandartCar StandartYear { get; }
    }
}
