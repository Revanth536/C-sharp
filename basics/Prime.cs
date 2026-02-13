using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Prime
    {
        public static void Main(string[] args)
        {
            // To check wheather a number is Prime or not   
            //int a = Convert.ToInt32(Console.ReadLine());
            //int fc = 0;
            //for (int i = 1; i <= a; i++) {
            //    if (a % i == 0)
            //        fc++;
            //}
            //if (fc == 2)
            //    Console.Write("Prime");
            //else
            //    Console.Write("Not Prime");

            // To check prime number in range
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            
            for (int i = a; i <= b; i++) { 
                int fc = 0;
                for(int j = 1; j <= i; j++ )
                {
                    if(i%j==0)
                        fc++;
                }
                if (fc == 2)
                    Console.Write(i + " ");
            }
        }
    }
}
