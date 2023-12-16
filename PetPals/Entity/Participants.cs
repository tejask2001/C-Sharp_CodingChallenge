using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Participants
    {
        private int participantID;
        private string participantName;
        private string participantType;
        private int eventID;

        public Participants() { }
        public Participants(int participantID, string participantName, string participantType, int eventID)
        {
            this.participantID = participantID;
            this.participantName = participantName;
            this.participantType = participantType;
            this.eventID = eventID;
        }

        public int ParticipantID
        {
            get { return participantID; }
            set { participantID = value; }
        }

        public string ParticipantName
        {
            get { return participantName; }
            set { participantName = value; }
        }

        public string ParticipantType
        {
            get { return participantType; }
            set { participantType = value; }
        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public override string ToString()
        {
            return $"ParticipantID: {ParticipantID}, ParticipantName: {ParticipantName}, " +
                   $"ParticipantType: {ParticipantType}, EventID: {EventID}";
        }
    }
}
