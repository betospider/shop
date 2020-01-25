using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentShop
{
    class Saxophone : Instrument
    {
        public Saxophone(string name, string type, int price) : base()
        {
            this.Name = name;
            this.Type = type;
            this.Price = price;

        }
        //public override string InstrumentType()
        //{
        //    Console.WriteLine("\nSaxophones available:");
        //    return Name + Price + type;

        //}
    }
}
