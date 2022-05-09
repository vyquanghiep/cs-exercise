using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai19
    {
        static void Main(string[] args)
        {
            int h1, m1, s1,h2,m2,s2;
            float time,h, m, s;
            Console.WriteLine("nhap so gio1 : ");
            h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so phut1 : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so giay1 : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            time = 3600 * h1 + 60 * m1 + s1;
            Console.WriteLine("nhap so gio2 : ");
            h2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so phut2 : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so giay2 : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            time -= 3600 * h2 + 60 * m2 + s2;
            h = time / 3600;
            m = (time % 3600)/60;
            s = (time % 3600) % 60;
            Console.WriteLine("{0} gio, {1}phut,{2} giay ");
            Console.Read();


        }
    }
}
