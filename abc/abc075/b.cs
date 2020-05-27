using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var input = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var h = input[0];
    var w = input[1];

    var map = new char[w, h];

    for(var y=0; y < h; y++)
    {
      var line = Console.ReadLine();
      for(int x=0; x < w; x++)
      {
        map[x,y] = line[x];
      }
    }

    var dx = new []{ -1,0,1, -1,1, -1,0,1 };
    var dy = new []{ -1,-1,-1, 0,0 ,1,1,1 };

    for(var y=0; y < h; y++)
    {
      for(int x=0; x < w; x++)
      {
        if(map[x,y] == '#') continue;

        var count = 0;
        for(var i=0; i < 8; i++)
        {
          var tx = x + dx[i];
          var ty = y + dy[i];
          if(tx < 0 || w <= tx ) continue;
          if(ty < 0 || h <= ty ) continue;

          if(map[tx,ty] == '#') count++;
        }

        map[x,y] = count.ToString().First();
      }
    }

    for(var y=0; y < h; y++)
    {
      for(int x=0; x < w; x++)
      {
        Console.Write(map[x,y]);
      }
      Console.Write(Environment.NewLine);
    }
  }
}