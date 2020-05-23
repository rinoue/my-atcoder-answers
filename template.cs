using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Globalization;

public class Hello
{
    public static void Main()
    {
        var S = Console.ReadLine().Trim();
        var splitedArray = Console.ReadLine().Trim().Split();
        var M = int.Parse(Console.ReadLine().Trim());
        var N = int.Parse(Console.ReadLine().Trim());
        var M = int.Parse(splitedArray.First());
        var N = int.Parse(splitedArray.Last());        
        var M = int.Parse(splitedArray[0]);
        var N = int.Parse(splitedArray[1]);        


        var ans  = "";
        Console.WriteLine(ans);
   }
}