using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._32
{
    internal class BAO : TAILIEU
    {
        public string NgayPhatHanh { get; set; }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập ngày phát hành: ");
            NgayPhatHanh = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ngày phát hành: " + NgayPhatHanh);
        }   
    }
}
