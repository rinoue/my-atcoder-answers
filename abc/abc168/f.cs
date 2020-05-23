using System;
using System.Linq;
using System.Collections.Generic;

public class Hello
{
    struct L {
        public int a, b, c;
        public L(int a = 0, int b = 0, int c = 0) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }   
    }
    readonly static int[] dx = new []{ -1, 0, 1, 0 };
    readonly static int[] dy = new []{ 0, -1, 0, 1 };

    public static void Main()
    {
        var N_M = Console.ReadLine().Trim().Split().Select(e=>int.Parse(e)).ToArray();
        var N = N_M[0];
        var M = N_M[1];        

        var mpX = new Dictionary<int, int>();
        var mpY = new Dictionary<int, int>();
        mpX[0] = 0;
        mpY[0] = 0;

        var lh = new List<L>();
        var lv = new List<L>();

        for(var i = 0; i < N; i++) {
            var A_B_C = Console.ReadLine().Trim().Split().Select(e=>int.Parse(e)).ToArray();
            var a = A_B_C[0];
            var b = A_B_C[1];
            var c = A_B_C[2];
            mpX[a] = 0;
            mpX[b] = 0;
            mpY[c] = 0;
            lh.Add(new L(a, b, c));
        }
       for(var i = 0; i < M; i++) {
            var A_B_C = Console.ReadLine().Trim().Split().Select(e=>int.Parse(e)).ToArray();
            var c = A_B_C[0];
            var a = A_B_C[1];
            var b = A_B_C[2];
            mpY[a] = 0;
            mpY[b] = 0;
            mpX[c] = 0;
            lv.Add(new L(a, b, c));
       }

        var xs = new List<int>();
        var ys = new List<int>();
        
        foreach(var id in mpX.Keys.OrderBy(e=>e).ToArray())
        {           
            mpX[id] = xs.Count();
            xs.Add(id);
        }

        foreach(var id in mpY.Keys.OrderBy(e=>e).ToArray())
        {           
            mpY[id] = ys.Count();
            ys.Add(id);
        }

        int h = xs.Count() * 2;
        int w = ys.Count() * 2;

        var d = new int[h, w];
        for(var i = 0; i < N; i++) {
            int a = mpX[lh[i].a]*2;
            int b = mpX[lh[i].b]*2;
            int c = mpY[lh[i].c]*2;
            for (var x = a; x <= b; ++x) d[x,c] = -1;
        }
        for(var i = 0; i < M; i++) {
            int a = mpY[lv[i].a]*2;
            int b = mpY[lv[i].b]*2;
            int c = mpX[lv[i].c]*2;
            for (var y = a; y <= b; ++y) d[c,y] = -1;
        }

        var q = new Queue<(int, int)>();
        int sx = mpX[0] * 2;
        int sy = mpY[0] * 2;
        d[sx, sy] = 1;
        q.Enqueue((sx, sy));
        while(q.Count() > 0)
        {
            var f = q.Dequeue();
            int x = f.Item1;
            int y = f.Item2;
            for(var v=0 ; v<4; v++)
            {
                int nx = x + dx[v];
                int ny = y + dy[v];
                if (nx < 0 || nx >= h) continue; 
                if (ny < 0 || ny >= w) continue; 
                if (d[nx, ny] != 0) continue; 
                d[nx, ny] = 1;
                q.Enqueue((nx, ny));
            }
        }

        long ans  = 0;
        for(var x = 0; x < h; x++) {
            for(var y = 0; y < w; y++) {
                if (d[x, y] != 1) continue;
                if ((x == 0) || (x == h-1) || (y == 0) || (y == w-1)) {
                    Console.WriteLine("INF");
                    return;
                }
                if ((x%2 == 0) || (y%2 == 0)) continue;
                long ex = xs[x/2+1]-xs[x/2];
                long ey = ys[y/2+1]-ys[y/2];
                ans += ex * ey;         
            }
        }
        Console.WriteLine(ans);
   }
}