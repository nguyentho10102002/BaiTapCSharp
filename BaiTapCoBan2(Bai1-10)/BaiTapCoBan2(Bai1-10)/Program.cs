using System;
using System.Linq;
using System.Text;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14f;
            double V341, S341;
            //Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này.
            Console.WriteLine("Nhap vao dien tich(S) cua mat cau : ");
            S341 = Convert.ToDouble(Console.ReadLine());
            V341 = (4 * pi * Math.Pow(Math.Sqrt(S341 / (4 * pi)), 3)) / 3;
            Console.WriteLine("The tich V mat cau la: {0}", V341);
            //Nhập vào tọa độ 2 điểm A(xA, yA)và B(xB, yB). Tính khoảng cách AB.
            double xA, yA, xB, yB, d;
            Console.WriteLine("Nhap vao hoanh do diem A xA  : ");
            xA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao tung do diem A yA  : ");
            yA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao hoanh do diem B xB  : ");
            xB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao tung do diem B yB  : ");
            yB = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
            Console.WriteLine("Do dai AB la : {0}", d);
            //Viết chương trình giải phương trình bậc 1: ax + b = 0(a, bnhập từ bàn phím).
            //Xét tất cả các trường hợp có thể.
            float a, b, x;
            Console.WriteLine("Moi ban nhap a : ");
            a = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Bien a phai khac 0 !!! ");
                Console.WriteLine("Phuong trinh vo nghiem !!! Moi ban nhap lai !!!");
            }
            else
            {
                Console.WriteLine("Moi ban nhap b : ");
                b = float.Parse(Console.ReadLine());

                x = -b / a;
                Console.WriteLine("Phuong trinh {0}x + {1} = 0 \n=> co nghiem la x = {2} ", a, b, x);
            }
            //Viết chương trình giải phương trình bậc 2: ax2+ bx + c = 0(a, b, cnhập từ bàn phím).
            //Xét tất cả các trường hợp có thể.
            int a341, b341, c341;
            double denta;
            double X1, X2, X;
            Console.WriteLine("Nhap bien a341 cua phuong trinh bac 2 : ");
            a341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap bien b341 cua phuong trinh bac 2 : ");
            b341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap bien c341 cua phuong trinh bac 2 : ");
            c341 = Convert.ToInt32(Console.ReadLine());
            if (a341 == 0)
                if (b341 == 0)
                {
                    Console.WriteLine("Phuong trinh tren vo nghiem !!! ");
                }
                else
                {
                    X = -c341 / b341;
                    Console.WriteLine("Phuong trinh tren co mot nghiem la {0} ", X);
                }
            else
            {
                denta = b341 * b341 - 4 * a341 * c341;
                if (denta > 0)
                {
                    X1 = (-b341 + Math.Sqrt(denta)) / (2 * a341);
                    X2 = (-b341 - Math.Sqrt(denta)) / (2 * a341);
                    Console.WriteLine("Phuong trinh tren co hai nghiem phan biet : X1 = {0} \n X2 = {1} ", X1, X2);
                }
                else if (denta == 0)
                {
                    Console.WriteLine("Phuong trinh tren co hai nghiem kep nghiem");
                    Console.WriteLine("X1 = X2 {0}", -b341 / 2 * a341);
                }
                else if (denta < 0)
                {
                    Console.WriteLine("Phuong trinh tren vo nghiem !!! ");
                }



            }

        }
    }
}
