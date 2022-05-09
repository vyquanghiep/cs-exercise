using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BTCoban.Tatcabaitap
{
    class Bai1
    {


        static void Main(string[] args)
        {
            {

                float r119;
                float pi = 3.1415926535f;

                Console.Write("Nhap ban kinh hinh cau: ");
                r119 = Convert.ToSingle(Console.ReadLine());

                Console.Write("\nDien tich hinh cau la: ");
                Console.WriteLine(4 * pi * (r119 * r119));

                Console.Write("\nThe tich hinh cau la: ");
                Console.WriteLine(4 / 3 * pi * (r119 * r119 * r119));

                Console.ReadKey();
            }

        }
    }
}
