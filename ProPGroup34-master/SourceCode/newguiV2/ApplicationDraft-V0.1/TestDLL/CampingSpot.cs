using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class CampingSpot
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int SpotNr { get; set; }
        public string LocationName { get; set; }
        public string SpotName { get; set; }
        public bool ToBeServiced { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////


        /**
         * Full variables constructors
         */
        public CampingSpot(int nr, string location, string name, bool serviced)
        {
            this.SpotNr = nr;
            this.LocationName = location;
            this.SpotName = name;
            this.ToBeServiced = serviced;
        }

        /**
         * Constructor to display
         */
        public CampingSpot(int nr, string name)
        {
            this.SpotNr = nr;
            this.SpotName = name;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////
        public override string ToString()
        {
            return "Spot #" + this.SpotNr + " - " + this.SpotName + " at " + this.LocationName + (ToBeServiced ? " - Needes servicing" : " - Clear");
        }
    }
}
