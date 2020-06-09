using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1
{
    class Samkutxedi
    {
        float page1, page2, page3,height;
        public Samkutxedi(int par1, int par2, int par3, int height1)
        {
            page1 = par1;
            page2 = par2;
            page3 = par3;
            height = height1;
        }
        public double Fartobi(Samkutxedi sam1)
        {
            return (sam1.page1 * sam1.height) / 2;
        }
    }
}
