using System;
using System.Text.RegularExpressions;

namespace console.lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(15);
            solution(32);
            solution(9);
            solution(529);
        }

        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binary = Convert.ToString(N, 2);
            string pattern = @"(?<=1)(0{1,})(?=1)";

            var matches = Regex.Matches(binary, pattern);

            var length = 0;
            foreach (var item in matches)
            {
                length = Math.Max(length, item.ToString().Length);
            }
            System.Console.WriteLine(length);

            return length;
        }
    }
}
