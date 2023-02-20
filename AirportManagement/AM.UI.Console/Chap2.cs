using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{

    public static class Chap2
    {
        public static ShowLine showLine;

        public static void Test1()

        {
              FlightService flightService = new FlightService();

            flightService.ShowFlights("Destination", "Destination");
            flightService.ShowFlights("Destination", "Madrid");
            flightService.ShowFlights("Destination", "3");



        }

    }
}
