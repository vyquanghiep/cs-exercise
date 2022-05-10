using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điemanhngay10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr119 = new int[100];
            int i, j, n =10, max119,min119, tmp;
          
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("phan tu arr199[{0}]: ", i);
                arr119[i] = Convert.ToInt32(Console.ReadLine());

            }
            max119 = arr119[0];
            min119 = arr119[0];
            for (i = 0; i < n; i++)
            {
                if (arr119[i] > max119)
                {
                    max119 = arr119[i];
                }

                if (arr119[i] < min119)
                {
                    min119 = arr119[i];
                }
            }
                for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr119[i]);

            }
            /*sap xep */
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr119[j] < arr119[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr119[i];
                        arr119[i] = arr119[j];
                        arr119[j] = tmp;
                    }
                }
            }
            Console.Write("ma tang dan la");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr119[i]);

            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", max119);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", min119);
            Console.ReadKey();
        }
    }
}
