using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrati k1 = new Kvadrati();
            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            k1.Minicheba(par1: ref num1, par2: ref num2);
            Console.WriteLine("First number: {0}\nSecond number: {1}", num1, num2);
            Console.WriteLine("Minichebis shemdeg: "+ k1.Minicheba(par1: ref num1, par2: ref num2));
            Console.ReadKey();
        }
    }
}
