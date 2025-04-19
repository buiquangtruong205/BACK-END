using LAP1._38;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Bienlai> danhSach = new List<Bienlai>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Nhập danh sách biên lai");
            Console.WriteLine("2. Hiển thị thông tin biên lai");
            Console.WriteLine("3. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    Console.Write("Nhập số lượng hộ sử dụng điện: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nNhập thông tin biên lai hộ thứ {i + 1}:");
                        Bienlai bl = new Bienlai();
                        bl.NhapBienLai();
                        danhSach.Add(bl);
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Danh sách biên lai đã nhập ---");
                    foreach (var bl in danhSach)
                    {
                        bl.HienThiBienLai();
                        Console.WriteLine("--------------------------------");
                    }
                    break;

                case 3:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

        } while (luaChon != 3);
    }
}