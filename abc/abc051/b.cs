using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var k = input[0];
    var s = input[1];

    var ans = 0;
    for (var x = 0; x <= k; x++)
    {
      for (var y = 0; y <= k; y++)
      {
        var z = (s - x - y);
        if (z < 0 || k < z) continue;
        if (x + y + z == s) ans++;
      }
    }

    Console.WriteLine(ans);
  }
}