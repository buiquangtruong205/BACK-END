using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._311
{
    internal class MaTran
    {
        private int soDong;
        private int soCot;
        private double[,] duLieu;

        // Hàm tạo không đối
        public MaTran()
        {
            soDong = 0;
            soCot = 0;
            duLieu = new double[0, 0];
        }

        // Hàm tạo có đối số
        public MaTran(int n, int m)
        {
            soDong = n;
            soCot = m;
            duLieu = new double[n, m];
        }

        // Nhập ma trận
        public void Nhap()
        {
            Console.Write("Nhập số dòng: ");
            soDong = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            soCot = int.Parse(Console.ReadLine());
            duLieu = new double[soDong, soCot];

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"Nhập phần tử [{i},{j}]: ");
                    duLieu[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        // Hiển thị ma trận
        public void HienThi()
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(duLieu[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Cộng hai ma trận
        public MaTran Cong(MaTran b)
        {
            if (soDong != b.soDong || soCot != b.soCot)
                throw new Exception("Hai ma trận không cùng kích thước!");

            MaTran kq = new MaTran(soDong, soCot);
            for (int i = 0; i < soDong; i++)
                for (int j = 0; j < soCot; j++)
                    kq.duLieu[i, j] = this.duLieu[i, j] + b.duLieu[i, j];

            return kq;
        }

        // Hiệu hai ma trận
        public MaTran Hieu(MaTran b)
        {
            if (soDong != b.soDong || soCot != b.soCot)
                throw new Exception("Hai ma trận không cùng kích thước!");

            MaTran kq = new MaTran(soDong, soCot);
            for (int i = 0; i < soDong; i++)
                for (int j = 0; j < soCot; j++)
                    kq.duLieu[i, j] = this.duLieu[i, j] - b.duLieu[i, j];

            return kq;
        }

        // Nhân hai ma trận
        public MaTran Tich(MaTran b)
        {
            if (this.soCot != b.soDong)
                throw new Exception("Số cột của A phải bằng số dòng của B để nhân!");

            MaTran kq = new MaTran(this.soDong, b.soCot);
            for (int i = 0; i < kq.soDong; i++)
            {
                for (int j = 0; j < kq.soCot; j++)
                {
                    double tong = 0;
                    for (int k = 0; k < this.soCot; k++)
                    {
                        tong += this.duLieu[i, k] * b.duLieu[k, j];
                    }
                    kq.duLieu[i, j] = tong;
                }
            }
            return kq;
        }

        // Thương hai ma trận (chia từng phần tử – không phải chia ma trận kiểu toán học)
        public MaTran Thuong(MaTran b)
        {
            if (soDong != b.soDong || soCot != b.soCot)
                throw new Exception("Hai ma trận không cùng kích thước!");

            MaTran kq = new MaTran(soDong, soCot);
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (b.duLieu[i, j] == 0)
                        throw new DivideByZeroException($"Phần tử [{i},{j}] của ma trận B bằng 0, không thể chia.");

                    kq.duLieu[i, j] = this.duLieu[i, j] / b.duLieu[i, j];
                }
            }
            return kq;
        }
    }
}
