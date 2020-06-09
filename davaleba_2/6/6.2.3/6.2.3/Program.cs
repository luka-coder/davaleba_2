using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Page_1: ");
            double page1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Page_2: ");
            double page2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Page_3: ");
            double page3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Samkutxedi s1 = new Samkutxedi(page1, page2, page3,height);
            s1.Dabruneba(perim: out page1);
        }
    }
}
