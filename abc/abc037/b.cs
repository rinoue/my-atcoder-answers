using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var N = int.Parse(input[0]);
        var Q = int.Parse(input[1]);

        var ans = new int[N];

        for(var i=0; i < Q; i++)
        {
            input = Console.ReadLine().Split();
            var L = int.Parse(input[0]) - 1;
            var R = int.Parse(input[1]) - 1;
            var T = int.Parse(input[2]);

            for(; L <= R; L++)
            {
                ans[L] = T;
            }
        }

        foreach(var n in ans)
        {
            Console.WriteLine(n);
        }
    }
}
