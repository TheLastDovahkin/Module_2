using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_6
{
    public class TaxiPark
    {
        protected TaxiPark(string phoneNum, string adres)
        {
            Adres = adres;
            Number = phoneNum;
        }   

        public string Adres { get; }

        public string Number { get; }
    }
}
