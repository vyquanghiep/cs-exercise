using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_mang119.DS_baitap
{
    class Bai63_119
    {
        static void Main(string[] args)
        {
            int[] arr119 = new int[100];
            int i, n, dem119 = 0;
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            for (i=0;i<n ; i++)
            {
                arr119[i] = rnd.Next(-100, 100);
                Console.WriteLine(arr119[i]);
                if(arr119[i]%4==0 && Math.Abs(arr119[i]) % 10 == 6)
                {
                    dem119 = dem119 + 1;
                }

            }
          

            Console.Write("co {0} phan tu chia het cho 4 và tan cung la 6: \n", dem119);
            Console.Write("Nhan doi phan tu le: \n ");
            for (i = 0; i < n; i++)
            {
                if (arr119[i] % 2 == 0)
                {
                    arr119[i] = arr119[i] * 2;
                }
                Console.WriteLine(arr119[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
