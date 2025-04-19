using System;

namespace LAP1._33
{
    internal class ThiSinhKhoiC : ThiSinh
    {
        public float Van { get; set; }
        public float Su { get; set; }
        public float Dia { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Van: ");
            Van = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Su: ");
            Su = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Dia: ");
            Dia = float.Parse(Console.ReadLine());
        }

        public override float TongDiem() => Van + Su + Dia + Uutien;
        public override string KhoiThi() => "C";
    }
}
