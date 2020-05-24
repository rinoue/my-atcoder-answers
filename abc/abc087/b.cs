using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var a = int.Parse(Console.ReadLine().Trim());
    var b = int.Parse(Console.ReadLine().Trim());
    var c = int.Parse(Console.ReadLine().Trim());
    var x = int.Parse(Console.ReadLine().Trim());

    var ans = 0;

    for(var i = 0; i <= a; i++) {
      for(var j = 0; j <= b; j++) {
        for(var k = 0; k <= c; k++) {
          var sum = 500 * i + 100 * j + 50 * k;
          if(sum == x) {
            ans++;
          } 
        }
      }
    }

    Console.WriteLine(ans);
  }
}