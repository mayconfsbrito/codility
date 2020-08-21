using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        var array = new int[] { 3, 1, 2, 4, 3 };
        var expected = 1;
        var result = 0;
        result = solution(array);
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);

        array = new int[] { 1, 1, 1, 1, 6, 11 };
        result = solution(array);
        expected = 1;
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);

        array = new int[] { 3, 3, 3, 3, 2, 15 };
        result = solution(array);
        expected = 1;
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);

        array = new int[] { 15, 2, 3, 3, 3, 3 };
        result = solution(array);
        expected = 1;
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);

        array = new int[] { };
        result = solution(array);
        expected = 0;
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);

        array = new int[] { 12 };
        result = solution(array);
        expected = 0;
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);

        array = Enumerable.Range(0, 10000).ToArray();
        result = solution(array);
        expected = 3030;
        System.Console.WriteLine(result);
        System.Console.WriteLine(result == expected);
    }

    public static int solution(int[] A)
    {
        Int64 sumP1 = A.Sum();
        Int64 sumP2 = 0;
        Int64 bestResult = Int64.MaxValue;
        Int64 result = 0;
        for (int i = 0; i < A.Length; i++)
        {
            sumP1 -= A[i];
            sumP2 += A[i];
            result = Math.Abs(sumP1 - sumP2);

            if (result < Math.Abs(bestResult)) bestResult = result;
        }
        return (int)bestResult;
    }
}