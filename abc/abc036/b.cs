using System;

public class Program
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine());

        var ans = new char[N,N];

        for(var y=0; y < N; y++)
        {
            var line = Console.ReadLine();
            for(var x=0; x < N; x++)
            {
                ans[N - y - 1, x] = line[x];
            }
        }

        for(var y=0; y < N; y++)
        {
            for(var x=0; x < N; x++)
            {
                Console.Write(ans[x, y]);
            }
            Console.Write(Environment.NewLine);
        }

    }
}