using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._316
{
    internal class HinhTron
    {
        public Diem tam;
        public float banKinh;

        public HinhTron()
        {
            tam = new Diem();
            banKinh = 0;
        }

        public HinhTron(Diem d, float bk)
        {
            tam = d;
            banKinh = bk;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập tọa độ tâm:");
            tam.Nhap();
            Console.Write("Nhập bán kính: ");
            banKinh = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("Tâm: ");
            tam.Xuat();
            Console.WriteLine($", Bán kính: {banKinh}, Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}");
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        public double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }

        public bool GiaoNhau(HinhTron h)
        {
            double d = Diem.TinhKhoangCach(this.tam, h.tam);
            return d <= (this.banKinh + h.banKinh) && d >= Math.Abs(this.banKinh - h.banKinh);
        }
    }
}
