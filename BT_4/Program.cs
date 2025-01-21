using System;
using System.Text;

class Program
{
    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // Hàm tính ước chung lớn nhất (GCD)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập dãy số
        Console.Write("Nhập số lượng phần tử trong dãy số: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int sumEven = 0, sumOdd = 0;

        Console.WriteLine("Nhập các phần tử trong dãy số:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0)  // Số chẵn
                sumEven += arr[i];
            else                  // Số lẻ
                sumOdd += arr[i];
        }

        // Kiểm tra xem tổng các số lẻ và tổng các số chẵn có phải là nguyên tố cùng nhau không
        bool arePrimes = IsPrime(sumEven) && IsPrime(sumOdd);
        bool areCoprime = GCD(sumEven, sumOdd) == 1;

        Console.WriteLine($"Tổng các số chẵn: {sumEven}");
        Console.WriteLine($"Tổng các số lẻ: {sumOdd}");

        if (arePrimes && areCoprime)
        {
            Console.WriteLine("Tổng các số lẻ và tổng các số chẵn đều là nguyên tố và nguyên tố cùng nhau.");
        }
        else if (arePrimes)
        {
            Console.WriteLine("Tổng các số lẻ và tổng các số chẵn đều là nguyên tố nhưng không nguyên tố cùng nhau.");
        }
        else
        {
            Console.WriteLine("Tổng các số lẻ và tổng các số chẵn không đều là nguyên tố.");
        }
    }
}
