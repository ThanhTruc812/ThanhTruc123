using System;

namespace Bài_tập_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap mot so bat ki: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("cac so chan <=n la: {0}", i);

                    }

                }
            }
            else
            {
                Console.WriteLine("moi nhap lai");
            }Console.ReadKey();

        }
    }
}
