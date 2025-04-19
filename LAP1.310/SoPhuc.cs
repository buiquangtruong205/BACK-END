using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._310
{
    internal class SoPhuc
    {
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }

        // Hàm tạo không đối
        public SoPhuc()
        {
            PhanThuc = 0;
            PhanAo = 0;
        }

        // Hàm tạo có đối số
        public SoPhuc(double a, double b)
        {
            PhanThuc = a;
            PhanAo = b;
        }

        // Nhập số phức từ người dùng
        public void Nhap()
        {
            Console.Write("Nhập phần thực: ");
            PhanThuc = double.Parse(Console.ReadLine());
            Console.Write("Nhập phần ảo: ");
            PhanAo = double.Parse(Console.ReadLine());
        }

        // Hiển thị số phức dạng a + bi hoặc a - bi
        public void HienThi()
        {
            string dau = PhanAo >= 0 ? "+" : "-";
            Console.WriteLine($"{PhanThuc} {dau} {Math.Abs(PhanAo)}i");
        }

        // Cộng hai số phức
        public SoPhuc Cong(SoPhuc b)
        {
            return new SoPhuc(this.PhanThuc + b.PhanThuc, this.PhanAo + b.PhanAo);
        }

        // Trừ hai số phức
        public SoPhuc Tru(SoPhuc b)
        {
            return new SoPhuc(this.PhanThuc - b.PhanThuc, this.PhanAo - b.PhanAo);
        }

        // Nhân hai số phức
        public SoPhuc Nhan(SoPhuc b)
        {
            double thuc = this.PhanThuc * b.PhanThuc - this.PhanAo * b.PhanAo;
            double ao = this.PhanThuc * b.PhanAo + this.PhanAo * b.PhanThuc;
            return new SoPhuc(thuc, ao);
        }

        // Chia hai số phức
        public SoPhuc Chia(SoPhuc b)
        {
            double mau = b.PhanThuc * b.PhanThuc + b.PhanAo * b.PhanAo;
            if (mau == 0)
            {
                throw new DivideByZeroException("Không thể chia cho số phức 0.");
            }
            double thuc = (this.PhanThuc * b.PhanThuc + this.PhanAo * b.PhanAo) / mau;
            double ao = (this.PhanAo * b.PhanThuc - this.PhanThuc * b.PhanAo) / mau;
            return new SoPhuc(thuc, ao);
        }
    }
}
