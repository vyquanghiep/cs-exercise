using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_mang119.DS_baitap
{
    class Bai61_119
    {
        static void Main(string[] args)
        {
            int[] arr119 = new int[100];
            int i, n, tong119 = 0, pos;
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            for (i = 0; i < n; i++)
            {
                arr119[i] = rnd.Next(-100, 100);
                Console.WriteLine(arr119[i]);
                if (arr119[i] > 0)
                {
                    tong119 = tong119 + arr119[i];

                }


            }
            Console.Write("Tong so nguyen duong:{0} ", tong119);
            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
            /* xac dinh vi tri cua i trong mang*/
            i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                arr119[i] = arr119[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr119[i]);
            }

            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
