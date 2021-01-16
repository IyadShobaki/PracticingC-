//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp4
//{
//    class Program
//    {
//        public void amIOld(int age)
//        {
//            Console.WriteLine(
//                (age >= 18) ? "You are old." : ((age >= 13) ? "You are a teenager.": "You are young.")
//            );
//        }
//        public static string SummarizeText(string text)
//        {
//            const int maxLength = 20;

//            if (text.Length < maxLength)
//                return text;

//            var indexOfLastWhiteSpace = text.LastIndexOf(' ', maxLength);
//            var summary = text.Substring(0, indexOfLastWhiteSpace);
//            return summary + "...";
//        }
//        static void Main(string[] args)
//        {


//            //Console.Write("Enter number of words: ");
//            //var numberOfWords = int.Parse(Console.ReadLine());

//            //for (var i = 0; i < numberOfWords; i++)
//            //{
//            //    Console.Write($"Enter {i+1} word: ");
//            //    var str = Console.ReadLine();

//            //    for (var j = 0; j < str.Length; j++)
//            //    {
//            //        if (j % 2 == 0) Console.Write(str[j]);
//            //    }

//            //    Console.Write(" ");

//            //    for (var j = 0; j < str.Length; j++)
//            //    {
//            //        if (j % 2 != 0) Console.Write(str[j]);
//            //    }

//            //    Console.Write(Environment.NewLine);
//            //}

//            //var numbers = new List<int>() { 9, 2, 2, 3, 4, 5, 6, 7 };

//            //numbers.Sort();
//            ////var distinctNumbers = numbers.Distinct().ToList();

//            //Console.WriteLine(String.Join(',', numbers));

//            //var names = new string[] { "Dave", "Adam", "Bill" };

//            //var query = from name in names
//            //            orderby name ascending
//            //            select name;



//            //var sentence = "This is going to be a rally rally rally rally long text.";
//            //Console.WriteLine(SummarizeText(sentence));

//            //Console.WriteLine(indexOfWhiteSpace);


//            //var now = DateTime.Now;

//            //Console.WriteLine(now.ToString("MMMM dd, yyyy"));

//            //var number = 255;

//            //Console.WriteLine(number.ToString("C2"));
//            //Console.WriteLine(number.ToString("E"));
//            //Console.WriteLine(number.ToString("f1"));
//            //Console.WriteLine(number.ToString("X")); // Hexadecimal




//            //var numbers = new[] { 3, 4, 5, 6, 7, 8, 9 };
//            //var t = Array.BinarySearch(numbers, 7);
//            //Console.WriteLine(t);

//            //var d = Array.Exists(numbers, n => n == 0);
//            //Console.WriteLine(d);
//            //var f = Array.Find(numbers, n => n == 11); // 0
//            //Console.WriteLine(f);

//            //var words = new[] { "Sue", "Sto", "Bil", "Tim" };
//            //var a = Array.FindAll(words, n => n.StartsWith("s", StringComparison.OrdinalIgnoreCase));
//            //Console.WriteLine(String.Join(',', a));

//            //Array.Fill(numbers, 11);
//            //Console.WriteLine(String.Join('-',numbers));

//            //Array.ForEach(a, n => Console.WriteLine(n.IndexOf('e')));
//            //Array.ForEach(words, w => Console.WriteLine(w + "s"));
//            // Array.ForEach(words, w => Console.WriteLine(w.Contains('s', StringComparison.OrdinalIgnoreCase))); //w.StartsWith('S')));
//            //Console.Write(String.Join(' ', words));

//            // var result =  words.Select(x => "'" + x +"'");

//            //Console.Write(string.Join(' ', result));
//            //Console.WriteLine();

//            //var dds = "Sue";
//            //Console.WriteLine(words[0].Equals(dds));
//            //bool ee = ReferenceEquals(dds, words[0]);
//            //Console.WriteLine(ee);

//            //var s = Array.TrueForAll(words, w => w.Length == 3);
//            //Console.WriteLine(s);
//            //var random = new Random();

//            //const int passwordLength = 10;
//            //char[] buffer = new char[passwordLength];
//            //for (int i = 0; i < passwordLength; i++)
//            //{
//            //    buffer[i] = ((char)('a' + random.Next(0, 26)));
//            //}


//            //Console.WriteLine(new string(buffer));

//            //Console.WriteLine((int) '$');

//            Console.ReadLine();
//        }
//    }
//}


// 2D array challnenge (Hacker Rank)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        int maxSum = 0;
        bool firstSum = true;

        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                int sum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2] + arr[x + 1][y + 1] + arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];
                if ((sum > maxSum) || (firstSum))
                {
                    maxSum = sum;
                    firstSum = false;
                }
            }
        }

        Console.WriteLine(maxSum.ToString());




        // Another solution
        //int maxResult = 0;
        //int result = 0;
        //for (int arr_i = 0; arr_i < 4; arr_i++)
        //{
        //    for (int arr_j = 0; arr_j < 4; arr_j++)
        //    {
        //        result = arr[arr_i][arr_j] + arr[arr_i][arr_j + 1] + arr[arr_i][arr_j + 2] +
        //            arr[arr_i + 1][arr_j + 1] + arr[arr_i + 2][arr_j] + arr[arr_i + 2][arr_j + 1] + arr[arr_i + 2][arr_j + 2];
        //        if (arr_i == 0 && arr_j == 0)
        //        {
        //            maxResult = result;
        //        }
        //        else if (maxResult < result)
        //        {
        //            maxResult = result;
        //        }
        //    }

        //}
        //Console.WriteLine(maxResult.ToString());

        Console.ReadLine();
    }
}