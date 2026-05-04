using System;

struct HSSV
{
    public string ma;
    public string hoten;
    public double toan;
    public double ly;
    public double hoa;
    public double tbc;
}

class Program
{
    static void Nhap(HSSV[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập HSSV thứ {i + 1}:");

            Console.Write("Mã: ");
            a[i].ma = Console.ReadLine();

            Console.Write("Họ tên: ");
            a[i].hoten = Console.ReadLine();

            Console.Write("Điểm Toán: ");
            a[i].toan = double.Parse(Console.ReadLine());

            Console.Write("Điểm Lý: ");
            a[i].ly = double.Parse(Console.ReadLine());

            Console.Write("Điểm Hoá: ");
            a[i].hoa = double.Parse(Console.ReadLine());

            // Tính TBC
            a[i].tbc = (a[i].toan + a[i].ly + a[i].hoa) / 3;
        }
    }

    static void Xuat(HSSV[] a, int n)
    {
        Console.WriteLine("\nDANH SÁCH HSSV:");
        Console.WriteLine("Mã\tHọ tên\t\tToán\tLý\tHoá\tTBC");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{a[i].ma}\t{a[i].hoten}\t{a[i].toan}\t{a[i].ly}\t{a[i].hoa}\t{a[i].tbc:F2}");
        }
    }

    static void TimMax(HSSV[] a, int n)
    {
        int max = 0;
        for (int i = 1; i < n; i++)
        {
            if (a[i].tbc > a[max].tbc)
                max = i;
        }

        Console.WriteLine("\nHSSV có TBC lớn nhất:");
        Console.WriteLine($"{a[max].ma} - {a[max].hoten} - TBC: {a[max].tbc:F2}");
    }

    static void TimMin(HSSV[] a, int n)
    {
        int min = 0;
        for (int i = 1; i < n; i++)
        {
            if (a[i].tbc < a[min].tbc)
                min = i;
        }

        Console.WriteLine("\nHSSV có TBC nhỏ nhất:");
        Console.WriteLine($"{a[min].ma} - {a[min].hoten} - TBC: {a[min].tbc:F2}");
    }

    static void TBC_Lop(HSSV[] a, int n)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += a[i].tbc;
        }

        Console.WriteLine($"\nTBC cả lớp: {(sum / n):F2}");
    }

    static void LietKeYeu(HSSV[] a, int n)
    {
        Console.WriteLine("\nDanh sách HSSV có TBC < 5:");
        for (int i = 0; i < n; i++)
        {
            if (a[i].tbc < 5)
            {
                Console.WriteLine($"{a[i].ma} - {a[i].hoten} - TBC: {a[i].tbc:F2}");
            }
        }
    }

    static void Main()
    {
        int n;

        do
        {
            Console.Write("Nhập số HSSV (5 < n < 50): ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 5 || n >= 50);

        HSSV[] ds = new HSSV[n];

        Nhap(ds, n);
        Xuat(ds, n);
        TimMax(ds, n);
        TimMin(ds, n);
        TBC_Lop(ds, n);
        LietKeYeu(ds, n);
    }
}