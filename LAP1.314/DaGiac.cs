using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._314
{
    internal class DaGiac
    {
        protected int SoCanh;
        protected int[] KichThuocCanh;

        public DaGiac(int soCanh)
        {
            SoCanh = soCanh;
            KichThuocCanh = new int[SoCanh];
        }

        public virtual void Nhap()
        {
            Console.WriteLine($"Nhập {SoCanh} cạnh:");
            for (int i = 0; i < SoCanh; i++)
            {
                Console.Write($"Cạnh {i + 1}: ");
                KichThuocCanh[i] = int.Parse(Console.ReadLine());
            }
        }

        public virtual void Xuat()
        {
            Console.Write("Các cạnh: ");
            for (int i = 0; i < SoCanh; i++)
            {
                Console.Write(KichThuocCanh[i] + " ");
            }
            Console.WriteLine();
        }

        public virtual int TinhChuVi()
        {
            int chuVi = 0;
            for (int i = 0; i < SoCanh; i++)
            {
                chuVi += KichThuocCanh[i];
            }
            return chuVi;
        }
    }
}
