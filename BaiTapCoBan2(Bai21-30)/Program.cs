using System;
using System.Linq;
using System.Text;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n(nnhập từ bàn phím).
            int N341, i341, sum341, count341;
            sum341 = count341 = 0;
            Console.WriteLine("Moi ban nhap vao so nguyen duong N : ");
            N341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac uoc cua so {0} la : ", N341);
            for (i341 = 1; i341 <= N341; i341++)
            {
                if (N341 % i341 == 0)
                {
                    Console.Write(" {0}", i341);
                    count341++;
                    sum341 += i341;
                }
            }
            Console.WriteLine("\n ");
            Console.WriteLine("\nTong Cac uoc cua so {0} la : {1}\n ", N341, sum341);
            Console.WriteLine("So uoc cua so {0} la : {1} ", N341, count341);
            //Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước.
            //Biết số hoàn hảo là số nguyên dương, bằng tổng các ước số thực sự của nó (ví dụ:28 = 14 +7 + 4 + 2 + 1).
            int n, Sum, j;
            Sum = 0;
            Console.WriteLine("Nhap vao so nguyen duong n : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so hoan hao nho hon {0} la : ", n);
            for (i341 = 1; i341 < n ; ++i341)
            {
                for (sum341 = 0, j = 1 ; sum341 <= i341 && j < i341; ++j)
                    if (i341 % j == 0) sum341 += j;
                if (sum341 == i341)
                    Console.WriteLine("{0} ", i341);
            }


        }
    }
}