using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 4;
            int n = 5;
            int good = 0;
            int bad = 0;    
            int s = 0;

            int sum = 0;

            for (s = 1; s <= n; s = s + 1)
            {

                Console.WriteLine($"Student {s}");
                bool L = true;
                sum = 0;
                for (int i = 1; i <= count; i = i + 1)
                {
                    int o = int.Parse(Console.ReadLine());
                    if (o <= 3 || o > 5)
                    {
                        L = false;
                        break;
                    }
                    sum = sum + o;
                }

                Console.WriteLine($"sum {sum}");
                if (L == true)
                {
                    good = good + 1;
                }
                else
                {
                    bad = bad + 1;
                }
            }
            Console.WriteLine($"bad {bad}");
            Console.WriteLine($"good students {good}");
            Console.ReadLine();
        }       
                 


    }
}
