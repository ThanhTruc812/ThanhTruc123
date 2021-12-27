using System;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C;
            Console.WriteLine("nhap so vao A:");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap so vao B:");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap so vao C:");
            C = float.Parse(Console.ReadLine());
            float delta = B * B - 4 * A * C;
            if (delta > 0)
            {
                Console.WriteLine("Phuong Trinh Co 2 Nghiem:");
                Console.WriteLine("X1 = {0}", ((-B + Math.Sqrt(delta)) / (2 * A)));
                Console.WriteLine("X2 = {0}", ((-B - Math.Sqrt(delta)) / (2 * A)));
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong Trinh Co 1 Nghiem:");
                Console.WriteLine("X1=X2{0}", (-B / 2 * A));
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong Trinh Vo Nghiem.");

            }
        }
    }
}
