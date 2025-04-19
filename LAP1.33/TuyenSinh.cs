using System;
using System.Collections.Generic;
using System.Linq;

namespace LAP1._33
{
    internal class TuyenSinh
    {
        private List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

        public void ThemThiSinh(ThiSinh ts)
        {
            danhSachThiSinh.Add(ts);
        }

        public void HienThiTrungTuyen()
        {
            Console.WriteLine("\n== Danh sách thí sinh trúng tuyển ==");

            foreach (var ts in danhSachThiSinh)
            {
                float diemChuan = ts.KhoiThi() switch
                {
                    "A" => 15f,
                    "B" => 16f,
                    "C" => 13.5f,
                    _ => float.MaxValue
                };

                if (ts.TongDiem() >= diemChuan)
                {
                    ts.HienThi();
                }
            }
        }

        public void TimTheoSoBaoDanh(int sbd)
        {
            var ketQua = danhSachThiSinh.FirstOrDefault(ts => ts.Sobaodanh == sbd);
            if (ketQua != null)
            {
                Console.WriteLine("\n== Thí sinh tìm thấy ==");
                ketQua.HienThi();
            }
            else
            {
                Console.WriteLine("Không tìm thấy thí sinh có SBD: " + sbd);
            }
        }
    }
}
