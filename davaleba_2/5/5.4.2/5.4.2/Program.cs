﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Namravli n = new Namravli();
            Console.Write("Cvladi_1:");
            int cvladi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cvladi_2:");
            int cvladi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cvladi_3:");
            int cvladi3 = Convert.ToInt32(Console.ReadLine());
            int multi = n.Gamotvla(cvladi1,cvladi2,cvladi3);
            Console.WriteLine($"Cvladi_1:{cvladi1}");
            Console.WriteLine($"Cvladi_2:{cvladi2}");
            Console.WriteLine($"Cvladi_3:{cvladi3}");
            Console.WriteLine($"Multi:{multi}");
            Console.ReadKey();
        }
    }
}
