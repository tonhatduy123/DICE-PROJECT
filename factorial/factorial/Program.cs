using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <= n; i++)
            {
                f *= i;
            }

            Console.WriteLine("N!= " + f);
        }
    }
}
