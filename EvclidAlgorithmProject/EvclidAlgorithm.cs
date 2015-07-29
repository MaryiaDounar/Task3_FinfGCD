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
        private static Stopwatch stopwatch = new Stopwatch();

        private static int FindGCD(int number1, int number2)
        {
            while (number2 != 0)
                number2 = number1 % (number1 = number2);
            return number1;
        }

        public static int FindGCDByEvclidAlgorithm(int number1, int number2, out TimeSpan time)
        {
            stopwatch.Start();
            int gcd = FindGCD(number1, number2);
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            return gcd;
        }

        public static int FindGCDByEvclidAlgorithm(int number1, int number2, int number3, out TimeSpan time)
        {
            stopwatch.Start();
            int gcd = FindGCD(number1, number2);
            gcd = FindGCD(gcd, number3);
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            return gcd;
        }

        public static int FindGCDByEvclidAlgorithm(out TimeSpan time, params int[] numbers)
        {
            stopwatch.Start();
            int gcd = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
               gcd = FindGCD(gcd, numbers[i + 1]);
            }
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            return gcd;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private static int FindGCDStaine(int number1, int number2)
        {
            if (number1 == 0) return number2;
            if (number2 == 0) return number1;
            if (number1 == number2) return number1;
            if (number1 == 1 || number2 == 1) return 1;
            if ((number1 % 2 == 0) && (number2 % 2 == 0)) return 2 * FindGCDStaine(number1 / 2, number2 / 2);
            if ((number1 % 2 == 0) && (number2 % 2 != 0)) return FindGCDStaine(number1 / 2, number2);
            if ((number1 % 2 != 0) && (number2 % 2 == 0)) return FindGCDStaine(number1, number2 / 2);
            return FindGCDStaine(number2, Math.Abs(number1 - number2));
        }


        public static int FindGCDByStaineAlgorithm(int number1, int number2, out TimeSpan time)
        {
            stopwatch.Start();
            int gcd = FindGCDStaine(number1, number2);
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            return gcd;
        }

        public static int FindGCDByStaineAlgorithm(int number1, int number2, int number3, out TimeSpan time)
        {
            stopwatch.Start();
            int gcd = FindGCDStaine(number1, number2);
            gcd = FindGCDStaine(gcd, number3);
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            return gcd;
        }

        public static int FindGCDByStaineAlgorithm(out TimeSpan time, params int[] numbers)
        {
            stopwatch.Start();
            int gcd = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                gcd = FindGCDStaine(gcd, numbers[i + 1]);
            }
            stopwatch.Stop();
            time = stopwatch.Elapsed;
            return gcd;
        }
    }
}
