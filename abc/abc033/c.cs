using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var S = Console.ReadLine().Split('+');

        var sum = 0;

        foreach(var span in S)
        {
            sum += span.Any(e=>e=='0') ? 0 : 1;
        }

        Console.WriteLine(sum);
    }
}