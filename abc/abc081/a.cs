using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var S = Console.ReadLine().Trim();

    var ans = S.Count(c=>c == '1');
    Console.WriteLine(ans);
  }
}