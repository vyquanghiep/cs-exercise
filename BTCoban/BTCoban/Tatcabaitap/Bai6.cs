using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai6
    {
        static void Main(string[] args)
        {
            //in tang dan
            int a, b, c, t119;
            Console.WriteLine("nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                t119 = a;
                a = b;
                b = t119;
            }
            if (a < c)
            {
                t119 = a;
                a = c;
                c = t119;

            }
            if (b < c)
            {
                t119 = b;
                b = c;
                c = t119;
            }
            Console.WriteLine("tang dan la: {0} -> {1} -> {2} \n",c,b,a);
            Console.Read();
        }
    }
}
