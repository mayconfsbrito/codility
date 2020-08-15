using System;
using System.Text.RegularExpressions;

namespace console.lesson2.CyclicRotation
{
    static class Solution
    {
        static void Main(string[] args)
        {
            var a = new int[] { 3, 8, 9, 7, 6 };
            var k = 3;
            solution(a, k);

            a = new int[] { 0, 0, 0 };
            k = 3;
            solution(a, k);

            a = new int[] { };
            solution(a, k);
        }

        public static int[] solution(int[] A, int K)
        {
            if (A.Length > 0 && K > 0)
            {
                for (int i = A.Length; i > (A.Length - K); i--)
                {
                    var lastValue = A[A.Length - 1];
                    int actualValue = 0;
                    for (int j = 1; j < A.Length; j++)
                    {

                        if (j == 1)
                        {
                            actualValue = A[j];
                            A[j] = A[j - 1];
                        }
                        else
                        {
                            var tmp = A[j];
                            A[j] = actualValue;
                            actualValue = tmp;
                        }
                    }
                    A[0] = lastValue;
                }
            }

            System.Console.WriteLine("Final Result");
            foreach (var item in A)
            {
                System.Console.WriteLine(item);
            }

            return A;
        }
    }
}
