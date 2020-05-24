using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    Func<(int, int)[], bool> check = (s) =>
    {
      int h = 0;
      foreach (var p in s)
      {
        int b = h + p.Item1;
        if (b < 0) {
          return false;
        }
        h += p.Item2;
      }
      return true;
    };

    var n = int.Parse(Console.ReadLine().Trim());

    var ls = new List<(int, int)>();
    var rs = new List<(int, int)>();
    int total = 0;
    for (var i = 0; i < n; i++)
    {
      var s = Console.ReadLine().Trim();

      int h = 0, b = 0;
      foreach (var c in s)
      {
        if (c == '(')
        {
          ++h;
        }
        else
        {
          --h;
        }
        b = Math.Min(b, h);
      }
      if (h > 0)
      {
        ls.Add((b, h));
      }
      else { 
        rs.Add((b - h, -h)); 
      }
      total += h;
    }

    var lsDsc = ls.OrderByDescending(e => e).ToArray();
    var rsDsc = rs.OrderByDescending(e => e).ToArray();

    if (check(lsDsc) && check(rsDsc) && (total == 0))
    {
      Console.WriteLine("Yes");
    }
    else
    {
      Console.WriteLine("No");
    }
  }
}