using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._32
{
    internal class TAPCHI : TAILIEU
    {
        public string SoPhatHanh { get; set; }
        public string ThangPhatHanh { get; set; }
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số phát hành: ");
            SoPhatHanh = Console.ReadLine();
            Console.WriteLine("Nhập tháng phát hành: ");
            ThangPhatHanh = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số phát hành: " + SoPhatHanh);
            Console.WriteLine("Tháng phát hành: " + ThangPhatHanh);
        }
    }
}
