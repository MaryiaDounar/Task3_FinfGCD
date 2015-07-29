using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EvclidAlgorithmProject;
using log4net;
using System.Reflection;



namespace EvclidAlgorithmTest
{
    [TestFixture]
    public class CheckEvclidAlgorithm: TestInitialize
    {
        public static TimeSpan time;
        public static readonly ILog Logger = LogManager.GetLogger("Log4net");

        private const string messageForTwoParameters = "Time of execution {0} for two parameters: {1}";
        private const string messageForThreeParameters = "Time of execution {0} for three parameters: {1}";
        private const string messageForManyParameters = "Time of execution {0} for array of parameters: {1}";



        [TestCase(18, 30, Result = 6)]
        [TestCase(0,0, Result = 0)]
        [TestCase(0,1, Result = 1)]
        [Test]
        public int FindGCDByEvclidAlgorithmTest(int number1, int number2)
        {
            int x = EvclidAlgorithm.FindGCDByEvclidAlgorithm(number1, number2, out time);
            Logger.Info(String.Format(messageForTwoParameters, MethodBase.GetCurrentMethod().Name, time));
            return x;
        }

        [TestCase(18, 30, 99, Result = 3)]
        [Test]
        public int FindGCDByEvclidAlgorithmTest(int number1, int number2, int number3)
        {
            int x = EvclidAlgorithm.FindGCDByEvclidAlgorithm(number1, number2, number3, out time);
            Logger.Info(String.Format(messageForThreeParameters, MethodBase.GetCurrentMethod().Name, time));
            return x;
        }

        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCDByEvclidAlgorithmTest(params int[] numbers)
        {
            int x = EvclidAlgorithm.FindGCDByEvclidAlgorithm(out time, numbers);
            Logger.Info(String.Format(messageForManyParameters, MethodBase.GetCurrentMethod().Name, time));
            return x;
        }

        [TestCase(18, 30, Result = 6)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(0, 1, Result = 1)]
        [Test]
        public int FindGCDByStaineAlgorithmTest(int number1, int number2)
        {
            int x = EvclidAlgorithm.FindGCDByStaineAlgorithm(number1, number2, out time);
            Logger.Info(String.Format(messageForTwoParameters, MethodBase.GetCurrentMethod().Name, time));
            return x;
        }

        [TestCase(18, 30, 99, Result = 3)]
        [Test]
        public int FindGCDByStaineAlgorithmTest(int number1, int number2, int number3)
        {
            int x = EvclidAlgorithm.FindGCDByStaineAlgorithm(number1, number2, number3, out time);
            Logger.Info(String.Format(messageForThreeParameters, MethodBase.GetCurrentMethod().Name, time));
            return x;
        }

        [TestCase(78, 294, 570, 36, Result = 6)]
        [Test]
        public int FindGCDByStaineAlgorithmTest(params int[] numbers)
        {
            int x = EvclidAlgorithm.FindGCDByStaineAlgorithm(out time, numbers);
            Logger.Info(String.Format(messageForManyParameters, MethodBase.GetCurrentMethod().Name, time));
            return x;
        }
    }
}
