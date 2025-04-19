using LAP1._313;

internal class Program
{
    private static void Main(string[] args)
    {
        PhanSo A = new PhanSo();
        PhanSo B = new PhanSo();

        Console.WriteLine("Nhập phân số A:");
        A.Nhap();
        Console.WriteLine("Nhập phân số B:");
        B.Nhap();

        int chon;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Hiển thị A và B");
            Console.WriteLine("2. Rút gọn A và B");
            Console.WriteLine("3. Cộng A + B");
            Console.WriteLine("4. Trừ A - B");
            Console.WriteLine("5. Nhân A * B");
            Console.WriteLine("6. Chia A / B");
            Console.WriteLine("7. Thoát");
            Console.Write("Chọn chức năng: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Phân số A: "); A.HienThi();
                    Console.Write("Phân số B: "); B.HienThi();
                    break;
                case 2:
                    A.RutGon(); B.RutGon();
                    Console.WriteLine("Sau khi rút gọn:");
                    Console.Write("A: "); A.HienThi();
                    Console.Write("B: "); B.HienThi();
                    break;
                case 3:
                    Console.Write("Tổng A + B = ");
                    A.Cong(B).HienThi();
                    break;
                case 4:
                    Console.Write("Hiệu A - B = ");
                    A.Tru(B).HienThi();
                    break;
                case 5:
                    Console.Write("Tích A * B = ");
                    A.Nhan(B).HienThi();
                    break;
                case 6:
                    Console.Write("Thương A / B = ");
                    A.Chia(B).HienThi();
                    break;
                case 7:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Chọn sai!");
                    break;
            }
        } while (chon != 7);
    }
}