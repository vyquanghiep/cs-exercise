using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai18
    {
        static void Main(string[] args)
        {
            int h;
            float t, n, g;
            Console.WriteLine("nhap so gio: ");
            h =  Convert.ToInt32(Console.ReadLine());
            t = h / 24 / 7;
            n = (h % (24 * 7)) / 24;
            g = (h % (24 * 7)) % 24 ;
            Console.WriteLine("{0} tuan, {1}ngay , {2} gio",t,n,g);
            Console.Read();
        }
    }
}
