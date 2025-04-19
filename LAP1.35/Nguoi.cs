using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._35
{
    internal class Nguoi
    {
       // Với mỗi cá nhân, người ta cần quản lý các thông tin : Họ và tên, năm sinh, số chứng
        //minh thư nhân dân.
        //1.Hãy xây dựng lớp Nguoi để quản lý thông tin cá nhân về mỗi cá nhân.

        public string hoTen {  get; set; }
        public string namSinh { get; set; }
        public string CMND { get; set; }

        public void Nhap()
        {
            Console.WriteLine($"Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine($"Nhap nam sinh: ");
            namSinh = Console.ReadLine();
            Console.WriteLine($"Nhap CMND: ");
            CMND = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Ho Ten: {hoTen}, Nam sinh: {namSinh}, CMND: {CMND}");
        }
    }
}
