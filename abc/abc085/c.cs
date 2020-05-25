using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var n = input[0];
    var ly = input[1];

    var ans = new []{-1, -1, -1};

    for(var x=0; x <= n; x++) {
      for(var y=0; y <= n; y++) {
        var z = n - x - y;
        if(z < 0) continue; 
        var total = 10000 * x + 5000 * y + 1000 * z;
        if (total == ly)
        {
          ans[0] = x;
          ans[1] = y;
          ans[2] = z;
          x = y = n;
        }     
      }
    }

    Console.WriteLine($"{ans[0]} {ans[1]} {ans[2]}");
  }
}