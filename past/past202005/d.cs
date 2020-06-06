using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var led = new[] {
    ".###..#..###.###.#.#.###.###.###.###.###",
    ".#.#.##....#...#.#.#.#...#.....#.#.#.#.#",
    ".#.#..#..###.###.###.###.###...#.###.###",
    ".#.#..#..#.....#...#...#.#.#...#.#.#...#",
    ".###.###.###.###...#.###.###...#.###.###"
    };

    var ans = "";

    var n = int.Parse(Console.ReadLine().Trim());
    var s = new List<string>(5);
    for (var i = 0; i < 5; i++)
    {
      s.Add(Console.ReadLine().Trim());
    }

    for (var i = 0; i < n; i++)
    {
      for (var j = 0; j <= 9; j++)
      {
        var match = true;

        for (var k = 0; k < 5; k++)
        {
          match = (s[k].Substring(4 * i, 4) == led[k].Substring(4 * j, 4));
          if (!match) break;
        }

        if (match)
        {
          ans += j;
          break;
        }
      }
    }

    Console.WriteLine(ans);
  }
}