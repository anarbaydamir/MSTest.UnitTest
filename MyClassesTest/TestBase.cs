using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    public class TestBase
    {
        //used to store information about unit test, by default created in each class
        public TestContext TestContext { get; set; }
    }
}
