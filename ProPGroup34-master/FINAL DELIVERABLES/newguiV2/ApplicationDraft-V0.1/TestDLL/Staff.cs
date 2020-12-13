using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Staff : Participant
    {
        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        double salary;

        public string JobDescription { get; set; }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Staff(int idNr, string firstName, string lastName, string phone, string mail,
                      string rfidNr, bool checkedIn, string jobDescription, double salary) 
                    : base (idNr, firstName, lastName, phone, mail, rfidNr, checkedIn)
        {
            this.JobDescription = jobDescription;
            this.Salary = salary;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        // info to string
        public override string ToString()
        {
            return "[" + this.JobDescription + "] Staff #" + base.ToString();
        }
    }
}
