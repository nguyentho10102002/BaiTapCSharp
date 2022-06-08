using System;
using System.Linq;
using System.Text;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần, theo ngày và theo giờ.
            int ngay341, tuan341, gio341, H341;
            Console.WriteLine("Moi ban nhap vao so gio : ");
            H341 = Convert.ToInt32(Console.ReadLine());
            tuan341 = H341 / (24 * 7);
            ngay341 = (H341 % (24 * 7)) / 24;
            gio341 = (H341 % (24 * 7)) % 24;
            Console.WriteLine("So tuan la : Tuan = {0} \n So ngay la : Ngay = {1} \n So gio la : Gio = {2}", tuan341, ngay341, gio341);
            // 19.Nhập vào thời điểm 1 và thời điểm 2. Tìm thời gian trải qua giữa hai thời điểm này tính bằng giờ, phút, giây.
            int gio1, phut1, giay1, gio2, phut2, giay2;
            int time, time1, time2;
            Console.WriteLine("Nhap vao so gio thoi diem 1  : ");
            gio1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so phut thoi diem 1  : ");
            phut1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so giay thoi diem 1  : ");
            giay1 = Convert.ToInt32(Console.ReadLine());
            time1 = 3600 * gio1 + 60 * phut1 + giay1;
            Console.WriteLine("Nhap vao so gio thoi diem 2  : ");
            gio2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so phut thoi diem 2  : ");
            phut2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so giay thoi diem 2  : ");
            giay2 = Convert.ToInt32(Console.ReadLine());
            time2 = 3600 * gio2 + 60 * phut2 + giay2;
            if (time1 > time2)
            {
                Console.WriteLine("Ban da nhap sai !!! Xin moi nhap lai!!! ");
            }
            else
            {
                time = time2 - time1;
                Console.WriteLine("Khoang cach thoi gian giua hai thoi diem la : {0} gio {1} phut {2} giay", time / 3600, (time % 3600) / 60, (time % 3600) % 60);
            }

            //20.Viết chương trình nhập số kW điện đã tiêu thụ. Tính tiền điện phải trả, biết rằng khung giá điện như sau:
            double Kw341, money341;
            Console.WriteLine("Nhap vao Kw tieu thu dien : ");
            Kw341 = Convert.ToDouble(Console.ReadLine());
            money341 = Kw341 * 500;
            if (Kw341 > 100)
            {
                money341 += (Kw341 - 100) * 300;
            }
            if (Kw341 > 250)
            {
                money341 += (Kw341 - 250) * 200;
            }
            if (Kw341 > 350)
            {
                money341 += (Kw341 - 350) * 500;
            }
            Console.WriteLine("So tien phai tra la  : {0} ", money341);
        }
    }
}
