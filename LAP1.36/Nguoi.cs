using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._36
{
    internal class Nguoi
    {
        //Các thông tin cá nhân của mỗi cán bộ giáo viên: Họ và tên, năm sinh, quê quán, số
        //chứng minh thư
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string CMND { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = Console.ReadLine();
            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhập CMND: ");
            CMND = Console.ReadLine();
        }
        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, CMND: {CMND}");
        }
    }
}
