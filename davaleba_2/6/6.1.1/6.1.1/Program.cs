using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Page_1: ");
            int page1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Page_2: ");
            int page2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Page_3: ");
            int page3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Samkutxedi S1 = new Samkutxedi(page1, page2, page3, height);
            double shedegi = S1.Fartobi();
            Console.WriteLine("\nPage_1:" + page1 + "\nPage_2:" + page2 + "\nPage_3:" + page3 + "\nHeight:" + height + "\nFartobi:" + S1.Fartobi());
            Console.ReadKey();

        }
    }
}
