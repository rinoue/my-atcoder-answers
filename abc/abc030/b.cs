using System;

public class Program
{
    public static void Main()
    {

        var input = Console.ReadLine().Split(' ');
        var n = int.Parse(input[0]);
        var m = int.Parse(input[1]);

        var l = (360f/12) * (n % 12) + (360f/12/60) * m;
        var s = (360f/60) * m;

        Console.WriteLine(Math.Min(360 - Math.Abs(s - l), Math.Abs(s - l)));
    }
}