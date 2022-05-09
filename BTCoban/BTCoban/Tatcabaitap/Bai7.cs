using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai7
    {
        static void Main(string[] args) {
            int a, b, x;
            Console.WriteLine("nhap he so a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nhap he so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(b != 0)
            {
                x = -b / a;
                Console.WriteLine("x : {0}",x);

            }
            else
            {
                Console.WriteLine("Nhap lai");
            }
            Console.Read();
        }
       
    }
}
