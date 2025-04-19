using System;

namespace LAP1._33
{
    internal class ThiSinhKhoiB : ThiSinh
    {
        public float Toan { get; set; }
        public float Hoa { get; set; }
        public float Sinh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Toan: ");
            Toan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            Hoa = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Sinh: ");
            Sinh = float.Parse(Console.ReadLine());
        }

        public override float TongDiem() => Toan + Hoa + Sinh + Uutien;
        public override string KhoiThi() => "B";
    }
}
