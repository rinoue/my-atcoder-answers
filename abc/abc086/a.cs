using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var a = input[0];
    var b = input[1];

    var ans = (a * b) % 2 > 0 ? "Odd" : "Even";
    Console.WriteLine(ans);
  }
}