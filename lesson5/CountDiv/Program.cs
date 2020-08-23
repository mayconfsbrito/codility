using System;
using System.Linq;

namespace console.lesson5.CountDiv
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var A = 6;
            var B = 11;
            var K = 2;
            var expected = 3;
            var result = solution(A, B, K);
            System.Console.WriteLine($"{result == expected}");

            A = 1;
            B = 100;
            K = 5;
            expected = 20;
            result = solution(A, B, K);
            System.Console.WriteLine($"{result == expected}");

            A = 1;
            B = 2000000000;
            K = 5;
            expected = 400000000;
            result = solution(A, B, K);
            System.Console.WriteLine($"{result == expected}");

            A = 4;
            B = 5;
            K = 3;
            expected = 0;
            result = solution(A, B, K);
            System.Console.WriteLine($"{result == expected}");
        }

        public static int solution(int A, int B, int K)
        {
            var rest = A % K;
            var firstDivisible = (rest == 0 ? A : A + (K - rest));
            var result = ((B - firstDivisible) / K);
            if (firstDivisible >= A && firstDivisible <= B) result++;
            return result;
        }
    }
}
