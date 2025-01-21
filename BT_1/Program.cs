using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập giá trị x và độ chính xác epsilon
        Console.Write("Nhập giá trị x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhập độ chính xác epsilon (0 < epsilon < 1): ");
        double epsilon = double.Parse(Console.ReadLine());

        if (epsilon <= 0 || epsilon >= 1)
        {
            Console.WriteLine("Vui lòng nhập epsilon hợp lệ (0 < epsilon < 1).");
            return;
        }

        // Tính e^x
        double term = 1; // Số hạng đầu tiên là 1
        double sum = term; // Tổng bắt đầu với số hạng đầu tiên
        int n = 1; // Chỉ số giai thừa

        while (Math.Abs(term) > epsilon)
        {
            term *= x / n; // Tính số hạng tiếp theo
            sum += term; // Cộng vào tổng
            n++; // Tăng chỉ số giai thừa
        }

        // In kết quả
        Console.WriteLine($"Giá trị gần đúng của e^{x} là: {sum}");
    }
}
