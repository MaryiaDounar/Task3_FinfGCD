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
        public static int FindGCDByEvclidAlgorithm(int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (number2 != 0)
                number2 = number1 % (number1 = number2);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return number1;
        }

        public static int FindGCDByEvclidAlgorithm(params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                while (numbers[i + 1] != 0)
                    numbers[i + 1] = gcd % (gcd = numbers[i + 1]);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return gcd;
        }

        public static int FindGCDByStaineAlgorithm(int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (number1 == 0) return number2;
            if (number2 == 0) return number1;
            if (number1 == number2) return number1;
            if (number1 == 1 || number2 == 1) return 1;
            if ((number1 % 2 == 0) && (number2 % 2 == 0)) return 2 * FindGCDByStaineAlgorithm(number1 / 2, number2 / 2);
            if ((number1 % 2 == 0) && (number2 % 2 != 0)) return FindGCDByStaineAlgorithm(number1 / 2, number2);
            if ((number1 % 2 != 0) && (number2 % 2 == 0)) return FindGCDByStaineAlgorithm(number1, number2 / 2);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return FindGCDByStaineAlgorithm(number2, Math.Abs(number1 - number2));
        }

        public static int FindGCDByStaineAlgorithm(params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int gcd = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (gcd == 0) gcd = numbers[i+1];
                if (gcd == 1 || numbers[i + 1] == 1) gcd = 1;
                if ((gcd % 2 == 0) && (numbers[i + 1] % 2 == 0)) gcd = 2 * FindGCDByStaineAlgorithm(gcd / 2, numbers[i + 1] / 2);
                if ((gcd % 2 == 0) && (numbers[i + 1] % 2 != 0)) gcd = FindGCDByStaineAlgorithm(gcd / 2, numbers[i + 1]);
                if ((gcd % 2 != 0) && (numbers[i + 1] % 2 == 0)) gcd = FindGCDByStaineAlgorithm(gcd, numbers[i + 1] / 2);
                gcd = FindGCDByStaineAlgorithm(numbers[i + 1], Math.Abs(gcd - numbers[i + 1]));
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            return gcd;
        }
    }
}
