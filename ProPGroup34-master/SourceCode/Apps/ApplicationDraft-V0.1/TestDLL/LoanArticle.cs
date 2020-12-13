using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class LoanArticle : Article
    {
        /// <summary>
        /// This class stores information about loanable articles
        /// </summary>
        
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
        public LoanArticle(int shopNr, string shopName, int articleNr, string articleName, double price, int available, string img, string rfid, double deposit)
            : base(shopNr, shopName, articleNr, articleName, price, available, img)
        {
            // using base 
            this.RFIDNr = rfid;
            this.DepositValue = deposit;
        }
        /**
         * Constructors without ShopName
         */
        public LoanArticle(int shopNr, int articleNr, string articleName, double price, int available, string img, string rfid)
            :base(shopNr, articleNr, articleName, price, available, img)
        {
            // using base
            this.RFIDNr = rfid;
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

        /// <summary>
        /// Returns info of a loanable article as as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Article #" + this.ArticleNr + " - " + this.ArticleName + " - $" + this.Price + " - In stock: " + this.Available;
        }

        /// <summary>
        /// Sets availability to 1 - which means has been returned
        /// Returns true on success and false otherwise
        /// </summary>
        /// <returns></returns>
        public bool ReturnItem()
        {
            if (this.Available == 0)
            {
                this.Available = 1;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets availability to 0 - which means has been borrowed
        /// Returns true on success and false otherwise
        /// </summary>
        /// <returns></returns>
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
