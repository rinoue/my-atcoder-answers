using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class ModInt
{
  public const long Mod = 998244353;

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

class Combination
{
  ModInt[] fact, ifact;
  public Combination(int n)
  {
    fact = new ModInt[n + 1];
    ifact = new ModInt[n + 1];

    fact[0] = 1;
    for (int i = 1; i <= n; ++i) { fact[i] = fact[i - 1] * i; }
    ifact[n] = ModInt.Inverse(fact[n]);
    for (int i = n; i >= 1; --i) { ifact[i - 1] = ifact[i] * i; }
  }
  public ModInt Val(int n, int k)
  {
    if (k < 0 || k > n) return 0;
    return fact[n] * ifact[k] * ifact[n - k];
  }
}

public class AtCoder
{
  public static void Main()
  {
    var nmk = Console.ReadLine().Trim().Split().Select(e => int.Parse(e)).ToArray();
    var n = nmk[0];
    var m = nmk[1];
    var k = nmk[2];

    var c = new Combination(200005);

    ModInt ans = 0;
    ModInt col = m;
    for (var x = n - 1; x >= 0; --x)
    {
      ModInt now = col;
      now *= c.Val(n - 1, x);
      if (x <= k) ans += now;
      col *= m - 1;
    }

    Console.WriteLine(ans);
  }
}