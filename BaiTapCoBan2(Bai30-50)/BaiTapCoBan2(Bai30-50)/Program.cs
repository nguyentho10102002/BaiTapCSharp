using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace test_1
{
    class Program
    {

        //Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím)
        static int kiemtraSNT(int N341)
        {
            if (N341 < 2)
            {
                return 0;
            }
            int i;
            int k = (int)Math.Sqrt(N341);
            for (i = 2; i <= k; i++)
            {
                if (N341 % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        static void Main(String[] args)
        {
            int N341;
            Console.WriteLine("Nhap so nguyen duong N : ");
            N341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} So nguyen to dau tien la : \n", N341);
            int dem = 0;
            int i = 2;
            while (dem < N341)
            {
                if (kiemtraSNT(i) == 1)
                {
                    Console.WriteLine("{0}", i);
                    dem++;
                }
                i++;
            }
            //Với ncho trước, tính tổngS, biết: Nếu nchẵn:S = 2 + 4 + 6 + ... + n
            //Nếu nlẻ:S = 1 + 2 + 3 + ... + n
            int n341, S341;
            Console.WriteLine("Nhap so nguyen duong n : ");
            n341 = Convert.ToInt32(Console.ReadLine());
            S341 = 0;
            for (S341 = 0, i = n341; i > 0; i -= 2)
            {
                S341 += i;
            }
            Console.WriteLine("Tong la : {0} ", S341);
             
        }
    }
}

