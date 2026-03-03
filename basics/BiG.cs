using System;
using System.Numerics; 

public class Program
{
    public static void Main()
    {
        BigInteger b1 = BigInteger.Parse(Console.ReadLine());                
        BigInteger b2 = BigInteger.Parse(Console.ReadLine());


        BigInteger sum = b1 + b2;
        BigInteger product = b1 * b2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
