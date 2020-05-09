using System;

public class Program
{
    public static void Main()
    {
        var S = Console.ReadLine();

        var ans = new int[6];

        foreach(var c in S)
        {
            ans[c-'A']++;
        }

        Console.WriteLine(String.Join(" ", ans));
    }
}