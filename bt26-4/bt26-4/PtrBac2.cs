using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt26_4
{
    public class PtrBac2
    {
        private float a_341;
        private float b_341;
        private float c_341;

        public  PtrBac2()
        {
        }
        public  PtrBac2(float a_341 , float b_341 ,float c_341 )
        {
            a_341 = this.a_341;
            b_341 = this.b_341;
            c_341 = this.c_341;
        }
        public float a1_341
        { get; set; }
        public float b1_341
        { get; set; }
        public float c1_341
        { get; set; }

        public float denTa (float a_341 , float b_341 ,float c_341)
        {
            return  (b_341 * b_341) - 4 * a_341 * c_341;
        }
        public void nghiem(float a_341  , float b_341 , float c_341 )
        {        
                if (denTa(a_341,b_341,c_341) > 0)
                {
                    Console.WriteLine("Phuong trinh co hai nghiem : ");
                    Console.WriteLine("X1 = {0}", ((-b_341 - Math.Sqrt(denTa(a_341,b_341,c_341)) / 2 * a_341)));
                    Console.WriteLine("X2 = {0}", ((-b_341 + Math.Sqrt(denTa(a_341, b_341, c_341)) / 2 * a_341)));

                }
                else if (denTa(a_341,b_341,c_341) == 0)
                {
                    Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                    Console.WriteLine("X1 = X2 {0}", -b_341 / 2 * a_341);
                }
                else if (denTa(a_341,b_341,c_341) < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            
        }
    }
}
