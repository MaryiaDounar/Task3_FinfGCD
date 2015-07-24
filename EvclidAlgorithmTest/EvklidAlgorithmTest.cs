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

        [TestCase(18, 30, Result = 6)]
        [TestCase(0,0, Result = 0)]
        [TestCase(0,1, Result = 1)]
        [Test]
        public int FindGCDByEvclidAlgorithmTest(int number1, int number2)
        {
            return EvclidAlgorithm.FindGCDByEvclidAlgorithm(number1, number2);
        }

        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCDByEvclidAlgorithmTest(params int[] numbers)
        {
            return EvclidAlgorithm.FindGCDByEvclidAlgorithm(numbers);
        }

        [TestCase(18, 30, Result = 6)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(0, 1, Result = 1)]
        [Test]
        public int FindGCDByStaineAlgorithmTest(int number1, int number2)
        {
            return EvclidAlgorithm.FindGCDByStaineAlgorithm(number1, number2);
        }

        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCDByStaineAlgorithmTest(params int[] numbers)
        {
            return EvclidAlgorithm.FindGCDByStaineAlgorithm(numbers);
        }
    }
}
