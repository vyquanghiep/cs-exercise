using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_mang119.DS_baitap
{
    class Bai70_119
    {
        static void Main(string[] args)
        {

            int[] arr1_119 = new int[100];
            int[] arr2_119 = new int[100]; // mang chua cac phan tu chan
            int[] arr3_119 = new int[100];
            int[] arr4_119 = new int[100];// mang chua cac phan tu le
            int i, j = 0, k = 0,z=0, n;


            Console.Write("\nChia mang thanh mang chan, mang le trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1_119[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1_119[i] % 2 == 0&& arr1_119[i] !=0)
                {
                    arr2_119[j] = arr1_119[i];
                    j++;
                }
                if(arr1_119[i]%2 !=0)
                {
                    arr3_119[k] = arr1_119[i];
                    k++;
                }
                if (arr1_119[i] == 0)
                {
                    arr4_119[z] = arr1_119[i];
                    z++;
                }
            }

           
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2_119[i]);
            }
          
            for (i = 0; i < z; i++)
            {
                Console.Write("{0} ", arr4_119[i]);
            }
     
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3_119[i]);
            }
          
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
