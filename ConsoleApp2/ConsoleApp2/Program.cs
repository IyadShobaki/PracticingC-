using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements;

            while (true)
            {
                Console.Write("Enter a list of 5 or more numbers seperated by a comma: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                    {
                        bool[] isNumbers = Array.ConvertAll(elements, e => int.TryParse(e, out _));
                        if (!isNumbers.Contains(false))
                        {
                            break;
                        }
                    }
                    

                }
                Console.WriteLine("Invalid list");

            }
            Console.WriteLine(String.Join('-',elements));

            //string[] elements;

            //while (true)
            //{
            //    bool flag = false;
            //    Console.Write("Enter a list of at least 5 comma seperated number: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        elements = input.Split(',');
            //        if (elements.Length >= 5)
            //        {
            //            foreach (var ele in elements)
            //            {
            //                if (!int.TryParse(ele, out _))
            //                {
            //                    flag = true;
            //                    break;
            //                }
            //            }
            //            if (!flag)
            //            {
            //                break;
            //            }
            //        }

            //    }

            //    Console.WriteLine("Invalid list. Try again!");
            //}
            //Console.WriteLine(String.Join(' ', elements));

            //var distinctList = elements.Distinct().ToList();
            //Console.WriteLine("Smallest 3 numbers in the list are:");
            //distinctList.Sort();

            //Console.WriteLine(String.Join(' ', distinctList.Take(3)));




            //var numbers = new List<int>();
            //bool check;

            //do
            //{
            //    Console.Write("Enter a number or 'Quit' to exist: ");
            //    var input = Console.ReadLine();
            //    check = int.TryParse(input, out int number);
            //    if (check == false && input.ToLower() == "quit")
            //    {
            //        Console.WriteLine("Unique numbers inserted:");
            //        var uniques = numbers.Distinct().ToList();
            //        Console.WriteLine(String.Join(' ', uniques));
            //        break;
            //    }
            //    if (check == false)
            //    {
            //        Console.WriteLine("Invalid input. Please try again!");
            //    }
            //    else
            //    {
            //        numbers.Add(number);
            //    }

            //} while (true);
            //int[] array1 = new []{ 1, 2, 3, 4, 5 };
            //int[] array2 = new int[array1.Length];

            //for (int i = array1.Length; i > 0; i--)
            //{
            //    array2[array1.Length - i] = array1[i - 1];
            //}

            //Console.WriteLine($"[{String.Join(',', array2)}]");

            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.Write("Enter a number (or 'Quit' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "quit")
            //        break;

            //    numbers.Add(Convert.ToInt32(input));
            //}

            //var uniques = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //}

            //Console.WriteLine("Unique numbers:");
            //foreach (var number in uniques)
            //    Console.WriteLine(number);


            //var numberList = new List<int>();
            //int number;
            //bool check;
            //do
            //{
            //    Console.Write("Enter a number: ");
            //    var input = Console.ReadLine();
            //    check = int.TryParse(input, out number);
            //    if (check == false && input.ToLower() == "quit")
            //    {
            //        Console.WriteLine("All unique numbers you inserted:");
            //        // using LINQ
            //        var distinctList = numberList.Distinct().ToList();
            //        foreach (var element in distinctList)
            //        {
            //            Console.WriteLine(element);
            //        }
            //        break;
            //    }
            //    if (check == false)
            //    {
            //        Console.WriteLine("To exit type quit or enter more numbers");
            //    }
            //    else
            //    {
            //        numberList.Add(number);
            //    }

            //} while (true);

            //char[] numbers = new char[]{ 'a', 'b', 'c' };
            //Console.WriteLine(String.Join(' ',numbers));


            //var numbers = new int[5];
            //int count = 0;
            //while (count < 5)
            //{
            //    Console.Write($"Enter {count + 1} number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    if (Array.IndexOf(numbers, number) != -1)
            //    {
            //        Console.WriteLine("This number has been entered before." +
            //            "\nPlease enter different number");
            //        continue;
            //    }
            //    numbers[count] = number;
            //    count++;

            //}

            //Array.Sort(numbers);
            //Console.WriteLine(String.Join(",", numbers));


            //Console.Write("Enter your name: ");
            //string input = Console.ReadLine();
            //char[] inputArr = input.ToCharArray();
            //Array.Reverse(inputArr);

            //Console.WriteLine(new string(inputArr));

            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int index = numbers.IndexOf(1, 1, 5);
            //Console.WriteLine("Index of 1: " + index);

            //numbers.RemoveAll(item => item == 1);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            Console.ReadLine();
        }
    }
}
