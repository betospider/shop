using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentShop
{
    class Sales
    {
        protected string sales_type;
        protected int customerID;
        protected int instrumentID;
        public Sales(int customerID = 1, int instrumentID = 2, string sales_type = "purchase")
        {
            this.customerID = customerID;
            this.instrumentID = instrumentID;
            this.sales_type = sales_type;
        }

        public int Purchase(Instrument instrument, int instrumentID, int salesID)
        {
            return salesID;
        }
    }
}

