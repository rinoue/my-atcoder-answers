using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());

    var s = Console.ReadLine().Trim();

    var w = new int[n];
    var e = new int[n];

    var wc = 0;
    var ec = 0;

    for (var i = 0; i < n; i++)
    {
      if(s[i] == 'W') wc++;
      if(s[n-1-i] == 'E') ec++;
      w[i]+= wc;
      e[n-1-i]+= ec;
    }

    var min = int.MaxValue;

    for (var i = 0; i < n; i++)
    {
      var sum = 0;
      if(0 < i) sum += w[i-1];
      if(i < n - 1) sum += e[i+1];
      if(sum < min) min = sum;
    }

    Console.WriteLine(min);
  }
}