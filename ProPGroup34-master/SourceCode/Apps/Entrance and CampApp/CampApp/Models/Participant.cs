using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp
{
 public  class Participant:Visitor
    {
        #region private fields
        public ParticipantRole Role { get; set; }

        public string LeaderRFIDCode { get; set; }
        #endregion

        #region constructor
        public Participant(string rfid,string fullname,double balance, ParticipantRole role,string leaderRFIDCode):base(fullname,rfid,balance)
        {
            Role = role;
            LeaderRFIDCode = leaderRFIDCode;
        }
        public Participant()
        {
                
        }
        #endregion

        #region Method

        public override string ToString()
        {
            return base.ToString() + " " + Role;

        }
     #endregion
    }
}
