using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        var A_B_H_M = Console.ReadLine().Trim().Split();
        var A = int.Parse(A_B_H_M[0]);
        var B = int.Parse(A_B_H_M[1]);        
        var H = int.Parse(A_B_H_M[2]);        
        var M = int.Parse(A_B_H_M[3]);        

        var th = (double)(60 * H + M) / 720 * 2 * Math.PI;
        var tm = (double)(M) / 60 * 2 * Math.PI;

        var xh = A * Math.Cos(th);
        var yh = A * Math.Sin(th);
        var xm = B * Math.Cos(tm);
        var ym = B * Math.Sin(tm);
        
        var dx = xh - xm;
        var dy = yh - ym;

        var ans = Math.Sqrt(dx*dx + dy*dy);
        Console.WriteLine(ans);
   }
}