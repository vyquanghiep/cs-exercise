using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCoban.Tatcabaitap
{
    class Bai39
    {
        static void Main(string[] args)
        {
            int x, y, z;
            for (x = 1; x < 100; ++x)
            {
                for (y = 1; y < 100; ++y)
                {
                    for (z = 1; z < 100; ++z)
                    {
                        if (x * x + y * y == z * z)
                        {
                            if (y - x == 1 && z - y == 1)
                                Console.WriteLine("{0} , {1},{2}: ba so nguyen lien tiep ", x,y,z);
                            if (y % 2 == 0 && y - x == 2 && z - y == 2)
                                Console.WriteLine("{0} , {1},{2}: ba so chan lien tiep ", x, y, z);
                        }
                    }
                }
            }
            Console.Read();
        }
        }
}
