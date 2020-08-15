using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace console.lesson2.OddOccurencesInArray
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var a = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            System.Console.WriteLine(solution(a));

            a = new int[] {
                9, 3, 9, 3, 9, 7, 9, 7, 1, 1,
                2, 4, 5, 5, 4, 2, 100, 200, 300, 5000,
                18 , 50000, 500000, 100, 200, 300, 5000, 50000, 500000, 101, 101, 102,
                102, 90, 99, 800, 800, 99, 90, 800, 11, 11,
            };
            System.Console.WriteLine(solution(a));

            a = new int[] { };
            System.Console.WriteLine(solution(a));

            a = new int[10000000];
            var randNum = new Random();
            for (int i = 0; i < a.Length / 2; i++)
            {
                int number = randNum.Next(800, 1000000000);
                a[i] = number;
                a[a.Length - i - 1] = number;
            }
            a[6666] = 120;
            System.Console.WriteLine("Ultima tentativa!");
            System.Console.WriteLine(solution(a));
        }

        public static int solution(int[] A)
        {
            var numbers = A
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 == 1)
                .SelectMany(x => x)
                .FirstOrDefault();
            return numbers;
        }
    }
}
