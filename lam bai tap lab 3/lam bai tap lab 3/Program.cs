using System;

namespace lam_bai_tap_lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3 , b = 2;
            int c;
            if (b == 0)
            {
                Console.WriteLine("error:divide by zero");

            } else
            {
                c = a / b;
                Console.WriteLine("c="+c);
            }
            

        }
    }
}
