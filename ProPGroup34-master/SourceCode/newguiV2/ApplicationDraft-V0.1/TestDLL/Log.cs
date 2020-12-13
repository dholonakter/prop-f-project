using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Log
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public string StartPeriod { get; set; }
        public string EndPeriod { get; set; }
        public string SenderNr { get; set; }
        public string ReceiverNr { get; set; }
        public double Amount { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Log(string startPeriod, string endPeriod, string senderNr, string receiverNr, double amount)
        {
            this.StartPeriod = startPeriod;
            this.EndPeriod = endPeriod;
            this.SenderNr = senderNr;
            this.ReceiverNr = receiverNr;
            this.Amount = amount;
        }

    }
}
