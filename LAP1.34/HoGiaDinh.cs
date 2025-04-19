using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._34
{
    internal class HoGiaDinh
    {
        public int SoThanhVien { get; set; }
        public string SoNha { get; set; }
        public List<Nguoi> DanhSachNguoi { get; set; } = new List<Nguoi>();

        public void Nhap()
        {
            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhập số thành viên: ");
            SoThanhVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin thành viên thứ {i + 1} ---");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                DanhSachNguoi.Add(nguoi);
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"\nSố nhà: {SoNha}, Số thành viên: {SoThanhVien}");
            foreach (var nguoi in DanhSachNguoi)
            {
                nguoi.HienThi();
            }
        }

        public bool CoNguoiTen(string ten)
        {
            return DanhSachNguoi.Exists(n => n.HoTen.ToLower().Contains(ten.ToLower()));
        }
    }
}
