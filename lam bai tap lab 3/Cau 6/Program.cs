using System;

namespace Cau_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So KM di duoc la:");
            float km = float.Parse(Console.ReadLine());
            Double Tien = 0;
            
            if (km <= 1)
            {
               Tien = km * 15000;
             
            }
            else if (1 < km && km <= 5)
            {
                Tien = 1 * 15000 + (km - 1) * 13500;
                
            }
            else if (km > 5)
            {
             Tien = 1*15000+4*13500 + ((km - 5)*11000);
            
            }
            if (km > 120)
            {
                Tien = Tien * 0.9f;
             
            }
            Console.WriteLine("So tien ban phai tra la : " + Tien);

            Console.ReadKey();
        }
    }
}
