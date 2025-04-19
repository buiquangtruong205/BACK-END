using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._38
{
    internal class Khachhang
    {
        public string HoTenChuHo { get; set; }
        public string SoNha { get; set; }
        public string MaCongTo { get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhập họ tên chủ hộ: ");
            HoTenChuHo = Console.ReadLine();
            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhập mã số công tơ: ");
            MaCongTo = Console.ReadLine();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên chủ hộ: {HoTenChuHo}, Số nhà: {SoNha}, Mã công tơ: {MaCongTo}");
        }
    }
}
