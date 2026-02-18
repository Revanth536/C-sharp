using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Palind
    {
        public static void Main(String[] args)
        {
            int p=Convert.ToInt32( Console.ReadLine() );
            int t = p, sum = 0;
            while (p > 0)
            {
                int r = p % 10;
                sum += r;
                p /= 10;
            }
            if (t == sum)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
