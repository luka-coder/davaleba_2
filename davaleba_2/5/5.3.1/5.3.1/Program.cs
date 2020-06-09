using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane p1 = new Plane(500,20);
            p1.Gamotana();
            p1.Calculate();
            Console.ReadKey();
        }
    }
}
