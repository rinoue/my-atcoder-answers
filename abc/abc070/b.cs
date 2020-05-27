using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
    var a = input[0];
    var b = input[1];
    var c = input[2];
    var d = input[3];

    var s =  a > c ? a : c;
    var e =  b < d ? b : d;

    var ans = (e-s) >= 0 ? (e-s) : 0;
    Console.WriteLine(ans);
  }
}