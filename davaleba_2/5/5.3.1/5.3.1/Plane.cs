using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1
{
    class Plane
    {
        private int capacity;
        private float distance;
        private float calculate;


        public  Plane(int capacity1,float distance1)
        {
            capacity = capacity1;
            distance = distance1;
            calculate = capacity * distance;
        }
        public void Gamotana()
        {
            Console.WriteLine("Capacity:" + capacity + "\nDistance:" + distance);
        }
        public void Calculate()
        {
            calculate = capacity * distance;
            Console.WriteLine($"Distance with full tank: {calculate}");
        }
    }
}
