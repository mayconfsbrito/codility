using System;
using System.Text.RegularExpressions;

namespace console.lesson2.CyclicRotation
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 85;
            var d = 30;
            System.Console.WriteLine(solution(x, y, d));

            x = 0; y = 5; d = 1;
            System.Console.WriteLine(solution(x, y, d));

            x = 10; y = 5; d = 30;
            System.Console.WriteLine(solution(x, y, d));

            x = 0; y = 1; d = 0;
            System.Console.WriteLine(solution(x, y, d));

            x = 12; y = 1; d = 9999999;
            System.Console.WriteLine(solution(x, y, d));
        }

        public static int solution(int X, int Y, int D)
        {
            System.Console.WriteLine("Tentativa:");

            if (X >= Y || D == 0) return 0;
            return (int)Math.Ceiling((decimal)(Y - X) / D);

        }
    }
}
