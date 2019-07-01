using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    abstract class Human
    {
        public Human(string name)
        {
            Console.WriteLine($"Human klasi-{name}");
        }
    }

    class Man : Human
    {
        public Man(string str):base(str)
        {
            Console.WriteLine($"MAN klasi-{str}");
        }
    }

    class Woman : Human
    {
        public Woman(string str) : base(str)
        {
            Console.WriteLine($"Woman klasi-{str}");
        }
    }
}
