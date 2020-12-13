using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Visitor:Participant
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        double credit;

        public double Credit
        {
            get { return credit; }
            set
            {
                if (value < 0)
                {
                    credit = 0;
                }
                else
                {
                    credit = value;
                }
            }
        }
        public int ReservNr { get; set; }
        public List<LoanArticle> ArticlesBorrowed { get; set; } // need for checking out
        public bool IsInCamp { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Visitor(int visitorNr, string firstName, string lastName, string phone, string mail,
                      string rfidNr, bool checkedIn, double credit, int reservNr, bool isInCamp)
                      : base(visitorNr, firstName, lastName, phone, mail, rfidNr, checkedIn)
        {  
            this.Credit = credit;
            this.ReservNr = reservNr;
            this.IsInCamp = isInCamp;
            ArticlesBorrowed = new List<LoanArticle>();
        }
        public Visitor(int visitorNr, string firstName, string lastName, string phone, string mail)
            : base(visitorNr, firstName, lastName, phone, mail)
        {
            // base
        }
        public Visitor (int visitorNr, string firstName, string lastName, string phone, string mail, string rfidNr) 
            : base(visitorNr, firstName, lastName, phone, mail)
        {
            // base
            this.RFIDNr = rfidNr;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        // info to string
        public override string ToString()
        {
            return "Visitor Nr." + this.IdNr 
                + ": " + this.FirstName + " , " + this.LastName.ToUpper()
                + "; Phone: " + this.Phone;
        }
       
        // add credit by amount
        public void ChangeCreditBy (int amount)
        {
            this.Credit += amount;
        }

        // returns true if the list of borrowed articles is empty
        public bool CanLeave()
        {
            if (ArticlesBorrowed.Count == 0)
            {
                return true;
            }
            return false;
        }

        // returns a string of info about all unreturned articles
        public string ShowAllArticlesUnreturned()
        {
            string info = "No articles unreturned";
            if (ArticlesBorrowed.Count != 0)
            {
                info = "";
                info += "UNRETURNED ITEMS:";
                foreach (Article a in ArticlesBorrowed)
                {
                    info += "\nArticle #" + a.ArticleNr + " at Loan Stand " + a.ShopName;
                }
                return info;
            }
            return info;
        }
    }
}
