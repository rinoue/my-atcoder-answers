using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    const int INF = int.MaxValue;
    var a = new int[12, 12];

    var nmx = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var n = nmx[0];
    var m = nmx[1];
    var x = nmx[2];

    var c = new int[n];
    for (var i = 0; i < n; i++)
    { 
    var splited = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
      c[i] = splited[0];
      for (var j = 0; j < m; j++)
      {
        a[i, j] = splited[j + 1];
      }
    }

    var ans = INF;
    for (var s = 0; s < (1 << n); s++)
    {
      int cost = 0;
      var d = new int[m];
      for (var i = 0; i < n; i++)
      {
        if (((s >> i) & 1) > 0)
        {
          cost += c[i];
          for (var j = 0; j < m; j++)
          {
            d[j] += a[i, j];
          }
        }
        bool ok = true;
        for (var j = 0; j < m; j++)
        {
          if (d[j] < x) ok = false;
        }
        if (ok) ans = Math.Min(ans, cost);
      }
    }

    if (ans == INF)
    {
      Console.WriteLine(-1);
    }
    else
    {
      Console.WriteLine(ans);
    }
  }
}