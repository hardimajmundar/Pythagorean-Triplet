using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application9
{
    public class MainFuncation
    {
        public int Pythagoreanfun()
        {
            int Pythagoreansum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                int iq = i * i;

                for (int j = 1; j <= 1000; j++)
                {
                    int jq = j * j;

                    if (i + j > 1000) break;

                    for (int k = 1; k <= (1000 - j - i); k++)
                    {
                        int kq = k * k;
                        int ijkPlus = i + j + k;

                        if (iq + jq == kq && ijkPlus == 1000)
                        {
                            Pythagoreansum = i * j * k;
                            Console.WriteLine("Pythagorean sum= " + Pythagoreansum);
                            break;
                        }
                    }
                }
            }
            return Pythagoreansum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainFuncation fun = new MainFuncation();
            fun.Pythagoreanfun();
            Console.ReadKey();
        }
    }
}
