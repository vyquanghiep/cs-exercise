using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai20
    {
        static void Main(string[] args)
        {
            int kw;
            float money;
            Console.WriteLine("nhap so kw: ");
            kw = Convert.ToInt32(Console.ReadLine());
            money = kw * 500;
            /* từ kw 100 trở đi, thêm phụ thu (800 - 500) cho mỗi kw tăng thêm */
            if (kw > 100) money += (kw - 100) * 300;
            /* từ kw 250 trở đi, thêm phụ thu (1000 - 800) cho mỗi kw tăng thêm */
            if (kw > 250) money += (kw - 250) * 200;
            /* từ kw 350 trở đi, thêm phụ thu (1500 - 1000) cho mỗi kw tăng thêm */
            if (kw > 350) money += (kw - 350) * 500;

            Console.WriteLine("so tien la: {0} ",money);
            Console.Read();
        }
    }
}
