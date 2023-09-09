using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        long tot = 0;
        long n = 1_000_000_000;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (long i = 1; i <= n; i++){tot += i;}
        stopwatch.Stop();
        double elapsedSeconds = (double)stopwatch.ElapsedMilliseconds / 1000.0;
        Console.WriteLine("Soma: " + tot);
        Console.WriteLine("Tempo: " + elapsedSeconds.ToString("F15"));
    }
}