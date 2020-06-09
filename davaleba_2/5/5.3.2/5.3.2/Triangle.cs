using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._2
{
    class Triangle
    {
        public float page1;
        public float page2;
        public float page3;
        public float height;
        private float perimetri;
        private float fartobi;

        public Triangle(float par1, float par2, float par3,float height1)
        {
            page1 = par1;
            page2 = par2;
            page3 = par3;
            height = height1;
            perimetri = page1+page2+page3;
            fartobi = (page1*height)/2;
        }
        public void Gamotana()
        {
            Console.WriteLine("Gverdi_1: " + page1 + "\nGverdi_2: " + page2 + "\nGverdi_3: " + page3 +"\nSimagle:"+height+"\nPerimetri: " + perimetri + "\nFartobi: " + fartobi);
        }
    }
}
