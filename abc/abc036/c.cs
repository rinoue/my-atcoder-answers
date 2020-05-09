using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var a_n = new List<int>();

        for(var i=0; i<N; i++)
        {
            var a = int.Parse(Console.ReadLine());
            a_n.Add(a);
        }

        var map = new Dictionary<int, int>();

        var b_i = 0;
        foreach(var k in a_n.OrderBy(_=>_).Distinct())
        {
            map[k] = b_i;
            b_i++;
        }

        foreach(var a in a_n)
        {
            Console.WriteLine(map[a]);
        }
    }
}