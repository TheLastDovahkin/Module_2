using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars
{
    public class Leaf : CarEngine
    {
        public Leaf(double price, string name, double weight, double consumption, string colour)
            : base(price, name, weight, consumption, colour)
        {
        }

        public override TypeOfCar TypeOfCar => TypeOfCar.Electric;

        public override YearOfEcoCar Year => throw new NotImplementedException();

    }
}
