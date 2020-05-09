using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var A = int.Parse(line[0]);
        var D = int.Parse(line[1]);
        var ad = new int[] { (A + 1) * D , A * (D + 1) };

        Console.WriteLine(ad.Max());
    }
}