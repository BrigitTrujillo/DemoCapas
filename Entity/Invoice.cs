using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice
    {
        public int detail_id { get; set; }
        public int invoice_id { get;set; }
        public string quantity { get;}

        public decimal price { get; set; }

        public decimal subtotal { get;}

        public Boolean active { get;}
    }
}
