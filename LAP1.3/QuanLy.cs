using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._3
{
    internal class QuanLy
    {
        private List<CanBo> canBoList = new List<CanBo>();

        public void NhapThongTin()
        {
            Console.WriteLine("Bạn muốn nhập cho: 1. Công Nhân, 2. Kỹ Sư, 3. Nhân Viên");
            int choice = int.Parse(Console.ReadLine());

            CanBo canBo = null;

            switch (choice)
            {
                case 1:
                    canBo = new CongNhan();
                    break;
                case 2:
                    canBo = new KiSu();
                    break;
                case 3:
                    canBo = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            canBo.NhapThongTin();
            canBoList.Add(canBo);
        }

        public void TimKiem(string hoTen)
        {
            var result = canBoList.FindAll(c => c.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase));
            if (result.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var canBo in result)
                {
                    canBo.HienThiThongTin();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy cán bộ nào!");
            }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("Danh sách cán bộ:");
            foreach (var canBo in canBoList)
            {
                canBo.HienThiThongTin();
            }
        }
    }
}
