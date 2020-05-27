using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AtCoder
{
  public static void Main()
  {
    var n = int.Parse(Console.ReadLine().Trim());
  
    var x = new ModInt(1);

    for(var i=1; i <= n; i++)
    {
      x = x * i;
    }

    Console.WriteLine(x);
  }
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
