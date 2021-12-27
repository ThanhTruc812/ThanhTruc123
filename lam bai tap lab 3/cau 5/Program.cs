using System;

namespace cau_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so vao canh A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so vao canh B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so vao canh C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int sum = A + B + C;
            if (sum == 180)
            {
                Console.WriteLine("Day la 3 goc cua tam giac ");

            }
            else
            {
                Console.WriteLine("day khong phai 3 goc cua tam giac");
            }
            Console.ReadKey();
        }
    }
}
