using System;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? n - 1 : n + 1);
    }
}