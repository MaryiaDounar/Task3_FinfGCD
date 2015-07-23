using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EvclidAlgorithmProject
{
    public class EvclidAlgorithm
    {
        public static int FindGCD(int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (b != 0)
                b = a % (a = b);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return a;

        }

        public static int FindGCD(params int[] list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = list[0];
            for (int i = 0; i < list.Length - 1; i++)
            {
                while (list[i + 1] != 0)
                    list[i + 1] = gcd % (gcd = list[i + 1]);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return gcd;
        }

        public static int GCD(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * GCD(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return GCD(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return GCD(a, b / 2);
            return GCD(b, Math.Abs(a - b));
        }

        public static int GCD(params int[] list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = list[0];
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (gcd == 0) gcd = list[i+1];
                if (list[i + 1] == 0) gcd = gcd;
                if (gcd == list[i + 1]) gcd = gcd;
                if (gcd == 1 || list[i + 1] == 1) gcd = 1;
                if ((gcd % 2 == 0) && (list[i + 1] % 2 == 0)) gcd = 2 * GCD(gcd / 2, list[i + 1] / 2);
                if ((gcd % 2 == 0) && (list[i + 1] % 2 != 0)) gcd = GCD(gcd / 2, list[i + 1]);
                if ((gcd % 2 != 0) && (list[i + 1] % 2 == 0)) gcd = GCD(gcd, list[i + 1] / 2);
                gcd = GCD(list[i + 1], Math.Abs(gcd - list[i + 1]));
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return gcd;
        }
    }
}
