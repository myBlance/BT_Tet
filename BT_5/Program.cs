using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập kích thước ma trận A
        Console.Write("Nhập số hàng m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột n: ");
        int n = int.Parse(Console.ReadLine());

        // Khởi tạo ma trận A
        double[,] A = new double[m, n];

        Console.WriteLine("Nhập các phần tử của ma trận A:");

        // Nhập các phần tử của ma trận A
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"A[{i + 1},{j + 1}]: ");
                A[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Tính A * A^T
        double[,] result = MultiplyMatrixWithTranspose(A, m, n);

        // In kết quả
        Console.WriteLine("Kết quả của A * A^T là:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{result[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

    // Hàm nhân ma trận với ma trận chuyển vị
    static double[,] MultiplyMatrixWithTranspose(double[,] A, int m, int n)
    {
        double[,] result = new double[m, m];

        // Tính A * A^T
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    result[i, j] += A[i, k] * A[j, k];
                }
            }
        }

        return result;
    }
}
