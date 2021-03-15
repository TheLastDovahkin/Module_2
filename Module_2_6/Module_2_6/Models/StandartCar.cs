using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models
{
    public abstract class StandartCar : EasyCar
    {
        protected StandartCar(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public abstract double EngineVolume {get;}

        public abstract EstandartCar[] EstandartCars { get; }
    }
}
