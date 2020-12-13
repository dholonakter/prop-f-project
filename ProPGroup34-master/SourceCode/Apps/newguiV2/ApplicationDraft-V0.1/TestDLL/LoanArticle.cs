using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class LoanArticle : Article
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public string RFIDNr { get; set; }
        public double DepositValue { get; set; }


        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////

        /**
         * Constructor with full variables
         */
        public LoanArticle(int shopNr, string shopName, int articleNr, string articleName, double price, int available, string rfid, double deposit)
            : base(shopNr, shopName, articleNr, articleName, price, available)
        {
            // using base 
            this.RFIDNr = rfid;
            this.DepositValue = deposit;
        }
        
        /**
         * Constructors without ShopName and Img
         */
        public LoanArticle(int shopNr, int articleNr, string articleName, double price, int available, string rfid, double deposit)
            : base(shopNr, articleNr, articleName, price, available)
        {
            // using base
            this.DepositValue = deposit;
            this.RFIDNr = rfid;
        }
        /**
         * Simplest constructors to display items
         */
        public LoanArticle(string shopName, int articleNr, string articleName) : base(shopName, articleNr, articleName)
        {
            // using base
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        // Sets availability to 1 -> Returned
        public bool ReturnItem()
        {
            if (this.Available == 0)
            {
                this.Available = 1;
                return true;
            }
            return false;
        }

        // Sets availability to 0 -> Borrowed
        public bool BorrowItem()
        {
            if (this.Available == 1)
            {
                this.Available = 0;
                return true;
            }
            return false;
        }
    }
}
