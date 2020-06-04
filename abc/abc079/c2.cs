using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine();
    var a = int.Parse(input[0].ToString());
    var b = int.Parse(input[1].ToString());
    var c = int.Parse(input[2].ToString());
    var d = int.Parse(input[3].ToString());

    var i = 0;
    var v = 0;
    for (i = 0; i < 16; i++)
    {
      v = a;
      v += (i & (1 << 2)) > 0 ? b : -b;
      v += (i & (1 << 1)) > 0 ? c : -c;
      v += (i & (1 << 0)) > 0 ? d : -d;

      if (v == 7) break;
    }

    var op = new[] { "-", "+" };
    var ans =
      a + op[i >> 2 & 1] +
      b + op[i >> 1 & 1] +
      c + op[i >> 0 & 1] +
      d + "=7";

    Console.WriteLine(ans);
  }
}