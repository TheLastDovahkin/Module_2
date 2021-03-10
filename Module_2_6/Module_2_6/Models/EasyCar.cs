using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models
{
    public abstract class EasyCar : Auto
    {
        protected EasyCar(double price, string name, double weight, double consumption, string colour)
            : base(price, name, weight, consumption, colour)
        {
        }

        public abstract int Year { get; }
       
    }
}
