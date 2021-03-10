using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6
{
    public class Auto
    {
        protected Auto(double price, string name, double weight, double consumption, string colour)
        {
            Price = price;
            Name = name;
            Weight = weight;
            Consumption = consumption;
            Colour = colour;
        }
        
        public double Price { get; }

        public string Name { get; }

        public double Weight { get; }

        public double Consumption { get; }

        public string Colour { get; }

    }
}
