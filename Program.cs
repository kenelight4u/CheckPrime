using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // int add = 0;
            // for (int i = 1; i <= 10; i++)
            // {
            //     add = add + i;
            // }
            // Console.WriteLine(add);

            Console.WriteLine("\nCHECK FOR A PRIME NUMBER \n");
            Console.Write("Enter the Number: ");
            long number = long.Parse(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine("Prime Number");               
            else
                Console.WriteLine("Not a Prime Number");

        }
        public static bool IsPrime(long number) {
            if (number <= 1)
                return false;
            else if (number % 2 == 0)
                return number == 2;

            long N = (long) (Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
