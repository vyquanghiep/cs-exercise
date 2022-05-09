using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_mang119.DS_baitap
{
    class Bai65_119
    {
        static void Main(string[] args)
        {
            int i, n,tong119=0;
            int[] arr119 = new int[100];
            Console.Write("nhap so phan tu cua mang");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                    Console.WriteLine("phan tu arr199[{0}]: ",i);
                    arr119[i] = Convert.ToInt32(Console.ReadLine());
                if (arr119[i] < 0 && arr119[i] % 2 != 0)
                {
                    tong119 = tong119 + arr119[i];
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr119[i]);
           
            }
         
            Console.WriteLine("tong so nguyen am le:{0} ", tong119);
            Console.ReadKey();
        }
        }
}
