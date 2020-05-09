using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var W = int.Parse(input[0]);
        var H = int.Parse(input[1]);

        var DP = new int[W, H];

        DP[0, 0] = 1;
        for(var a = 1; a < W; a++) {
            for(var b = 1; b < H; b++) {
                DP[a, 0] = 1;
                DP[0, b] = 1;
                DP[a,b] = DP[a-1, b] + DP[a, b-1] ;
                DP[a,b] %= 1000000007 ;
            }
        }

        Console.WriteLine(DP[W-1, H-1]);
    }
}