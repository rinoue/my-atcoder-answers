using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Globalization;

public class Program
{
    public static int Main()
    {
        new Program().calc();
        return 0;
    }

    Scanner cin;

    void calc()
    {
        cin = new Scanner();
        int N, K;
        N = cin.nextInt();
        K = cin.nextInt();
        double[] w = new double[N];
        double[] p = new double[N];
        for (int i = 0; i < N; i++)
        {
            w[i] = cin.nextInt();
            p[i] = cin.nextInt();
        }

        double ok = 0;
        double ng = 100;
        for (int t = 0; t < 100; t++)
        {
            double mid = (ok + ng) / 2;
            if (check(mid, K, w, p)) ok = mid;
            else ng = mid;
        }
        Console.WriteLine("{0:0.00000000000}", ok);
    }

    bool check(double mid, int K, double[] w, double[] p)
    {
        double ans = 0;
        int N = w.Length;
        double[] nokori = new double[N];
        for (int i = 0; i < N; i++)
        {
            nokori[i] = w[i] * (p[i] - mid);
        }
        Array.Sort(nokori);
        Array.Reverse(nokori);

        for (int i = 0; i < K; i++)
        {
            ans += nokori[i];
        }

        if (ans >= 0) return true;
        else return false;
    }

}

class Scanner
{
    string[] s;
    int i;

    char[] cs = new char[] { ' ' };

    public Scanner()
    {
        s = new string[0];
        i = 0;
    }

    public string next()
    {
        if (i < s.Length) return s[i++];
        string st = Console.ReadLine();
        while (st == "") st = Console.ReadLine();
        s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
        i = 0;
        return next();
    }

    public int nextInt()
    {
        return int.Parse(next());
    }

    public long nextLong()
    {
        return long.Parse(next());
    }

    public double nextDouble()
    {
        return double.Parse(next());
    }
}
