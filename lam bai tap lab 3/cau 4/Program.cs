using System;

namespace cau_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so vao a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so vao b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so vao c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so vao d: ");
            int d = int.Parse(Console.ReadLine());

            int max = a;
            if (max < b)
            {
                max = b;

            }if (max < c)
            {
                max = c;

            }if (max < d)
            {
                max = d;
            }int min = a;
            if (min > b)
            {
                min = b; 
            }if (min > c)
            {
                min = c;
            }if (min > d)
            {
                min = d;
            }
            Console.WriteLine("Max va Min trong 4 so {0},{1},{2},{3} la {4},{5}", a, b, c, d,max,min);
            Console.ReadKey();




        }
    }
}
