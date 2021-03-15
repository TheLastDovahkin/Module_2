using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models
{
    public abstract class EasyCar : Auto
    {
        protected EasyCar(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        } 

        public abstract double Consumption { get; }
    }
}
