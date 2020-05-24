using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());

    var table = new int[100 + 1];

    for(var i = 0; i < n; i++)
    {
      var d = int.Parse(Console.ReadLine().Trim());
      table[d] = 1;
    }

    var ans = table.Count(d => d > 0);
    Console.WriteLine(ans);
  }
}