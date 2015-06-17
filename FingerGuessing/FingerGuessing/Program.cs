using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("幾個人猜拳");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}人猜,剪刀=1、石頭=2、布=3" + "\n", a);
            int j = 0, k = 0, l = 0, t = 0;
            string p = "";

            Random random = new Random();
            while (a > 1)
            {
                p = "";
                j = 0;
                k = 0;
                l = 0;

                while (a > 0)
                {
                    int b = random.Next(1, 4);
                    if (b == 1)
                    {
                        j++;
                    }
                    else if (b == 2)
                    {
                        k++;
                    }
                    else
                    {
                        l++;
                    }

                    p = p + b;

                    a--;
                }
                t++;
                if (j != 0 && k != 0 && l != 0)
                {
                    a = j + k + l;
                    p = p + "皆異和局";
                }
                else if (j != 0 && k == 0 && l == 0 || j == 0 && k != 0 && l == 0 || j == 0 && k == 0 && l != 0)
                {
                    a = j + k + l;
                    p = p + "皆同和局";
                }
                else if (j != 0 && k != 0 && l == 0)
                {
                    a = Pe(k);
                    p = p + "石頭贏有";
                }
                else if (j != 0 && k == 0 && l != 0)
                {
                    a = Pe(j);
                    p = p + "剪刀贏有";
                }
                else
                {
                    a = Pe(l);
                    p = p + "布贏有";
                }
                Console.WriteLine("第" + t + "局:" + p + a + "人再玩" + "\r\n");
            }
        }

        public static int Pe(int sum)
        {
            int w = 0;
            if (sum > 1)
            {
                w = sum;
            }
            else
            {
                w = 1;
            }
            return w;
        }
    }
}