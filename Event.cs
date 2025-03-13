using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Event
    {
        public int EventNumber {  get; set; }
        public string Location { get; set; }
        public string EventName { get; set; }

        public Event(int eventNumber, string location, string eventName)
        {
            EventNumber = eventNumber;
            Location = location;
            EventName = eventName;
        }
        public override string ToString()
        {
            return $"{EventNumber}\n{Location}\n{EventName}";
        }
    }
}
