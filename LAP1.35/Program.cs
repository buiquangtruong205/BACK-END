using LAP1._35;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //        Bài 5: Để quản lý khách hàng đến thuê phòng của một khách sạn, người ta cần quản lý những
        //thông tin sau:
        //-Số ngày trọ, loại phòng trọ, giá phòng, và các thông tin cá nhân về mỗi khách trọ.
        //-Với mỗi cá nhân, người ta cần quản lý các thông tin : Họ và tên, năm sinh, số chứng
        //minh thư nhân dân.
        //1.Hãy xây dựng lớp Nguoi để quản lý thông tin cá nhân về mỗi cá nhân.
        //2.Xây dựng lớp KhachSan để quản lý các thông tin về khách thuê phòng.
        //3.Viết các phương thức: nhập, hiển thị các thông tin về mỗi khách thuê phòng.
        //4.Cài đặt chương trình thực hiện các công việc sau:
        //        -Nhập vào một dãy gồm n khách trọ(n - nhập từ bàn phím)
        //        - Hiển thị ra màn hình thông tin về các cá nhân hiện đang trọ ở khách sạn đó.
        //        - Tìm kiếm thông tin về những khách thuê phòng theo họ và tên.
        //-Tính tiền cho khách hàng khi thanh toán trả phòng
        //- Thoát khỏi chương trình.

        QLKS ks = new QLKS();

        while (true)
        {
            Console.WriteLine("\n======== MENU ========");
            Console.WriteLine("1. Nhập danh sách khách thuê phòng");
            Console.WriteLine("2. Hiển thị danh sách khách");
            Console.WriteLine("3. Tìm kiếm theo họ tên");
            Console.WriteLine("4. Tính tiền trả phòng theo CMND");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    ks.NhapDanhSach();
                    break;
                case 2:
                    ks.HienThiTatCa();
                    break;
                case 3:
                    Console.Write("Nhập họ tên cần tìm: ");
                    string ten = Console.ReadLine();
                    ks.TimTheoTen(ten);
                    break;
                case 4:
                    Console.Write("Nhập CMND để tính tiền: ");
                    string cmnd = Console.ReadLine();
                    ks.TinhTienTheoCMND(cmnd);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}