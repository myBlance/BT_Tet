using System;
using System.Text;

class Program
{
    // Hàm kiểm tra số chính phương
    static bool IsPerfectSquare(int number)
    {
        if (number < 1) return false;
        int sqrt = (int)Math.Sqrt(number);
        return sqrt * sqrt == number;
    }

    static void Main()
    {
        // Đảm bảo hiển thị ký tự UTF-8 trong Console
        Console.OutputEncoding = Encoding.UTF8;

        // Nhập vào số nguyên dương n
        Console.Write("Nhập vào một số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        // Tìm tất cả các cặp (a, b) sao cho a, b là số chính phương và a^2 + b^2 là số chính phương
        Console.WriteLine("Các cặp (a, b) sao cho a và b là số chính phương và a^2 + b^2 là số chính phương:");

        bool found = false;  // Cờ kiểm tra có tìm thấy cặp nào không

        for (int a = 1; a < n; a++)
        {
            if (IsPerfectSquare(a)) // Kiểm tra a có phải là số chính phương
            {
                for (int b = 1; b < n; b++)
                {
                    if (IsPerfectSquare(b)) // Kiểm tra b có phải là số chính phương
                    {
                        int sumOfSquares = a * a + b * b;
                        if (IsPerfectSquare(sumOfSquares)) // Kiểm tra a^2 + b^2 có phải là số chính phương
                        {
                            Console.WriteLine($"a = {a}, b = {b}, a^2 + b^2 = {sumOfSquares}");
                            found = true;  // Đánh dấu là đã tìm thấy ít nhất 1 cặp
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Không có cặp (a, b) thỏa mãn điều kiện.");
        }
    }
}
