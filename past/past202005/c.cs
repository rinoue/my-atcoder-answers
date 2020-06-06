using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var arn = Console.ReadLine().Trim().Split().Select(e => long.Parse(e)).ToArray();
    var a = arn[0];
    var r = arn[1];
    var n = arn[2];

    long ans = a;

    for (var i = 1; i < n; i++)
    {
      ans *= r;
      if (ans > 1000000000)
      {
        Console.WriteLine("large");
        return;
      }
    }

    Console.WriteLine(ans);
  }
}