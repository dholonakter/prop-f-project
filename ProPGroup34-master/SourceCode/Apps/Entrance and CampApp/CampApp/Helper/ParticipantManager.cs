using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp
{
    public class ParticipantManager
    {
        #region private constant fields
        private const double CAMP_BOOKING_PRICE_PER_PERSON = 10;
        private const int MAX_ALLOWED_PARTICIPANT=6;
        private const string PARTICIPANTNOTALLOWEDEXCEPTION_MESSAGE = "Cannot Add more participant max allowed is ";
        private List<Participant> participants;
        #endregion

        #region constructor
        public ParticipantManager()
        {
            participants = new List<Participant>(MAX_ALLOWED_PARTICIPANT);
            
        }
        #endregion

        #region private Method

        private bool IsParticipantExist(string rfidCode)
        {
            foreach (Participant participant in participants)
            {
                if (participant.RFID.Equals(rfidCode))
                    return true;
            }
            return false;
        }
        #endregion

        #region public Method
        public bool AddParticipant(Visitor visitor)
        {
            bool onSuccess = false;
            if (visitor != null)
            {
                if (participants.Count<= MAX_ALLOWED_PARTICIPANT)
                {
                    if(!IsParticipantExist(visitor.RFID))
                    {
                        Participant newParticipant = new Participant
                        {
                            FullName = visitor.FullName,
                            RFID = visitor.RFID,
                            Balance = visitor.Balance
                        };
                        participants.Add(newParticipant);
                    }
                }
                else if (participants.Count>MAX_ALLOWED_PARTICIPANT)
                {
                    throw new ParticipantNotAllowedException(PARTICIPANTNOTALLOWEDEXCEPTION_MESSAGE + MAX_ALLOWED_PARTICIPANT);
                }
            }
            return onSuccess;
        }

        public bool UpdateAllParticipants(ParticipantRole role,double topUp)
        {
            bool onSuccess = false;

            for (int index = 0; index < participants.Count; index++)
            {
                if(index==0)
                {
                    participants[index].Role = role;
                    participants[index].LeaderRFIDCode = participants[index].RFID;
                    participants[index].Balance+=topUp;
                    participants[index].Balance -= (participants.Count * CAMP_BOOKING_PRICE_PER_PERSON);
                    onSuccess = true;
                }
                else
                {
                    participants[index].Role = ParticipantRole.Member;
                    participants[index].LeaderRFIDCode = participants[0].RFID;
                    onSuccess = true;
                }
            }
            return onSuccess;
        }
        public List<Participant> GetAllParticipant()
        {
            return participants;
        }

        public void RemoveAllParticipant()
        {
            participants.Clear();
        }
        public bool RemoveParticipant(Participant participant)
        {
            return participants.Remove(participant);
        }
        #endregion

    }
}
