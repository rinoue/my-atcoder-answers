using System;

public class Program
{
    public static void Main()
    {
        var ans = 0;
        for(var i=0; i<12; i++)
        {
            if(Console.ReadLine().Contains("r")) ans++;
        }

        Console.WriteLine(ans);
    }
}