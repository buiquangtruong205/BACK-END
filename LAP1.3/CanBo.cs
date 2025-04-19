using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._3
{
    internal class CanBo
    {
        //        Bài 1: Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên.
        //+ Mỗi cán bộ cần quản lý các thuộc tính: Họ tên, năm sinh, giới tính, địa chỉ
        //+ Các công nhân cần quản lý: Bậc(công nhân bậc 3/7, bậc 4/7 ...)
        //+ Các kỹ sư cần quản lý: Ngành đào tạo
        //+ Các nhân viên phục vụ cần quản lý thông tin: công việc
        //1. Xây dựng các lớp NhanVien, CongNhan, KySu kế thừa từ lớp CanBo
        //2. Xây dựng các phương thức nhập, hiển thị thông tin và kiểm tra về các thuộc tính của các
        //lớp.
        //3. Xây dựng lớp QLCB cài đặt các phương thức thực hiện các chức sau:
        //- Nhập thông tin mới cho cán bộ(Hỏi người dùng muốn nhập cho: công nhân, kỹ sư
        //hay nhân viên và nhập đúng thông tin cho đối tượng đó).
        //- Tìm kiếm theo họ tên
        //- Hiển thị thông tin về danh sách các cán bộ
        //- Thoát khỏi chương trình.
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Họ Tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Năm Sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Giới Tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Địa Chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ Tên: {HoTen}, Năm Sinh: {NamSinh}, Giới Tính: {GioiTinh}, Địa Chỉ: {DiaChi}");
        }


    }
}
