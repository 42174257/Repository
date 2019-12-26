using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0, i = 0, k = 0;//i:公鸡 j:母鸡 k:小鸡
            for (j = 0; j <= 100; j++)
            {
                for (i = 0; i <= 100; i++)
                {
                    for (k = 0; k <= 100; k++)
                    {
                        if (((j + i + k) == 100) && ((j * 3 + i * 5 + k / 3) == 100) && (k % 3 == 0))
                        {
                            Console.WriteLine("母鸡:{0}公鸡:{1}小鸡:{2}", j, i, k);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
