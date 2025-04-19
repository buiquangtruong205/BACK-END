namespace LAP1._3;
internal class Program
{

    private static void Main(string[] args)
    {
        QuanLy qlcb = new QuanLy();
        while (true)
        {
            Console.WriteLine("===== QUAN LY CAN BO =====");
            Console.WriteLine("1. Nhap thong tin can bo");
            Console.WriteLine("2. Tim kiem theo ho ten");
            Console.WriteLine("3. Hien thi thong tin can bo");
            Console.WriteLine("4. Thoat");
            Console.Write("Chọn chuc nang: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    qlcb.NhapThongTin();
                    break;
                case 2:
                    Console.Write("Nhap ho ten can tim: ");
                    string hoTen = Console.ReadLine();
                    qlcb.TimKiem(hoTen);
                    break;
                case 3:
                    qlcb.HienThiThongTin();
                    break;
                case 4:
                    Console.WriteLine("Thoat chuong trinh.");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le, vui long thu lai.");
                    break;
            }
        }

    }

}
