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

        /// <summary>
        /// Returns ticket's information as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Reservation #" + this.ReservNr 
                  + "\nReserved on " + this.ReservDate
                  + "\nSpot #" + Spot.SpotNr + " " + Spot.SpotName 
                  + "\nReserved by: " + Reserver.FirstName + " " + Reserver.LastName 
                  + "\nPhone: " + Reserver.Phone 
                  + "\nEmail: " + Reserver.Email
                  + "\nPeriod: " + StartDate + " to " + EndDate
                  + "\nStatus: " + (Paid ? "PAID" : "NOT PAID") 
                  + "\nPeople: " + NrCheckedIn + "/" + NrOfRegistered;
        }

        public void CheckIn()
        {
            this.NrCheckedIn += 1;
        }

        public void ChangeStatus()
        {
            this.Paid = true;
        }
    }
}
