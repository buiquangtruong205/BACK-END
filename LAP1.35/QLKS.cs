using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._35
{
    internal class QLKS
    {
        private List<KhachSan> danhSachKhach = new List<KhachSan>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số lượng khách trọ: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin khách thứ {i + 1} ---");
                KhachSan khach = new KhachSan();
                khach.Nhap();
                danhSachKhach.Add(khach);
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n=== Danh sách khách đang trọ ===");
            foreach (var khach in danhSachKhach)
            {
                khach.HienThi();
                Console.WriteLine("------------------");
            }
        }

        public void TimTheoTen(string ten)
        {
            Console.WriteLine($"\n== Kết quả tìm kiếm tên '{ten}' ==");
            var ketQua = danhSachKhach.Where(k => k.ThongTinNguoi.hoTen.ToLower().Contains(ten.ToLower())).ToList();

            if (ketQua.Any())
            {
                foreach (var khach in ketQua)
                {
                    khach.HienThi();
                    Console.WriteLine("------------------");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách nào.");
            }
        }

        public void TinhTienTheoCMND(string cmnd)
        {
            var khach = danhSachKhach.FirstOrDefault(k => k.ThongTinNguoi.CMND == cmnd);
            if (khach != null)
            {
                Console.WriteLine("\nThông tin thanh toán:");
                khach.HienThi();
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách có CMND: " + cmnd);
            }
        }

    }
}
