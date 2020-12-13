using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp
{
       public class CampSpot

        {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFree { get; set; }
        public int LocationId { get; set; }

        public CampSpot()
        {

        }

        public CampSpot(int id, string name, bool isFree,int locationId)
        {
            Id = id;
            Name = name;
            IsFree = isFree;
            LocationId = locationId;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
