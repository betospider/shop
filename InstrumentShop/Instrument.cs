using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentShop
{
    public class Instrument
    {
        [Key]
        public int id { get; set;}
       
        public string name { get; set; }
        public string type { get; set; }
        public int price;

        //public Instrument(string name) { this.name = name; }
        //public Instrument(string name = "guitar", string type = "acoustic", int price = 1000)
        //{
        //    this.name = name;
        //    this.type = type;
        //    this.price = price;
        //}

        public int GetPrice()
        {
            return price;
        }

        public string GetInstrument()
        {
            return name;
        }

        public virtual string InstrumentType()
        {
            Console.WriteLine("Parent class instruments :");
            return name;
        }

    }
}
