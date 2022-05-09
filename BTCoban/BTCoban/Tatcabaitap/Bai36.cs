using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai36
    {
        static void Main(string[] args)
        {
            int n, k, i;
            float count;
            Console.WriteLine("nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            k = 2;
            count = 0;
            Console.WriteLine("{0} so to dau tien: ",n);
            while (count < n)
            { /* vòng lặp kiểm tra k có phải là số nguyên tố */
                for (i = 2; i * i <= k; ++i)
                    if (k % i == 0) break;
                if (i * i > k)
                {
                    Console.WriteLine("{0} ", k);
                    count++;
                }
                k++;
            }
        }
    }
}
