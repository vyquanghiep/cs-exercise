using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_mang119.DS_baitap
{
    class Bai64_119
    {
        static void Main(string[] args)
        {
            int[] arr119 = new int[100];
            int i,j, n, so119;
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("phan tu arr199[{0}]: ", i);
                arr119[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            Console.Write("Nhap gia tri can xoa: ");
            so119 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
              
                if(arr119[i] == so119)
                {
                    for (j = i; j < n - 1; j++)
                    {

                        arr119[j] = arr119[j + 1];

                    }
                    n--;


                    i--;
                }

            }
            Console.Write("mang sau khi xoa: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr119[i]);

            }
            Console.ReadKey();
        }
    }
}