using System;

public class Program
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine().Trim());
        var b = int.Parse(Console.ReadLine().Trim());
        var n = int.Parse(Console.ReadLine().Trim());

        while(true)
        {
            if(n % a == 0 && n % b == 0) break;
            n++;
        }

        Console.WriteLine(n);
    }
}