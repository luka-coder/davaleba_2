using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._1
{
    class Chemi_Klasi
    {
        int num1, num2, num3,sum;
        public int Gamotvla(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            sum = this.num1 + this.num2 + this.num3;
            return sum;
        }
    }
}
