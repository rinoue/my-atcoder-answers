using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var nmq = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var n = nmq[0];
    var m = nmq[1];
    var q = nmq[2];

    var pList = new Dictionary<int, HashSet<int>>(m);
    var cList = new int[n];

    var pi = 1;

    for (var i = 0; i < m; i++)
    {
      var uv = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
      var u = uv[0];
      var v = uv[1];

      if (!pList.ContainsKey(u))
      {
        pList[u] = new HashSet<int>();
      }

      pList[u].Add(v);

      if (!pList.ContainsKey(v))
      {
        pList[v] = new HashSet<int>();
      }

      pList[v].Add(u);
    }

    cList = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();

    for (var i = 0; i < q; i++)
    {
      var query = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();

      var x = query[1];
      Console.WriteLine(cList[x - 1]);

      if (query[0] == 1)
      {
        var c = cList[x - 1];

        if (pList.ContainsKey(x))
        {
          foreach (var next in pList[x])
          {
            cList[next - 1] = c;
          }
        }

      }
      else
      {
        var y = query[2];
        cList[x - 1] = y;
      }
    }

  }
}