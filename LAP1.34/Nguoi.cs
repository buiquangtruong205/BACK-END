using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._34
{
    internal class Nguoi
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập Tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập Nghề nghiệp: ");
            NgheNghiep = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"CMND: {CMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
        }
    }
}
