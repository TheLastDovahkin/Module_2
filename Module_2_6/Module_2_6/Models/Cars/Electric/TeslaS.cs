﻿using Module_2_6.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6.Models.Cars.Electric
{
    public class TeslaS : CarEngine
    {
        public TeslaS(double price, string name, double weight, string colour)
            : base(price, name, weight, colour)
        {
        }

        public override TypeOfEngine TypeOfCar => TypeOfEngine.Electric;

        public override string Year => "2015";

        public override double Consumption => 16.0;
    }
}
