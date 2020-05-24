using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());
    var a = Console.ReadLine().Trim().Split().Select(e => int.Parse(e));

    var alice = 0;
    var bob = 0;

    var cards =  a.OrderByDescending(e=>e).ToArray();
    for(var i=0; i < n; i++)
    {
      if((i % 2) == 0)
      {
        alice += cards[i];
      }
      else {
        bob += cards[i];
      }
    }

    var ans = alice - bob;
    Console.WriteLine(ans);
  }
}