using LAP1._314;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập số lượng tam giác: ");
        int n = int.Parse(Console.ReadLine());
        TamGiac[] danhSachTG = new TamGiac[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập tam giác thứ {i + 1}:");
            danhSachTG[i] = new TamGiac();
            danhSachTG[i].Nhap();
        }

        Console.WriteLine("\nCác tam giác thỏa mãn định lý Pitago:");
        for (int i = 0; i < n; i++)
        {
            if (danhSachTG[i].ThoaManPitago())
            {
                Console.Write($"Tam giác thứ {i + 1}: ");
                danhSachTG[i].Xuat();
            }
        }
    }
}