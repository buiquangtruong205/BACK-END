using LAP1._311;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập ma trận A:");
        MaTran A = new MaTran();
        A.Nhap();

        Console.WriteLine("Nhập ma trận B:");
        MaTran B = new MaTran();
        B.Nhap();

        int luaChon;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Tính tổng A + B");
            Console.WriteLine("2. Tính hiệu A - B");
            Console.WriteLine("3. Tính tích A * B");
            Console.WriteLine("4. Tính thương A / B (chia từng phần tử)");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            try
            {
                MaTran ketQua;
                switch (luaChon)
                {
                    case 1:
                        ketQua = A.Cong(B);
                        Console.WriteLine("Kết quả A + B:");
                        ketQua.HienThi();
                        break;
                    case 2:
                        ketQua = A.Hieu(B);
                        Console.WriteLine("Kết quả A - B:");
                        ketQua.HienThi();
                        break;
                    case 3:
                        ketQua = A.Tich(B);
                        Console.WriteLine("Kết quả A * B:");
                        ketQua.HienThi();
                        break;
                    case 4:
                        ketQua = A.Thuong(B);
                        Console.WriteLine("Kết quả A / B:");
                        ketQua.HienThi();
                        break;
                    case 5:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

        } while (luaChon != 5);
    }
}