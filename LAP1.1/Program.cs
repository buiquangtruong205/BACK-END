internal class Program
{
    private static void Main(string[] args)
    {
        /*Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
        [tên], bạn [tuổi] tuổi!".*/
        Console.WriteLine("Nhap Ten Cua Ban: ");
        string name = Console.ReadLine();
        Console.WriteLine("Nhap Tuoi Cua Ban: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Ten: " + name + "\nTuoi: " + age);

        /*Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
        chiều rộng*/

        Console.WriteLine("Nhap Chieu Dai: ");
        double dai = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap Chieu Rong: ");
        double rong = double.Parse(Console.ReadLine());
        double dienTich = dai * rong;
        Console.WriteLine("Dien Tich Hinh Chu Nhat: " + dienTich);

        /*Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F và ngược lại khi người dùng
         Công thức: F = (C * 9/5) + 32*/

        Console.WriteLine("Nhap NNhiet do do C: ");
        double doC = double.Parse(Console.ReadLine());
        double doF = (doC * 9 / 5) + 32;
        Console.WriteLine("Nhiet Do Do F: " + doF);

        // Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.

        Console.WriteLine("Nhap So can ktra chan le: ");
        int so = int.Parse(Console.ReadLine());
        if (so % 2 == 0)
        {
            Console.WriteLine("So Chan");
        }
        else
        {
            Console.WriteLine("So Le");
        }

        //Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.

        Console.WriteLine("Nhap So Thu Nhat: ");
        double so1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap So Thu Hai: ");
        double so2 = double.Parse(Console.ReadLine());

        double tong = so1 + so2;
        double tich = so1 * so2;
        Console.WriteLine("Tong cua hai so: " + tong + "\n Tich cua hai so: " + tich);

        //Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.

        Console.WriteLine("Nhap so can ktra: ");
        int a = int.Parse(Console.ReadLine());
        if (a < 0)
        {
            Console.WriteLine("So Am");
        }
        else if (a > 0)
        {
            Console.WriteLine("So Duong");
        }
        else
        {
            Console.WriteLine("So Khong");

        }

        //Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
        Console.WriteLine("Nhap nam: ");
        int nam = int.Parse(Console.ReadLine());
        if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
        {
            Console.WriteLine("Nam Nhuan");
        }
        else
        {
            Console.WriteLine("Nam Khong Nhuan");
        }

        // Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
        Console.WriteLine("Nhap so de lam bang cuu chuong: ");
        int b = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(b + " x " + i + " = " + b * i);
        }

        //Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
        Console.WriteLine("Nhap so can tinh giai thua: ");
        double sotinhgt = double.Parse(Console.ReadLine());
        double giaithua = 1;
        for (int i = 1; i <= sotinhgt; i++)
        {
            giaithua *= i;
        }

        Console.WriteLine("Dap so: " + giaithua);

        //Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
        Console.WriteLine("Nhap so ktra so nguyen to: ");
        int soNguyenTo = int.Parse(Console.ReadLine());
        if (soNguyenTo < 2)
        {
            Console.WriteLine("Khong Phai So Nguyen To");
        }
        else
        {
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(soNguyenTo); i++)
            {
                if (soNguyenTo % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("La So Nguyen To");
            }
            else
            {
                Console.WriteLine("Khong Phai So Nguyen To");
            }
        }
    }
}