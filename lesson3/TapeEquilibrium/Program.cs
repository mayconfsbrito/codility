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

        array = new int[] { 1000, -1000 };
        result = solution(array);
        expected = 2000;
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
        long sumP1 = 0;
        long sumP2 = A.Sum();
        long bestResult = Int64.MaxValue;
        long result = 0;

        for (int i = 0; i < A.Length - 1; i++)
        {
            sumP1 += A[i];
            sumP2 -= A[i];
            result = Math.Abs(sumP1 - sumP2);
            if (Math.Abs(result) < Math.Abs(bestResult)) bestResult = result;
        }
        return (int)Math.Abs(bestResult);
    }
}