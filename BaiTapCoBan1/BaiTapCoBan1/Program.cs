using System;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình màn hình console sẽ cho phép ta nhập vào một số nguyên, in ra màn hình “Đây là số nguyên dương”
            //Nếu số vừa nhập vào là một số lớn hơn hoặc bằng 0, ngược lại in ra “Đây là số nguyên âm”.
            Console.WriteLine("Nhap vao so ban muon kiem tra : ");
            int N341 = Convert.ToInt32(Console.ReadLine()); ;


            if (N341 <= 0)
            {
                Console.WriteLine("Day la so nguyen am !!! ");
            }
            else
            {
                Console.WriteLine("Day la so nguyen duong !!!");
            }

            //Viết chương trình cho phép nhập vào một số nguyên dạng số, sau khi chạy thì chương trình sẽ ghi số đó ra dưới dạng chữ.
            //VD: 1->Một, 2->Hai, …
            Console.WriteLine("Nhap vao mot so ban muon doc : ");
            int n341 = Convert.ToInt32(Console.ReadLine());
            switch (n341)
            {
                case 0: Console.WriteLine("Khong"); break;
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
                default:
                    Console.WriteLine("Hay nhap lai tu 0 -> 9 !!!");
                    break;
            }
            //Viết chương trình cho phép nhập vào 3 số thực
            // Chương trình này sẽ kiểm tra 3 số này có phải là 3 cạnh của một tam giác hay không.
            int a341, b341, c341;
            Console.WriteLine("Nhap canh 1 cua tam giac : ");
            a341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh 2 cua tam giac : ");
            b341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh 3 của tam giac : ");
            c341 = Convert.ToInt32(Console.ReadLine());
            if (a341 + b341 > c341 && b341 + c341 > a341 && a341 + c341 > b341)
            {
                Console.WriteLine("Day la ba canh cua tam giac !!!");
            }
            else
            {
                Console.WriteLine("Day khong phai la ba canh cua tam giac !!!");
            }

            //Viết chương trình cho phép nhập vào 3 số
            //Chương trình sẽ kiểm tra 3 số này có phải là 3 cạnh của một tam giác vuông hay không.
            int x341, y341, z341;
            Console.WriteLine("Nhap canh 1 cua tam giac vuong : ");
            x341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh 2 cua tam giac vuong : ");
            y341 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh 3 cua tam giac vuong : ");
            z341 = Convert.ToInt32(Console.ReadLine());
            if ((x341 * x341 + y341 * y341 == z341 * z341) || (y341 * y341 + z341 * z341 == x341 * x341) || (z341 * z341 + x341 * x341 == y341 * y341))
            {
                Console.WriteLine("Day la ba canh cua tam giac vuong !!!");
            }
            else
            {
                Console.WriteLine("Day khong phai la ba canh cua tam giac vuong !!!");
            }
        }
    }

}
