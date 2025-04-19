using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._34
{
    internal class KhuPho
    {
        private List<HoGiaDinh> danhSachHo = new List<HoGiaDinh>();

        public void NhapDSHoGiaDinh()
        {
            Console.Write("Nhập số lượng hộ dân: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin hộ dân thứ {i + 1} ---");
                HoGiaDinh ho = new HoGiaDinh();
                ho.Nhap();
                danhSachHo.Add(ho);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n=== Danh sách toàn bộ hộ dân ===");
            foreach (var ho in danhSachHo)
            {
                ho.HienThi();
            }
        }

        public void TimTheoSoNha(string soNha)
        {
            var ketQua = danhSachHo.Find(ho => ho.SoNha.Equals(soNha, StringComparison.OrdinalIgnoreCase));
            if (ketQua != null)
            {
                Console.WriteLine("\n== Thông tin hộ dân theo số nhà ==");
                ketQua.HienThi();
            }
            else
            {
                Console.WriteLine("Không tìm thấy hộ dân với số nhà: " + soNha);
            }
        }

        public void TimTheoHoTen(string ten)
        {
            Console.WriteLine($"\n== Kết quả tìm kiếm theo tên '{ten}' ==");
            var ketQua = danhSachHo.FindAll(ho => ho.CoNguoiTen(ten));

            if (ketQua.Count > 0)
            {
                foreach (var ho in ketQua)
                {
                    ho.HienThi();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy hộ nào có người tên: " + ten);
            }
        }
    }
}
