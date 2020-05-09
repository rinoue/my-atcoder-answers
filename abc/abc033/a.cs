using System;

public class Program
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine(N % 1111 == 0 ? "SAME" : "DIFFERENT");
    }
}