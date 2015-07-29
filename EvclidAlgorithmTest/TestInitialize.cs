using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using log4net.Config;

namespace EvclidAlgorithmTest
{
   public class TestInitialize
    {
        [TestFixtureSetUp]
        public void ConfigureLog4Net()
        {
            XmlConfigurator.Configure();
        }
    }
}
