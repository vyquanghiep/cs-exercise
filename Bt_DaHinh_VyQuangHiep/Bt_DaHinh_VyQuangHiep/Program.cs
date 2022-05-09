using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_DaHinh_VyQuangHiep
{
    class Dagiac
    {
       
        public virtual void In119()
        {
            Console.WriteLine("Đa giác có: 4 cạnh");
        }
    }
    class Tamgiac:Dagiac
    {
        
       
        public override void In119()
        {
            Console.WriteLine("Tam giác có: 3 cạnh");
        }
    }
    class Hinhvuong : Dagiac
    {

      
        public override void In119()
        {
            Console.WriteLine("Hình vuông có 2 cặp cạnh song song và 1 góc vuông");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dagiac tamgiac1 = new Tamgiac();
            tamgiac1.In119();

            Dagiac hinhvuong1 = new Hinhvuong();
            hinhvuong1.In119();
        }
    }
}
