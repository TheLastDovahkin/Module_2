using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars.Standart
{
    public class Camry : CarEngine
    {
        public Camry(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public override TypeOfEngine TypeOfCar => TypeOfEngine.Standart;

        public override string Year => "2015";

        public override double Consumption => 11.5;


    }
}
