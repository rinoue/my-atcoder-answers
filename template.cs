using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Globalization;

public class AtCoder
{
  public static void Main()
  {
    var S = Console.ReadLine().Trim();
    var splited = Console.ReadLine().Trim().Split();
    var splited = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var a = splited[0];
    var b = splited[1];
    var c = splited[2];
    var d = splited[3];
    var M = int.Parse(Console.ReadLine().Trim());
    var N = int.Parse(Console.ReadLine().Trim());


    var ans = "";
    Console.WriteLine(ans);
  }
}