using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var s = new string(Console.ReadLine().Trim().Reverse().ToArray());

    var words = new[] { "dream", "dreamer", "erase", "eraser" };
    for(var i=0 ; i < 4; i++)
    {
      words[i] = new string(words[i].Reverse().ToArray());
    }

    var t = 0;
    var index = 0;
    while (t < s.Length)
    {
      var i = 0;
      while (i < 4)
      {
        if((t + words[i].Length) <= s.Length && words[i] == s.Substring(t, words[i].Length)) 
        {
          t += words[i].Length;
          break;
        }

        i++;
      }
      if (i >= 4) break;
    }

    var ans = (t == s.Length) ? "YES" : "NO";

    Console.WriteLine(ans);
  }
}