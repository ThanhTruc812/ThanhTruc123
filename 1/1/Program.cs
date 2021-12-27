using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập một số vào N:");
            int A = int.Parse(Console.ReadLine());
            long S = 0;
            for (int i = 1; i <= A; i++)
            {
                S = S + i;
            }Console.WriteLine("Tổng 1+2+...+{0} là {1}", A, S);
            Console.ReadKey();
        }
    }
}
