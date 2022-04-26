using bt26_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program

{
    class Program
    {
        static void main (string[] args)
        {
            PtrBac2 pt_341 = new PtrBac2();
            Console.WriteLine("Nhap a_341 = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b_341 = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c = ");
            float c = float.Parse(Console.ReadLine());
            pt_341.nghiem(a, b, c);
            Console.ReadKey();

        }
    }
}
