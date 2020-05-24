using System;

public class AtCoder
{
  public static void Main()
  {
    var S = Console.ReadLine().Trim();
    var T = Console.ReadLine().Trim();

    var ans = T.Substring(0, S.Length) == S ? "Yes" : "No";
    Console.WriteLine(ans);
  }
}