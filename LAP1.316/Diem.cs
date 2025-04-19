using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._316
{
    internal class Diem
    {
        public double x, y;

        public Diem() { }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Nhap()
        {
            Console.Write("Nhập hoành độ x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write($"({x}, {y})");
        }

        public static double TinhKhoangCach(Diem d1, Diem d2)
        {
            return Math.Sqrt(Math.Pow(d1.x - d2.x, 2) + Math.Pow(d1.y - d2.y, 2));
        }
    }
}
