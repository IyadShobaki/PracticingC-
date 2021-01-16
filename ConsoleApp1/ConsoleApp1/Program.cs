using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    public enum ShippingMethod
    {
        RegularAirMail,
        RegisteredAirMail,
        Express
    }
    class Program
    {

        public static long Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
        public static long FactorialLoop(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            long value = 1;
            for (int i = number; i > 0; i--)
            {
                value *= i;
            }
            return value;
        }
        static void Main(string[] args)
        {


            int[] numbers = new int[] { 1, 2, 3, 4 };
            int index = Array.IndexOf(numbers, 3);
            Array.Clear(numbers, 0, 2);

            //Array.Fill(numbers, 9);
           
            var anotherArray = new int[2];
            Array.Copy(numbers, anotherArray, 2);

            var cloneArr = (int[]) anotherArray.Clone();

            foreach (var number in cloneArr)
            {
                Console.WriteLine(number);
            }

            
            //var listOfNames = new List<string>();
            //while (true)
            //{
            //    Console.Write("Enter a name (OK to quit): ");
            //    var input = Console.ReadLine();
            //    if (input.ToUpper() == "OK")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        listOfNames.Add(input);

            //    }

            //}
            //if (listOfNames.Count > 2)
            //{
            //    Console.WriteLine($"{listOfNames[0]}, {listOfNames[1]} and {listOfNames.Count - 2} others like your post.");
            //}
            //else if (listOfNames.Count == 2)
            //{
            //    Console.WriteLine($"{listOfNames[0]} and {listOfNames[1]} like your post.");

            //}
            //else
            //{
            //    Console.WriteLine($"{listOfNames[0]} likes your post.");

            //}

            //Console.WriteLine("Enter a series of numbers seperated by a comma:");
            //var input = Console.ReadLine();
            //var numbersString = input.Split(',');
            //int maximumNumber = int.Parse(numbersString[0]);
            //foreach (var number in numbersString)
            //{
            //    int intNumber = int.Parse(number);
            //    if (maximumNumber < intNumber)
            //    {
            //        maximumNumber = intNumber;
            //    }
            //}
            //Console.WriteLine($"Maximum number: {maximumNumber}");

            //var random = new Random();
            //int randomNumber = random.Next(1, 10);
            //Console.WriteLine(randomNumber);

            //int count = 1;
            //while (count < 5)
            //{
            //    Console.WriteLine($"Attempt number {count}");
            //    Console.Write("Guess a number between 1 and 10: ");
            //    var input = Console.ReadLine();
            //    var isNumber = int.TryParse(input, out int number);
            //    if (isNumber)
            //    {
            //        if (number == randomNumber)
            //        {
            //            Console.WriteLine("You won!");
            //            break;
            //        }

            //    }
            //    count++;
            //}
            //if (count == 5)
            //{
            //    Console.WriteLine("You lost");
            //}

            //while (true)
            //{
            //    Console.Write("Enter a number: ");
            //    var input = Console.ReadLine();
            //    var number = int.TryParse(input, out int result);
            //    long factorial = 0;
            //    if (number)
            //    {
            //        factorial = Factorial(result);
            //    }

            //    Console.WriteLine(factorial);
            //}

            //----------------------------------
            //while (true)
            //{

            //    Console.Write("Enter a number: ");
            //    var input = Console.ReadLine();
            //    var isNumber = int.TryParse(input, out int number);
            //    if (isNumber)
            //    {
            //        Console.WriteLine(FactorialLoop(number));
            //    }
            //    if (input.ToUpper() == "OK")
            //    {
            //        break;
            //    }
            //}

            //int sum = 0;
            //while(true)
            //{
            //    Console.Write("Please enter a number: ");

            //    var input = Console.ReadLine();
            //    if (input.ToUpper() == "OK")
            //    {
            //        break;
            //    }
            //    sum += int.Parse(input);

            //}
            //Console.WriteLine($"Sum: {sum}");
            //int count = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //var sentence = "This sentence is really really really a long sentence.";
            //var summary = StringUtilities.SummarizeText(sentence);
            //Console.WriteLine(summary);

            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 2;
            //Console.WriteLine((ShippingMethod) methodId);


            //var methodName = "Express";
            //var newMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            //Console.WriteLine(newMethod);

            //byte number1 = 255;

            //number1 += 2;

            //Console.WriteLine(number1); // result is 1
            //checked
            //{
            //    byte number = 255;
            //    number = number + 1;
            //}
            //byte number;
            //checked
            //{
            //    number = 255;
            //    number += 1; // will throw an exception

            //}
            //Console.WriteLine(number);
            // Vectors
            //int size = Vector<int>.Count;
            //Console.WriteLine(size); // 8 integers, each 32 bits long) ( support 256 in my cpu -- Iyad)


            //Vector128<float> x = Vector128.Create(1.0f,2.0f,3.0f,4.0f); 
            //Vector128<float> y = Vector128.Create(1.0f, 2.0f,4.0f,8.0f);
            //var f = Sse.Add(x, y);
            //Console.WriteLine("f: " + f);


            //// Process.Start(@"c:\windows\notepad.exe");

            //double a = double.NaN;
            //if (double.NaN != (0.0 / 0.0))
            //{
            //    Console.WriteLine("ddd");
            //}
            //else
            //{
            //    Console.WriteLine("Ssss");
            //}

            //Console.WriteLine(0.1 + 0.2);  // 0.30000000000000004
            //if ((0.1 + 0.2) == 0.3)
            //{
            //    Console.WriteLine("ddddd");
            //}
            //else
            //{
            //    Console.WriteLine("dffgg");
            //}
            //Console.WriteLine(double.IsNaN(a));


            Console.ReadLine();

        }
    }
}
