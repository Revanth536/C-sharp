using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Prime
    {
        public static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int fc = 0;
            for (int i = 1; i <= a; i++) {
                if (a % i == 0)
                    fc++;
            }
            if (fc == 2)
                Console.Write("Prime");
            else
                Console.Write("Not Prime");
        }
    }
}
