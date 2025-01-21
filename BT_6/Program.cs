using System;
using System.Text;

class Program
{
    // Kiểm tra xem một số có phải là số nguyên tố hay không
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Hàm kiểm tra giả thuyết Goldbach
    static void CheckGoldbach(int N)
    {
        for (int P = 2; P < N; P++)
        {
            if (IsPrime(P))
            {
                for (int Q = P; Q < N; Q++)
                {
                    if (IsPrime(Q))
                    {
                        for (int R = Q; R < N; R++)
                        {
                            if (IsPrime(R) && P + Q + R == N)
                            {
                                Console.WriteLine($"N = {N} có thể phân tích thành: {P} + {Q} + {R}");
                                return; // Dừng ngay khi tìm thấy 3 số nguyên tố
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine($"Không thể phân tích {N} thành tổng của 3 số nguyên tố.");
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập vào số nguyên dương N (> 5): ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 5)
        {
            Console.WriteLine("N phải lớn hơn 5.");
        }
        else
        {
            CheckGoldbach(N);
        }
    }
}
