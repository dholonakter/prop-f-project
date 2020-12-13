using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class LoanOrder:Order
    {
        // fields
        public DateTime ReturnDate { get; set; }

        // constructor
        public LoanOrder(Shop originShop) : base(originShop)
        {
            // use base
        }
        
    }
}
