using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine().Trim());

        var cities = new List<Tuple<string, int>>();

        var sum = 0;
        for(var i=0; i < N; i++)
        {
            var line = Console.ReadLine().Split(' ');
            var S = line[0];
            var P = Int32.Parse(line[1]);
            sum += P;
            cities.Add(Tuple.Create<string, int>(S, P));
        }

        var result = cities.Where(e=>e.Item2 > sum / 2);

        var name = "atcoder";
        if(result.Count() > 0)
        {
            name = result.First().Item1;
        }

        Console.WriteLine(name);
    }
}