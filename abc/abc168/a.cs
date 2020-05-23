using System;

public class Hello
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine().Trim());

        var yomi = new [] {"hon", "pon", "bon"};
        var table = new []{ 1, 1, 0, 2, 0, 0, 1, 0, 1, 0 };

        var ans  = yomi[table[N % 10]];
        Console.WriteLine(ans);
   }
}