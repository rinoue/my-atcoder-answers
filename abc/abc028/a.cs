using System;

public class Program
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var ans = "Perfect";

        if(N <= 59)
        {
            ans = "Bad";
        }
        else if(N <= 89)
        {
            ans = "Good";
        }
        else if(N <= 99)
        {
            ans = "Great";
        }

        Console.WriteLine(ans);
    }
}