using LAP1._36;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //        Bài 7: Khoa Công nghệ thông tin - Trường Đại Học Đại Nam cần quản lý việc thanh toán
        //tiền lương cho các cán bộ giáo viên trong khoa. Để quản lý được, thì nhà quản lý cần có những
        //thông tin như sau:
        //-Với mỗi cán bộ giáo viên, có các thông tin chung như sau: lương cứng, thưởng, phạt,
        //lương thực lĩnh
        //và các thông tin cá nhân của mỗi cán bộ giáo viên
        //-Các thông tin cá nhân của mỗi cán bộ giáo viên: Họ và tên, năm sinh, quê quán, số
        //chứng minh thư
        //nhân dân.
        //1.Hãy xây dựng lớp Nguoi để quản lý các thông tin cá nhân về mỗi cán bộ giáo viên
        //2.Xây dựng lớp CBGV(cán bộ giáo viên) để quản lý các thông tin chung về mỗi cán bộ giáo
        //viên
        //3.Xây dựng các phương thức: nhập, hiển thị các thông tin cá nhân của mỗi cán bộ giáo viên
        //4.Tính lương thực lĩnh cho mỗi cán bộ nếu công thức tính lương được tính như sau:
        //Lương thực lĩnh = Lương cứng + thưởng - phạt
        //5.Nhập vào một danh sách các cán bộ giáo viên, thực hiện các công việc sau:
        //-Tìm kiếm thông tin về cán bộ giáo viên theo quê quán;
        //        -Hiển thị thông tin về các cán bộ giáo viên có lương thực lĩnh trên 5 triệu đồng một
        //tháng.
        //- Thoát khỏi chương trình
        List<CBGV> danhSachCBGV = new List<CBGV>();

        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Nhập danh sách cán bộ giáo viên");
            Console.WriteLine("2. Hiển thị toàn bộ thông tin cán bộ giáo viên");
            Console.WriteLine("3. Tìm kiếm theo quê quán");
            Console.WriteLine("4. Hiển thị GV có lương thực lĩnh > 5 triệu");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhập số lượng cán bộ giáo viên: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhập cán bộ thứ {i + 1}");
                        CBGV gv = new CBGV();
                        gv.Nhap();
                        danhSachCBGV.Add(gv);
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Thông tin cán bộ giáo viên ---");
                    foreach (var gv in danhSachCBGV)
                    {
                        gv.HienThi();
                        Console.WriteLine("------------------------");
                    }
                    break;

                case 3:
                    Console.Write("Nhập quê quán cần tìm: ");
                    string qq = Console.ReadLine();
                    var ketQua = danhSachCBGV.Where(gv => gv.QueQuan.ToLower().Contains(qq.ToLower())).ToList();
                    if (ketQua.Count > 0)
                    {
                        Console.WriteLine("== Kết quả tìm thấy ==");
                        foreach (var gv in ketQua)
                        {
                            gv.HienThi();
                            Console.WriteLine("------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy cán bộ nào.");
                    }
                    break;

                case 4:
                    Console.WriteLine("== Danh sách GV có lương > 5 triệu ==");
                    foreach (var gv in danhSachCBGV)
                    {
                        if (gv.LuongThucLinh() > 5000000)
                        {
                            gv.HienThi();
                            Console.WriteLine("------------------------");
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Chương trình kết thúc.");
                    return;

                default:
                    Console.WriteLine("Chức năng không hợp lệ.");
                    break;
            }
        }
    }

}