using System;

public class AtCoder
{
  public static void Main()
  {
    var s = Console.ReadLine().Trim();
    var t = Console.ReadLine().Trim();

    var ans = "different";

    if (s == t)
    {
      ans = "same";
    }
    else if (s.ToLower() == t.ToLower())
    {
      ans = "case-insensitive";
    }

    Console.WriteLine(ans);
  }
}