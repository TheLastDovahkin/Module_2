using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars
{
    public class Leaf : CarEngine
    {
        public Leaf(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public override TypeOfEngine TypeOfCar => TypeOfEngine.Electric;

        public override YearOfEcoCar EcoYear => YearOfEcoCar.Nissan2010;

        public override double Consumption => 10.0;

    }
}
