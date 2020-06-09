using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._2
{
    class Square
    {
        double page1, page2, perimetri;
        public Square(double par1, double par2)
        {
            page1 = par1;
            page2 = par2;
        }
        public double Perimetri(Square Squ1)
        {
            return (page1 + page2) * 2;
        }
    }
}
