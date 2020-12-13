using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Participant
    {
        /// <summary>
        /// Superclass for Visitor and Staff
        /// </summary>

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int IdNr { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RFIDNr { get; set; }
        public bool CheckedIn { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Participant(int idNr, string firstName, string lastName, string phone, string mail,
                      string rfidNr, bool checkedIn)
        {
            this.IdNr = idNr;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = mail;
            this.RFIDNr = rfidNr;
            this.CheckedIn = checkedIn;
        }

        public Participant(int idNr, string firstName, string lastName, string phone, string mail)
        {
            this.IdNr = idNr;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = mail;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////
        /// <summary>
        /// Returns a string with info of a participant
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.IdNr + " " + this.FirstName + " " + this.LastName 
                + "\nPhone: " + this.Phone
                + "\nChecked in: " + this.CheckedIn.ToString()
                + "\nRFID: " + this.RFIDNr;
        }

        /// <summary>
        /// Changes RFID's attribute and sets CheckedIn to true
        /// </summary>
        /// <param name="rfid"></param>
        public void CheckInWith(string rfid)
        {
            this.RFIDNr = rfid;
            this.CheckedIn = true;
        }

        /// <summary>
        /// Sets RFID to blank and sets CheckedIn to false
        /// </summary>
        public void CheckOut()
        {
            this.RFIDNr = "";
            this.CheckedIn = false;
        }
    }
}
