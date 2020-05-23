using System;
using System.Linq;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        var N = int.Parse(Console.ReadLine().Trim());

        int zero = 0;
        var map = new Dictionary<Tuple<long, long>, int[]>();

        for(var i = 0; i < N; i++)
        {
            var A_B = Console.ReadLine().Trim().Split().Select(e=> long.Parse(e)).ToArray();
            var x = A_B[0];
            var y = A_B[1];

            if(x == 0 && y == 0) {
                zero++;
                continue;
            }
            var g = Gcd(x, y);
            x /= g;
            y /= g;
            if (y < 0) { x = -x; y = -y; }
            if (y == 0 && x < 0) { x = -x; y = -y; }
            bool rot90 = (x <= 0); 
            if (rot90) {
                var tmp = x;
                x = y; y = -tmp;
            }

            var t = Tuple.Create(x,y);
            if (rot90) {  
                if(map.ContainsKey(t)) {
                    map[t][0]++;
                } else {
                    map[t] = new []{1,0};
                }
            }
            else {
                if(map.ContainsKey(t)) {
                    map[t][1]++;
                } else {
                    map[t] = new []{0,1};
                }
            }
        }

        ModInt ans = 1;
        foreach(var p in map.Values)
        {
            int s = p[0];
            int t = p[1];
            ModInt now = 1;
            now += ModInt.Pow(2, s) - 1;
            now += ModInt.Pow(2, t) - 1;
            ans *= now;
        }
        ans -= 1;

        ans += zero;
        Console.WriteLine(ans);
   }

    class ModInt
    {
        public const long Mod = 1000000007;

        public long num;

        public ModInt(long n) { num = n; }

        public override string ToString() { return num.ToString(); }
        public static ModInt operator +(ModInt l, ModInt r) { l.num += r.num; if (l.num >= Mod) l.num -= Mod; return l; }
        public static ModInt operator -(ModInt l, ModInt r) { l.num -= r.num; if (l.num < 0) l.num += Mod; return l; }
        public static ModInt operator *(ModInt l, ModInt r) { return new ModInt(l.num * r.num % Mod); }
        public static implicit operator ModInt(long n) { n %= Mod; if (n < 0) n += Mod; return new ModInt(n); }

        public static ModInt Pow(ModInt v, long k) { return Pow(v.num, k); }

        public static ModInt Pow(long v, long k)
        {
            long ret = 1;
            for (k %= Mod - 1; k > 0; k >>= 1, v = v * v % Mod)
                if ((k & 1) == 1) ret = ret * v % Mod;
            return new ModInt(ret);
        }

        public static ModInt Inverse(ModInt v) { return Pow(v, Mod - 2); }
    }

    private static long Gcd(long a, long b)
    {
        if (a < b)
        {
            return Gcd(b, a);
        }
        while (b != 0)
        {
            long r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
}