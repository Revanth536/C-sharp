namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 1)
                Console.WriteLine("Weird");
            else if (n < 2 && n >= 5)
                Console.WriteLine("Not Weird");
            else if (n >= 6 && n <= 20)
                Console.WriteLine("Weird");
            else if (n > 20)
                Console.WriteLine("Not Weird");
        }
    }
}
