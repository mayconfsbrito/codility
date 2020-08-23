using System;
using System.Linq;

namespace console.lesson4.MaxCounters
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            var N = 5;
            var result = new int[N];
            var testeResult = false;
            var expected = new int[] { 3, 2, 2, 4, 2 };
            result = solution(N, A);
            testeResult = Enumerable.SequenceEqual(result, expected);
            System.Console.WriteLine($"{testeResult}");

            A = Enumerable.Range(1, 10).ToArray();
            N = 8;
            expected = Enumerable.Repeat(1, N).ToArray();
            result = solution(N, A);
            testeResult = Enumerable.SequenceEqual(result, expected);
            System.Console.WriteLine($"{testeResult}");

            A = Enumerable.Range(1, 10).ToArray();
            A[5] = 1;
            A[6] = 1;
            N = 8;
            expected = Enumerable.Repeat(3, N).ToArray();
            result = solution(N, A);
            testeResult = Enumerable.SequenceEqual(result, expected);
            System.Console.WriteLine($"{testeResult}");

            A = Enumerable.Range(1, 10).ToArray();
            A[5] = 1;
            A[9] = 1;
            N = 8;
            expected = Enumerable.Repeat(2, N).ToArray();
            expected[0] = 3;
            result = solution(N, A);
            testeResult = Enumerable.SequenceEqual(result, expected);
            System.Console.WriteLine($"{testeResult}");

            A = Enumerable.Range(1, 1000000).ToArray();
            N = 200000;
            A[5] = N + 1;
            A[9] = N + 1;
            A[99] = N + 2;
            expected = Enumerable.Repeat(4, N).ToArray();
            result = solution(N, A);
            testeResult = Enumerable.SequenceEqual(result, expected);
            System.Console.WriteLine($"{testeResult}");
        }

        public static int[] solution(int N, int[] A)
        {
            var resultArray = new int[N];
            var countMaxValue = 0;
            var lastResetValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var value = A[i];
                if (value <= N)
                {
                    var position = value - 1;
                    ++resultArray[position];
                    if (resultArray[position] <= lastResetValue) resultArray[position] = lastResetValue + 1;
                    if (resultArray[position] > countMaxValue) countMaxValue = resultArray[position];
                }
                else
                {
                    lastResetValue = countMaxValue;
                }
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (resultArray[i] < lastResetValue) resultArray[i] = lastResetValue;
            }

            return resultArray;
        }
    }
}
