using LAP1._33;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //        Bài 3: Các thí sinh dự thi đại học bao gồm các thí sinh thi khối A, thí sinh thi khối B, thí sinh
        //thi khối C
        //+ Các thí sinh cần quản lý các thuộc tính: Số báo danh, họ tên, địa chỉ, ưu tiên.
        //+Thí sinh thi khối A thi các môn: Toán, lý, hoá
        //+ Thí sinh thi khối B thi các môn: Toán, Hoá, Sinh
        //+ Thí sinh thi khối C thi các môn: Văn, Sử, Địa
        //1.Xây dựng các lớp để quản lý các thí sinh sao cho sử dụng lại được nhiều nhất.
        //2.Xây dựng lớp TuyenSinh cài đặt các phương thức thực hiện các nhiệm vụ sau:
        //-Nhập thông tin về các thí sinh dự thi
        //-Hiển thị thông tin về các thí sinh đã trúng tuyển(Giả sử điểm chuẩn cho khối A: 15,
        //điểm chuẩn khối B: 16, điểm chuẩn khối C: 13,5).
        //-Tìm kiếm các thí sinh theo số báo danh
        //-Kết thúc chương trình.
        TuyenSinh ts = new TuyenSinh();
        while (true)
        {
            Console.WriteLine("\n1. Thêm thí sinh");
            Console.WriteLine("2. Hiển thị thí sinh trúng tuyển");
            Console.WriteLine("3. Tìm theo SBD");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhập khối (A/B/C): ");
                    string khoi = Console.ReadLine().ToUpper();
                    ThiSinh thiSinh = khoi switch
                    {
                        "A" => new ThiSinhKhoiA(),
                        "B" => new ThiSinhKhoiB(),
                        "C" => new ThiSinhKhoiC(),
                        _ => null
                    };
                    if (thiSinh != null)
                    {
                        thiSinh.Nhap();
                        ts.ThemThiSinh(thiSinh);
                    }
                    else Console.WriteLine("Khối không hợp lệ.");
                    break;

                case 2:
                    ts.HienThiTrungTuyen();
                    break;

                case 3:
                    Console.Write("Nhập SBD: ");
                    int sbd = int.Parse(Console.ReadLine());
                    ts.TimTheoSoBaoDanh(sbd);
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}