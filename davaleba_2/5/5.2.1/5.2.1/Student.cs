using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1
{
    class Student
    {
        public float Avg(int[] array)
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / array.Length;
            return avg;
        }
    }
}
