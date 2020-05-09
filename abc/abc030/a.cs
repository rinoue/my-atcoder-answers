using System;

public class Program
{
    public static void Main()
    {

        var input = Console.ReadLine().Split(' ');
        var A = int.Parse(input[0]);
        var B = int.Parse(input[1]);
        var C = int.Parse(input[2]);
        var D = int.Parse(input[3]);

        var ans = B * C - A * D;

        if(ans > 0)
        {
            Console.WriteLine("TAKAHASHI");
        }
        else if(ans == 0)
        {
            Console.WriteLine("DRAW");
        }
        else
        {
            Console.WriteLine("AOKI");
        }
    }
}