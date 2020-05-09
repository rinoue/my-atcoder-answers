using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Myon
{

    public Myon() { }
    public static int Main()
    {
        new Myon().calc();
        return 0;
    }

    Scanner cin;

    void calc()
    {
        cin = new Scanner();
        int N = cin.nextInt();
        int[] x = new int[N];
        int[] y = new int[N];
        for (int i = 0; i < N; i++)
        {
            x[i] = cin.nextInt();
            y[i] = cin.nextInt();
        }


        double EPS = 1e-12;

        long mid = 0; //90
        long high = 0; //90 over


        //点Bを固定
        for (int i = 0; i < N; i++)
        {
            List<double> l = new List<double>();
            for (int j = 0; j < N; j++)
            {
                if(i != j) l.Add(Math.Atan2(y[i] - y[j], x[i] - x[j]));
            }
            l.Sort();

            int[] pointer = new int[3];

            //90度未満、90度以下、180度未満の3つ
            double[] diff = { Math.PI / 2 - EPS, Math.PI / 2 + EPS, Math.PI - EPS };

            //点Aについて全通り試す
            for (int j = 0; j < l.Count; j++)
            {
                for (int k = 0; k < diff.Length; k++)
                {
                    //それぞれのポインタを必要な部分まで動かす
                    while (true)
                    {
                        double rad = l[pointer[k] % l.Count]
                            + Math.PI * 2 * (pointer[k] / l.Count)
                            - l[j];
                        if (rad < diff[k]) pointer[k]++;
                        else break;
                    }
                }
                //直角・鈍角の数を纏めて計算
                mid += pointer[1] - pointer[0];
                high += pointer[2] - pointer[1];
            }
        }
        long low = N * (N - 1) * (long)(N - 2) / 6 - mid - high;
        Console.WriteLine("{0} {1} {2}", low, mid, high);
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