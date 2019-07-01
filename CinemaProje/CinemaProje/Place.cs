using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProje
{
   public class Place
    {
        private static int ID;
        private int uniqueId;

        public int Col { get; set; }
        public int Row { get; set; }

        

        public Place(int col,int row)
        {
            Col = col;
            Row = row;
        }

       
    }
}
