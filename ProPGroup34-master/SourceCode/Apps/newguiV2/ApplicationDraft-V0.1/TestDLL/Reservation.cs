using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Reservation
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int ReservNr { get; set; }
        public DateTime ReservDate { get; set; }
        public CampingSpot Spot { get; set; }
        public Visitor Reserver { get; set; }
        public int NrOfRegistered { get; set; }
        public int NrCheckedIn { get; set; }
        public bool Paid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Reservation (int reservNr, DateTime reservDate, CampingSpot spot, 
            Visitor reserver, int nrOfRegistered, int nrCheckedIn, bool paid, DateTime startDate, DateTime endDate)
        {
            this.ReservNr = reservNr;
            this.ReservDate = reservDate;
            this.Spot = spot;
            this.Reserver = reserver;
            this.NrOfRegistered = nrOfRegistered;
            this.NrCheckedIn = nrCheckedIn;
            this.Paid = paid;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        // returns reservation's info as a string
        public override string ToString()
        {
            return "RESERVATION NR. " + ReservNr +
                        "; Reserved on: " + ReservDate +
                        "; Reserved spot: " + Spot.SpotName +
                        "; Status: " + NrCheckedIn + "/" + NrOfRegistered + " present";
        }

        // adds a camper to the reservation
        public void CheckIn()
        {
            this.NrCheckedIn += 1;
        }

        // changes status to paid
        public void ChangeStatus()
        {
            this.Paid = true;
        }
    }
}
