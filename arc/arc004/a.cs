using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
    struct Pair
    {
      public int x;
      public int y;

      public Pair(int x, int y)
      {
        this.x = x;
        this.y = y;
      }
    };

  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());

    var pList = new List<Pair>(n);

    for(var i=0; i < n; i++)
    {
      var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
      var x = input[0];
      var y = input[1];
      pList.Add(new Pair(x,y));
    }

    var lines = new Dictionary<Pair, HashSet<Pair>>();

    for(var i = 0; i < n; i++)
    {
      var key = pList[i];

      for(var j = 0; j < n; j ++)
      {
        if(i == j) continue;

        if(lines.ContainsKey(pList[j]) && lines[pList[j]].Contains(pList[i]))
        {
          continue;
        }

        if(!lines.ContainsKey(key))
        {
          lines[key] = new HashSet<Pair>();
        }
      
        lines[key].Add(pList[j]);
      }
    }

    double ans = 0;

    foreach(var p1 in lines.Keys)
    {
      foreach(var p2 in lines[p1])
      {
        var x = Math.Abs(p2.x - p1.x);
        var y = Math.Abs(p2.y - p1.y);


        var l = Math.Sqrt(x * x + y * y);

        if(l > ans) ans = l; 
      }
    }

    Console.WriteLine(ans);
  }
}