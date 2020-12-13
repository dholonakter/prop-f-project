using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampEntranceApp
{
 public class CampSpot

      {
        public int SpotNr { get; set; }
        public int LocationNr { get; set; }
        public string SpotName { get; set; }

        public CampSpot(int spotnr,int locationnr,string spotname)
        {
            this.SpotNr = spotnr;
            this.SpotName = spotname;
            this.LocationNr = locationnr;
        }

        

    }
}
