using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh26_4.Diemdanh
{
    class Bai1
    {
       

        static void Main(string[] args)
        {
           
            float a, b, c;
            Console.WriteLine("Nhap vao a : ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b : ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao c : ");
            c = float.Parse(Console.ReadLine());
            float delta119 = b * b - 4 * a * c;
            if (delta119 > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta119)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta119)) / 2 * a));

            }
            else if (delta119 == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta119 < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }


            Console.ReadLine();

        }


    }
}
