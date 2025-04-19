using System;

namespace LAP1._33
{
    internal class ThiSinhKhoiA : ThiSinh
    {
        public float Toan { get; set; }
        public float Ly { get; set; }
        public float Hoa { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Toan: ");
            Toan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Ly: ");
            Ly = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            Hoa = float.Parse(Console.ReadLine());
        }

        public override float TongDiem() => Toan + Ly + Hoa + Uutien;
        public override string KhoiThi() => "A";
    }
}
