using System;
using System.Linq;

public class AtCoder
{
  const int INF = int.MaxValue;
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());
    var a = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();

    var ans = INF;

    for(var i=0; i < n; i++)
    {
      var count = 0;
      while(a[i] > 0) {
        if((a[i] & 1) > 0) {
          break;
        }
        a[i] = a[i] >> 1;
        count++;
      }
      if(count < ans) ans = count;      
    }

    Console.WriteLine(ans);
  }
}