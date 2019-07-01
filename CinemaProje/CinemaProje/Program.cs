using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProje
{
    class Program
    {
        static void Main(string[] args)
        {
            ZalType big = new ZalType("big");
            ZalType small = new ZalType("small");
            ZalType middle = new ZalType("middle");

            KinoTeatr seans = new KinoTeatr("ParkCinema", big, 7,3);

            Place place = new Place(2,2);
            seans.AddPlace(place);
        }
    }
}
