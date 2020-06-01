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
    var yen = input[1];

    for (var x = 0; x <= n; x++)
    {
      for (var y = 0; y <= n; y++)
      {
        var z = n - x - y;
        if (z >= 0 && (10000 * x + 5000 * y + 1000 * z) == yen)
        {
          Console.WriteLine($"{x} {y} {z}");
          return;
        }
      }
    }

    Console.WriteLine("-1 -1 -1");
  }
}