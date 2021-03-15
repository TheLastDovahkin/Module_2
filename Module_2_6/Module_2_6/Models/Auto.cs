using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6
{
    public class Auto
    {
        protected Auto(double price, string name, double weight, string colour)
        {
            Price = price;
            Name = name;
            Weight = weight;
            Colour = colour;
        }
        
        public double Price { get; }

        public string Name { get; }

        public double Weight { get; }

        public string Colour { get; }

    }
}
