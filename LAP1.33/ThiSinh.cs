using System;

namespace LAP1._33
{
    internal abstract class ThiSinh
    {
        public int Sobaodanh { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public float Uutien { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap so bao danh: ");
            Sobaodanh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Diachi = Console.ReadLine();
            Console.Write("Nhap diem uu tien: ");
            Uutien = float.Parse(Console.ReadLine());
        }

        public abstract float TongDiem();
        public abstract string KhoiThi();

        public virtual void HienThi()
        {
            Console.WriteLine($"SBD: {Sobaodanh}, Họ tên: {Hoten}, Địa chỉ: {Diachi}, Ưu tiên: {Uutien}, Tổng điểm: {TongDiem()}, Khối Thi:{KhoiThi}");
        }
    }
}
