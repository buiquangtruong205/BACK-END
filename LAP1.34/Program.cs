using LAP1._34;

internal class Program
{
    private static void Main(string[] args)
    {
        //        Bài 4: Để quản lý các hộ dân trong một khu phố, người ta quản lý các thông tin như sau:
        //-Với mỗi hộ dân, có các thuộc tính:
        //+Số thành viên trong hộ(số người)
        //+Số nhà của hộ dân đó(số nhà được gắn cho mỗi hộ dân)
        //+ Thông tin về mỗi cá nhân trong hộ gia đình.
        //- Với mỗi cá nhân, người ta quản lý các thông tin như: số chứng minh nhân dân, họ và
        //tên, tuổi, năm sinh, nghề nghiệp.
        //1.Hãy xây dựng lớp Nguoi để quản lý thông tin về mỗi cá nhân.
        //2.Xây dựng lớp KhuPho để quản lý thông tin về các hộ gia đình.
        //3.Viết các phương thức nhập, hiển thị thông tin cho mỗi hộ gia đình.
        //4.Cài đặt chương trình thực hiện các công việc sau:
        //        -Nhập vào một dãy gồm n hộ dân(n - nhập từ bàn phím).
        //        - Tìm kiếm thông tin về hộ dân theo họ tên hoặc theo số nhà
        //        - Hiển thị thông tin cho toàn bộ các hộ dân trong khu phố.
        //-Thoát khỏi chương trình.
        KhuPho khuPho = new KhuPho();

        while (true)
        {
            Console.WriteLine("\n======== MENU ========");
            Console.WriteLine("1. Nhập danh sách hộ dân");
            Console.WriteLine("2. Hiển thị toàn bộ hộ dân");
            Console.WriteLine("3. Tìm kiếm theo số nhà");
            Console.WriteLine("4. Tìm kiếm theo họ tên");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    khuPho.NhapDSHoGiaDinh();
                    break;
                case 2:
                    khuPho.HienThiTatCa();
                    break;
                case 3:
                    Console.Write("Nhập số nhà cần tìm: ");
                    string soNha = Console.ReadLine();
                    khuPho.TimTheoSoNha(soNha);
                    break;
                case 4:
                    Console.Write("Nhập tên cần tìm: ");
                    string ten = Console.ReadLine();
                    khuPho.TimTheoHoTen(ten);
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