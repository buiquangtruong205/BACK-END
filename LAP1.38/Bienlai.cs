using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._38
{
    internal class Bienlai : Khachhang
    {
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }

        public int SoDien
        {
            get { return ChiSoMoi - ChiSoCu; }
        }

        public double TinhTienDien()
        {
            int so = SoDien;
            double tien = 0;

            if (so <= 50)
            {
                tien = so * 1250;
            }
            else if (so <= 100)
            {
                tien = 50 * 1250 + (so - 50) * 1500;
            }
            else
            {
                tien = 50 * 1250 + 50 * 1500 + (so - 100) * 2000;
            }

            return tien;
        }

        public void NhapBienLai()
        {
            base.NhapThongTin();
            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());

            if (ChiSoMoi < ChiSoCu)
            {
                Console.WriteLine("Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                NhapBienLai();
            }
        }

        public void HienThiBienLai()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, Chỉ số mới: {ChiSoMoi}, Số điện: {SoDien}, Số tiền phải trả: {TinhTienDien():N0} VNĐ");
        }
    }
}
