using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 125;
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(binary);

            var sum = 0;
            var max = 0;
            while (number > 0)
            {
                if (number % 2 == 1)
                {
                    sum++;
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
                else
                {
                    sum = 0;
                }
                number /= 2;
                Console.WriteLine("Number / 2 = " + number);
            }
            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
