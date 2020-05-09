using System;

public class Program
{
    public static void Main()
    {
        var S = Console.ReadLine();
        var N = int.Parse(Console.ReadLine());

        var A = (N - 1) / 5;
        var b = (N - 1) % 5;

        Console.WriteLine(S[A].ToString() + S[b].ToString());
    }
}