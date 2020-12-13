using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampEntranceApp
{
    public class Reservation
    {
        #region Properties
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Time { get; set; }
        public int TotalMember { get; set; }
        public int SpotNumber { get; set; }
        public int LocationNumber { get; set; }//used this field for dbi364365 database
        public string LeaderRFIDCode { get; set; }//used this field for dbi364365 database
        public bool IsPaid { get; set; }
        public int NrOfCheckedIn { get; set; }
        public int Reserver { get; set; }//this column should be in reservation in participant_id in participant table.
        #endregion

        #region Constructor
        public Reservation(string startDate, string endDate, int spotNr,int totalnr, int nrofcheckedIn,bool isPaid)
        {
            StartDate = startDate;
            EndDate = endDate;
            TotalMember = totalnr;
            SpotNumber = spotNr;
            IsPaid = isPaid;
            NrOfCheckedIn = nrofcheckedIn;
        }
        #endregion

        #region Public Method
        public override string ToString()
        {
            return base.ToString() + StartDate + EndDate + TotalMember;
        }
        #endregion

    }
}
