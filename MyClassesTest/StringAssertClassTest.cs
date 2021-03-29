using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    [TestClass]
    public class StringAssertClassTest:TestBase
    {
        [TestMethod]
        public void StringContains()
        {
            string str1 = "Anar";
            string str2 = "nar";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        public void StringStartsWith()
        {
            string str1 = "Anar";
            string str2 = "A";

            StringAssert.StartsWith(str1, str2);
        }
    }
}
