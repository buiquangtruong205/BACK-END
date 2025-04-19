using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._314
{
    internal class TamGiac : DaGiac
    {
        public TamGiac() : base(3) { }

        public override int TinhChuVi()
        {
            return base.TinhChuVi();
        }

        public double TinhDienTich()
        {
            double a = KichThuocCanh[0];
            double b = KichThuocCanh[1];
            double c = KichThuocCanh[2];
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool ThoaManPitago()
        {
            Array.Sort(KichThuocCanh); // sắp xếp để cạnh lớn nhất ở cuối
            int a = KichThuocCanh[0];
            int b = KichThuocCanh[1];
            int c = KichThuocCanh[2];
            return c * c == a * a + b * b;
        }
    }
}
