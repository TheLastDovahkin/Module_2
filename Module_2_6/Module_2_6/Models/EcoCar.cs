using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models
{
    public abstract class EcoCar : EasyCar
    {
        protected EcoCar(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public abstract double Distance { get; }

        public abstract EecoCar[] EcoCars { get; }
    }
}
