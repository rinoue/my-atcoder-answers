using System;

public class Program
{
    public static void Main()
    {
        var LH = Console.ReadLine().Split(' ');
        var L = int.Parse(LH[0]);
        var H = int.Parse(LH[1]);
        var N = int.Parse(Console.ReadLine());

        for(var i=0; i < N; i++) {
            var A = int.Parse(Console.ReadLine());

            if(A < L) {
               Console.WriteLine(L-A);
            } else
            if(H < A) {
               Console.WriteLine(-1);
            }
            else
            {
               Console.WriteLine(0);
            }
        }
    }
}