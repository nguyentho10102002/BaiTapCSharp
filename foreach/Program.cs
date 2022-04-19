using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace test_1
{
    class Program
    {
        
         
        enum lop
        {
            T1 = 1, T2, T3
        }

        struct sinhVien
        {
            public string MSV_341;
            public string Hoten_341;
            public lop lop_341;
            public double diemToan_341;
            public double diemLy_341;
            public double diemHoa_341;

        }
        static void nhapDanhSach(ref sinhVien[] sv_341)
        {
            for (int i_341 = 0; i_341 < sv_341.Length; i_341++)
            {
                Console.WriteLine("Nhập thông tin sinh viên {0}:", i_341 + 1);
                Console.WriteLine("Nhập mã sinh viên: ");
                sv_341[i_341].MSV_341 = Console.ReadLine();
                Console.WriteLine("Nhập họ và tên sinh viên: ");
                sv_341[i_341].Hoten_341 = Console.ReadLine();
                Console.WriteLine("Nhập lớp (1,2,3) : ");
                sv_341[i_341].lop_341 = (lop)int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Toán: ");
                sv_341[i_341].diemToan_341 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Lý: ");
                sv_341[i_341].diemLy_341 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Hóa: ");
                sv_341[i_341].diemHoa_341 = double.Parse(Console.ReadLine());
            }
        }

        static void xuatThongTin(sinhVien sv_341)
        {
            Console.WriteLine("Mã sinh viên: " + sv_341.MSV_341);
            Console.WriteLine("Họ và Tên: " + sv_341.Hoten_341);
            Console.WriteLine("Lớp: " + sv_341.lop_341);
            Console.WriteLine("Điểm Toán: " + sv_341.diemToan_341);
            Console.WriteLine("Điểm Lý: " + sv_341.diemLy_341);
            Console.WriteLine("Điểm Hóa: " + sv_341.diemHoa_341);
        }
        static double tinhDTB(sinhVien sv_341)
        {
            return (sv_341.diemToan_341 + sv_341.diemLy_341 + sv_341.diemHoa_341) / 3;
        }

        static void timSinhVien(sinhVien[] sv_341, string ten)
        {
            for (int i = 0; i < sv_341.Length; i++)
            {
                if (string.Equals(ten, sv_341[i].Hoten_341))
                {
                    xuatThongTin(sv_341[i]);
                    Console.WriteLine("Điểm trung bình: " + tinhDTB(sv_341[i]));
                }

            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Bạn cần bao nhiêu sinh viên: ");
            int n_341 = int.Parse(Console.ReadLine());
            sinhVien[] sv_341 = new sinhVien[n_341];
            nhapDanhSach(ref sv_341);
            foreach (sinhVien s_341 in sv_341)
            {
                
                xuatThongTin(s_341);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("\nNhập tên sinh viên cần tìm: ");
            string name_341 = Console.ReadLine();
            timSinhVien(sv_341, name_341);
            Console.ReadKey();
        }
    }
}
