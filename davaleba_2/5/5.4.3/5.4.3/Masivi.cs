using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._3
{
    class Masivi
    {
        int[] array;
        public int Gamotvla(int[] array)
        {
            int i;
            this.array = array;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
            }
            return this.array[i];
        }
    }
}
