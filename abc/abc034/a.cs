using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var x = int.Parse(input[0]);
        var y = int.Parse(input[1]);


        Console.WriteLine(x > y ? "Worse" : "Better");
    }
}