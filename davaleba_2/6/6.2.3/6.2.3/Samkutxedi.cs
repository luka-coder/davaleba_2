using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3
{
    class Samkutxedi
    {
        double page1, page2, page3, height, perim;
        public Samkutxedi(double par1, double par2, double par3, double height1)
        {
            page1 = par1;
            page2 = par2;
            page3 = par3;
            height = height1;
        }
        public double Dabruneba(out double perim)
        {
            perim = page1 + page2 + page3;
            return (page1 * height) / 2;
        }
    }
}
