using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampApp
{
    public class Visitor
    {
        #region Properties
        public int Id { get; set; }
        public string FullName { get; set; }
        public string RFID { get; set; }
        public double Balance { get; set; }
        public bool IsCheckedIn { get; set; }
        #endregion

        #region constructor
        public Visitor(string fullname,string rfid,double balance)
        {
            this.RFID = rfid;
            this.Balance = balance;
            this.FullName = fullname;
        }
        public Visitor()
        {

        }
        #endregion

        #region Method
        public override string ToString()
        {
            return FullName + "," + Balance + "," + RFID;

        }
#endregion
    }
}