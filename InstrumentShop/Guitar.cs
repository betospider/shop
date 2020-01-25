using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentShop
{
    class Guitar : Instrument
    {
        public Guitar(string name, string type, int price) : base()
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public override string InstrumentType()
        {
            Console.WriteLine("\nGuitars available:");
            return name + price + type;

        }



    }
}
