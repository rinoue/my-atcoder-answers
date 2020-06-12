using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var dg = Console.ReadLine().Trim().Split();
    var d = int.Parse(dg[0]);
    var g = int.Parse(dg[1]);


    var p = new List<int>(d);
    var c = new List<int>(d);

    for(var i=0; i < d; i++)
    {
      var pc = Console.ReadLine().Trim().Split();
      p.Add(int.Parse(pc[0]));
      c.Add(int.Parse(pc[1]));
    }

    var ans = int.MaxValue;

    for(var mask = 0; mask < (1 << d); mask++)
    {
      int s = 0;
      int num = 0;
      int rest_max = -1;
      for(int i = 0; i < d; i++)
      {
        if(((mask >> i) & 1) > 0)
        {
          s += 100 * (i + 1) * p[i] + c[i];
          num += p[i];
        }
        else
        {
          rest_max = i;
        }
        if(s < g)
        {
          int s1 = 100 * (rest_max + 1);
          int need = (g - s + s1 - 1) / s1;
          if (need >= p[rest_max])
          {
            continue;
          }
          num += need;
        }
        ans = Math.Min(ans, num);
      }
    }

    Console.WriteLine(ans);
  }
}