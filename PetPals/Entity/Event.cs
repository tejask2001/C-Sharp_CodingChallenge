using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Event
    {
        private int eventID;
        private string eventName;
        private DateTime eventDate;
        private string location;

        public Event() { }
        public Event(int eventID, string eventName, DateTime eventDate, string location)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.eventDate = eventDate;
            this.location = location;
        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        public DateTime EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public override string ToString()
        {
            return $"EventID: {EventID}, EventName: {EventName}, " +
                   $"EventDate: {EventDate}, Location: {Location}";
        }
    }
}
