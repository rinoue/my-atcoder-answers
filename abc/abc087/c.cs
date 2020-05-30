using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());

    var w = n;
    var h = 2;

    var map = new List<int[]>(n);

    for(var i = 0; i < h; i++)
    {
      var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
      map.Add(input);
    }

    var ans = 0;

    for(var i = 0; i < w; i++)
    { 
      var sum = map[0].Take(i+1).Sum();
      sum += map[1].Skip(i).Sum();

      if(sum > ans) ans = sum;
    }

    Console.WriteLine(ans);
  }
}