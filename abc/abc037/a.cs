using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var A = int.Parse(input[0]);
        var B = int.Parse(input[1]);
        var C = int.Parse(input[2]);

        Console.WriteLine(C / Math.Min(A, B));
    }
}