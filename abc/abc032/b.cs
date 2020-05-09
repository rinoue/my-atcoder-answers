using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var s = Console.ReadLine();
        var k = int.Parse(Console.ReadLine());

        var dic = new HashSet<string>();

        for(var i=0; i<s.Length && (i + k) <= s.Length; i++)
        {
            var word = s.Substring(i, k);

            if(!dic.Contains(word))
            {
                dic.Add(word);
            }
        }

        Console.WriteLine(dic.Count);
    }
}