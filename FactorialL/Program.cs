using System;

namespace FactorialL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(9));
        }
        public static long Fact(int number)
        {
            if (number >= 1)
            {
                long result = 1;
                do
                {
                    result = result * number;
                    number--;
                }
                while (number != 1);
                return result;
            }
            return 0;
        }
    }
}
