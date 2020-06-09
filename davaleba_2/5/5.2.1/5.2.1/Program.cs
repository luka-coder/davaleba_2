using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 50, 87, 71, 90, 94, 58, 83, 57, 70, 60 };
            float Result;
            Student S1 = new Student();
            Result = S1.Avg(array);
            Console.WriteLine($"AVG : {Result}");
            Console.ReadKey();
        }
    }
}
