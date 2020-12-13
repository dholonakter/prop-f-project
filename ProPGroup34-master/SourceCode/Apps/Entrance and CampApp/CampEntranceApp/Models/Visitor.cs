using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampEntranceApp
{
    public class Visitor
    {
         #region Properties
        public int Id { get; set; }
        public string FullName { get; set; }//dbi364365 database
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Phone { get; set; }
        public string RFID { get; set; }
        public double Balance { get; set; }
        public bool IsCheckedIn { get; set; }
        #endregion

         #region constructor
        public Visitor(string firstname,string lastname,string rfid,double balance)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.RFID = rfid;
            this.Balance = balance;
        }
        public Visitor()
        {

        }
        #endregion

         #region  Public Method
        public override string ToString()
        {
            return FirstName + "," + LastName + "," + RFID;

        }
        #endregion
    }
}