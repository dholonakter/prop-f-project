using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp
{
     public  class Location
    {

        #region private fields
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        #endregion

        #region Construcor
        public Location(int locationId, string locationName)
        {
            LocationId = locationId;
            LocationName = locationName;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return LocationName;
        }
        #endregion
    }
}
