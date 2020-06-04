using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var s = Console.ReadLine().Trim().ToCharArray();

    var n = Math.Pow(2, s.Length - 1);
    long ans = 0;

    for (var i = 1; i <= n; i++)
    {
      var val = "0";
      for (var j = 0; j < s.Count(); j++)
      {
        val += s[j].ToString();
                
        if (((i >> j) & 1) > 0)
        {
          ans += long.Parse(val);
          val = "0";        
        }
      }
      ans += long.Parse(val);
    }

    Console.WriteLine(ans);
  }
}