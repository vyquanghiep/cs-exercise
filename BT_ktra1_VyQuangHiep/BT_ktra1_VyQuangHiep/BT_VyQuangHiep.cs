using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ktra1_VyQuangHiep
{
    class BT_VyQuangHiep
    {
        //msv1011505310119
        //pt bai1
        static int TinhTong(int a19, int b19)
        {
            return a19 + b19;
        }
        static int TinhHieu(int a19, int b19)
        {
            return a19 - b19;
        }
        static int TinhTich(int a19, int b19)
        {
            return a19 * b19;
        }
        static float TinhThuong(int a19, int b19)
        {
            return a19 / b19;
        }
        //pt bai 2
        static void veco(int N19, int M19)
        {
            char drawChar = '=';
            char insideChar = '*';


            // Vẽ từ trên xuống
            for (int i = 0; i < N19; i++)
            {
                // Vẽ từ trái sang
                for (int j = 0; j < M19; j++)
                {


                    if (i % (N19 - 1) == 0 || ((i % (N19 - 1) != 0) && (j % (M19 - 1) == 0)))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                }
                //mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();

            }
        }
        //pt Bai 3
        static double Chuyendoi(int n19)
        {
            double dec = 0, i = 0, d;
            while (n19 != 0)
            {
                d = n19 % 10;
                dec = dec + d * Math.Pow(2, i); // su dung ham trong C#
                n19 = n19 / 10;
                i++;
            }
            return dec;
        }
        //pt bai 4
        static void Thongtin(string ten, string lop, string msv)
        {
            Console.WriteLine(ten);
            Console.WriteLine(lop);
            Console.WriteLine(msv);
        }
        static void Main(string[] args)
        {
            //Bai1
            int a19, b19;
            Console.Write("Nhap 2 so duong bat ki: \n");
            Console.Write("Nhap a:\n ");
            a19 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b:\n ");
            b19 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong cua a va b la: "
                + TinhTong(a19, b19));
            Console.WriteLine("Hieu  cua a va b la: "
               + TinhHieu(a19, b19));
            Console.WriteLine("tich cua a va b la: "
               + TinhTich(a19, b19));
            Console.WriteLine("Thuong cua a va b la: "
               + TinhThuong(a19, b19));
            //bai2
            Console.Write("Ve co bai 2 \n ");
            int N19 = 10;
            int M19 = 20;
            veco(N19, M19);

            //Bai3
            int n19, n;
            Console.Write("Nhap so trong he nhi phan: \n ");
            n19 = Convert.ToInt32(Console.ReadLine());
            n = n19;
            Console.Write("\nSo trong he nhi phan: {0}\nSo thap phan tuong duong la: {1}\n\n", n, Chuyendoi(n19));
            //Bai4
            string ten19, lop19, msv19;
            Console.Write("Nhap ten: \n ");
            ten19 = Console.ReadLine();
            Console.Write("Nhap lop: \n ");
            lop19 = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: \n ");
            msv19 = Console.ReadLine();
            Console.Write("Ket qua la: \n ");
            Thongtin(ten19,lop19,msv19);
            Console.Read();

        }
    }
}
