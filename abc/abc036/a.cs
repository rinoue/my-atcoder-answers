using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var A = int.Parse(input[0]);
        var B = int.Parse(input[1]);

//        var ans = (B / A) + (B % A > 0 ? 1 : 0);
        var ans = (B + A - 1) / A;

        Console.WriteLine(ans);
    }
}