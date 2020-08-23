using System;
using System.Linq;

namespace console.lesson4.MaxCounters
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var A = new int[] { 1, 3, 6, 4, 1, 2 };
            var expected = 5;
            var result = solution(A);
            System.Console.WriteLine($"{result == expected}");

            A = new int[] { 1, 2, 3 };
            expected = 4;
            result = solution(A);
            System.Console.WriteLine($"{result}");
            System.Console.WriteLine($"{result == expected}");

            A = new int[] { -1, -3 };
            expected = 1;
            result = solution(A);
            System.Console.WriteLine($"{result == expected}");

            A = Enumerable.Range(-10, 100000).ToArray(); ;
            A[28] = 2;
            expected = 18;
            result = solution(A);
            System.Console.WriteLine($"{result == expected}");

        }

        public static int solution(int[] A)
        {
            A = A.Where(x => x > 0).OrderBy(x => x).Distinct().ToArray();
            var lastNumber = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == lastNumber) lastNumber++;
                else return lastNumber;
            }
            return lastNumber;
        }
    }
}
