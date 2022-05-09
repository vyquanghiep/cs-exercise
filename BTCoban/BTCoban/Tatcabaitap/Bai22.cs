using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai22
    {
        static void Main(string[] args)
        {
            float count, sum;
            int n, i;
            Console.WriteLine("nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac uoc so: ");
            for (count = sum = 0, i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("{0} ", i);
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine("Co {0} uoc, {1} Tong la: ",count,sum);
            Console.Read();
        }
    }
}
