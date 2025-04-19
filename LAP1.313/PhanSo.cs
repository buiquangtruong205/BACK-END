using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._313
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Constructor không đối số
        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        // Constructor có đối số
        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau == 0 ? 1 : mau; // tránh chia cho 0
        }

        // Nhập phân số
        public void Nhap()
        {
            Console.Write("Tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0. Đặt mẫu số = 1.");
                MauSo = 1;
            }
        }

        // Hiển thị phân số
        public void HienThi()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        // Rút gọn phân số
        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
            // Đảm bảo mẫu dương
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }

        // Cộng phân số
        public PhanSo Cong(PhanSo p)
        {
            int tu = this.TuSo * p.MauSo + p.TuSo * this.MauSo;
            int mau = this.MauSo * p.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        // Trừ phân số
        public PhanSo Tru(PhanSo p)
        {
            int tu = this.TuSo * p.MauSo - p.TuSo * this.MauSo;
            int mau = this.MauSo * p.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        // Nhân phân số
        public PhanSo Nhan(PhanSo p)
        {
            int tu = this.TuSo * p.TuSo;
            int mau = this.MauSo * p.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        // Chia phân số
        public PhanSo Chia(PhanSo p)
        {
            if (p.TuSo == 0)
            {
                Console.WriteLine("Không thể chia cho phân số có tử bằng 0!");
                return new PhanSo(0, 1);
            }
            int tu = this.TuSo * p.MauSo;
            int mau = this.MauSo * p.TuSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }
    }
}
