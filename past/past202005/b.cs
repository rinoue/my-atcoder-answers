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

    var score = (new int[m + 1]).Select(v => n).ToArray();
    var get = new Dictionary<int, List<int>>(n);

    for (var i = 0; i < q; i++)
    {
      var s = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();

      if (s[0] == 1)
      {
        if (!get.ContainsKey(s[1]))
        {
          Console.WriteLine(0);
        }
        else
        {
          Console.WriteLine(get[s[1]].Sum(e => score[e]));
        }
      }
      else
      {
        if (score[s[2]] > 0) score[s[2]]--;

        if (!get.ContainsKey(s[1]))
        {
          get[s[1]] = new List<int>();
        }
        get[s[1]].Add(s[2]);
      }
    }
  }
}