using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Participant
    {
        // Superclass for visitor and staff

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
        
        // info to string
        public override string ToString()
        {
            return this.IdNr + " " + this.FirstName + " " + this.LastName 
                + "\nPhone: " + this.Phone
                + "\nChecked in: " + this.CheckedIn.ToString()
                + "\nRFID: " + this.RFIDNr;
        }

        // updates rfid and status for checking in
        public void CheckInWith(string rfid)
        {
            this.RFIDNr = rfid;
            this.CheckedIn = true;
        }

        // updates rfid and status for checking out
        public void CheckOut()
        {
            this.RFIDNr = "";
            this.CheckedIn = false;
        }
    }
}
