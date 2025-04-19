using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._32
{
    internal class SACH: TAILIEU
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập tên tác giả: ");
            TenTacGia = Console.ReadLine();
            Console.WriteLine("Nhập số trang: ");
            SoTrang = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Tên tác giả: " + TenTacGia);
            Console.WriteLine("Số trang: " + SoTrang);
        }

    }
}
