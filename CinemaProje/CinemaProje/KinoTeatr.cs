using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProje
{
   public class KinoTeatr
    {
        private static int ID;
        private int uniqueId;

        public string CinemaName { get; set; }

        public ZalType Type { get;private set; }

        public readonly int Price;

        private Place[,] places;
        private int countPlace;


        public KinoTeatr(string name, ZalType type, int price, int count)
        {
            ID++;
            uniqueId = ID;
            CinemaName = name;
            Type = type;
            Price = price;
            places = new Place[0,0];
            countPlace = count;
        }
        public void AddPlace(Place place)
        {
            Console.WriteLine(places.Length);
        }
    }
}
