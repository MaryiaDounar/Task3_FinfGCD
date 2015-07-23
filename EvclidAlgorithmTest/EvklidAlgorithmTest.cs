using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EvclidAlgorithmProject;

namespace EvclidAlgorithmTest
{
    [TestFixture]
    public class EvklidAlgorithmTest
    {
        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCD(int a, int b,int c, int d)
        {
            return EvclidAlgorithm.FindGCD(a, b, c, d);
        }

        [TestCase(18, 30, Result = 6)]
        [Test]
        public int FindGCDForTwoNumbers(int a, int b)
        {
            return EvclidAlgorithm.FindGCD(a, b);
        }

        [TestCase(18, 30, Result = 6)]
        [Test]
        public int FindGCDByStaine(int a, int b)
        {
            return EvclidAlgorithm.GCD(a, b);
        }

        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCDBySSS(int a, int b, int c, int d)
        {
            return EvclidAlgorithm.GCD(a, b, c, d);
        }
    }
}
