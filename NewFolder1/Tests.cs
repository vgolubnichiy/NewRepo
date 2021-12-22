using adressbook_web_tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.NewFolder1
{
    public class Tests
    {

        [Test]
        public void Method()
        {
            UntitledTestCase d = new UntitledTestCase();
            d.SetupTest();
            d.TheUntitledTestCaseTest();
            d.TeardownTest();
        }
    }


}
