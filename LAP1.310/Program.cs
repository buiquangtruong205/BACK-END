using LAP1._310;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập số phức A:");
        SoPhuc A = new SoPhuc();
        A.Nhap();

        Console.WriteLine("Nhập số phức B:");
        SoPhuc B = new SoPhuc();
        B.Nhap();

        int luaChon;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Tính tổng A + B");
            Console.WriteLine("2. Tính hiệu A - B");
            Console.WriteLine("3. Tính tích A * B");
            Console.WriteLine("4. Tính thương A / B");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            SoPhuc ketQua;
            try
            {
                switch (luaChon)
                {
                    case 1:
                        ketQua = A.Cong(B);
                        Console.Write("Tổng A + B = ");
                        ketQua.HienThi();
                        break;

                    case 2:
                        ketQua = A.Tru(B);
                        Console.Write("Hiệu A - B = ");
                        ketQua.HienThi();
                        break;

                    case 3:
                        ketQua = A.Nhan(B);
                        Console.Write("Tích A * B = ");
                        ketQua.HienThi();
                        break;

                    case 4:
                        ketQua = A.Chia(B);
                        Console.Write("Thương A / B = ");
                        ketQua.HienThi();
                        break;

                    case 5:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

        } while (luaChon != 5);
    }
}