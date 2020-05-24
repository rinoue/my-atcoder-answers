using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  const int D = 60;
  const int MAX_N = 200005;

  public static void Main()
  {
    var to = new int[D, MAX_N];

    var nk = Console.ReadLine().Trim().Split().ToArray();
    var n = int.Parse(nk[0]);
    var k = long.Parse(nk[1]);

    var a = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    for (var i = 0; i < n; i++)
    {
      to[0, i] = a[i] - 1;
    }

    for (var i = 0; i < D - 1; i++)
    {
      for (var j = 0; j < n; j++)
      {
        to[i + 1, j] = to[i, to[i, j]];
      }
    }

    var v = 0;
    for (var i = D - 1; i >= 0; --i)
    {
      long l = 1L << i;
      if (l <= k)
      {
        v = to[i, v];
        k -= l;
      }
    }
    Console.WriteLine(v + 1);
  }
}