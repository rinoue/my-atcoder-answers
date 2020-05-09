using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var R = new int[N];

        for(var i=0; i<N; i++)
        {
            R[i] = int.Parse(Console.ReadLine());
        }

        var ans = R.OrderByDescending(_ => _)
        .Select((r, i) => Math.PI * r * r * (i % 2 == 0 ? 1 : -1) )
        .Sum();

        Console.WriteLine(ans);
    }
}