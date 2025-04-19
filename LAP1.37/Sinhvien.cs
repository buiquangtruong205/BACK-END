using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._37
{
    internal class Sinhvien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }
        public string MaSV { get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập lớp: ");
            Lop = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên: ");
            MaSV = Console.ReadLine();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, Mã SV: {MaSV}");
        }
    }
}
