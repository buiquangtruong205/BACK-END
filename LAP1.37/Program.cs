using LAP1._37;

internal class Program
{
    private static void Main(string[] args)
    {
        List<TheMuon> danhSach = new List<TheMuon>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Nhập danh sách thẻ mượn");
            Console.WriteLine("2. Tìm kiếm theo mã số sinh viên");
            Console.WriteLine("3. Hiển thị sinh viên đến hạn trả sách");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    Console.Write("Nhập số lượng sinh viên mượn sách: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhập thông tin thẻ mượn thứ {i + 1}:");
                        TheMuon tm = new TheMuon();
                        tm.NhapTheMuon();
                        danhSach.Add(tm);
                    }
                    break;

                case 2:
                    Console.Write("Nhập mã số sinh viên cần tìm: ");
                    string masv = Console.ReadLine();
                    var ketQua = danhSach.Where(sv => sv.MaSV.ToLower() == masv.ToLower()).ToList();
                    if (ketQua.Count == 0)
                        Console.WriteLine("Không tìm thấy sinh viên.");
                    else
                    {
                        Console.WriteLine("Thông tin thẻ mượn của sinh viên:");
                        ketQua.ForEach(sv => sv.HienThiTheMuon());
                    }
                    break;

                case 3:
                    Console.Write("Nhập ngày hiện tại (dd/MM/yyyy): ");
                    DateTime today = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    var dsQuaHan = danhSach.Where(sv => sv.HanTra.Date <= today.Date).ToList();
                    if (dsQuaHan.Count == 0)
                        Console.WriteLine("Không có sinh viên nào đến hạn trả.");
                    else
                    {
                        Console.WriteLine("Danh sách sinh viên đến hạn trả sách:");
                        dsQuaHan.ForEach(sv => sv.HienThiTheMuon());
                    }
                    break;

                case 4:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        } while (luaChon != 4);
    }
}