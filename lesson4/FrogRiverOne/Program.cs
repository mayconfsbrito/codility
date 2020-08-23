using System;
using System.Linq;

namespace console.lesson4.FrogRiverOne
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            var X = 5;
            var result = 0;
            var expected = 6;
            result = solution(X, A);
            System.Console.WriteLine($"{result} => {result == expected}");

            A = new int[] { 1, 3, 1, 4, 2, 3 };
            X = 5;
            result = solution(X, A);
            expected = -1;
            System.Console.WriteLine($"{result} => {result == expected}");

            A = Enumerable.Range(1, 6).ToArray();
            X = 3;
            result = solution(X, A);
            expected = 2;
            System.Console.WriteLine($"{result} => {result == expected}");
        }

        public static int solution(int X, int[] A)
        {
            var tempArray = new int[X];
            int countFounds = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var value = A[i] - 1;
                if (value < X && tempArray[value] == 0)
                {
                    tempArray[value] = 1;
                    countFounds++;
                }

                if (countFounds == X)
                    return i;
            }

            return -1;
        }
    }
}
