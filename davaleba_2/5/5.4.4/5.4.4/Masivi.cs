using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._4
{
    class Masivi
    {
        int[] array;
        public int Gamotvla(int[] array)
        {
            int i,min;
            min = array[0];
            for (i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                } 
            }
            return min;
        }
    }
}
