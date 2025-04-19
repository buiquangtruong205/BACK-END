using LAP1._315;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập số lượng tam giác: ");
        int n = int.Parse(Console.ReadLine());
        TamGiac[] danhSachTG = new TamGiac[n];

        double tongChuVi = 0, tongDienTich = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập tam giác thứ {i + 1}:");
            danhSachTG[i] = new TamGiac();
            danhSachTG[i].Nhap();
            tongChuVi += danhSachTG[i].TinhChuVi();
            tongDienTich += danhSachTG[i].TinhDienTich();
        }

        Console.WriteLine($"\nTổng chu vi các tam giác: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các tam giác: {tongDienTich:F2}");
    }
}