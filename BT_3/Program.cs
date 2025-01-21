using System;
using System.Text;

class Program
{
    // Hàm kiểm tra số Palindrome
    static bool IsPalindrome(int number)
    {
        int original = number;
        int reverse = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        return original == reverse;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập vào số lượng phần tử
        Console.Write("Nhập số lượng phần tử của dãy số: ");
        int n = int.Parse(Console.ReadLine());

        // Khởi tạo mảng chứa các số nguyên
        int[] arr = new int[n];

        // Nhập các phần tử vào dãy
        Console.WriteLine("Nhập các phần tử của dãy số:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"x{i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // In ra các số Palindrome trong dãy
        Console.WriteLine("Các số Palindrome trong dãy là:");
        foreach (int num in arr)
        {
            if (IsPalindrome(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}
