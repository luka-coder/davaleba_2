using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Page_1: ");
            double page1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Page_2: ");
            double page2 = Convert.ToDouble(Console.ReadLine());

            Square s1 = new Square(page1, page2);
            Square s2 = new Square(page1+10, page2 + 20);
            double shedegi1 = s1.Perimetri(s1);
            double shedegi2 = s2.Perimetri(s2);
            Console.WriteLine($"\nPage_1: {page1}"+$"\nPage_2: {page2}"+$"\nFartobi_1: {shedegi1}"+$"\nFartobi_2: {shedegi2}");
            Console.ReadKey();
        }
    }
}
