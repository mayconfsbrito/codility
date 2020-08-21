using System;
using System.Linq;

namespace console.lesson2.CyclicRotation
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var A = new int[] { 2, 3, 1, 5 };
            System.Console.WriteLine(solution(A));

            A = new int[] { };
            System.Console.WriteLine(solution(A));

            A = new int[] { 2, 3, 1, 5, 5 };
            System.Console.WriteLine(solution(A));

            A = Enumerable.Range(1, 3).ToArray();
            A[0] = A.Length + 1;
            System.Console.WriteLine(solution(A));

            A[0] = 1;
            A[1] = A.Length + 1;
            System.Console.WriteLine(solution(A));

            A = Enumerable.Range(1, 100000).ToArray();
            A[99] = A.Length + 1;
            System.Console.WriteLine(solution(A));
        }
        public static int solution(int[] A)
        {
            int missing = A.Length;
            for (int i = 1; i <= A.Length; i++)
            {
                missing ^= A[i - 1];
                missing ^= i;
            }

            return missing;
        }
    }
}
