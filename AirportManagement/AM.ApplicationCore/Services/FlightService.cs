using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightService: IFlightService
    {

        ICollection<Flight> s;
        ShowLine showLine;

      

        public FlightService (ICollection<Flight> source , ShowLine showLine) {
            s = source;
            this.showLine = showLine;
                }

        public void ShowFlights(string filterType, string filterValue)
        {
            showLine($"*****filterType : {filterType } , filterValue :  { filterValue}");

            switch (filterType)
            {
                case "Destination":
                    foreach(Flight flight in s)
                    {
                        if (flight.Destination == filterValue) {
                           showLine(flight);
                        }
                    }
                    break;

                case "FlightDate":
                    DateTime d = DateTime.Parse(filterValue);
                    foreach (Flight flight in s)
                    {
                   
                        if (flight.FlightDate ==d)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "FlightId":

                    int id = Int32.Parse(filterValue);

                    foreach (Flight flight in s)
                    {

                        if (flight.FlightId == id)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                default:

                    throw new ArgumentException("unkown");
            }


           
           
        }

        public static IEnumerable<Tuple<int, float>(int flightId, float DurationInMinutes) GetDurationsInMinute(this IEnumerable<Flight> flights)
        {
            flights.Select(f => new Tuple<int, float>(f.FlightId, f.EstimatedDuration * 60));
        }
    }
}
