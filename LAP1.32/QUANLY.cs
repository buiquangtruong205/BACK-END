using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._32
{
    internal class QUANLY
    {
        private List<TAILIEU> danhSachTaiLieu = new List<TAILIEU>();

        public void NhapTaiLieu()
        {
            Console.WriteLine("Chọn loại tài liệu:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Lựa chọn (1-3): ");
            int loai = int.Parse(Console.ReadLine());

            TAILIEU tl = null;
            switch (loai)
            {
                case 1:
                    tl = new SACH();
                    break;
                case 2:
                    tl = new TAPCHI();
                    break;
                case 3:
                    tl = new BAO();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            tl.Nhap();
            danhSachTaiLieu.Add(tl);
            Console.WriteLine("Đã thêm tài liệu.\n");
        }

        public void HienThiTatCaTaiLieu()
        {
            Console.WriteLine("=== DANH SÁCH TÀI LIỆU ===");
            foreach (var tl in danhSachTaiLieu)
            {
                tl.Xuat();
                Console.WriteLine("--------------------------");
            }
        }

        public void TimKiemTheoLoai()
        {
            Console.WriteLine("Chọn loại tài liệu cần tìm:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Lựa chọn (1-3): ");
            int loai = int.Parse(Console.ReadLine());

            Type typeToFind = null;

            switch (loai)
            {
                case 1: typeToFind = typeof(SACH); break;
                case 2: typeToFind = typeof(TAPCHI); break;
                case 3: typeToFind = typeof(BAO); break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            Console.WriteLine($"=== KẾT QUẢ TÌM KIẾM {typeToFind.Name.ToUpper()} ===");
            foreach (var tl in danhSachTaiLieu)
            {
                if (tl.GetType() == typeToFind)
                {
                    tl.Xuat();
                    Console.WriteLine("--------------------------");
                }
            }
        }

        public void Thoat()
        {
            Console.WriteLine("Chương trình kết thúc.");
            Environment.Exit(0);
        }
    }
}
