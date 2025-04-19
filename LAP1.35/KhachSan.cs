using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._35
{
    internal class KhachSan : Nguoi
    {
        //-Số ngày trọ, loại phòng trọ, giá phòng, và các thông tin cá nhân về mỗi khách trọ.

        public Nguoi ThongTinNguoi { get; set; } = new Nguoi();
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; }
        public float GiaPhong { get; set; }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin cá nhân:");
            ThongTinNguoi.Nhap();
            Console.Write("Nhập số ngày trọ: ");
            SoNgayTro = int.Parse(Console.ReadLine());
            Console.Write("Nhập loại phòng: ");
            LoaiPhong = Console.ReadLine();
            Console.Write("Nhập giá phòng/ngày: ");
            GiaPhong = float.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            ThongTinNguoi.HienThi();
            Console.WriteLine($"Số ngày trọ: {SoNgayTro}, Loại phòng: {LoaiPhong}, Giá phòng/ngày: {GiaPhong}, Tổng tiền: {TinhTien()}");
        }

        public float TinhTien()
        {
            return SoNgayTro * GiaPhong;
        }

    }
}
