using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Hello
{
    const int INF = int.MaxValue;

    public static void Main()
    {
        var N_M = Console.ReadLine().Trim().Split();
        var N = int.Parse(N_M[0]);
        var M = int.Parse(N_M[1]);

        var to = new List<int>[100005];

        for(var i=0; i < M; i++) {
            var A_B = Console.ReadLine().Trim().Split();
            var A = int.Parse(A_B[0]);
            var B = int.Parse(A_B[1]);
            A--;
            B--;
            if(to[A] == null) to[A] = new List<int>(); to[A].Add(B);
            if(to[B] == null) to[B] = new List<int>(); to[B].Add(A);
        }

        var q = new Queue<int>();
        var dist = Enumerable.Repeat(INF, N).ToList();
        var pre = Enumerable.Repeat(-1, N).ToList();
        dist[0] = 0;

        q.Enqueue(0);
        while (q.Count() > 0)
        {
            int v = q.Dequeue();
            foreach(var u in to[v]) {
                if(dist[u] != INF) continue;
                dist[u] = dist[v] + 1;
                pre[u] = v;
                q.Enqueue(u);
            }
        }

        Console.WriteLine("Yes");
        for(var i = 1; i < N; i++)  {
            var ans  = pre[i];
            ++ans;
            Console.WriteLine(ans);
        }
   }
}