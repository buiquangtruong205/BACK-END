using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._32
{
    internal class TAILIEU
    {
        public string MaTaiLieu { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }
        public void Nhap()
        {
            Console.WriteLine("Nhập mã tài liệu: ");
            MaTaiLieu = Console.ReadLine();
            Console.WriteLine("Nhập tên nhà xuất bản: ");
            TenNhaXuatBan = Console.ReadLine();
            Console.WriteLine("Nhập số bản phát hành: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Mã tài liệu: " + MaTaiLieu);
            Console.WriteLine("Tên nhà xuất bản: " + TenNhaXuatBan);
            Console.WriteLine("Số bản phát hành: " + SoBanPhatHanh);
        }
    }
}
