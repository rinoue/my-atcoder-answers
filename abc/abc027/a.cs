using System;

public class Program
{
    public static void Main()
    {
        var l = Console.ReadLine().Split(' ');

        var ans = "";
        if(l[0] == l[1])
        {
            ans = l[2];
        }
        else if(l[1] == l[2])
        {
            ans = l[0];
        }
        else
        {
            ans = l[1];
        }

        Console.WriteLine(ans);
    }
}