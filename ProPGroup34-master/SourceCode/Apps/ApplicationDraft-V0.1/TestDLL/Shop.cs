using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Shop
    {
        /// <summary>
        /// This class holds information about a shop (can be store/loan)
        /// </summary>

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int ShopNr { get; set; }
        public string ShopName { get; set; }
        public string LocationName { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Shop(int nr, string name, string loc)
        {
            this.ShopNr = nr;
            this.ShopName = name;
            this.LocationName = loc;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////
        public override string ToString()
        {
            return "Store #" + this.ShopNr + " - " + this.ShopName + " located at " + this.LocationName;
        }

    }
}
