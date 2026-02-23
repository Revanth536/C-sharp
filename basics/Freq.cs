// Hello World


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Freq
    {
        public static void Main(String[] args)
        {
            String s = Convert.ToString(Console.ReadLine());
            String n = s.Replace(" ", "");
            Dictionary<char, int> m = new Dictionary<char, int>();
            foreach (char c in n.ToCharArray())
            {
                if (m.ContainsKey(c))
                {
                    m[c]++;
                }
                else
                    m.Add(c, 1);

            }
            foreach (KeyValuePair<char, int> pair in m)
            {
                Console.WriteLine($"{pair.Key}{pair.Value}");
            }
        }
    }
}
