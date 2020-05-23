using System;
using System.Linq;

public class Hello
{
    public static void Main()
    {
        var K = int.Parse(Console.ReadLine().Trim());
        var S = Console.ReadLine().Trim();

        var ans  = S.Length <= K ? S : S.Substring(0, K) + "...";
        Console.WriteLine(ans);
   }
}