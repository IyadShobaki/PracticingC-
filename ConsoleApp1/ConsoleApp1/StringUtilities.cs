using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class StringUtilities
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(" ");
            int charchtersLength = 0;
            var summaryList = new List<string>();

            foreach (var word in words)
            {
                summaryList.Add(word);
                charchtersLength += word.Length + 1;
                if (charchtersLength > maxLength)
                {
                    break;
                }
            }
            return String.Join(" ", summaryList) + "...";
        }
    }
}
