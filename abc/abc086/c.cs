using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());

    var t = new int[n+1];
    var x = new int[n+1];
    var y = new int[n+1];

    for(var i = 0; i < n; i++)
    {
      var intput = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray(); 
      t[i+1] = intput[0];
      x[i+1] = intput[1];
      y[i+1] = intput[2];      
    }

    bool ans  = true;
    for(var i=0; i < n; i++)
    {
      var dt = t[i+1] - t[i]; 
      var dist = Math.Abs(x[i+1] - x[i]) + Math.Abs(y[i+1] - y[i]);
      if (dist > dt) {
          ans = false;
          break;
      }
      if ((dt%2) != (dist%2))
      {
        ans = false;
        break;
      }
    }

    Console.WriteLine(ans ? "Yes" : "No");
  }
}