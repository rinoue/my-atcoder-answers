using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var W = int.Parse(input[0]);
        var H = int.Parse(input[1]);

        Console.WriteLine((double)H / W == 0.75f ? "4:3" : "16:9");
    }
}