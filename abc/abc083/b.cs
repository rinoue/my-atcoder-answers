using System;
using System.Linq;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var n = input[0];
    var a = input[1];
    var b = input[2];

    var ans = 0;

    for(var i = 1; i <= n; i++)
    {
      var num = i;
      var sum = 0;
      while(num != 0) {
        sum += num % 10;
        if(sum > b) break;
        num /= 10;
      }
      if(a <= sum && sum <= b) {
        ans += i;
      }
    }


    Console.WriteLine(ans);
  }
}