using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai23
    {
        static void Main(string[] args)
        {
            int n, i, j, sum;
            Console.WriteLine("nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so hoan hao nho hon n: ");
            for (i = 1; i < n; ++i)
            {
                for (sum = 0, j = 1; sum <= i && j < i; ++j)
                    if (i % j == 0) sum += j;
                if (sum == i) Console.WriteLine("i :{0} ",i); ;
            }
            Console.Read();
        }
        }
}
