using System;

namespace LAP1._36
{
    internal class CBGV : Nguoi
    {
        public float LuongCuong { get; set; }
        public float Thuong { get; set; }
        public float Phat { get; set; }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin cá nhân:");
            base.Nhap();
            Console.Write("Nhập lương cứng: ");
            LuongCuong = float.Parse(Console.ReadLine());
            Console.Write("Nhập thưởng: ");
            Thuong = float.Parse(Console.ReadLine());
            Console.Write("Nhập phạt: ");
            Phat = float.Parse(Console.ReadLine());
        }

        public float LuongThucLinh()
        {
            return LuongCuong + Thuong - Phat;
        }

        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lương cứng: {LuongCuong}, Thưởng: {Thuong}, Phạt: {Phat}, Lương thực lĩnh: {LuongThucLinh()}");
        }
    }
}
