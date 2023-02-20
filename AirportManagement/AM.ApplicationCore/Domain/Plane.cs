using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual  IList<Flight> Flights { get; set; }


        public Plane()
        {}
        public Plane(PlaneType PlaneT ,int C, DateTime ManufactureD)
        {
            PlaneT = PlaneType;
            C = Capacity;
            ManufactureD = ManufactureDate;
            
            
        }

        public override string ToString()
        {
            return "Plane Id :" + PlaneId + ", Capacity : " + Capacity + ", Date : " + ManufactureDate; 
        }
    }
}
