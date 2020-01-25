using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentShop
{
    public class Instrument
    {
        [Key]
        public int Id { get; set;}
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
}
