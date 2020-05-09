using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine());

        var input = Console.ReadLine().Split().Select(e=>int.Parse(e)).ToArray();
        var b = input[0];
        var c = input[1];

        var s = Console.ReadLine();

        var ans = (a + b + c) + " " + s;
        Console.WriteLine(ans);
    }
}