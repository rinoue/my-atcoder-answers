using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var abck = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var a = abck[0];
    var b = abck[1];
    var c = abck[2];
    var k = abck[3];

    int xa = Math.Min(a, k);
    k -= xa;
    int xb = Math.Min(b, k);
    k -= xb;
    int xc = k;

    var ans = xa - xc;
    Console.WriteLine(ans);
  }
}