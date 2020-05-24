using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var nk = Console.ReadLine().Trim().Split().ToArray();
    var n = int.Parse(nk[0]);
    var k = long.Parse(nk[1]);

    var a = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();

    var s = new List<long>();
    var ord = Enumerable.Repeat(-1, n+1).ToArray();
    int c = 1;
    int l = 0;
    {
      int v = 1;
      while (ord[v] == -1) {
        ord[v] = s.Count();
        s.Add(v);
        v = a[v-1];
      }
      c = s.Count() - ord[v];
      l = ord[v];
    }

    if (k < l) {
      Console.WriteLine(s[(int)k]);
    }
    else
    {
      k -= l;
      k %= c;
      Console.WriteLine(s[l+(int)k]);
    }
  }
}