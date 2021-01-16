using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4 };
            Array.IndexOf(arr, 1);
            Array.Sort(arr);

            var l = new List<int> { 1, 2, 3, 4 };
            l.Contains(2);
            l.Sort();

            //Console.Write("Enter a comma seperated numbers: ");
            //var input = Console.ReadLine();

            //var numbers = input.Split(',');
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //}
            //Console.WriteLine("Max number is: " + max);


            //var number = new Random().Next(1, 10);
            //Console.WriteLine("Secret number " + number);

            //bool check;
            //int guess;
            //int count = 0;
            //while (count < 4)
            //{
            //    Console.Write($"You have {4 - (count)} attempts to guess the secret number.\n({count + 1} attempt): ");
            //    var input = Console.ReadLine();
            //    check = int.TryParse(input, out guess);
            //    if (check == false)
            //    {
            //        Console.WriteLine("Please enter a number. Try again");
            //        continue;
            //    }
            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    count++;
            //}
            //if (count == 4)
            //{
            //    Console.WriteLine("You lose!");
            //}



            //var number = new Random().Next(1, 10);

            //Console.WriteLine(number);

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Guess the secret number: ");
            //    var guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        Console.ReadLine();
            //        return;
            //    }
            //}
            //Console.WriteLine("You lost!");

            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());

            //long factorial = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine($"{number}! = {factorial}");

            //int count = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
