using System;
using System.Linq;

namespace console.lesson4.MaxCounters
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var A = new int[] { 4, 1, 3, 2 };
            var expected = 1;
            var result = solution(A);
            System.Console.WriteLine($"{result == expected}");

            A = Enumerable.Range(1, 1000001).ToArray(); ;
            expected = 1;
            result = solution(A);
            System.Console.WriteLine($"{result == expected}");

            A = Enumerable.Range(2, 1000001).ToArray(); ;
            expected = 0;
            result = solution(A);
            System.Console.WriteLine($"{result == expected}");

            A = Enumerable.Range(1, 10000001).ToArray(); ;
            A[100] = 12;
            A[1000] = 12;
            A[10000] = 12;
            expected = 0;
            result = solution(A);
            System.Console.WriteLine($"{result == expected}");

            A = new int[] { 4, 5, 3, 2 };
            expected = 0;
            result = solution(A);
            System.Console.WriteLine($"{result == expected}");

        }

        public static int solution(int[] A)
        {
            int[] tempArray = new int[A.Length];
            int countDistincts = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var value = A[i];
                var position = value - 1;
                if (value > 0 && value <= A.Length && tempArray[position] == 0)
                {
                    tempArray[position] = 1;
                    countDistincts++;
                }
                else return 0;
            }

            if (countDistincts == A.Length)
                return 1;
            return 0;
            // int maxNumber = A.Max();
            // if (A.Distinct().Count() < maxNumber) return 0;
            // return 1;
        }
    }
}
