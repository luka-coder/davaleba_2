using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._2
{
    class Chemi_Klasi_2
    {
        public Chemi_Klasi_1 Gamotana(int[] array1)
        {
            int max = array1[0];
            int min = array1[0];
            for(int i = 0; i < array1.Length; i++)
            {
                if (max < array1[i]) max = array1[i];
                if (min > array1[i]) min = array1[i];
            }
            return new Chemi_Klasi_1(min, max);
        }
    }
}
