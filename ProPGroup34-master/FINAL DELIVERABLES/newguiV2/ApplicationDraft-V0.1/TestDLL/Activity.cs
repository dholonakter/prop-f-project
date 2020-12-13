using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Activity
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int ActivityNr { get; set; }
        public string ActivityName { get; set; } 
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string LocationName { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        
        public Activity(int activityNr, string activityName, string startTime, string endTime, string locationName)
        {
            this.ActivityNr = activityNr;
            this.ActivityName = activityName;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.LocationName = locationName;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        // Export string
        public override string ToString()
        {
            return "Activity #" + this.ActivityNr + " - " + this.ActivityName +
                "- Start: " + this.StartTime + " - End: " + this.EndTime + " - At location: " + this.LocationName;
        }
    }
}
