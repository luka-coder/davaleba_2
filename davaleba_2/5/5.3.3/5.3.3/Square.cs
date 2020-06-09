using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._3
{
    class Square
    {
        public float page1;
        public float page2;
        private float perimetri;
        private float fartobi;

        public Square(float par1,float par2)
        {
            page1 = par1;
            page2 = par2;
            perimetri = (page1 + page2) * 2;
            fartobi = page1 * page2;
        }
        public void Gamotana()
        {
            Console.WriteLine("Page_1:" + page1 + "\nPage_2:" + page2 + "\nPerimetri:" + perimetri + "\nFartobi:" + fartobi);
        }
    }
}
