using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Ticket
    {
        /// <summary>
        /// Class to hold Ticket's information
        /// </summary>

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int TicketNr { get; set; }
        public DateTime TicketDate { get; set; }
        public int BuyerNr { get; set; }
        public string TicketType { get; set; }
        public bool Paid { get; set; }
        public double Price { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Ticket(int ticketNr, DateTime date, int buyer, string type, bool paid, double price)
        {
            this.TicketNr = ticketNr;
            this.TicketDate = date;
            this.BuyerNr = buyer;
            this.TicketType = type;
            this.Paid = paid;
            this.Price = price;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        /// <summary>
        /// Returns ticket's information as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Ticket #" + this.TicketNr
                + "\nBought on " + this.TicketDate
                + "\nType: " + this.TicketType
                + "\nBuyer: " + this.BuyerNr
                + "\nStatus: " + (Paid ? "PAID" : "NOT PAID")
                + "\nPrice : €" + Price.ToString("0.00") + (Paid? "" : " + €10.00 = €" + (Price + 10).ToString("0.00"));
        }

        public void ChangeStatus()
        {
            Paid = !Paid;
        }
    }
}
