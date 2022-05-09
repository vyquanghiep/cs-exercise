using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh26_4.Diemdanh
{
    class Bai2
    {
        class Animal
        {
           
          
            public virtual void dichuyen119()
            {
                Console.WriteLine("di chuyển");
            }
        }
        class Cat : Animal
        {
           

           
            public override void dichuyen119()
            {
                Console.WriteLine("run");
            }
        }
        class Bird : Animal
        {

           
            public override void dichuyen119()
            {
                Console.WriteLine("fly");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal Cat1 = new Cat();
                Cat1.dichuyen119();

                Animal bird1 = new Bird();
                bird1.dichuyen119();

                Console.ReadLine();

            }
        }
    }
}
